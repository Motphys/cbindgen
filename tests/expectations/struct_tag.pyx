from libc.stdint cimport int8_t, int16_t, int32_t, int64_t, intptr_t
from libc.stdint cimport uint8_t, uint16_t, uint32_t, uint64_t, uintptr_t
cdef extern from *:
  ctypedef bint bool
  ctypedef struct va_list

cdef extern from *:

  cdef struct Opaque:
    pass

  cdef struct Normal:
    int32_t x;
    float y;

  cdef struct NormalWithZST:
    int32_t x;
    float y;

  cdef struct TupleRenamed:
    int32_t m0;
    float m1;

  cdef struct TupleNamed:
    int32_t x;
    float y;

  cdef struct WithBool:
    int32_t x;
    float y;
    bool z;

  cdef struct TupleWithBool:
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
