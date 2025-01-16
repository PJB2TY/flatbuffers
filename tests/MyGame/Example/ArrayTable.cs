// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace MyGame.Example
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ArrayTable : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_12_23(); }
  public static ArrayTable GetRootAsArrayTable(ByteBuffer _bb) { return GetRootAsArrayTable(_bb, new ArrayTable()); }
  public static ArrayTable GetRootAsArrayTable(ByteBuffer _bb, ArrayTable obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool ArrayTableBufferHasIdentifier(ByteBuffer _bb) { return Table.__has_identifier(_bb, "ARRT"); }
  public static bool VerifyArrayTable(ByteBuffer _bb) {Google.FlatBuffers.Verifier verifier = new Google.FlatBuffers.Verifier(_bb); return verifier.VerifyBuffer("ARRT", false, ArrayTableVerify.Verify); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ArrayTable __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public MyGame.Example.ArrayStruct? A { get { int o = __p.__offset(4); return o != 0 ? (MyGame.Example.ArrayStruct?)(new MyGame.Example.ArrayStruct()).__assign(o + __p.bb_pos, __p.bb) : null; } }

  public static void StartArrayTable(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddA(FlatBufferBuilder builder, Offset<MyGame.Example.ArrayStruct> aOffset) { builder.AddStruct(0, aOffset.Value, 0); }
  public static Offset<MyGame.Example.ArrayTable> EndArrayTable(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<MyGame.Example.ArrayTable>(o);
  }
  public static void FinishArrayTableBuffer(FlatBufferBuilder builder, Offset<MyGame.Example.ArrayTable> offset) { builder.Finish(offset.Value, "ARRT"); }
  public static void FinishSizePrefixedArrayTableBuffer(FlatBufferBuilder builder, Offset<MyGame.Example.ArrayTable> offset) { builder.FinishSizePrefixed(offset.Value, "ARRT"); }
  public ArrayTableT UnPack() {
    var _o = new ArrayTableT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ArrayTableT _o) {
    _o.A = this.A.HasValue ? this.A.Value.UnPack() : null;
  }
  public static Offset<MyGame.Example.ArrayTable> Pack(FlatBufferBuilder builder, ArrayTableT _o) {
    if (_o == null) return default(Offset<MyGame.Example.ArrayTable>);
    StartArrayTable(builder);
    AddA(builder, MyGame.Example.ArrayStruct.Pack(builder, _o.A));
    return EndArrayTable(builder);
  }
}

public class ArrayTableT
{
  [Newtonsoft.Json.JsonProperty("a")]
  public MyGame.Example.ArrayStructT A { get; set; }

  public ArrayTableT() {
    this.A = new MyGame.Example.ArrayStructT();
  }

  public static ArrayTableT DeserializeFromJson(string jsonText) {
    return Newtonsoft.Json.JsonConvert.DeserializeObject<ArrayTableT>(jsonText);
  }
  public string SerializeToJson() {
    return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
  }
  public static ArrayTableT DeserializeFromBinary(byte[] fbBuffer) {
    return ArrayTable.GetRootAsArrayTable(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    ArrayTable.FinishArrayTableBuffer(fbb, ArrayTable.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


static public class ArrayTableVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*A*/, 160 /*MyGame.Example.ArrayStruct*/, 8, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
