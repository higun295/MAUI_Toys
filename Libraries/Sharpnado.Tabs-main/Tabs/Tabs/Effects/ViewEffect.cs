﻿// https://raw.githubusercontent.com/NAXAM/effects-xamarin-forms/master/Naxam.Effects/ViewStyleEffect.cs
// b7a6099  on 13 Jun 17 @fleuverouge fleuverouge[iOS] Add RoundedViewEffects
// This file isn't generated, but this comment is necessary to exclude it from StyleCop analysis.
// <auto-generated/>

using System.Linq;

using Xamarin.Forms;

namespace Sharpnado.Tabs.Effects
{
    public class ViewStyleEffect : RoutingEffect
    {
        public static readonly string Name = $"Sharpnado.{nameof(ViewStyleEffect)}";

        public ViewStyleEffect()
            : base(Name)
        {
        }
    }

    public static class ViewEffect
    {
        public static readonly BindableProperty TouchFeedbackColorProperty =
            BindableProperty.CreateAttached(
                "TouchFeedbackColor",
                typeof(Color),
                typeof(ViewEffect),
#if NET6_0_OR_GREATER
                Colors.Transparent,
#else
                Color.Default,
#endif
                propertyChanged: AttachEffect
            );
        
        public static Color GetTouchFeedbackColor(BindableObject view)
        {
            return (Color)view.GetValue(TouchFeedbackColorProperty);
        }

        public static void SetTouchFeedbackColor(BindableObject view, Color value)
        {
            view.SetValue(TouchFeedbackColorProperty, value);
        }

        public static bool IsTapFeedbackColorSet(BindableObject element)
        {
            return ViewEffect.GetTouchFeedbackColor(element) != Colors.Transparent;
        }

        private static void AttachEffect(BindableObject bindable, object oldValue, object newValue)
        {
            if (!(bindable is View view))
            {
                System.Diagnostics.Debug.WriteLine($"Cannot apply ViewEffect to {bindable.GetType().Name} object");
                return;
            }

            var frame = bindable as Frame;
            if (frame != null)
            {
                System.Diagnostics.Debug.WriteLine($"Frame not supported for android, attaching it to its content {frame.Content?.GetType().Name}");

                view = frame.Content;

                if (view == null)
                {
                    System.Diagnostics.Debug.WriteLine("Frame content is null: cannot apply effect");
                    return;
                }
            }

            if (newValue != null && GetTouchFeedbackColor(bindable) == (Color)newValue && frame != null)
            {
                SetTouchFeedbackColor(view, (Color)newValue);
            }

            var effect = view.Effects.FirstOrDefault(x => x is ViewStyleEffect);
            if (frame == null && effect == null)
            {
                var resolvedEffect = Effect.Resolve(ViewStyleEffect.Name);
                view.Effects.Add(resolvedEffect);
            }
        }
    }
}