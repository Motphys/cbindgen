using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct HashTable_Str__c_char__false {
  public nuint num_buckets;
  public nuint capacity;
  public byte* occupied;
  public Str* keys;
  public byte* vals;
}





[StructLayout(LayoutKind.Sequential)]
internal unsafe partial struct HashTable_Str__u64__true {
  public nuint num_buckets;
  public nuint capacity;
  public byte* occupied;
  public Str* keys;
  public ulong* vals;
}


