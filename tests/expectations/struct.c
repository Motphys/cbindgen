#include <stdarg.h>
#include <stdbool.h>
#include <stdint.h>
#include <stdlib.h>

typedef struct Opaque Opaque;

typedef struct {
  int32_t x;
  float y;
} Normal;

typedef struct {
  int32_t x;
  float y;
} NormalWithZST;

typedef struct {
  int32_t m0;
  float m1;
} TupleRenamed;

typedef struct {
  int32_t x;
  float y;
} TupleNamed;

typedef struct {
  int32_t x;
  float y;
  bool z;
} WithBool;

typedef struct {
  int32_t _0;
  float _1;
  bool _2;
} TupleWithBool;

void root(Opaque *a,
          Normal b,
          NormalWithZST c,
          TupleRenamed d,
          TupleNamed e,
          WithBool f,
          TupleWithBool g);
