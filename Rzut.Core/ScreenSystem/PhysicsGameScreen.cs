/* Original source Farseer Physics Engine:
 * Copyright (c) 2014 Ian Qvist, http://farseerphysics.codeplex.com
 * Microsoft Permissive License (Ms-PL) v1.1
 */

using System;
using tainicom.Aether.Physics2D.Diagnostics;
using tainicom.Aether.Physics2D.Dynamics;
using tainicom.Aether.Physics2D.Dynamics.Joints;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Input.Touch;

namespace tainicom.Aether.Physics2D.Samples.ScreenSystem
{
    public class PhysicsGameScreen : GameScreen
    {
        public Camera2D Camera;
        protected DebugView DebugView;
        protected World World;
        protected Body HiddenBody;
        protected FixedMouseJoint _fixedMouseJoint;

        private float _agentForce;
        private float _agentTorque;
        private Body _userAgent;

        public GestureType? CurrentDrag = null;
        public Direction DragDirection = Direction.None;
        public PinchMotion Pinch = PinchMotion.None;

        public enum Direction
        {
            None, Left, Right, Down, Up
        }

        public enum PinchMotion
        {
            None, Inwards, Outwards
        }


        protected PhysicsGameScreen()
        {
            TransitionOnTime = TimeSpan.FromSeconds(0.75);
            TransitionOffTime = TimeSpan.FromSeconds(0.75);
            HasCursor = true;
            EnableCameraControl = true;
            _userAgent = null;
            World = null;
            Camera = null;
            DebugView = null;
        }

        public bool EnableCameraControl { get; set; }

        protected void SetUserAgent(Body agent, float force, float torque)
        {
            _userAgent = agent;
            _agentForce = force;
            _agentTorque = torque;
        }

        public override void LoadContent()
        {
            base.LoadContent();

            if (World == null)
            {
                World = new World(Vector2.Zero);
                World.JointRemoved += JointRemoved;
            }
            else
            {
                World.Clear();
            }

            if (DebugView == null)
            {
                DebugView = new DebugView(World);
                DebugView.RemoveFlags(DebugViewFlags.Shape);
                DebugView.RemoveFlags(DebugViewFlags.Joint);
                DebugView.DefaultShapeColor = Color.White;
                DebugView.SleepingShapeColor = Color.LightGray;
                DebugView.LoadContent(ScreenManager.GraphicsDevice, ScreenManager.Content);
            }

            if (Camera == null)
                Camera = new Camera2D(ScreenManager.GraphicsDevice);
            else
                Camera.ResetCamera();

            HiddenBody = World.CreateBody(Vector2.Zero);

            // Loading may take a while... so prevent the game from "catching up" once we finished loading
            ScreenManager.Game.ResetElapsedTime();
        }
        
        protected virtual void JointRemoved(World sender, Joint joint)
        {
            if (_fixedMouseJoint == joint)
                _fixedMouseJoint = null;
        }

        public override void Update(GameTime gameTime, bool otherScreenHasFocus, bool coveredByOtherScreen)
        {
            if (!coveredByOtherScreen && !otherScreenHasFocus)
            {
                // variable time step but never less then 30 Hz
                World.Step(Math.Min((float)gameTime.ElapsedGameTime.TotalSeconds, (1f / 30f)));
            }

            Camera.Update(gameTime);
            base.Update(gameTime, otherScreenHasFocus, coveredByOtherScreen);
        }

