﻿// Copyright (c) 2007-2017 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE


namespace osu.Game.Modes.Osu.Objects
{
    public class Spinner : OsuHitObject
    {
        public double Length;

        public override double EndTime => StartTime + Length;

        public override HitObjectType Type => HitObjectType.Spinner;
    }
}
