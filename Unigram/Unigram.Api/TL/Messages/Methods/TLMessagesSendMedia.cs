// <auto-generated/>
using System;

namespace Telegram.Api.TL.Messages.Methods
{
	/// <summary>
	/// RCP method messages.sendMedia.
	/// Returns <see cref="Telegram.Api.TL.TLUpdatesBase"/>
	/// </summary>
	public partial class TLMessagesSendMedia : TLObject
	{
		[Flags]
		public enum Flag : Int32
		{
			Silent = (1 << 5),
			Background = (1 << 6),
			ClearDraft = (1 << 7),
			ReplyToMsgId = (1 << 0),
			ReplyMarkup = (1 << 2),
			GroupedId = (1 << 8),
		}

		public bool IsSilent { get { return Flags.HasFlag(Flag.Silent); } set { Flags = value ? (Flags | Flag.Silent) : (Flags & ~Flag.Silent); } }
		public bool IsBackground { get { return Flags.HasFlag(Flag.Background); } set { Flags = value ? (Flags | Flag.Background) : (Flags & ~Flag.Background); } }
		public bool IsClearDraft { get { return Flags.HasFlag(Flag.ClearDraft); } set { Flags = value ? (Flags | Flag.ClearDraft) : (Flags & ~Flag.ClearDraft); } }
		public bool HasReplyToMsgId { get { return Flags.HasFlag(Flag.ReplyToMsgId); } set { Flags = value ? (Flags | Flag.ReplyToMsgId) : (Flags & ~Flag.ReplyToMsgId); } }
		public bool HasReplyMarkup { get { return Flags.HasFlag(Flag.ReplyMarkup); } set { Flags = value ? (Flags | Flag.ReplyMarkup) : (Flags & ~Flag.ReplyMarkup); } }
		public bool HasGroupedId { get { return Flags.HasFlag(Flag.GroupedId); } set { Flags = value ? (Flags | Flag.GroupedId) : (Flags & ~Flag.GroupedId); } }

		public Flag Flags { get; set; }
		public TLInputPeerBase Peer { get; set; }
		public Int32? ReplyToMsgId { get; set; }
		public TLInputMediaBase Media { get; set; }
		public Int64 RandomId { get; set; }
		public TLReplyMarkupBase ReplyMarkup { get; set; }
		public Int64? GroupedId { get; set; }

		public TLMessagesSendMedia() { }
		public TLMessagesSendMedia(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesSendMedia; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (Flag)from.ReadInt32();
			Peer = TLFactory.Read<TLInputPeerBase>(from);
			if (HasReplyToMsgId) ReplyToMsgId = from.ReadInt32();
			Media = TLFactory.Read<TLInputMediaBase>(from);
			RandomId = from.ReadInt64();
			if (HasReplyMarkup) ReplyMarkup = TLFactory.Read<TLReplyMarkupBase>(from);
			if (HasGroupedId) GroupedId = from.ReadInt64();
		}

		public override void Write(TLBinaryWriter to)
		{
			UpdateFlags();

			to.Write(0x61A461CD);
			to.Write((Int32)Flags);
			to.WriteObject(Peer);
			if (HasReplyToMsgId) to.Write(ReplyToMsgId.Value);
			to.WriteObject(Media);
			to.Write(RandomId);
			if (HasReplyMarkup) to.WriteObject(ReplyMarkup);
			if (HasGroupedId) to.Write(GroupedId.Value);
		}

		private void UpdateFlags()
		{
			HasReplyToMsgId = ReplyToMsgId != null;
			HasReplyMarkup = ReplyMarkup != null;
			HasGroupedId = GroupedId != null;
		}
	}
}