        public override void HandleInput(InputHelper input, GameTime gameTime)
        {
            // Control debug view
            if (input.IsNewKeyPress(Keys.F12))
            {
                EnableOrDisableFlag(DebugViewFlags.Shape);
                EnableOrDisableFlag(DebugViewFlags.DebugPanel);
                EnableOrDisableFlag(DebugViewFlags.PerformanceGraph);
                EnableOrDisableFlag(DebugViewFlags.Joint);
                EnableOrDisableFlag(DebugViewFlags.ContactPoints);
                EnableOrDisableFlag(DebugViewFlags.ContactNormals);
                EnableOrDisableFlag(DebugViewFlags.Controllers);
            }

            if (input.IsNewKeyPress(Keys.F1))
                EnableOrDisableFlag(DebugViewFlags.Shape);
            if (input.IsNewKeyPress(Keys.F2))
            {
                EnableOrDisableFlag(DebugViewFlags.DebugPanel);
                EnableOrDisableFlag(DebugViewFlags.PerformanceGraph);
            }
            if (input.IsNewKeyPress(Keys.F3))
                EnableOrDisableFlag(DebugViewFlags.Joint);
            if (input.IsNewKeyPress(Keys.F4))
            {
                EnableOrDisableFlag(DebugViewFlags.ContactPoints);
                EnableOrDisableFlag(DebugViewFlags.ContactNormals);
            }
            if (input.IsNewKeyPress(Keys.F5))
                EnableOrDisableFlag(DebugViewFlags.PolygonPoints);
            if (input.IsNewKeyPress(Keys.F6))
                EnableOrDisableFlag(DebugViewFlags.Controllers);
            if (input.IsNewKeyPress(Keys.F7))
                EnableOrDisableFlag(DebugViewFlags.CenterOfMass);
            if (input.IsNewKeyPress(Keys.F8))
                EnableOrDisableFlag(DebugViewFlags.AABB);

            if (input.IsNewButtonPress(Buttons.Back) || input.IsNewKeyPress(Keys.Escape))
                ScreenManager.Game.Exit();

            if (HasCursor)
                HandleCursor(input);

            if (_userAgent != null)
                HandleUserAgent(input);

            if (EnableCameraControl)
                HandleCamera(input, gameTime);

            base.HandleInput(input, gameTime);
        }

        private void HandleCursor(InputHelper input)
        {
            Vector2 position = Camera.ConvertScreenToWorld(input.Cursor);

            if ((input.IsNewButtonPress(Buttons.A) || input.IsNewMouseButtonPress(MouseButtons.LeftButton) || input.IsNewTouchPress()) && _fixedMouseJoint == null)
            {
                Fixture savedFixture = World.TestPoint(position);
                if (savedFixture != null)
                {
                    Body body = savedFixture.Body;
                    _fixedMouseJoint = new FixedMouseJoint(body, position);
                    _fixedMouseJoint.MaxForce = 1000.0f * body.Mass;
                    World.Add(_fixedMouseJoint);
                    body.Awake = true;
                }
            }

            if ((input.IsNewButtonRelease(Buttons.A) || input.IsNewMouseButtonRelease(MouseButtons.LeftButton) || input.IsNewTouchRelease()) && _fixedMouseJoint != null)
            {
                World.Remove(_fixedMouseJoint);
                _fixedMouseJoint = null;
            }

            if (_fixedMouseJoint != null)
                _fixedMouseJoint.WorldAnchorB = position;
        }

