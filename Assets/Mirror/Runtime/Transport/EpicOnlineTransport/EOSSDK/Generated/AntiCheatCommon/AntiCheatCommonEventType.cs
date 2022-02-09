// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.AntiCheatCommon
{
	/// <summary>
	/// Types supported for custom gameplay behavior events.
	/// These have a considerable impact on performance
	/// </summary>
	public enum AntiCheatCommonEventType : int
	{
		/// <summary>
		/// Not used
		/// </summary>
		Invalid = 0,
		/// <summary>
		/// A general game event that is not specific to any individual player.
		/// Low memory use which is constant with respect to the number of players.
		/// </summary>
		GameEvent = 1,
		/// <summary>
		/// An event that is logically associated with a specific player. Events logged in
		/// this category require a specific ClientHandle to which they will be attached.
		/// Higher memory use which scales according to the number of players.
		/// </summary>
		PlayerEvent = 2
	}
}