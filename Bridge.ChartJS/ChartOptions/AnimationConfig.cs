using System;

namespace Bridge.ChartJS
{
    [ObjectLiteral]
    [External]
    public class AnimationConfig
    {
        /// <summary>
        /// The number in milliseconds an animation takes.
        /// </summary>
        public int Duration;
        /// <summary>
        /// Easing function to use. Available options are: 'linear', 'easeInQuad', 'easeOutQuad', 'easeInOutQuad', 'easeInCubic', 'easeOutCubic', 'easeInOutCubic', 'easeInQuart', 'easeOutQuart', 'easeInOutQuart', 'easeInQuint', 'easeOutQuint', 'easeInOutQuint', 'easeInSine', 'easeOutSine', 'easeInOutSine', 'easeInExpo', 'easeOutExpo', 'easeInOutExpo', 'easeInCirc', 'easeOutCirc', 'easeInOutCirc', 'easeInElastic', 'easeOutElastic', 'easeInOutElastic', 'easeInBack', 'easeOutBack', 'easeInOutBack', 'easeInBounce', 'easeOutBounce', 'easeInOutBounce'.
        /// </summary>
        public string Easing;
        /// <summary>
        /// Callback called on each step of an animation. 
        /// </summary>
        public Action<AnimationDetails> OnProgress;
        /// <summary>
        /// Callback called at the end of an animation
        /// </summary>
        public Action<AnimationDetails> OnComplete;
    }

    [ObjectLiteral]
    [External]
    public class AnimationDetails
    {
        public Chart ChartInstance;
        /// <summary>
        /// Contains details of the on-going animation
        /// </summary>
        public AnimationObject AnimationObject;
    }

    [ObjectLiteral]
    [External]
    public class AnimationObject
    {
        /// <summary>
        /// Current Animation frame number
        /// </summary>
        public double CurrentStep;
        /// <summary>
        /// Number of animation frames
        /// </summary>
        public double NumSteps;
        /// <summary>
        /// Animation easing to use
        /// </summary>
        public string Easing;
        /// <summary>
        /// Function that renders the chart
        /// </summary>
        public dynamic Render;
        /// <summary>
        /// User callback
        /// </summary>
        public dynamic OnAnimationProgress;
        /// <summary>
        /// User callback
        /// </summary>
        public dynamic OnAnimationComplete;
    }
}