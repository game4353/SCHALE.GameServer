// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::SCHALE.Common.Crypto;
using global::Google.FlatBuffers;

public struct EventContentCharacterBonusExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static EventContentCharacterBonusExcel GetRootAsEventContentCharacterBonusExcel(ByteBuffer _bb) { return GetRootAsEventContentCharacterBonusExcel(_bb, new EventContentCharacterBonusExcel()); }
  public static EventContentCharacterBonusExcel GetRootAsEventContentCharacterBonusExcel(ByteBuffer _bb, EventContentCharacterBonusExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EventContentCharacterBonusExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long EventContentId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CharacterId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.EventContentItemType EventContentItemType_(int j) { int o = __p.__offset(8); return o != 0 ? (SCHALE.Common.FlatData.EventContentItemType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (SCHALE.Common.FlatData.EventContentItemType)0; }
  public int EventContentItemType_Length { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<SCHALE.Common.FlatData.EventContentItemType> GetEventContentItemType_Bytes() { return __p.__vector_as_span<SCHALE.Common.FlatData.EventContentItemType>(8, 4); }
#else
  public ArraySegment<byte>? GetEventContentItemType_Bytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public SCHALE.Common.FlatData.EventContentItemType[] GetEventContentItemType_Array() { int o = __p.__offset(8); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); SCHALE.Common.FlatData.EventContentItemType[] a = new SCHALE.Common.FlatData.EventContentItemType[l]; for (int i = 0; i < l; i++) { a[i] = (SCHALE.Common.FlatData.EventContentItemType)__p.bb.GetInt(p + i * 4); } return a; }
  public long BonusPercentage(int j) { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int BonusPercentageLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetBonusPercentageBytes() { return __p.__vector_as_span<long>(10, 8); }
#else
  public ArraySegment<byte>? GetBonusPercentageBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public long[] GetBonusPercentageArray() { return __p.__vector_as_array<long>(10); }

  public static Offset<SCHALE.Common.FlatData.EventContentCharacterBonusExcel> CreateEventContentCharacterBonusExcel(FlatBufferBuilder builder,
      long EventContentId = 0,
      long CharacterId = 0,
      VectorOffset EventContentItemType_Offset = default(VectorOffset),
      VectorOffset BonusPercentageOffset = default(VectorOffset)) {
    builder.StartTable(4);
    EventContentCharacterBonusExcel.AddCharacterId(builder, CharacterId);
    EventContentCharacterBonusExcel.AddEventContentId(builder, EventContentId);
    EventContentCharacterBonusExcel.AddBonusPercentage(builder, BonusPercentageOffset);
    EventContentCharacterBonusExcel.AddEventContentItemType_(builder, EventContentItemType_Offset);
    return EventContentCharacterBonusExcel.EndEventContentCharacterBonusExcel(builder);
  }

  public static void StartEventContentCharacterBonusExcel(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddEventContentId(FlatBufferBuilder builder, long eventContentId) { builder.AddLong(0, eventContentId, 0); }
  public static void AddCharacterId(FlatBufferBuilder builder, long characterId) { builder.AddLong(1, characterId, 0); }
  public static void AddEventContentItemType_(FlatBufferBuilder builder, VectorOffset eventContentItemType_Offset) { builder.AddOffset(2, eventContentItemType_Offset.Value, 0); }
  public static VectorOffset CreateEventContentItemType_Vector(FlatBufferBuilder builder, SCHALE.Common.FlatData.EventContentItemType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateEventContentItemType_VectorBlock(FlatBufferBuilder builder, SCHALE.Common.FlatData.EventContentItemType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateEventContentItemType_VectorBlock(FlatBufferBuilder builder, ArraySegment<SCHALE.Common.FlatData.EventContentItemType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateEventContentItemType_VectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<SCHALE.Common.FlatData.EventContentItemType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartEventContentItemType_Vector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBonusPercentage(FlatBufferBuilder builder, VectorOffset bonusPercentageOffset) { builder.AddOffset(3, bonusPercentageOffset.Value, 0); }
  public static VectorOffset CreateBonusPercentageVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateBonusPercentageVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBonusPercentageVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBonusPercentageVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartBonusPercentageVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<SCHALE.Common.FlatData.EventContentCharacterBonusExcel> EndEventContentCharacterBonusExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.EventContentCharacterBonusExcel>(o);
  }
  public EventContentCharacterBonusExcelT UnPack() {
    var _o = new EventContentCharacterBonusExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(EventContentCharacterBonusExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("EventContentCharacterBonus");
    _o.EventContentId = TableEncryptionService.Convert(this.EventContentId, key);
    _o.CharacterId = TableEncryptionService.Convert(this.CharacterId, key);
    _o.EventContentItemType_ = new List<SCHALE.Common.FlatData.EventContentItemType>();
    for (var _j = 0; _j < this.EventContentItemType_Length; ++_j) {_o.EventContentItemType_.Add(TableEncryptionService.Convert(this.EventContentItemType_(_j), key));}
    _o.BonusPercentage = new List<long>();
    for (var _j = 0; _j < this.BonusPercentageLength; ++_j) {_o.BonusPercentage.Add(TableEncryptionService.Convert(this.BonusPercentage(_j), key));}
  }
  public static Offset<SCHALE.Common.FlatData.EventContentCharacterBonusExcel> Pack(FlatBufferBuilder builder, EventContentCharacterBonusExcelT _o) {
    if (_o == null) return default(Offset<SCHALE.Common.FlatData.EventContentCharacterBonusExcel>);
    var _EventContentItemType_ = default(VectorOffset);
    if (_o.EventContentItemType_ != null) {
      var __EventContentItemType_ = _o.EventContentItemType_.ToArray();
      _EventContentItemType_ = CreateEventContentItemType_Vector(builder, __EventContentItemType_);
    }
    var _BonusPercentage = default(VectorOffset);
    if (_o.BonusPercentage != null) {
      var __BonusPercentage = _o.BonusPercentage.ToArray();
      _BonusPercentage = CreateBonusPercentageVector(builder, __BonusPercentage);
    }
    return CreateEventContentCharacterBonusExcel(
      builder,
      _o.EventContentId,
      _o.CharacterId,
      _EventContentItemType_,
      _BonusPercentage);
  }
}

public class EventContentCharacterBonusExcelT
{
  public long EventContentId { get; set; }
  public long CharacterId { get; set; }
  public List<SCHALE.Common.FlatData.EventContentItemType> EventContentItemType_ { get; set; }
  public List<long> BonusPercentage { get; set; }

  public EventContentCharacterBonusExcelT() {
    this.EventContentId = 0;
    this.CharacterId = 0;
    this.EventContentItemType_ = null;
    this.BonusPercentage = null;
  }
}


static public class EventContentCharacterBonusExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*EventContentId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*CharacterId*/, 8 /*long*/, 8, false)
      && verifier.VerifyVectorOfData(tablePos, 8 /*EventContentItemType_*/, 4 /*SCHALE.Common.FlatData.EventContentItemType*/, false)
      && verifier.VerifyVectorOfData(tablePos, 10 /*BonusPercentage*/, 8 /*long*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
