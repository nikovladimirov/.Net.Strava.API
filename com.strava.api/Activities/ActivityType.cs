#region Copyright (C) 2014 Sascha Simon

//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see http://www.gnu.org/licenses/.
//
//  Visit the official homepage at http://www.sascha-simon.com

#endregion

namespace com.strava.api.Segments
{
    /// <summary>
    /// The type of an activity.
    /// </summary>
    public enum ActivityType
    {
        /// <summary>
        /// Ride
        /// </summary>
        Ride,
        /// <summary>
        /// Run
        /// </summary>
        Run,
        /// <summary>
        /// Swim
        /// </summary>
        Swim,
        /// <summary>
        /// Hike
        /// </summary>
        Hike,
        /// <summary>
        /// Walk
        /// </summary>
        Walk,
        /// <summary>
        /// Nordic Ski
        /// </summary>
        NordicSki,
        /// <summary>
        /// Alpine Ski
        /// </summary>
        AlpineSki,
        /// <summary>
        /// Backcountry Ski
        /// </summary>
        BackcountrySki,
        /// <summary>
        /// Ice Skate
        /// </summary>
        IceSkate,
        /// <summary>
        /// Inline Skate
        /// </summary>
        InlineSkate,
        /// <summary>
        /// Kite Surf
        /// </summary>
        Kitesurf,
        /// <summary>
        /// Roller Ski
        /// </summary>
        RollerSki,
        /// <summary>
        /// Windsurf
        /// </summary>
        Windsurf,
        /// <summary>
        /// Workout
        /// </summary>
        Workout,
        /// <summary>
        /// Snowboard
        /// </summary>
        Snowboard,
        /// <summary>
        /// Snowshoe
        /// </summary>
        Snowshoe,
        /// <summary>
        /// Unknown - only returned if the activity type cannot be parsed (could be that a new type of activity has been introduced that the API doesnt yet support)
        /// </summary>
        Unknown
    }
}