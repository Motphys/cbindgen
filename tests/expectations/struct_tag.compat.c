#include <stdarg.h>
#include <stdbool.h>
#include <stdint.h>
#include <stdlib.h>

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

#ifdef __cplusplus
extern "C" {
#endif // __cplusplus

void root(struct Opaque *a,
          struct Normal b,
          struct NormalWithZST c,
          struct TupleRenamed d,
          struct TupleNamed e,
          struct WithBool f,
          struct TupleWithBool g);

#ifdef __cplusplus
}  // extern "C"
#endif  // __cplusplus
