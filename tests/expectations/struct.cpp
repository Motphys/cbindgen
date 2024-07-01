#include <cstdarg>
#include <cstdint>
#include <cstdlib>
#include <ostream>
#include <new>

struct Opaque;

struct Normal {
  int32_t x;
  float y;
};

struct NormalWithZST {
  int32_t x;
  float y;
};

struct TupleRenamed {
  int32_t m0;
  float m1;
};

struct TupleNamed {
  int32_t x;
  float y;
};

struct WithBool {
  int32_t x;
  float y;
  bool z;
};

struct TupleWithBool {
  int32_t _0;
  float _1;
  bool _2;
};

extern "C" {

void root(Opaque *a,
          Normal b,
          NormalWithZST c,
          TupleRenamed d,
          TupleNamed e,
          WithBool f,
          TupleWithBool g);

}  // extern "C"