        private void HandleCamera(InputHelper input, GameTime gameTime)
        {
            Vector2 camMove = Vector2.Zero;
            const float Speed = 100f;
            var time = (float)gameTime.ElapsedGameTime.TotalSeconds;
            if (input.KeyboardState.IsKeyDown(Keys.W))
                camMove.Y -= Speed * time;
            if (input.KeyboardState.IsKeyDown(Keys.S))
                camMove.Y += Speed * time;
            if (input.KeyboardState.IsKeyDown(Keys.A))
                camMove.X -= Speed * time;
            if (input.KeyboardState.IsKeyDown(Keys.D))
                camMove.X += Speed * time;
            if (input.KeyboardState.IsKeyDown(Keys.PageUp) || input.KeyboardState.IsKeyDown(Keys.OemPlus))
                Camera.Zoom += (Speed/2) * time * Camera.Zoom / 20f;
            if (input.KeyboardState.IsKeyDown(Keys.PageDown) || input.KeyboardState.IsKeyDown(Keys.OemMinus))
                Camera.Zoom -= (Speed/2) * time * Camera.Zoom / 20f;

            foreach (var gesture in ScreenManager.Input.Gestures)
            {
                if(gesture.GestureType == GestureType.DragComplete || gesture.GestureType == GestureType.PinchComplete)
                {
                    CurrentDrag = null;
                }
                else// if(gesture.GestureType == GestureType.HorizontalDrag || gesture.GestureType == GestureType.VerticalDrag)
                {
                    CurrentDrag = gesture.GestureType;   
                }

                if(gesture.GestureType == GestureType.PinchComplete)
                {
                    Pinch = PinchMotion.None;
                }

                if (gesture.GestureType == GestureType.Pinch)
                {
                    Vector2 a = gesture.Position;
                    Vector2 b = gesture.Position2;
                    float dist = Vector2.Distance(a, b);

                    // prior positions
                    Vector2 aOld = gesture.Position - gesture.Delta;
                    Vector2 bOld = gesture.Position2 - gesture.Delta2;
                    float distOld = Vector2.Distance(aOld, bOld);

                    // work out zoom amount based on pinch distance...
                    if (dist > distOld)
                        Pinch = PinchMotion.Outwards;
                    else if (dist < distOld)
                        Pinch = PinchMotion.Inwards;
                    else
                        Pinch = PinchMotion.None;
                }
                else if (gesture.GestureType == GestureType.HorizontalDrag)
                {
                    if (gesture.Delta.Y < 0 || gesture.Delta.X < 0)
                        DragDirection = Direction.Left;
                    else if (gesture.Delta.Y > 0 || gesture.Delta.X > 0)
                        DragDirection = Direction.Right;
                    else
                        DragDirection = Direction.None;
                }
                else if(gesture.GestureType == GestureType.VerticalDrag)
                {
                    if (gesture.Delta.Y < 0 || gesture.Delta.X < 0)
                        DragDirection = Direction.Down;
                    else if (gesture.Delta.Y > 0 || gesture.Delta.X > 0)
                        DragDirection = Direction.Up;
                    else DragDirection = Direction.None;
                }


            }

            if((CurrentDrag == GestureType.HorizontalDrag || CurrentDrag == GestureType.VerticalDrag) && DragDirection != Direction.None)
            {
                if (DragDirection == Direction.Left || DragDirection == Direction.Right)
                    camMove.X += Speed * time * ((DragDirection == Direction.Left) ? -1 : 1);
                else
                    camMove.Y += Speed * time * ((DragDirection == Direction.Down) ? -1 : 1);
            }

            if(CurrentDrag == GestureType.Pinch && Pinch != PinchMotion.None)
            {
                    Camera.Zoom += ((Speed / 2) * time * Camera.Zoom / 20f) * ((Pinch == PinchMotion.Inwards) ? -1: 1);
            }

            if (camMove != Vector2.Zero)
                Camera.MoveCamera(camMove);
            if (input.IsNewKeyPress(Keys.Home))
                Camera.ResetCamera();
        }

        private void HandleUserAgent(InputHelper input)
        {
            Vector2 force = _agentForce * new Vector2(input.GamePadState.ThumbSticks.Right.X, -input.GamePadState.ThumbSticks.Right.Y);
            float torque = _agentTorque * (input.GamePadState.Triggers.Right - input.GamePadState.Triggers.Left);

            _userAgent.ApplyForce(force);
            _userAgent.ApplyTorque(torque);

            float forceAmount = _agentForce * 0.6f;

            force = Vector2.Zero;
            torque = 0;

            if (input.KeyboardState.IsKeyDown(Keys.A))
                force += new Vector2(-forceAmount, 0);
            if (input.KeyboardState.IsKeyDown(Keys.S))
                force += new Vector2(0, forceAmount);
            if (input.KeyboardState.IsKeyDown(Keys.D))
                force += new Vector2(forceAmount, 0);
            if (input.KeyboardState.IsKeyDown(Keys.W))
                force += new Vector2(0, -forceAmount);
            if (input.KeyboardState.IsKeyDown(Keys.Q))
                torque -= _agentTorque;
            if (input.KeyboardState.IsKeyDown(Keys.E))
                torque += _agentTorque;

            _userAgent.ApplyForce(force);
            _userAgent.ApplyTorque(torque);
        }

        private void EnableOrDisableFlag(DebugViewFlags flag)
        {
            if ((DebugView.Flags & flag) == flag)
                DebugView.RemoveFlags(flag);
            else
                DebugView.AppendFlags(flag);
        }

        public override void Draw(GameTime gameTime)
        {
            DebugView.RenderDebugData(ref Camera.DebugProjection, ref Camera.DebugView);
            base.Draw(gameTime);
        }
    }
}