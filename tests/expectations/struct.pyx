from libc.stdint cimport int8_t, int16_t, int32_t, int64_t, intptr_t
from libc.stdint cimport uint8_t, uint16_t, uint32_t, uint64_t, uintptr_t
cdef extern from *:
  ctypedef bint bool
  ctypedef struct va_list

cdef extern from *:

  ctypedef struct Opaque:
    pass

  ctypedef struct Normal:
    int32_t x;
    float y;

  ctypedef struct NormalWithZST:
    int32_t x;
    float y;

  ctypedef struct TupleRenamed:
    int32_t m0;
    float m1;

  ctypedef struct TupleNamed:
    int32_t x;
    float y;

  ctypedef struct WithBool:
    int32_t x;
    float y;
    bool z;

  ctypedef struct TupleWithBool:
    int32_t _0;
    float _1;
    bool _2;

  void root(Opaque *a,
            Normal b,
            NormalWithZST c,
            TupleRenamed d,
            TupleNamed e,
            WithBool f,
            TupleWithBool g);
