.subsections_via_symbols
.section __DWARF, __debug_line,regular,debug
Ldebug_line_section_start:
Ldebug_line_start:
.section __DWARF, __debug_abbrev,regular,debug

	.byte 1,17,1,37,8,3,8,27,8,19,11,17,1,18,1,16,6,0,0,2,46,1,3,8,135,64,8,58,15,59,15,17
	.byte 1,18,1,64,10,0,0,3,5,0,3,8,73,19,2,10,0,0,15,5,0,3,8,73,19,2,6,0,0,4,36,0
	.byte 11,11,62,11,3,8,0,0,5,2,1,3,8,11,15,0,0,17,2,0,3,8,11,15,0,0,6,13,0,3,8,73
	.byte 19,56,10,0,0,7,22,0,3,8,73,19,0,0,8,4,1,3,8,11,15,73,19,0,0,9,40,0,3,8,28,13
	.byte 0,0,10,57,1,3,8,0,0,11,52,0,3,8,73,19,2,10,0,0,12,52,0,3,8,73,19,2,6,0,0,13
	.byte 15,0,73,19,0,0,14,16,0,73,19,0,0,16,28,0,73,19,56,10,0,0,18,46,0,3,8,17,1,18,1,0
	.byte 0,0
.section __DWARF, __debug_info,regular,debug
Ldebug_info_start:

LDIFF_SYM0=Ldebug_info_end - Ldebug_info_begin
	.long LDIFF_SYM0
Ldebug_info_begin:

	.short 2
	.long 0
	.byte 4,1
	.asciz "Mono AOT Compiler 5.4.0 (tarball Mon Dec  4 21:00:42 EST 2017)"
	.asciz "PInvoke.Kernel32.dll"
	.asciz ""

	.byte 2,0,0,0,0,0,0,0,0
LDIFF_SYM1=Ldebug_line_start - Ldebug_line_section_start
	.long LDIFF_SYM1
LDIE_I1:

	.byte 4,1,5
	.asciz "sbyte"
LDIE_U1:

	.byte 4,1,7
	.asciz "byte"
LDIE_I2:

	.byte 4,2,5
	.asciz "short"
LDIE_U2:

	.byte 4,2,7
	.asciz "ushort"
LDIE_I4:

	.byte 4,4,5
	.asciz "int"
LDIE_U4:

	.byte 4,4,7
	.asciz "uint"
LDIE_I8:

	.byte 4,8,5
	.asciz "long"
LDIE_U8:

	.byte 4,8,7
	.asciz "ulong"
LDIE_I:

	.byte 4,4,5
	.asciz "intptr"
LDIE_U:

	.byte 4,4,7
	.asciz "uintptr"
LDIE_R4:

	.byte 4,4,4
	.asciz "float"
LDIE_R8:

	.byte 4,8,4
	.asciz "double"
LDIE_BOOLEAN:

	.byte 4,1,2
	.asciz "boolean"
LDIE_CHAR:

	.byte 4,2,8
	.asciz "char"
LDIE_STRING:

	.byte 4,4,1
	.asciz "string"
LDIE_OBJECT:

	.byte 4,4,1
	.asciz "object"
LDIE_SZARRAY:

	.byte 4,4,1
	.asciz "object"
.section __DWARF, __debug_loc,regular,debug
Ldebug_loc_start:
.section __DWARF, __debug_frame,regular,debug
	.align 3

LDIFF_SYM2=Lcie0_end - Lcie0_start
	.long LDIFF_SYM2
Lcie0_start:

	.long -1
	.byte 3
	.asciz ""

	.byte 1,124,14,12,13,0
	.align 2
Lcie0_end:
.text
	.align 3
jit_code_start:

	.byte 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
.text
	.align 2
	.no_dead_strip ThisAssembly__ctor
ThisAssembly__ctor:
.file 1 "<unknown>"
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,3,223,141,226,0,1,189,232,128,128,189,232

Lme_0:
.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_FormatMessage_PInvoke_Kernel32_FormatMessageFlags_void__int_int_intptr___int
PInvoke_Kernel32_FormatMessage_PInvoke_Kernel32_FormatMessageFlags_void__int_int_intptr___int:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,112,13,45,233,10,223,77,226,13,176,160,225,20,0,139,229,24,16,139,229,2,64,160,225
	.byte 3,80,160,225,72,96,157,229,76,224,157,229,28,224,139,229,0,15,160,227,16,0,139,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 84
	.byte 0,0,159,231,7,31,160,227
bl _p_1

	.byte 32,0,139,229,64,31,160,227
bl _p_2

	.byte 32,0,155,229,0,160,160,225,4,207,139,226,20,0,155,229,24,16,155,229,4,32,160,225,5,48,160,225,0,160,141,229
	.byte 4,96,141,229,8,192,141,229
bl _p_3

	.byte 255,0,0,226,0,15,80,227,1,0,0,10,16,0,155,229,24,0,0,234
bl PInvoke_Kernel32_GetLastError

	.byte 122,16,0,227,1,0,80,225,9,0,0,26,0,224,218,229,8,0,154,229,12,0,144,229,20,16,154,229,1,0,128,224
	.byte 0,17,160,225,10,0,160,225,0,224,218,229
bl _p_4

	.byte 1,0,0,234,0,15,160,227,8,0,0,234,0,224,218,229,8,0,154,229,12,0,144,229,20,16,154,229,1,0,128,224
	.byte 28,16,155,229,1,0,80,225,217,255,255,186,0,15,160,227,10,223,139,226,112,13,189,232,128,128,189,232

Lme_16:
.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_GetLastError
PInvoke_Kernel32_GetLastError:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,1,223,77,226
bl _p_5

	.byte 1,223,141,226,0,1,189,232,128,128,189,232

Lme_17:
.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_void__int
PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_void__int:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,9,45,233,10,223,77,226,13,176,160,225,16,0,139,229,20,16,139,229,24,32,139,229
	.byte 0,15,160,227,8,0,139,229,0,15,160,227,12,0,139,229,16,0,155,229,0,15,80,227,36,0,0,10,0,0,159,229
	.byte 0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 88
	.byte 0,0,159,231,64,3,160,227,12,0,203,229,0,15,160,227,8,0,139,229,2,63,139,226,16,0,155,229,20,16,155,229
	.byte 24,32,155,229,0,207,160,227,0,192,141,229
bl _p_6

	.byte 255,0,0,226,0,15,80,227,8,0,0,10,2,15,139,226,0,128,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 88
	.byte 8,128,159,231
bl _p_7

	.byte 10,223,139,226,0,9,189,232,128,128,189,232,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 92
	.byte 0,0,159,231,18,31,160,227
bl _p_1

	.byte 32,0,139,229
bl PInvoke_Win32Exception__ctor

	.byte 32,0,155,229
bl _p_8

	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . -12
	.byte 0,0,159,231,64,19,160,227
bl _p_9

	.byte 0,16,160,225,148,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_8

Lme_18:
.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_System_ArraySegment_1_byte
PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_System_ArraySegment_1_byte:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,96,9,45,233,6,223,77,226,13,176,160,225,4,0,139,229,8,16,139,229,12,32,139,229
	.byte 16,48,139,229,4,0,155,229,0,15,80,227,34,0,0,10,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 96
	.byte 0,0,159,231,8,16,155,229,1,0,160,225,1,80,160,225,0,15,80,227,2,0,0,10,12,0,149,229,0,15,80,227
	.byte 1,0,0,26,0,111,160,227,3,0,0,234,12,0,149,229,0,15,80,227,28,0,0,155,4,111,133,226,0,0,159,229
	.byte 0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 96
	.byte 0,0,159,231,12,0,155,229,0,16,134,224,0,16,139,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 96
	.byte 0,0,159,231,16,32,155,229,4,0,155,229
bl _p_10

	.byte 6,223,139,226,96,9,189,232,128,128,189,232,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . -12
	.byte 0,0,159,231,64,19,160,227
bl _p_9

	.byte 0,16,160,225,148,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_8

	.byte 14,16,160,225,0,0,159,229
bl _p_11

	.byte 233,0,0,0

Lme_19:
.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_void__int
PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_void__int:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,9,45,233,10,223,77,226,13,176,160,225,16,0,139,229,20,16,139,229,24,32,139,229
	.byte 0,15,160,227,8,0,139,229,0,15,160,227,12,0,139,229,16,0,155,229,0,15,80,227,36,0,0,10,0,0,159,229
	.byte 0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 88
	.byte 0,0,159,231,64,3,160,227,12,0,203,229,0,15,160,227,8,0,139,229,2,63,139,226,16,0,155,229,20,16,155,229
	.byte 24,32,155,229,0,207,160,227,0,192,141,229
bl _p_12

	.byte 255,0,0,226,0,15,80,227,8,0,0,10,2,15,139,226,0,128,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 88
	.byte 8,128,159,231
bl _p_7

	.byte 10,223,139,226,0,9,189,232,128,128,189,232,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 92
	.byte 0,0,159,231,18,31,160,227
bl _p_1

	.byte 32,0,139,229
bl PInvoke_Win32Exception__ctor

	.byte 32,0,155,229
bl _p_8

	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . -12
	.byte 0,0,159,231,64,19,160,227
bl _p_9

	.byte 0,16,160,225,148,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_8

Lme_1a:
.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_System_ArraySegment_1_byte
PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_System_ArraySegment_1_byte:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,80,9,45,233,6,223,77,226,13,176,160,225,4,0,139,229,8,16,139,229,12,32,139,229
	.byte 16,48,139,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 96
	.byte 0,0,159,231,8,16,155,229,1,0,160,225,1,64,160,225,0,15,80,227,2,0,0,10,12,0,148,229,0,15,80,227
	.byte 1,0,0,26,0,111,160,227,3,0,0,234,12,0,148,229,0,15,80,227,17,0,0,155,4,111,132,226,0,0,159,229
	.byte 0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 96
	.byte 0,0,159,231,12,0,155,229,0,16,134,224,0,16,139,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 96
	.byte 0,0,159,231,16,32,155,229,4,0,155,229
bl _p_13

	.byte 6,223,139,226,80,9,189,232,128,128,189,232,14,16,160,225,0,0,159,229
bl _p_11

	.byte 233,0,0,0

Lme_1b:
.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_int
PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_int:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,19,223,77,226,0,16,141,229,52,0,141,229,56,32,141,229,0,15,160,227
	.byte 4,0,141,229,0,15,160,227,8,0,141,229,0,15,160,227,12,0,141,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 100
	.byte 0,0,159,231,56,16,157,229
bl _p_14

	.byte 0,16,160,225,1,15,141,226,0,128,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 96
	.byte 8,128,159,231,64,16,141,229
bl _p_15

	.byte 4,0,157,229,28,0,141,229,8,0,157,229,32,0,141,229,12,0,157,229,36,0,141,229,52,0,157,229,28,16,157,229
	.byte 32,32,157,229,36,48,157,229
bl _p_16

	.byte 0,48,160,225,64,16,157,229,0,15,160,227,16,0,141,229,0,15,160,227,20,0,141,229,0,15,160,227,24,0,141,229
	.byte 4,15,141,226,0,128,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 96
	.byte 8,128,159,231,0,47,160,227
bl _p_17

	.byte 16,0,157,229,40,0,141,229,20,0,157,229,44,0,141,229,24,0,157,229,48,0,141,229,0,32,157,229,2,0,160,225
	.byte 40,16,157,229,0,16,130,229,160,36,160,225,0,48,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . -4
	.byte 3,48,159,231,3,32,130,224,64,51,160,227,0,48,194,229,1,15,128,226,44,16,157,229,0,16,128,229,1,15,128,226
	.byte 48,16,157,229,0,16,128,229,19,223,141,226,0,1,189,232,128,128,189,232

Lme_1c:
.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_TryGetErrorMessage_PInvoke_Kernel32_FormatMessageFlags_void__int_int_System_Text_StringBuilder_intptr___string_
PInvoke_Kernel32_TryGetErrorMessage_PInvoke_Kernel32_FormatMessageFlags_void__int_int_System_Text_StringBuilder_intptr___string_:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,32,13,45,233,12,223,77,226,13,176,160,225,20,0,139,229,24,16,139,229,28,32,139,229
	.byte 32,48,139,229,72,80,157,229,76,224,157,229,36,224,139,229,80,224,157,229,40,224,139,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 104
	.byte 0,0,159,231,0,0,144,229,40,16,155,229,0,0,129,229,161,20,160,225,0,32,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . -4
	.byte 2,32,159,231,2,16,129,224,64,35,160,227,0,32,193,229,20,0,155,229,128,13,128,227,0,224,213,229,8,16,149,229
	.byte 12,16,145,229,20,32,149,229,2,16,129,224,64,195,129,226,24,16,155,229,28,32,155,229,32,48,155,229,0,80,141,229
	.byte 4,192,141,229,36,192,155,229,8,192,141,229
bl _p_18

	.byte 0,15,80,227,37,0,0,218,0,224,213,229,20,0,149,229,16,16,149,229,1,160,128,224,13,0,0,234,64,19,74,226
	.byte 5,0,160,225,0,224,213,229
bl _p_19

	.byte 0,16,160,225,1,8,160,225,32,8,160,225,176,17,203,225,8,15,80,227,2,0,0,218,176,1,219,225,184,1,80,227
	.byte 2,0,0,26,64,163,74,226,0,15,90,227,239,255,255,202,5,0,160,225,0,31,160,227,10,32,160,225,0,224,213,229
bl _p_20

	.byte 40,16,155,229,0,0,129,229,161,20,160,225,0,32,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . -4
	.byte 2,32,159,231,2,16,129,224,64,35,160,227,0,32,193,229,64,3,160,227,0,0,0,234,0,15,160,227,12,223,139,226
	.byte 32,13,189,232,128,128,189,232

Lme_1d:
.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_FindFirstFileEx_string_PInvoke_Kernel32_FINDEX_INFO_LEVELS_PInvoke_Kernel32_WIN32_FIND_DATA__PInvoke_Kernel32_FINDEX_SEARCH_OPS_intptr_PInvoke_Kernel32_FindFirstFileExFlags
PInvoke_Kernel32_FindFirstFileEx_string_PInvoke_Kernel32_FINDEX_INFO_LEVELS_PInvoke_Kernel32_WIN32_FIND_DATA__PInvoke_Kernel32_FINDEX_SEARCH_OPS_intptr_PInvoke_Kernel32_FindFirstFileExFlags:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,9,45,233,8,223,77,226,13,176,160,225,8,0,139,229,12,16,139,229,16,32,139,229
	.byte 20,48,139,229,48,224,157,229,24,224,139,229,52,224,157,229,28,224,139,229,24,192,155,229,8,0,155,229,12,16,155,229
	.byte 16,32,155,229,20,48,155,229,0,192,141,229,28,192,155,229,4,192,141,229
bl _p_21

	.byte 8,223,139,226,0,9,189,232,128,128,189,232

Lme_1e:
.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_FormatMessage_PInvoke_Kernel32_FormatMessageFlags_intptr_int_int_System_Text_StringBuilder_int_intptr__
PInvoke_Kernel32_FormatMessage_PInvoke_Kernel32_FormatMessageFlags_intptr_int_int_System_Text_StringBuilder_int_intptr__:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,9,45,233,12,223,77,226,13,176,160,225,16,0,139,229,20,16,139,229,24,32,139,229
	.byte 28,48,139,229,64,224,157,229,32,224,139,229,68,224,157,229,36,224,139,229,72,224,157,229,40,224,139,229,20,16,155,229
	.byte 16,0,155,229,24,32,155,229,28,48,155,229,32,192,155,229,0,192,141,229,36,192,155,229,4,192,141,229,40,192,155,229
	.byte 8,192,141,229
bl _p_18

	.byte 12,223,139,226,0,9,189,232,128,128,189,232

Lme_1f:
.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_CancelIoEx_PInvoke_Kernel32_SafeObjectHandle_intptr
PInvoke_Kernel32_CancelIoEx_PInvoke_Kernel32_SafeObjectHandle_intptr:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,4,16,141,229,4,16,157,229,0,0,157,229
bl _p_22

	.byte 255,0,0,226,3,223,141,226,0,1,189,232,128,128,189,232

Lme_20:
.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_intptr_int_intptr_intptr
PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_intptr_int_intptr_intptr:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,9,45,233,8,223,77,226,13,176,160,225,8,0,139,229,12,16,139,229,16,32,139,229
	.byte 20,48,139,229,48,224,157,229,24,224,139,229,12,16,155,229,20,48,155,229,24,192,155,229,8,0,155,229,16,32,155,229
	.byte 0,192,141,229
bl _p_23

	.byte 255,0,0,226,8,223,139,226,0,9,189,232,128,128,189,232

Lme_21:
.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_intptr_int_System_Nullable_1_int__intptr
PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_intptr_int_System_Nullable_1_int__intptr:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,9,45,233,19,223,77,226,13,176,160,225,56,0,139,229,60,16,139,229,64,32,139,229
	.byte 3,96,160,225,96,224,157,229,68,224,139,229,0,15,160,227,12,0,139,229,60,0,155,229,8,0,139,229,0,0,159,229
	.byte 0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 88
	.byte 0,0,159,231,4,0,214,229,0,15,80,227,2,0,0,26,0,15,160,227,20,0,139,229,6,0,0,234,0,128,159,229
	.byte 0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 88
	.byte 8,128,159,231,6,0,160,225
bl _p_7

	.byte 20,0,139,229,20,0,155,229,12,0,139,229,68,0,155,229,16,0,139,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 88
	.byte 0,0,159,231,4,0,214,229,56,16,155,229,24,16,139,229,8,16,155,229,28,16,139,229,64,16,155,229,32,16,139,229
	.byte 0,15,80,227,2,0,0,26,0,15,160,227,36,0,139,229,1,0,0,234,3,15,139,226,36,0,139,229,24,0,155,229
	.byte 28,16,155,229,32,32,155,229,36,48,155,229,16,192,155,229,0,192,141,229
bl _p_23

	.byte 255,16,0,226,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 88
	.byte 0,0,159,231,4,0,214,229,20,16,139,229,0,15,80,227,18,0,0,10,12,16,155,229,0,15,160,227,40,0,139,229
	.byte 0,15,160,227,44,0,139,229,10,15,139,226,0,128,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 88
	.byte 8,128,159,231
bl _p_24

	.byte 40,0,155,229,48,0,139,229,44,0,155,229,52,0,139,229,48,0,155,229,0,0,134,229,52,0,155,229,4,0,134,229
	.byte 20,0,155,229,19,223,139,226,64,9,189,232,128,128,189,232

Lme_22:
.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_void__int_System_Nullable_1_int__PInvoke_Kernel32_OVERLAPPED_
PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_void__int_System_Nullable_1_int__PInvoke_Kernel32_OVERLAPPED_:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,13,45,233,16,223,77,226,13,176,160,225,44,0,139,229,48,16,139,229,52,32,139,229
	.byte 3,96,160,225,88,224,157,229,56,224,139,229,0,15,160,227,8,0,139,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 88
	.byte 0,0,159,231,4,0,214,229,0,15,80,227,1,0,0,26,0,175,160,227,6,0,0,234,0,128,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 88
	.byte 8,128,159,231,6,0,160,225
bl _p_7

	.byte 0,160,160,225,8,160,139,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 88
	.byte 0,0,159,231,4,0,214,229,44,16,155,229,12,16,139,229,48,16,155,229,16,16,139,229,52,16,155,229,20,16,139,229
	.byte 0,15,80,227,2,0,0,26,0,15,160,227,24,0,139,229,1,0,0,234,2,15,139,226,24,0,139,229,12,0,155,229
	.byte 16,16,155,229,20,32,155,229,24,48,155,229,56,192,155,229,0,192,141,229
bl _p_23

	.byte 255,16,0,226,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 88
	.byte 0,0,159,231,4,0,214,229,1,160,160,225,0,15,80,227,18,0,0,10,8,16,155,229,0,15,160,227,28,0,139,229
	.byte 0,15,160,227,32,0,139,229,7,15,139,226,0,128,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 88
	.byte 8,128,159,231
bl _p_24

	.byte 28,0,155,229,36,0,139,229,32,0,155,229,40,0,139,229,36,0,155,229,0,0,134,229,40,0,155,229,4,0,134,229
	.byte 10,0,160,225,16,223,139,226,64,13,189,232,128,128,189,232

Lme_23:
.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_intptr_int_intptr_intptr
PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_intptr_int_intptr_intptr:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,9,45,233,8,223,77,226,13,176,160,225,8,0,139,229,12,16,139,229,16,32,139,229
	.byte 20,48,139,229,48,224,157,229,24,224,139,229,12,16,155,229,20,48,155,229,24,192,155,229,8,0,155,229,16,32,155,229
	.byte 0,192,141,229
bl _p_25

	.byte 255,0,0,226,8,223,139,226,0,9,189,232,128,128,189,232

Lme_24:
.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_intptr_int_System_Nullable_1_int__intptr
PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_intptr_int_System_Nullable_1_int__intptr:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,9,45,233,19,223,77,226,13,176,160,225,56,0,139,229,60,16,139,229,64,32,139,229
	.byte 3,96,160,225,96,224,157,229,68,224,139,229,0,15,160,227,12,0,139,229,60,0,155,229,8,0,139,229,0,0,159,229
	.byte 0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 88
	.byte 0,0,159,231,4,0,214,229,0,15,80,227,2,0,0,26,0,15,160,227,20,0,139,229,6,0,0,234,0,128,159,229
	.byte 0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 88
	.byte 8,128,159,231,6,0,160,225
bl _p_7

	.byte 20,0,139,229,20,0,155,229,12,0,139,229,68,0,155,229,16,0,139,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 88
	.byte 0,0,159,231,4,0,214,229,56,16,155,229,24,16,139,229,8,16,155,229,28,16,139,229,64,16,155,229,32,16,139,229
	.byte 0,15,80,227,2,0,0,26,0,15,160,227,36,0,139,229,1,0,0,234,3,15,139,226,36,0,139,229,24,0,155,229
	.byte 28,16,155,229,32,32,155,229,36,48,155,229,16,192,155,229,0,192,141,229
bl _p_25

	.byte 255,16,0,226,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 88
	.byte 0,0,159,231,4,0,214,229,20,16,139,229,0,15,80,227,18,0,0,10,12,16,155,229,0,15,160,227,40,0,139,229
	.byte 0,15,160,227,44,0,139,229,10,15,139,226,0,128,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 88
	.byte 8,128,159,231
bl _p_24

	.byte 40,0,155,229,48,0,139,229,44,0,155,229,52,0,139,229,48,0,155,229,0,0,134,229,52,0,155,229,4,0,134,229
	.byte 20,0,155,229,19,223,139,226,64,9,189,232,128,128,189,232

Lme_25:
.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_void__int_System_Nullable_1_int__PInvoke_Kernel32_OVERLAPPED_
PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_void__int_System_Nullable_1_int__PInvoke_Kernel32_OVERLAPPED_:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,13,45,233,16,223,77,226,13,176,160,225,44,0,139,229,48,16,139,229,52,32,139,229
	.byte 3,96,160,225,88,224,157,229,56,224,139,229,0,15,160,227,8,0,139,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 88
	.byte 0,0,159,231,4,0,214,229,0,15,80,227,1,0,0,26,0,175,160,227,6,0,0,234,0,128,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 88
	.byte 8,128,159,231,6,0,160,225
bl _p_7

	.byte 0,160,160,225,8,160,139,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 88
	.byte 0,0,159,231,4,0,214,229,44,16,155,229,12,16,139,229,48,16,155,229,16,16,139,229,52,16,155,229,20,16,139,229
	.byte 0,15,80,227,2,0,0,26,0,15,160,227,24,0,139,229,1,0,0,234,2,15,139,226,24,0,139,229,12,0,155,229
	.byte 16,16,155,229,20,32,155,229,24,48,155,229,56,192,155,229,0,192,141,229
bl _p_25

	.byte 255,16,0,226,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 88
	.byte 0,0,159,231,4,0,214,229,1,160,160,225,0,15,80,227,18,0,0,10,8,16,155,229,0,15,160,227,28,0,139,229
	.byte 0,15,160,227,32,0,139,229,7,15,139,226,0,128,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 88
	.byte 8,128,159,231
bl _p_24

	.byte 28,0,155,229,36,0,139,229,32,0,155,229,40,0,139,229,36,0,155,229,0,0,134,229,40,0,155,229,4,0,134,229
	.byte 10,0,160,225,16,223,139,226,64,13,189,232,128,128,189,232

Lme_26:
.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_CreateMutex_intptr_bool_string
PInvoke_Kernel32_CreateMutex_intptr_bool_string:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,5,223,77,226,0,0,141,229,4,16,205,229,8,32,141,229,0,0,157,229
	.byte 4,16,221,229,8,32,157,229
bl _p_26

	.byte 5,223,141,226,0,1,189,232,128,128,189,232

Lme_27:
.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_CreateMutex_System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_bool_string
PInvoke_Kernel32_CreateMutex_System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_bool_string:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,9,45,233,17,223,77,226,13,176,160,225,36,0,139,229,40,16,139,229,44,32,139,229
	.byte 48,48,139,229,88,224,157,229,52,224,139,229,92,224,157,229,56,224,139,229,0,15,160,227,0,0,139,229,0,15,160,227
	.byte 4,0,139,229,0,15,160,227,8,0,139,229,0,15,160,227,12,0,139,229,0,15,160,227,16,0,139,229,0,15,160,227
	.byte 20,0,139,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 108
	.byte 0,0,159,231,48,0,219,229,0,15,80,227,12,0,0,26,0,15,160,227,12,0,139,229,0,15,160,227,16,0,139,229
	.byte 0,15,160,227,20,0,139,229,12,0,155,229,24,0,139,229,16,0,155,229,28,0,139,229,20,0,155,229,32,0,139,229
	.byte 6,0,0,234,9,15,139,226,0,128,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 108
	.byte 8,128,159,231,6,31,139,226
bl _p_27

	.byte 24,0,155,229,0,0,139,229,28,0,155,229,4,0,139,229,32,0,155,229,8,0,139,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 108
	.byte 0,0,159,231,48,0,219,229,0,15,80,227,1,0,0,26,0,111,160,227,0,0,0,234,11,96,160,225,6,0,160,225
	.byte 52,16,219,229,56,32,155,229
bl _p_26

	.byte 17,223,139,226,64,9,189,232,128,128,189,232

Lme_28:
.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_GetSystemTime_intptr
PInvoke_Kernel32_GetSystemTime_intptr:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,0,0,157,229
bl _p_28

	.byte 3,223,141,226,0,1,189,232,128,128,189,232

Lme_29:
.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_GetSystemTime_PInvoke_Kernel32_SYSTEMTIME_
PInvoke_Kernel32_GetSystemTime_PInvoke_Kernel32_SYSTEMTIME_:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,0,0,157,229
bl _p_28

	.byte 3,223,141,226,0,1,189,232,128,128,189,232

Lme_2a:
.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_FormatMessage_PInvoke_Kernel32_FormatMessageFlags_intptr_int_int_intptr___int
PInvoke_Kernel32_FormatMessage_PInvoke_Kernel32_FormatMessageFlags_intptr_int_int_intptr___int:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,9,45,233,8,223,77,226,13,176,160,225,8,0,139,229,12,16,139,229,16,32,139,229
	.byte 20,48,139,229,48,224,157,229,24,224,139,229,52,224,157,229,28,224,139,229,12,16,155,229,8,0,155,229,16,32,155,229
	.byte 20,48,155,229,24,192,155,229,0,192,141,229,28,192,155,229,4,192,141,229
bl _p_29

	.byte 8,223,139,226,0,9,189,232,128,128,189,232

Lme_2b:
.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_intptr_int
PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_intptr_int:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,5,223,77,226,0,0,141,229,4,16,141,229,8,32,141,229,4,16,157,229
	.byte 0,0,157,229,8,32,157,229
bl _p_10

	.byte 5,223,141,226,0,1,189,232,128,128,189,232

Lme_2c:
.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_intptr_int
PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_intptr_int:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,5,223,77,226,0,0,141,229,4,16,141,229,8,32,141,229,4,16,157,229
	.byte 0,0,157,229,8,32,157,229
bl _p_13

	.byte 5,223,141,226,0,1,189,232,128,128,189,232

Lme_2d:
.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_TryGetErrorMessage_PInvoke_Kernel32_FormatMessageFlags_intptr_int_int_System_Text_StringBuilder_intptr___string_
PInvoke_Kernel32_TryGetErrorMessage_PInvoke_Kernel32_FormatMessageFlags_intptr_int_int_System_Text_StringBuilder_intptr___string_:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,9,45,233,12,223,77,226,13,176,160,225,16,0,139,229,20,16,139,229,24,32,139,229
	.byte 28,48,139,229,64,224,157,229,32,224,139,229,68,224,157,229,36,224,139,229,72,224,157,229,40,224,139,229,20,16,155,229
	.byte 16,0,155,229,24,32,155,229,28,48,155,229,32,192,155,229,0,192,141,229,36,192,155,229,4,192,141,229,40,192,155,229
	.byte 8,192,141,229
bl _p_3

	.byte 255,0,0,226,12,223,139,226,0,9,189,232,128,128,189,232

Lme_2e:
.text
	.align 2
	.no_dead_strip PInvoke_Kernel32__cctor
PInvoke_Kernel32__cctor:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,15,160,227,0,0,141,229,0,15,224,227,0,0,141,229
	.byte 0,16,160,225,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 112
	.byte 0,0,159,231,0,16,128,229,3,223,141,226,0,1,189,232,128,128,189,232

Lme_2f:
.text
ut_48:

	.byte 8,0,128,226
	b PInvoke_Kernel32_ACCESS_MASK__ctor_uint

ut_end:
.section __TEXT, __const
_unbox_trampoline_p:

	.long 0
LDIFF_SYM3=ut_end - ut_48
	.long LDIFF_SYM3
.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_ACCESS_MASK__ctor_uint
PInvoke_Kernel32_ACCESS_MASK__ctor_uint:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,4,16,141,229,4,16,157,229,0,0,157,229
	.byte 0,16,128,229,3,223,141,226,0,1,189,232,128,128,189,232

Lme_30:
.text
ut_49:

	.byte 8,0,128,226
	b PInvoke_Kernel32_ACCESS_MASK_get_Value

.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_ACCESS_MASK_get_Value
PInvoke_Kernel32_ACCESS_MASK_get_Value:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,0,0,157,229,0,0,144,229,3,223,141,226
	.byte 0,1,189,232,128,128,189,232

Lme_31:
.text
ut_50:

	.byte 8,0,128,226
	b PInvoke_Kernel32_ACCESS_MASK_get_AsInt32

.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_ACCESS_MASK_get_AsInt32
PInvoke_Kernel32_ACCESS_MASK_get_AsInt32:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,0,0,157,229,0,0,144,229,3,223,141,226
	.byte 0,1,189,232,128,128,189,232

Lme_32:
.text
ut_51:

	.byte 8,0,128,226
	b PInvoke_Kernel32_ACCESS_MASK_get_GenericRights

.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_ACCESS_MASK_get_GenericRights
PInvoke_Kernel32_ACCESS_MASK_get_GenericRights:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,0,0,157,229,0,0,144,229,240,4,0,226
	.byte 3,223,141,226,0,1,189,232,128,128,189,232

Lme_33:
.text
ut_52:

	.byte 8,0,128,226
	b PInvoke_Kernel32_ACCESS_MASK_get_SpecialRights

.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_ACCESS_MASK_get_SpecialRights
PInvoke_Kernel32_ACCESS_MASK_get_SpecialRights:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,0,0,157,229,0,0,144,229,240,6,0,226
	.byte 3,223,141,226,0,1,189,232,128,128,189,232

Lme_34:
.text
ut_53:

	.byte 8,0,128,226
	b PInvoke_Kernel32_ACCESS_MASK_get_StandardRights

.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_ACCESS_MASK_get_StandardRights
PInvoke_Kernel32_ACCESS_MASK_get_StandardRights:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,0,0,157,229,0,0,144,229,255,8,0,226
	.byte 3,223,141,226,0,1,189,232,128,128,189,232

Lme_35:
.text
ut_54:

	.byte 8,0,128,226
	b PInvoke_Kernel32_ACCESS_MASK_get_SpecificRights

.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_ACCESS_MASK_get_SpecificRights
PInvoke_Kernel32_ACCESS_MASK_get_SpecificRights:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,0,0,157,229,0,0,144,229,255,31,15,227
	.byte 1,0,0,224,3,223,141,226,0,1,189,232,128,128,189,232

Lme_36:
.text
ut_55:

	.byte 8,0,128,226
	b PInvoke_Kernel32_ACCESS_MASK_get_DesktopSpecificRights

.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_ACCESS_MASK_get_DesktopSpecificRights
PInvoke_Kernel32_ACCESS_MASK_get_DesktopSpecificRights:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,0,0,157,229,0,0,144,229,255,31,15,227
	.byte 1,0,0,224,3,223,141,226,0,1,189,232,128,128,189,232

Lme_37:
.text
ut_56:

	.byte 8,0,128,226
	b PInvoke_Kernel32_ACCESS_MASK_get_InteractiveWindowStationGenericRights

.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_ACCESS_MASK_get_InteractiveWindowStationGenericRights
PInvoke_Kernel32_ACCESS_MASK_get_InteractiveWindowStationGenericRights:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,0,0,157,229,0,0,144,229,240,4,0,226
	.byte 3,223,141,226,0,1,189,232,128,128,189,232

Lme_38:
.text
ut_57:

	.byte 8,0,128,226
	b PInvoke_Kernel32_ACCESS_MASK_get_NonInteractiveWindowStationGenericRights

.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_ACCESS_MASK_get_NonInteractiveWindowStationGenericRights
PInvoke_Kernel32_ACCESS_MASK_get_NonInteractiveWindowStationGenericRights:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,0,0,157,229,0,0,144,229,240,4,0,226
	.byte 3,223,141,226,0,1,189,232,128,128,189,232

Lme_39:
.text
ut_58:

	.byte 8,0,128,226
	b PInvoke_Kernel32_ACCESS_MASK_get_WindowStationSpecificRights

.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_ACCESS_MASK_get_WindowStationSpecificRights
PInvoke_Kernel32_ACCESS_MASK_get_WindowStationSpecificRights:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,0,0,157,229,0,0,144,229,255,31,15,227
	.byte 1,0,0,224,3,223,141,226,0,1,189,232,128,128,189,232

Lme_3a:
.text
ut_59:

	.byte 8,0,128,226
	b PInvoke_Kernel32_ACCESS_MASK_op_Implicit_int

.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_ACCESS_MASK_op_Implicit_int
PInvoke_Kernel32_ACCESS_MASK_op_Implicit_int:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,5,223,77,226,0,0,141,229,12,16,141,229,0,15,160,227,4,0,141,229
	.byte 12,0,157,229,4,0,141,229,8,0,141,229,0,0,157,229,8,16,157,229,0,16,128,229,5,223,141,226,0,1,189,232
	.byte 128,128,189,232

Lme_3b:
.text
ut_60:

	.byte 8,0,128,226
	b PInvoke_Kernel32_ACCESS_MASK_op_Explicit_PInvoke_Kernel32_ACCESS_MASK

.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_ACCESS_MASK_op_Explicit_PInvoke_Kernel32_ACCESS_MASK
PInvoke_Kernel32_ACCESS_MASK_op_Explicit_PInvoke_Kernel32_ACCESS_MASK:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,9,45,233,2,223,77,226,13,176,160,225,0,0,139,229,0,0,155,229,2,223,139,226
	.byte 0,9,189,232,128,128,189,232

Lme_3c:
.text
ut_61:

	.byte 8,0,128,226
	b PInvoke_Kernel32_ACCESS_MASK_op_Implicit_uint

.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_ACCESS_MASK_op_Implicit_uint
PInvoke_Kernel32_ACCESS_MASK_op_Implicit_uint:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,5,223,77,226,0,0,141,229,12,16,141,229,0,15,160,227,4,0,141,229
	.byte 12,0,157,229,4,0,141,229,8,0,141,229,0,0,157,229,8,16,157,229,0,16,128,229,5,223,141,226,0,1,189,232
	.byte 128,128,189,232

Lme_3d:
.text
ut_62:

	.byte 8,0,128,226
	b PInvoke_Kernel32_ACCESS_MASK_op_Implicit_PInvoke_Kernel32_ACCESS_MASK

.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_ACCESS_MASK_op_Implicit_PInvoke_Kernel32_ACCESS_MASK
PInvoke_Kernel32_ACCESS_MASK_op_Implicit_PInvoke_Kernel32_ACCESS_MASK:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,9,45,233,2,223,77,226,13,176,160,225,0,0,139,229,0,0,155,229,2,223,139,226
	.byte 0,9,189,232,128,128,189,232

Lme_3e:
.text
ut_63:

	.byte 8,0,128,226
	b PInvoke_Kernel32_ACCESS_MASK_op_Implicit_PInvoke_Kernel32_ACCESS_MASK_StandardRight

.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_ACCESS_MASK_op_Implicit_PInvoke_Kernel32_ACCESS_MASK_StandardRight
PInvoke_Kernel32_ACCESS_MASK_op_Implicit_PInvoke_Kernel32_ACCESS_MASK_StandardRight:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,5,223,77,226,0,0,141,229,12,16,141,229,0,15,160,227,4,0,141,229
	.byte 12,0,157,229,4,0,141,229,8,0,141,229,0,0,157,229,8,16,157,229,0,16,128,229,5,223,141,226,0,1,189,232
	.byte 128,128,189,232

Lme_3f:
.text
ut_64:

	.byte 8,0,128,226
	b PInvoke_Kernel32_ACCESS_MASK_op_Implicit_PInvoke_Kernel32_ACCESS_MASK_GenericRight

.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_ACCESS_MASK_op_Implicit_PInvoke_Kernel32_ACCESS_MASK_GenericRight
PInvoke_Kernel32_ACCESS_MASK_op_Implicit_PInvoke_Kernel32_ACCESS_MASK_GenericRight:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,5,223,77,226,0,0,141,229,12,16,141,229,0,15,160,227,4,0,141,229
	.byte 12,0,157,229,4,0,141,229,8,0,141,229,0,0,157,229,8,16,157,229,0,16,128,229,5,223,141,226,0,1,189,232
	.byte 128,128,189,232

Lme_40:
.text
ut_65:

	.byte 8,0,128,226
	b PInvoke_Kernel32_ACCESS_MASK_op_Implicit_PInvoke_Kernel32_ACCESS_MASK_SpecificRight

.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_ACCESS_MASK_op_Implicit_PInvoke_Kernel32_ACCESS_MASK_SpecificRight
PInvoke_Kernel32_ACCESS_MASK_op_Implicit_PInvoke_Kernel32_ACCESS_MASK_SpecificRight:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,5,223,77,226,0,0,141,229,12,16,141,229,0,15,160,227,4,0,141,229
	.byte 12,0,157,229,4,0,141,229,8,0,141,229,0,0,157,229,8,16,157,229,0,16,128,229,5,223,141,226,0,1,189,232
	.byte 128,128,189,232

Lme_41:
.text
ut_66:

	.byte 8,0,128,226
	b PInvoke_Kernel32_ACCESS_MASK_GetHashCode

.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_ACCESS_MASK_GetHashCode
PInvoke_Kernel32_ACCESS_MASK_GetHashCode:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,0,0,157,229,0,0,144,229,3,223,141,226
	.byte 0,1,189,232,128,128,189,232

Lme_42:
.text
ut_67:

	.byte 8,0,128,226
	b PInvoke_Kernel32_ACCESS_MASK_Equals_PInvoke_Kernel32_ACCESS_MASK

.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_ACCESS_MASK_Equals_PInvoke_Kernel32_ACCESS_MASK
PInvoke_Kernel32_ACCESS_MASK_Equals_PInvoke_Kernel32_ACCESS_MASK:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,9,45,233,2,223,77,226,13,176,160,225,0,0,139,229,4,16,139,229,0,0,155,229
	.byte 0,0,144,229,4,16,155,229,1,0,80,225,0,0,160,19,1,0,160,3,2,223,139,226,0,9,189,232,128,128,189,232

Lme_43:
.text
ut_68:

	.byte 8,0,128,226
	b PInvoke_Kernel32_ACCESS_MASK_Equals_object

.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_ACCESS_MASK_Equals_object
PInvoke_Kernel32_ACCESS_MASK_Equals_object:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,32,5,45,233,5,223,77,226,8,0,141,229,1,160,160,225,10,80,160,225,0,15,90,227
	.byte 10,0,0,10,0,0,154,229,0,0,144,229,8,0,144,229,8,0,144,229,0,16,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 116
	.byte 1,16,159,231,1,0,80,225,0,0,0,10,0,95,160,227,0,15,85,227,22,0,0,10,0,0,154,229,24,16,208,229
	.byte 0,15,81,227,22,0,0,27,0,0,144,229,0,0,144,229,0,16,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 116
	.byte 1,16,159,231,1,0,80,225,14,0,0,27,2,15,138,226,0,0,144,229,4,0,141,229,0,0,141,229,8,0,157,229
	.byte 0,0,144,229,0,16,157,229,1,0,80,225,0,0,160,19,1,0,160,3,0,0,0,234,0,15,160,227,5,223,141,226
	.byte 32,5,189,232,128,128,189,232,14,16,160,225,0,0,159,229
bl _p_11

	.byte 239,0,0,0

Lme_44:
.text
ut_69:

	.byte 8,0,128,226
	b PInvoke_Kernel32_ACCESS_MASK_CompareTo_object

.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_ACCESS_MASK_CompareTo_object
PInvoke_Kernel32_ACCESS_MASK_CompareTo_object:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,5,223,77,226,0,0,141,229,4,16,141,229,0,0,157,229,0,0,144,229
	.byte 8,0,141,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 120
	.byte 0,0,159,231,3,31,160,227
bl _p_1

	.byte 0,32,160,225,8,0,157,229,8,0,130,229,2,0,160,225,4,16,157,229,0,32,146,229,0,128,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 124
	.byte 8,128,159,231,15,224,160,225,16,240,18,229,5,223,141,226,0,1,189,232,128,128,189,232

Lme_45:
.text
ut_70:

	.byte 8,0,128,226
	b PInvoke_Kernel32_ACCESS_MASK_CompareTo_PInvoke_Kernel32_ACCESS_MASK

.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_ACCESS_MASK_CompareTo_PInvoke_Kernel32_ACCESS_MASK
PInvoke_Kernel32_ACCESS_MASK_CompareTo_PInvoke_Kernel32_ACCESS_MASK:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,13,45,233,2,223,77,226,13,176,160,225,0,160,160,225,4,16,139,229,0,15,160,227
	.byte 0,0,139,229,0,0,154,229,0,0,139,229,4,16,155,229,11,160,160,225,1,96,160,225,0,0,155,229,1,0,80,225
	.byte 1,0,0,42,0,111,224,227,5,0,0,234,0,0,154,229,6,0,80,225,1,0,0,154,64,99,160,227,0,0,0,234
	.byte 0,111,160,227,6,0,160,225,2,223,139,226,64,13,189,232,128,128,189,232

Lme_46:
.text
ut_71:

	.byte 8,0,128,226
	b PInvoke_Kernel32_ACCESS_MASK_ToString

.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_ACCESS_MASK_ToString
PInvoke_Kernel32_ACCESS_MASK_ToString:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,4,0,141,229,0,15,160,227,0,0,141,229,4,0,157,229
	.byte 0,0,144,229,0,0,141,229,13,0,160,225
bl _p_30

	.byte 3,223,141,226,0,1,189,232,128,128,189,232

Lme_47:
.text
ut_72:

	.byte 8,0,128,226
	b PInvoke_Kernel32_ACCESS_MASK_ToString_string_System_IFormatProvider

.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_ACCESS_MASK_ToString_string_System_IFormatProvider
PInvoke_Kernel32_ACCESS_MASK_ToString_string_System_IFormatProvider:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,5,223,77,226,4,0,141,229,8,16,141,229,12,32,141,229,0,15,160,227
	.byte 0,0,141,229,4,0,157,229,0,0,144,229,0,0,141,229,13,0,160,225,8,16,157,229,12,32,157,229
bl _p_31

	.byte 5,223,141,226,0,1,189,232,128,128,189,232

Lme_48:
.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_SafeFindFilesHandle__ctor
PInvoke_Kernel32_SafeFindFilesHandle__ctor:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 112
	.byte 0,0,159,231,0,16,144,229,0,0,157,229,64,35,160,227
bl _p_32

	.byte 3,223,141,226,0,1,189,232,128,128,189,232

Lme_49:
.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_SafeFindFilesHandle__ctor_intptr_bool
PInvoke_Kernel32_SafeFindFilesHandle__ctor_intptr_bool:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,5,223,77,226,0,0,141,229,4,16,141,229,8,32,205,229,0,0,159,229
	.byte 0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 128
	.byte 0,0,159,231,0,16,144,229,0,0,157,229,8,32,221,229
bl _p_32

	.byte 4,16,157,229,0,0,157,229,8,16,128,229,5,223,141,226,0,1,189,232,128,128,189,232

Lme_4a:
.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_SafeFindFilesHandle_get_IsInvalid
PInvoke_Kernel32_SafeFindFilesHandle_get_IsInvalid:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,0,0,157,229,8,0,144,229,0,16,159,229
	.byte 0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 112
	.byte 1,16,159,231,0,16,145,229,1,0,80,225,0,0,160,19,1,0,160,3,3,223,141,226,0,1,189,232,128,128,189,232

Lme_4b:
.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_SafeFindFilesHandle_ReleaseHandle
PInvoke_Kernel32_SafeFindFilesHandle_ReleaseHandle:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,0,0,157,229,8,0,144,229
bl _p_33

	.byte 255,0,0,226,3,223,141,226,0,1,189,232,128,128,189,232

Lme_4c:
.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_SafeFindFilesHandle__cctor
PInvoke_Kernel32_SafeFindFilesHandle__cctor:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 132
	.byte 0,0,159,231
bl _p_34

	.byte 0,0,141,229
bl _p_35

	.byte 0,16,157,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 136
	.byte 0,0,159,231,0,16,128,229,3,223,141,226,0,1,189,232,128,128,189,232

Lme_4d:
.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_SafeLibraryHandle__ctor
PInvoke_Kernel32_SafeLibraryHandle__ctor:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 112
	.byte 0,0,159,231,0,16,144,229,0,0,157,229,64,35,160,227
bl _p_32

	.byte 3,223,141,226,0,1,189,232,128,128,189,232

Lme_4e:
.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_SafeLibraryHandle__ctor_intptr_bool
PInvoke_Kernel32_SafeLibraryHandle__ctor_intptr_bool:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,5,223,77,226,0,0,141,229,4,16,141,229,8,32,205,229,0,0,159,229
	.byte 0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 112
	.byte 0,0,159,231,0,16,144,229,0,0,157,229,8,32,221,229
bl _p_32

	.byte 4,16,157,229,0,0,157,229,8,16,128,229,5,223,141,226,0,1,189,232,128,128,189,232

Lme_4f:
.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_SafeLibraryHandle_get_IsInvalid
PInvoke_Kernel32_SafeLibraryHandle_get_IsInvalid:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,0,0,157,229,8,0,144,229,0,16,159,229
	.byte 0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 112
	.byte 1,16,159,231,0,16,145,229,1,0,80,225,0,0,160,19,1,0,160,3,0,15,80,227,10,0,0,26,0,0,157,229
	.byte 8,0,144,229,0,16,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 128
	.byte 1,16,159,231,0,16,145,229,1,0,80,225,0,0,160,19,1,0,160,3,0,0,0,234,64,3,160,227,3,223,141,226
	.byte 0,1,189,232,128,128,189,232

Lme_50:
.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_SafeLibraryHandle_ReleaseHandle
PInvoke_Kernel32_SafeLibraryHandle_ReleaseHandle:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,0,0,157,229,8,0,144,229
bl _p_36

	.byte 255,0,0,226,3,223,141,226,0,1,189,232,128,128,189,232

Lme_51:
.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_SafeLibraryHandle__cctor
PInvoke_Kernel32_SafeLibraryHandle__cctor:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,5,223,77,226,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 128
	.byte 0,0,159,231,0,0,144,229,8,0,141,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 140
	.byte 0,0,159,231
bl _p_34

	.byte 8,16,157,229,4,0,141,229,64,35,160,227
bl _p_37

	.byte 4,16,157,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 144
	.byte 0,0,159,231,0,16,128,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 140
	.byte 0,0,159,231
bl _p_34

	.byte 0,0,141,229
bl _p_38

	.byte 0,16,157,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 148
	.byte 0,0,159,231,0,16,128,229,5,223,141,226,0,1,189,232,128,128,189,232

Lme_52:
.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_SafeObjectHandle__ctor
PInvoke_Kernel32_SafeObjectHandle__ctor:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 112
	.byte 0,0,159,231,0,16,144,229,0,0,157,229,64,35,160,227
bl _p_32

	.byte 3,223,141,226,0,1,189,232,128,128,189,232

Lme_53:
.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_SafeObjectHandle__ctor_intptr_bool
PInvoke_Kernel32_SafeObjectHandle__ctor_intptr_bool:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,5,223,77,226,0,0,141,229,4,16,141,229,8,32,205,229,0,0,159,229
	.byte 0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 112
	.byte 0,0,159,231,0,16,144,229,0,0,157,229,8,32,221,229
bl _p_32

	.byte 4,16,157,229,0,0,157,229,8,16,128,229,5,223,141,226,0,1,189,232,128,128,189,232

Lme_54:
.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_SafeObjectHandle_get_IsInvalid
PInvoke_Kernel32_SafeObjectHandle_get_IsInvalid:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,0,0,157,229,8,0,144,229,0,16,159,229
	.byte 0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 112
	.byte 1,16,159,231,0,16,145,229,1,0,80,225,0,0,160,19,1,0,160,3,0,15,80,227,10,0,0,26,0,0,157,229
	.byte 8,0,144,229,0,16,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 128
	.byte 1,16,159,231,0,16,145,229,1,0,80,225,0,0,160,19,1,0,160,3,0,0,0,234,64,3,160,227,3,223,141,226
	.byte 0,1,189,232,128,128,189,232

Lme_55:
.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_SafeObjectHandle_ReleaseHandle
PInvoke_Kernel32_SafeObjectHandle_ReleaseHandle:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,0,0,157,229,8,0,144,229
bl _p_39

	.byte 255,0,0,226,3,223,141,226,0,1,189,232,128,128,189,232

Lme_56:
.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_SafeObjectHandle__cctor
PInvoke_Kernel32_SafeObjectHandle__cctor:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,5,223,77,226,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 152
	.byte 0,0,159,231
bl _p_34

	.byte 8,0,141,229
bl _p_40

	.byte 8,16,157,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 156
	.byte 0,0,159,231,0,16,128,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 128
	.byte 0,0,159,231,0,0,144,229,4,0,141,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 152
	.byte 0,0,159,231
bl _p_34

	.byte 4,16,157,229,0,0,141,229,0,47,160,227
bl _p_41

	.byte 0,16,157,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 160
	.byte 0,0,159,231,0,16,128,229,5,223,141,226,0,1,189,232,128,128,189,232

Lme_57:
.text
ut_88:

	.byte 8,0,128,226
	b PInvoke_Kernel32_SECURITY_ATTRIBUTES_get_InheritHandle

.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_SECURITY_ATTRIBUTES_get_InheritHandle
PInvoke_Kernel32_SECURITY_ATTRIBUTES_get_InheritHandle:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,0,0,157,229,8,0,144,229,0,15,80,227
	.byte 0,0,160,227,1,0,160,131,3,223,141,226,0,1,189,232,128,128,189,232

Lme_58:
.text
ut_89:

	.byte 8,0,128,226
	b PInvoke_Kernel32_SECURITY_ATTRIBUTES_Create

.text
	.align 2
	.no_dead_strip PInvoke_Kernel32_SECURITY_ATTRIBUTES_Create
PInvoke_Kernel32_SECURITY_ATTRIBUTES_Create:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,9,223,77,226,0,0,141,229,0,15,160,227,4,0,141,229,0,15,160,227
	.byte 8,0,141,229,0,15,160,227,12,0,141,229,0,15,160,227,4,0,141,229,0,15,160,227,8,0,141,229,0,15,160,227
	.byte 12,0,141,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 164
	.byte 0,0,159,231
bl _p_42

	.byte 4,0,141,229,16,0,141,229,8,0,157,229,20,0,141,229,12,0,157,229,24,0,141,229,0,0,157,229,16,16,157,229
	.byte 0,16,128,229,20,16,157,229,4,16,128,229,24,16,157,229,8,16,128,229,9,223,141,226,0,1,189,232,128,128,189,232

Lme_59:
.text
	.align 2
	.no_dead_strip PInvoke_Kernel32Extensions_GetMessage_PInvoke_Win32ErrorCode
PInvoke_Kernel32Extensions_GetMessage_PInvoke_Win32ErrorCode:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,9,45,233,4,223,77,226,13,176,160,225,8,0,139,229,64,13,160,227,0,31,160,227
	.byte 8,32,155,229,0,63,160,227,0,207,160,227,0,192,141,229,65,203,160,227,4,192,141,229
bl _p_29

	.byte 4,223,139,226,0,9,189,232,128,128,189,232

Lme_5a:
.text
	.align 2
	.no_dead_strip PInvoke_Kernel32Extensions_ThrowOnError_PInvoke_Win32ErrorCode
PInvoke_Kernel32Extensions_ThrowOnError_PInvoke_Win32ErrorCode:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,5,223,77,226,0,0,141,229,0,0,157,229,0,15,80,227,2,0,0,26
	.byte 5,223,141,226,0,1,189,232,128,128,189,232,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 92
	.byte 0,0,159,231,18,31,160,227
bl _p_1

	.byte 8,0,141,229,0,16,157,229
bl _p_43

	.byte 8,0,157,229
bl _p_8

Lme_5b:
.text
	.align 2
	.no_dead_strip PInvoke_Kernel32Extensions_ThrowOnError_PInvoke_NTSTATUS
PInvoke_Kernel32Extensions_ThrowOnError_PInvoke_NTSTATUS:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,9,45,233,4,223,77,226,13,176,160,225,4,0,139,229,4,0,155,229,192,4,0,226
	.byte 192,4,80,227,2,0,0,10,4,223,139,226,0,9,189,232,128,128,189,232,4,0,155,229,0,0,139,229,0,0,159,229
	.byte 0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 168
	.byte 0,0,159,231,18,31,160,227
bl _p_1

	.byte 8,0,139,229,0,16,155,229
bl PInvoke_NTStatusException__ctor_PInvoke_NTSTATUS

	.byte 8,0,155,229
bl _p_8

Lme_5c:
.text
	.align 2
	.no_dead_strip PInvoke_NTStatusException__ctor_PInvoke_NTSTATUS
PInvoke_NTStatusException__ctor_PInvoke_NTSTATUS:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,9,45,233,2,223,77,226,13,176,160,225,0,0,139,229,4,16,139,229,4,0,155,229
bl _p_44

	.byte 0,32,160,225,0,0,155,229,4,16,155,229
bl PInvoke_NTStatusException__ctor_PInvoke_NTSTATUS_string

	.byte 2,223,139,226,0,9,189,232,128,128,189,232

Lme_5d:
.text
	.align 2
	.no_dead_strip PInvoke_NTStatusException__ctor_PInvoke_NTSTATUS_string
PInvoke_NTStatusException__ctor_PInvoke_NTSTATUS_string:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,9,45,233,4,223,77,226,13,176,160,225,0,0,139,229,4,16,139,229,8,32,139,229
	.byte 0,0,155,229,4,16,155,229,8,32,155,229,0,63,160,227
bl PInvoke_NTStatusException__ctor_PInvoke_NTSTATUS_string_System_Exception

	.byte 4,223,139,226,0,9,189,232,128,128,189,232

Lme_5e:
.text
	.align 2
	.no_dead_strip PInvoke_NTStatusException__ctor_PInvoke_NTSTATUS_string_System_Exception
PInvoke_NTStatusException__ctor_PInvoke_NTSTATUS_string_System_Exception:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,13,45,233,7,223,77,226,13,176,160,225,4,0,139,229,8,16,139,229,12,32,139,229
	.byte 16,48,139,229,4,0,155,229,0,0,139,229,12,160,155,229,10,0,160,225,0,15,80,227,2,0,0,26,8,0,155,229
bl _p_44

	.byte 0,160,160,225,0,0,155,229,10,16,160,225,16,32,155,229
bl _p_45

	.byte 4,0,155,229,17,15,128,226,8,16,155,229,0,16,128,229,7,223,139,226,0,13,189,232,128,128,189,232

Lme_5f:
.text
	.align 2
	.no_dead_strip PInvoke_NTStatusException_get_NativeErrorCode
PInvoke_NTStatusException_get_NativeErrorCode:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,5,223,77,226,0,16,141,229,8,0,141,229,8,0,157,229,17,15,128,226
	.byte 0,0,144,229,4,0,141,229,0,0,157,229,4,16,157,229,0,16,128,229,5,223,141,226,0,1,189,232,128,128,189,232

Lme_60:
.text
	.align 2
	.no_dead_strip PInvoke_NTStatusException_GetMessage_PInvoke_NTSTATUS
PInvoke_NTStatusException_GetMessage_PInvoke_NTSTATUS:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,16,9,45,233,15,223,77,226,13,176,160,225,28,0,139,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 172
	.byte 0,0,159,231,40,0,139,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 176
	.byte 0,0,159,231,64,19,160,227
bl _p_14

	.byte 52,0,139,229,44,0,139,229,28,0,155,229,16,0,139,229,16,0,155,229,48,0,139,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 180
	.byte 0,0,159,231,3,31,160,227
bl _p_1

	.byte 0,32,160,225,48,0,155,229,52,48,155,229,8,0,130,229,3,0,160,225,0,31,160,227,0,48,147,229,15,224,160,225
	.byte 132,240,147,229,40,0,155,229,44,16,155,229
bl _p_46

	.byte 0,64,160,225,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 184
	.byte 0,0,159,231,32,0,139,229,28,0,155,229,36,0,139,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 120
	.byte 0,0,159,231,3,31,160,227
bl _p_1

	.byte 0,16,160,225,32,0,155,229,36,32,155,229,8,32,129,229
bl _p_47

	.byte 0,0,139,229,0,15,80,227,5,0,0,10,0,0,155,229,4,16,160,225
bl _p_48

	.byte 255,0,0,226,0,15,80,227,1,0,0,26,20,64,139,229,31,0,0,234,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 188
	.byte 0,0,159,231,32,0,139,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 176
	.byte 0,0,159,231,128,19,160,227
bl _p_14

	.byte 0,48,160,225,40,0,139,229,3,0,160,225,0,31,160,227,0,32,155,229,0,48,147,229,15,224,160,225,132,240,147,229
	.byte 40,48,155,229,3,0,160,225,36,0,139,229,3,0,160,225,64,19,160,227,4,32,160,225,0,48,147,229,15,224,160,225
	.byte 132,240,147,229,32,0,155,229,36,16,155,229
bl _p_46

	.byte 20,0,139,229,20,0,155,229,4,0,139,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 192
	.byte 0,0,159,231,32,0,139,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 176
	.byte 0,0,159,231,128,19,160,227
bl _p_14

	.byte 44,0,139,229,40,0,139,229,28,0,155,229,24,0,139,229
bl _p_49

	.byte 0,32,160,225,44,48,155,229,3,0,160,225,0,31,160,227,0,48,147,229,15,224,160,225,132,240,147,229,40,48,155,229
	.byte 3,0,160,225,36,0,139,229,3,0,160,225,64,19,160,227,20,32,155,229,0,48,147,229,15,224,160,225,132,240,147,229
	.byte 32,0,155,229,36,16,155,229
bl _p_46

	.byte 8,0,139,229,0,15,160,227,12,0,139,229,8,0,155,229,15,223,139,226,16,9,189,232,128,128,189,232

Lme_61:
.text
	.align 2
	.no_dead_strip PInvoke_NTStatusException_GetSeverityString_PInvoke_NTSTATUS
PInvoke_NTStatusException_GetSeverityString_PInvoke_NTSTATUS:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,13,45,233,3,223,77,226,13,176,160,225,0,0,139,229,0,0,155,229,192,164,0,226
	.byte 10,0,160,225,64,4,80,227,4,0,0,138,0,15,90,227,7,0,0,10,64,4,90,227,10,0,0,10,24,0,0,234
	.byte 128,4,90,227,12,0,0,10,192,4,90,227,15,0,0,10,19,0,0,234,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 196
	.byte 0,0,159,231,19,0,0,234,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 200
	.byte 0,0,159,231,14,0,0,234,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 204
	.byte 0,0,159,231,9,0,0,234,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 208
	.byte 0,0,159,231,4,0,0,234,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 104
	.byte 0,0,159,231,0,0,144,229,3,223,139,226,0,13,189,232,128,128,189,232

Lme_62:
.text
	.align 2
	.no_dead_strip PInvoke_Win32Exception__ctor
PInvoke_Win32Exception__ctor:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229
bl _p_5

	.byte 0,16,160,225,0,0,157,229
bl PInvoke_Win32Exception__ctor_int

	.byte 3,223,141,226,0,1,189,232,128,128,189,232

Lme_63:
.text
	.align 2
	.no_dead_strip PInvoke_Win32Exception__ctor_PInvoke_Win32ErrorCode
PInvoke_Win32Exception__ctor_PInvoke_Win32ErrorCode:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,80,5,45,233,6,223,77,226,0,96,160,225,1,160,160,225,10,0,160,225
bl PInvoke_Kernel32Extensions_GetMessage_PInvoke_Win32ErrorCode

	.byte 0,16,160,225,0,160,141,229,1,64,160,225,0,15,80,227,30,0,0,26,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 212
	.byte 0,0,159,231,8,0,141,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 176
	.byte 0,0,159,231,64,19,160,227
bl _p_14

	.byte 16,0,141,229,12,0,141,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 180
	.byte 0,0,159,231,3,31,160,227
bl _p_1

	.byte 0,32,160,225,16,48,157,229,8,160,130,229,3,0,160,225,0,31,160,227,0,48,147,229,15,224,160,225,132,240,147,229
	.byte 8,0,157,229,12,16,157,229
bl _p_46

	.byte 0,64,160,225,6,0,160,225,0,16,157,229,4,32,160,225
bl PInvoke_Win32Exception__ctor_PInvoke_Win32ErrorCode_string

	.byte 6,223,141,226,80,5,189,232,128,128,189,232

Lme_64:
.text
	.align 2
	.no_dead_strip PInvoke_Win32Exception__ctor_int
PInvoke_Win32Exception__ctor_int:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,4,16,141,229,0,0,157,229,4,16,157,229
bl _p_43

	.byte 3,223,141,226,0,1,189,232,128,128,189,232

Lme_65:
.text
	.align 2
	.no_dead_strip PInvoke_Win32Exception__ctor_PInvoke_Win32ErrorCode_string
PInvoke_Win32Exception__ctor_PInvoke_Win32ErrorCode_string:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,5,223,77,226,0,0,141,229,4,16,141,229,8,32,141,229,0,0,157,229
	.byte 8,16,157,229
bl _p_50

	.byte 4,16,157,229,0,0,157,229,68,16,128,229,5,223,141,226,0,1,189,232,128,128,189,232

Lme_66:
.text
	.align 2
	.no_dead_strip PInvoke_Win32Exception_get_NativeErrorCode
PInvoke_Win32Exception_get_NativeErrorCode:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,0,0,157,229,68,0,144,229,3,223,141,226
	.byte 0,1,189,232,128,128,189,232

Lme_67:
.text
ut_105:

	.byte 8,0,128,226
	b System_Nullable_1_int__ctor_int

.text
	.align 2
	.no_dead_strip System_Nullable_1_int__ctor_int
System_Nullable_1_int__ctor_int:
.file 2 "/Library/Frameworks/Xamarin.iOS.framework/Versions/11.6.1.2/src/mono/mcs/class/corlib/System/Nullable.cs"
.loc 2 94 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,4,16,141,229,0,0,157,229,64,19,160,227
	.byte 4,16,192,229
.loc 2 95 0

	.byte 4,16,157,229,0,16,128,229
.loc 2 96 0

	.byte 3,223,141,226,0,1,189,232,128,128,189,232

Lme_69:
.text
ut_106:

	.byte 8,0,128,226
	b System_Nullable_1_int_get_HasValue

.text
	.align 2
	.no_dead_strip System_Nullable_1_int_get_HasValue
System_Nullable_1_int_get_HasValue:
.loc 2 99 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,0,0,157,229,4,0,208,229,3,223,141,226
	.byte 0,1,189,232,128,128,189,232

Lme_6a:
.text
ut_107:

	.byte 8,0,128,226
	b System_Nullable_1_int_get_Value

.text
	.align 2
	.no_dead_strip System_Nullable_1_int_get_Value
System_Nullable_1_int_get_Value:
.loc 2 104 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,0,0,157,229,4,0,208,229,0,15,80,227
	.byte 4,0,0,10
.loc 2 107 0

	.byte 0,0,157,229,0,0,144,229,3,223,141,226,0,1,189,232,128,128,189,232
.loc 2 105 0

	.byte 8,12,10,227
bl _p_51

	.byte 0,16,160,225,240,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_8

Lme_6b:
.text
ut_108:

	.byte 8,0,128,226
	b System_Nullable_1_int_Equals_object

.text
	.align 2
	.no_dead_strip System_Nullable_1_int_Equals_object
System_Nullable_1_int_Equals_object:
.loc 2 113 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,32,5,45,233,5,223,77,226,8,0,141,229,1,160,160,225,0,15,90,227,5,0,0,26
.loc 2 114 0

	.byte 8,0,157,229,4,0,208,229,0,15,80,227,0,0,160,19,1,0,160,3,33,0,0,234
.loc 2 115 0

	.byte 10,80,160,225,0,15,90,227,10,0,0,10,0,0,154,229,0,0,144,229,8,0,144,229,8,0,144,229,0,16,159,229
	.byte 0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 216
	.byte 1,16,159,231,1,0,80,225,0,0,0,10,0,95,160,227,0,15,85,227,1,0,0,26
.loc 2 116 0

	.byte 0,15,160,227,15,0,0,234
.loc 2 118 0

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 88
	.byte 8,128,159,231,13,16,160,225,10,0,160,225
bl _p_52

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 88
	.byte 8,128,159,231,8,0,157,229,0,16,157,229,4,32,157,229
bl _p_53

	.byte 255,0,0,226,5,223,141,226,32,5,189,232,128,128,189,232

Lme_6c:
.text
ut_109:

	.byte 8,0,128,226
	b System_Nullable_1_int_Equals_System_Nullable_1_int

.text
	.align 2
	.no_dead_strip System_Nullable_1_int_Equals_System_Nullable_1_int
System_Nullable_1_int_Equals_System_Nullable_1_int:
.loc 2 123 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,0,13,45,233,7,223,77,226,13,176,160,225,0,160,160,225,8,16,139,229,12,32,139,229
	.byte 8,0,155,229,0,0,139,229,12,0,155,229,4,0,139,229,4,0,219,229,4,16,218,229,1,0,80,225,1,0,0,10
.loc 2 124 0

	.byte 0,15,160,227,20,0,0,234
.loc 2 126 0

	.byte 4,0,218,229,0,15,80,227,1,0,0,26
.loc 2 127 0

	.byte 64,3,160,227,15,0,0,234
.loc 2 129 0

	.byte 2,15,139,226,16,0,139,229,0,0,154,229,20,0,139,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 180
	.byte 0,0,159,231,3,31,160,227
bl _p_1

	.byte 0,16,160,225,16,0,155,229,20,32,155,229,8,32,129,229
bl _p_54

	.byte 255,0,0,226,7,223,139,226,0,13,189,232,128,128,189,232

Lme_6d:
.text
ut_110:

	.byte 8,0,128,226
	b System_Nullable_1_int_GetHashCode

.text
	.align 2
	.no_dead_strip System_Nullable_1_int_GetHashCode
System_Nullable_1_int_GetHashCode:
.loc 2 134 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,0,5,45,233,0,160,160,225,4,0,218,229,0,15,80,227,1,0,0,26
.loc 2 135 0

	.byte 0,15,160,227,1,0,0,234
.loc 2 137 0

	.byte 0,224,218,229,0,0,154,229,0,223,141,226,0,5,189,232,128,128,189,232

Lme_6e:
.text
ut_111:

	.byte 8,0,128,226
	b System_Nullable_1_int_GetValueOrDefault

.text
	.align 2
	.no_dead_strip System_Nullable_1_int_GetValueOrDefault
System_Nullable_1_int_GetValueOrDefault:
.loc 2 142 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,0,0,157,229,0,0,144,229,3,223,141,226
	.byte 0,1,189,232,128,128,189,232

Lme_6f:
.text
ut_112:

	.byte 8,0,128,226
	b System_Nullable_1_int_GetValueOrDefault_int

.text
	.align 2
	.no_dead_strip System_Nullable_1_int_GetValueOrDefault_int
System_Nullable_1_int_GetValueOrDefault_int:
.loc 2 147 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,4,16,141,229,0,0,157,229,4,0,208,229
	.byte 0,15,80,227,1,0,0,26,4,0,157,229,1,0,0,234,0,0,157,229,0,0,144,229,3,223,141,226,0,1,189,232
	.byte 128,128,189,232

Lme_70:
.text
ut_113:

	.byte 8,0,128,226
	b System_Nullable_1_int_ToString

.text
	.align 2
	.no_dead_strip System_Nullable_1_int_ToString
System_Nullable_1_int_ToString:
.loc 2 152 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,0,0,157,229,4,0,208,229,0,15,80,227
	.byte 2,0,0,10
.loc 2 153 0

	.byte 0,0,157,229
bl _p_55

	.byte 4,0,0,234
.loc 2 155 0

	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 104
	.byte 0,0,159,231,0,0,144,229,3,223,141,226,0,1,189,232,128,128,189,232

Lme_71:
.text
ut_114:

	.byte 8,0,128,226
	b System_Nullable_1_int_Box_System_Nullable_1_int

.text
	.align 2
	.no_dead_strip System_Nullable_1_int_Box_System_Nullable_1_int
System_Nullable_1_int_Box_System_Nullable_1_int:
.loc 2 177 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,0,9,45,233,8,223,77,226,13,176,160,225,16,0,139,229,20,16,139,229,16,0,155,229
	.byte 0,0,139,229,20,0,155,229,4,0,139,229,4,0,219,229,0,15,80,227,1,0,0,26
.loc 2 178 0

	.byte 0,15,160,227,13,0,0,234
.loc 2 180 0

	.byte 16,0,155,229,8,0,139,229,20,0,155,229,12,0,139,229,8,0,155,229,24,0,139,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 180
	.byte 0,0,159,231,3,31,160,227
bl _p_1

	.byte 24,16,155,229,8,16,128,229,8,223,139,226,0,9,189,232,128,128,189,232

Lme_72:
.text
ut_115:

	.byte 8,0,128,226
	b System_Nullable_1_int_Unbox_object

.text
	.align 2
	.no_dead_strip System_Nullable_1_int_Unbox_object
System_Nullable_1_int_Unbox_object:
.loc 2 185 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,64,1,45,233,10,223,77,226,0,16,141,229,0,96,160,225,0,15,160,227,4,0,141,229
	.byte 0,15,160,227,8,0,141,229,0,15,86,227,13,0,0,26
.loc 2 186 0

	.byte 0,15,160,227,4,0,141,229,0,15,160,227,8,0,141,229,4,0,157,229,20,0,141,229,8,0,157,229,24,0,141,229
	.byte 0,0,157,229,20,16,157,229,0,16,128,229,24,16,157,229,4,16,128,229,31,0,0,234
.loc 2 187 0

	.byte 0,0,150,229,24,16,208,229,0,15,81,227,30,0,0,27,0,0,144,229,0,0,144,229,0,16,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 216
	.byte 1,16,159,231,1,0,80,225,22,0,0,27,8,16,150,229,0,15,160,227,12,0,141,229,0,15,160,227,16,0,141,229
	.byte 3,15,141,226,0,128,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 88
	.byte 8,128,159,231
bl _p_24

	.byte 12,0,157,229,28,0,141,229,16,0,157,229,32,0,141,229,0,0,157,229,28,16,157,229,0,16,128,229,32,16,157,229
	.byte 4,16,128,229,10,223,141,226,64,1,189,232,128,128,189,232,14,16,160,225,0,0,159,229
bl _p_11

	.byte 239,0,0,0

Lme_73:
.text
ut_116:

	.byte 8,0,128,226
	b System_ArraySegment_1_T_BYTE__ctor_T_BYTE__

.text
	.align 2
	.no_dead_strip System_ArraySegment_1_T_BYTE__ctor_T_BYTE__
System_ArraySegment_1_T_BYTE__ctor_T_BYTE__:
.file 3 "/Library/Frameworks/Xamarin.iOS.framework/Versions/11.6.1.2/src/mono/mcs/class/referencesource/mscorlib/system/arraysegment.cs"
.loc 3 39 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,3,223,77,226,0,128,141,229,0,96,160,225,1,160,160,225,0,15,90,227
	.byte 15,0,0,10
.loc 3 43 0

	.byte 0,160,134,229,166,4,160,225,0,16,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . -4
	.byte 1,16,159,231,1,0,128,224,64,19,160,227,0,16,192,229
.loc 3 44 0

	.byte 0,15,160,227,4,0,134,229
.loc 3 45 0

	.byte 12,0,154,229,8,0,134,229
.loc 3 46 0

	.byte 3,223,141,226,64,5,189,232,128,128,189,232
.loc 3 40 0

	.byte 155,5,2,227
bl _p_51

	.byte 0,16,160,225,148,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_8

Lme_74:
.text
ut_117:

	.byte 8,0,128,226
	b System_ArraySegment_1_T_BYTE__ctor_T_BYTE___int_int

.text
	.align 2
	.no_dead_strip System_ArraySegment_1_T_BYTE__ctor_T_BYTE___int_int
System_ArraySegment_1_T_BYTE__ctor_T_BYTE___int_int:
.loc 3 50 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,112,5,45,233,5,223,77,226,0,128,141,229,0,64,160,225,1,80,160,225,2,96,160,225
	.byte 3,160,160,225,0,15,85,227,21,0,0,10
.loc 3 52 0

	.byte 0,15,86,227,26,0,0,186
.loc 3 54 0

	.byte 0,15,90,227,35,0,0,186
.loc 3 56 0

	.byte 12,0,149,229,6,0,64,224,10,0,80,225,42,0,0,186
.loc 3 60 0

	.byte 0,80,132,229,164,4,160,225,0,16,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . -4
	.byte 1,16,159,231,1,0,128,224,64,19,160,227,0,16,192,229
.loc 3 61 0

	.byte 4,96,132,229
.loc 3 62 0

	.byte 8,160,132,229
.loc 3 63 0

	.byte 5,223,141,226,112,5,189,232,128,128,189,232
.loc 3 51 0

	.byte 155,5,2,227
bl _p_51

	.byte 0,16,160,225,148,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_8
.loc 3 53 0

	.byte 167,10,3,227
bl _p_51

	.byte 8,0,141,229,183,5,2,227
bl _p_51

	.byte 0,32,160,225,8,16,157,229,149,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_2
bl _p_8
.loc 3 55 0

	.byte 75,10,2,227
bl _p_51

	.byte 8,0,141,229,183,5,2,227
bl _p_51

	.byte 0,32,160,225,8,16,157,229,149,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_2
bl _p_8
.loc 3 57 0

	.byte 163,7,2,227
bl _p_51

	.byte 0,16,160,225,147,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_8

Lme_75:
.text
ut_118:

	.byte 8,0,128,226
	b System_ArraySegment_1_T_BYTE_get_Array

.text
	.align 2
	.no_dead_strip System_ArraySegment_1_T_BYTE_get_Array
System_ArraySegment_1_T_BYTE_get_Array:
.loc 3 73 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,128,141,229,4,0,141,229,4,0,157,229,0,0,144,229
	.byte 3,223,141,226,0,1,189,232,128,128,189,232

Lme_76:
.text
ut_119:

	.byte 8,0,128,226
	b System_ArraySegment_1_T_BYTE_get_Offset

.text
	.align 2
	.no_dead_strip System_ArraySegment_1_T_BYTE_get_Offset
System_ArraySegment_1_T_BYTE_get_Offset:
.loc 3 92 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,128,141,229,4,0,141,229,4,0,157,229,4,0,144,229
	.byte 3,223,141,226,0,1,189,232,128,128,189,232

Lme_77:
.text
ut_120:

	.byte 8,0,128,226
	b System_ArraySegment_1_T_BYTE_get_Count

.text
	.align 2
	.no_dead_strip System_ArraySegment_1_T_BYTE_get_Count
System_ArraySegment_1_T_BYTE_get_Count:
.loc 3 111 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,128,141,229,4,0,141,229,4,0,157,229,8,0,144,229
	.byte 3,223,141,226,0,1,189,232,128,128,189,232

Lme_78:
.text
ut_121:

	.byte 8,0,128,226
	b System_ArraySegment_1_T_BYTE_GetHashCode

.text
	.align 2
	.no_dead_strip System_ArraySegment_1_T_BYTE_GetHashCode
System_ArraySegment_1_T_BYTE_GetHashCode:
.loc 3 117 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,0,5,45,233,2,223,77,226,0,128,141,229,0,160,160,225,0,0,154,229,0,15,80,227
	.byte 9,0,0,10,0,16,154,229,1,0,160,225,0,16,145,229,15,224,160,225,40,240,145,229,4,16,154,229,1,0,32,224
	.byte 8,16,154,229,1,0,32,224,0,0,0,234,0,15,160,227,2,223,141,226,0,5,189,232,128,128,189,232

Lme_79:
.text
ut_122:

	.byte 8,0,128,226
	b System_ArraySegment_1_T_BYTE_Equals_object

.text
	.align 2
	.no_dead_strip System_ArraySegment_1_T_BYTE_Equals_object
System_ArraySegment_1_T_BYTE_Equals_object:
.loc 3 124 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,7,223,77,226,0,128,141,229,0,96,160,225,1,160,160,225,0,0,157,229
bl _p_56

	.byte 0,32,160,225,4,16,146,229,10,0,160,225
bl _p_57

	.byte 0,15,80,227,35,0,0,10
.loc 3 125 0

	.byte 0,0,154,229,24,16,208,229,0,15,81,227,35,0,0,27,0,0,144,229,0,0,144,229,20,0,141,229,0,0,157,229
bl _p_58

	.byte 0,16,160,225,20,0,157,229,1,0,80,225,26,0,0,27,2,15,138,226,0,16,144,229,4,16,141,229,4,16,144,229
	.byte 8,16,141,229,8,0,144,229,12,0,141,229,0,0,157,229
bl _p_59

	.byte 16,0,141,229,0,224,214,229,0,0,157,229
bl _p_60

	.byte 0,192,160,225,16,0,157,229,0,128,160,225,6,0,160,225,4,16,157,229,8,32,157,229,12,48,157,229,60,255,47,225
	.byte 255,0,0,226,0,0,0,234
.loc 3 127 0

	.byte 0,15,160,227,7,223,141,226,64,5,189,232,128,128,189,232,14,16,160,225,0,0,159,229
bl _p_11

	.byte 239,0,0,0

Lme_7a:
.text
ut_123:

	.byte 8,0,128,226
	b System_ArraySegment_1_T_BYTE_Equals_System_ArraySegment_1_T_BYTE

.text
	.align 2
	.no_dead_strip System_ArraySegment_1_T_BYTE_Equals_System_ArraySegment_1_T_BYTE
System_ArraySegment_1_T_BYTE_Equals_System_ArraySegment_1_T_BYTE:
.loc 3 132 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,0,13,45,233,15,223,77,226,13,176,160,225,0,128,139,229,0,160,160,225,40,16,139,229
	.byte 44,32,139,229,48,48,139,229,40,0,155,229,4,0,139,229,44,0,155,229,8,0,139,229,48,0,155,229,12,0,139,229
	.byte 4,0,155,229,0,16,154,229,1,0,80,225,20,0,0,26,40,0,155,229,16,0,139,229,44,0,155,229,20,0,139,229
	.byte 48,0,155,229,24,0,139,229,20,0,155,229,4,16,154,229,1,0,80,225,10,0,0,26,40,0,155,229,28,0,139,229
	.byte 44,0,155,229,32,0,139,229,48,0,155,229,36,0,139,229,8,16,154,229,1,0,80,225,0,0,160,19,1,0,160,3
	.byte 0,0,0,234,0,15,160,227,15,223,139,226,0,13,189,232,128,128,189,232

Lme_7b:
.text
ut_124:

	.byte 8,0,128,226
	b System_ArraySegment_1_T_BYTE_System_Collections_Generic_IList_T_get_Item_int

.text
	.align 2
	.no_dead_strip System_ArraySegment_1_T_BYTE_System_Collections_Generic_IList_T_get_Item_int
System_ArraySegment_1_T_BYTE_System_Collections_Generic_IList_T_get_Item_int:
.loc 3 150 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,3,223,77,226,0,128,141,229,0,96,160,225,1,160,160,225,0,0,150,229
	.byte 0,15,80,227,16,0,0,10
.loc 3 152 0

	.byte 0,15,90,227,21,0,0,186,8,0,150,229,0,0,90,225,18,0,0,170
.loc 3 156 0

	.byte 0,0,150,229,4,16,150,229,10,16,129,224,12,32,144,229,1,0,82,225,19,0,0,155,1,0,128,224,4,15,128,226
	.byte 0,0,208,229,3,223,141,226,64,5,189,232,128,128,189,232
.loc 3 151 0

	.byte 181,10,3,227
bl _p_51

	.byte 0,16,160,225,240,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_8
.loc 3 153 0

	.byte 63,12,0,227
bl _p_51

	.byte 0,16,160,225,149,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_8

	.byte 14,16,160,225,0,0,159,229
bl _p_11

	.byte 233,0,0,0

Lme_7c:
.text
ut_125:

	.byte 8,0,128,226
	b System_ArraySegment_1_T_BYTE_System_Collections_Generic_IList_T_set_Item_int_T_BYTE

.text
	.align 2
	.no_dead_strip System_ArraySegment_1_T_BYTE_System_Collections_Generic_IList_T_set_Item_int_T_BYTE
System_ArraySegment_1_T_BYTE_System_Collections_Generic_IList_T_set_Item_int_T_BYTE:
.loc 3 161 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,3,223,77,226,0,128,141,229,0,96,160,225,1,160,160,225,4,32,205,229
	.byte 0,0,150,229,0,15,80,227,17,0,0,10
.loc 3 163 0

	.byte 0,15,90,227,22,0,0,186,8,0,150,229,0,0,90,225,19,0,0,170
.loc 3 167 0

	.byte 0,0,150,229,4,16,150,229,10,16,129,224,12,32,144,229,1,0,82,225,20,0,0,155,1,0,128,224,4,15,128,226
	.byte 4,16,221,229,0,16,192,229
.loc 3 168 0

	.byte 3,223,141,226,64,5,189,232,128,128,189,232
.loc 3 162 0

	.byte 181,10,3,227
bl _p_51

	.byte 0,16,160,225,240,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_8
.loc 3 164 0

	.byte 63,12,0,227
bl _p_51

	.byte 0,16,160,225,149,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_8

	.byte 14,16,160,225,0,0,159,229
bl _p_11

	.byte 233,0,0,0

Lme_7d:
.text
ut_126:

	.byte 8,0,128,226
	b System_ArraySegment_1_T_BYTE_System_Collections_Generic_IList_T_IndexOf_T_BYTE

.text
	.align 2
	.no_dead_strip System_ArraySegment_1_T_BYTE_System_Collections_Generic_IList_T_IndexOf_T_BYTE
System_ArraySegment_1_T_BYTE_System_Collections_Generic_IList_T_IndexOf_T_BYTE:
.loc 3 173 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,7,223,77,226,0,128,141,229,0,160,160,225,4,16,205,229,0,0,154,229
	.byte 0,15,80,227,28,0,0,10
.loc 3 177 0

	.byte 0,0,154,229,8,0,141,229,4,0,154,229,16,0,141,229,8,0,154,229,20,0,141,229,0,0,157,229
bl _p_61

	.byte 12,0,141,229,0,0,157,229
bl _p_62

	.byte 0,192,160,225,8,0,157,229,12,16,157,229,16,32,157,229,20,48,157,229,1,128,160,225,4,16,221,229,60,255,47,225
	.byte 0,96,160,225
.loc 3 182 0

	.byte 0,15,80,227,1,0,0,170,0,15,224,227,1,0,0,234,4,0,154,229,0,0,70,224,7,223,141,226,64,5,189,232
	.byte 128,128,189,232
.loc 3 174 0

	.byte 181,10,3,227
bl _p_51

	.byte 0,16,160,225,240,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_8

Lme_7e:
.text
ut_127:

	.byte 8,0,128,226
	b System_ArraySegment_1_T_BYTE_System_Collections_Generic_IList_T_Insert_int_T_BYTE

.text
	.align 2
	.no_dead_strip System_ArraySegment_1_T_BYTE_System_Collections_Generic_IList_T_Insert_int_T_BYTE
System_ArraySegment_1_T_BYTE_System_Collections_Generic_IList_T_Insert_int_T_BYTE:
.loc 3 187 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,5,223,77,226,0,128,141,229,4,0,141,229,8,16,141,229,12,32,205,229
	.byte 254,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_0
bl _p_8

	.byte 5,223,141,226,0,1,189,232,128,128,189,232

Lme_7f:
.text
ut_128:

	.byte 8,0,128,226
	b System_ArraySegment_1_T_BYTE_System_Collections_Generic_IList_T_RemoveAt_int

.text
	.align 2
	.no_dead_strip System_ArraySegment_1_T_BYTE_System_Collections_Generic_IList_T_RemoveAt_int
System_ArraySegment_1_T_BYTE_System_Collections_Generic_IList_T_RemoveAt_int:
.loc 3 192 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,5,223,77,226,0,128,141,229,4,0,141,229,8,16,141,229,254,0,0,227
	.byte 0,2,64,227
bl _mono_create_corlib_exception_0
bl _p_8

	.byte 5,223,141,226,0,1,189,232,128,128,189,232

Lme_80:
.text
ut_129:

	.byte 8,0,128,226
	b System_ArraySegment_1_T_BYTE_System_Collections_Generic_IReadOnlyList_T_get_Item_int

.text
	.align 2
	.no_dead_strip System_ArraySegment_1_T_BYTE_System_Collections_Generic_IReadOnlyList_T_get_Item_int
System_ArraySegment_1_T_BYTE_System_Collections_Generic_IReadOnlyList_T_get_Item_int:
.loc 3 201 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,3,223,77,226,0,128,141,229,0,96,160,225,1,160,160,225,0,0,150,229
	.byte 0,15,80,227,16,0,0,10
.loc 3 203 0

	.byte 0,15,90,227,21,0,0,186,8,0,150,229,0,0,90,225,18,0,0,170
.loc 3 207 0

	.byte 0,0,150,229,4,16,150,229,10,16,129,224,12,32,144,229,1,0,82,225,19,0,0,155,1,0,128,224,4,15,128,226
	.byte 0,0,208,229,3,223,141,226,64,5,189,232,128,128,189,232
.loc 3 202 0

	.byte 181,10,3,227
bl _p_51

	.byte 0,16,160,225,240,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_8
.loc 3 204 0

	.byte 63,12,0,227
bl _p_51

	.byte 0,16,160,225,149,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_8

	.byte 14,16,160,225,0,0,159,229
bl _p_11

	.byte 233,0,0,0

Lme_81:
.text
ut_130:

	.byte 8,0,128,226
	b System_ArraySegment_1_T_BYTE_System_Collections_Generic_ICollection_T_get_IsReadOnly

.text
	.align 2
	.no_dead_strip System_ArraySegment_1_T_BYTE_System_Collections_Generic_ICollection_T_get_IsReadOnly
System_ArraySegment_1_T_BYTE_System_Collections_Generic_ICollection_T_get_IsReadOnly:
.loc 3 219 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,128,141,229,4,0,141,229,64,3,160,227,3,223,141,226
	.byte 0,1,189,232,128,128,189,232

Lme_82:
.text
ut_131:

	.byte 8,0,128,226
	b System_ArraySegment_1_T_BYTE_System_Collections_Generic_ICollection_T_Add_T_BYTE

.text
	.align 2
	.no_dead_strip System_ArraySegment_1_T_BYTE_System_Collections_Generic_ICollection_T_Add_T_BYTE
System_ArraySegment_1_T_BYTE_System_Collections_Generic_ICollection_T_Add_T_BYTE:
.loc 3 225 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,5,223,77,226,0,128,141,229,4,0,141,229,8,16,205,229,254,0,0,227
	.byte 0,2,64,227
bl _mono_create_corlib_exception_0
bl _p_8

	.byte 5,223,141,226,0,1,189,232,128,128,189,232

Lme_83:
.text
ut_132:

	.byte 8,0,128,226
	b System_ArraySegment_1_T_BYTE_System_Collections_Generic_ICollection_T_Clear

.text
	.align 2
	.no_dead_strip System_ArraySegment_1_T_BYTE_System_Collections_Generic_ICollection_T_Clear
System_ArraySegment_1_T_BYTE_System_Collections_Generic_ICollection_T_Clear:
.loc 3 230 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,128,141,229,4,0,141,229,254,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_0
bl _p_8

	.byte 3,223,141,226,0,1,189,232,128,128,189,232

Lme_84:
.text
ut_133:

	.byte 8,0,128,226
	b System_ArraySegment_1_T_BYTE_System_Collections_Generic_ICollection_T_Contains_T_BYTE

.text
	.align 2
	.no_dead_strip System_ArraySegment_1_T_BYTE_System_Collections_Generic_ICollection_T_Contains_T_BYTE
System_ArraySegment_1_T_BYTE_System_Collections_Generic_ICollection_T_Contains_T_BYTE:
.loc 3 235 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,0,5,45,233,6,223,77,226,0,128,141,229,0,160,160,225,4,16,205,229,0,0,154,229
	.byte 0,15,80,227,27,0,0,10
.loc 3 239 0

	.byte 0,0,154,229,8,0,141,229,4,0,154,229,16,0,141,229,8,0,154,229,20,0,141,229,0,0,157,229
bl _p_63

	.byte 12,0,141,229,0,0,157,229
bl _p_64

	.byte 0,192,160,225,8,0,157,229,12,16,157,229,16,32,157,229,20,48,157,229,1,128,160,225,4,16,221,229,60,255,47,225
.loc 3 244 0

	.byte 0,15,80,227,0,0,160,227,1,0,160,179,0,15,80,227,0,0,160,19,1,0,160,3,6,223,141,226,0,5,189,232
	.byte 128,128,189,232
.loc 3 236 0

	.byte 181,10,3,227
bl _p_51

	.byte 0,16,160,225,240,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_8

Lme_85:
.text
ut_134:

	.byte 8,0,128,226
	b System_ArraySegment_1_T_BYTE_System_Collections_Generic_ICollection_T_CopyTo_T_BYTE___int

.text
	.align 2
	.no_dead_strip System_ArraySegment_1_T_BYTE_System_Collections_Generic_ICollection_T_CopyTo_T_BYTE___int
System_ArraySegment_1_T_BYTE_System_Collections_Generic_ICollection_T_CopyTo_T_BYTE___int:
.loc 3 249 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,32,9,45,233,7,223,77,226,13,176,160,225,8,128,139,229,0,80,160,225,12,16,139,229
	.byte 16,32,139,229,0,0,149,229,0,15,80,227,9,0,0,10
.loc 3 253 0

	.byte 0,0,149,229,4,16,149,229,8,192,149,229,12,32,155,229,16,48,155,229,0,192,141,229
bl _p_65
.loc 3 254 0

	.byte 7,223,139,226,32,9,189,232,128,128,189,232
.loc 3 250 0

	.byte 181,10,3,227
bl _p_51

	.byte 0,16,160,225,240,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_8

Lme_86:
.text
ut_135:

	.byte 8,0,128,226
	b System_ArraySegment_1_T_BYTE_System_Collections_Generic_ICollection_T_Remove_T_BYTE

.text
	.align 2
	.no_dead_strip System_ArraySegment_1_T_BYTE_System_Collections_Generic_ICollection_T_Remove_T_BYTE
System_ArraySegment_1_T_BYTE_System_Collections_Generic_ICollection_T_Remove_T_BYTE:
.loc 3 258 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,5,223,77,226,0,128,141,229,4,0,141,229,8,16,205,229,254,0,0,227
	.byte 0,2,64,227
bl _mono_create_corlib_exception_0
bl _p_8

	.byte 5,223,141,226,0,1,189,232,128,128,189,232

Lme_87:
.text
ut_136:

	.byte 8,0,128,226
	b System_ArraySegment_1_T_BYTE_System_Collections_Generic_IEnumerable_T_GetEnumerator

.text
	.align 2
	.no_dead_strip System_ArraySegment_1_T_BYTE_System_Collections_Generic_IEnumerable_T_GetEnumerator
System_ArraySegment_1_T_BYTE_System_Collections_Generic_IEnumerable_T_GetEnumerator:
.loc 3 265 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,9,223,77,226,0,128,141,229,16,0,141,229,16,0,157,229,0,0,144,229
	.byte 0,15,80,227,24,0,0,10
.loc 3 269 0

	.byte 16,0,157,229,0,16,144,229,4,16,141,229,4,16,144,229,8,16,141,229,8,0,144,229,12,0,141,229,0,0,157,229
bl _p_66

	.byte 6,31,160,227
bl _p_1

	.byte 28,0,141,229,0,0,157,229
bl _p_67

	.byte 0,192,160,225,28,0,157,229,24,0,141,229,4,16,157,229,8,32,157,229,12,48,157,229,60,255,47,225,24,0,157,229
	.byte 9,223,141,226,0,1,189,232,128,128,189,232
.loc 3 266 0

	.byte 181,10,3,227
bl _p_51

	.byte 0,16,160,225,240,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_8

Lme_88:
.text
ut_137:

	.byte 8,0,128,226
	b System_ArraySegment_1_T_BYTE_System_Collections_IEnumerable_GetEnumerator

.text
	.align 2
	.no_dead_strip System_ArraySegment_1_T_BYTE_System_Collections_IEnumerable_GetEnumerator
System_ArraySegment_1_T_BYTE_System_Collections_IEnumerable_GetEnumerator:
.loc 3 276 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,9,223,77,226,0,128,141,229,16,0,141,229,16,0,157,229,0,0,144,229
	.byte 0,15,80,227,24,0,0,10
.loc 3 280 0

	.byte 16,0,157,229,0,16,144,229,4,16,141,229,4,16,144,229,8,16,141,229,8,0,144,229,12,0,141,229,0,0,157,229
bl _p_68

	.byte 6,31,160,227
bl _p_1

	.byte 28,0,141,229,0,0,157,229
bl _p_69

	.byte 0,192,160,225,28,0,157,229,24,0,141,229,4,16,157,229,8,32,157,229,12,48,157,229,60,255,47,225,24,0,157,229
	.byte 9,223,141,226,0,1,189,232,128,128,189,232
.loc 3 277 0

	.byte 181,10,3,227
bl _p_51

	.byte 0,16,160,225,240,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_8

Lme_89:
.text
ut_138:

	.byte 8,0,128,226
	b System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES__ctor_PInvoke_Kernel32_SECURITY_ATTRIBUTES

.text
	.align 2
	.no_dead_strip System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES__ctor_PInvoke_Kernel32_SECURITY_ATTRIBUTES
System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES__ctor_PInvoke_Kernel32_SECURITY_ATTRIBUTES:
.loc 2 94 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,0,9,45,233,4,223,77,226,13,176,160,225,0,0,139,229,4,16,139,229,8,32,139,229
	.byte 12,48,139,229,0,0,155,229,64,19,160,227,12,16,192,229
.loc 2 95 0

	.byte 4,16,155,229,0,16,128,229,8,16,155,229,4,16,128,229,12,16,155,229,8,16,128,229
.loc 2 96 0

	.byte 4,223,139,226,0,9,189,232,128,128,189,232

Lme_8a:
.text
ut_139:

	.byte 8,0,128,226
	b System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_get_HasValue

.text
	.align 2
	.no_dead_strip System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_get_HasValue
System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_get_HasValue:
.loc 2 99 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,0,0,157,229,12,0,208,229,3,223,141,226
	.byte 0,1,189,232,128,128,189,232

Lme_8b:
.text
ut_140:

	.byte 8,0,128,226
	b System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_get_Value

.text
	.align 2
	.no_dead_strip System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_get_Value
System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_get_Value:
.loc 2 104 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,7,223,77,226,0,16,141,229,16,0,141,229,16,0,157,229,12,0,208,229
	.byte 0,15,80,227,16,0,0,10
.loc 2 107 0

	.byte 16,0,157,229,0,16,144,229,4,16,141,229,4,16,144,229,8,16,141,229,8,0,144,229,12,0,141,229,0,0,157,229
	.byte 4,16,157,229,0,16,128,229,8,16,157,229,4,16,128,229,12,16,157,229,8,16,128,229,7,223,141,226,0,1,189,232
	.byte 128,128,189,232
.loc 2 105 0

	.byte 8,12,10,227
bl _p_51

	.byte 0,16,160,225,240,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_8

Lme_8c:
.text
ut_141:

	.byte 8,0,128,226
	b System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_Equals_object

.text
	.align 2
	.no_dead_strip System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_Equals_object
System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_Equals_object:
.loc 2 113 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,32,13,45,233,8,223,77,226,13,176,160,225,24,0,139,229,1,160,160,225,0,15,90,227
	.byte 5,0,0,26
.loc 2 114 0

	.byte 24,0,155,229,12,0,208,229,0,15,80,227,0,0,160,19,1,0,160,3,36,0,0,234
.loc 2 115 0

	.byte 10,80,160,225,0,15,90,227,10,0,0,10,0,0,154,229,0,0,144,229,8,0,144,229,8,0,144,229,0,16,159,229
	.byte 0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 220
	.byte 1,16,159,231,1,0,80,225,0,0,0,10,0,95,160,227,0,15,85,227,1,0,0,26
.loc 2 116 0

	.byte 0,15,160,227,18,0,0,234
.loc 2 118 0

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 108
	.byte 8,128,159,231,2,31,139,226,10,0,160,225
bl _p_70

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 108
	.byte 8,128,159,231,24,0,155,229,8,16,155,229,12,32,155,229,16,48,155,229,20,192,155,229,0,192,141,229
bl _p_71

	.byte 255,0,0,226,8,223,139,226,32,13,189,232,128,128,189,232

Lme_8d:
.text
ut_142:

	.byte 8,0,128,226
	b System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_Equals_System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES

.text
	.align 2
	.no_dead_strip System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_Equals_System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES
System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_Equals_System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES:
.loc 2 123 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,0,13,45,233,17,223,77,226,13,176,160,225,0,160,160,225,40,16,139,229,44,32,139,229
	.byte 48,48,139,229,88,224,157,229,52,224,139,229,40,0,155,229,0,0,139,229,44,0,155,229,4,0,139,229,48,0,155,229
	.byte 8,0,139,229,52,0,155,229,12,0,139,229,12,0,219,229,12,16,218,229,1,0,80,225,1,0,0,10
.loc 2 124 0

	.byte 0,15,160,227,54,0,0,234
.loc 2 126 0

	.byte 12,0,218,229,0,15,80,227,1,0,0,26
.loc 2 127 0

	.byte 64,3,160,227,49,0,0,234
.loc 2 129 0

	.byte 10,15,139,226,60,0,139,229,0,0,154,229,16,0,139,229,4,0,154,229,20,0,139,229,8,0,154,229,24,0,139,229
	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 224
	.byte 0,0,159,231,5,31,160,227
bl _p_1

	.byte 0,16,160,225,60,0,155,229,56,16,139,229,2,31,129,226,16,32,155,229,0,32,129,229,20,32,155,229,4,32,129,229
	.byte 24,32,155,229,8,32,129,229,0,16,144,229,28,16,139,229,4,16,144,229,32,16,139,229,8,0,144,229,36,0,139,229
	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 224
	.byte 0,0,159,231,5,31,160,227
bl _p_1

	.byte 0,32,160,225,56,16,155,229,2,15,130,226,28,48,155,229,0,48,128,229,32,48,155,229,4,48,128,229,36,48,155,229
	.byte 8,48,128,229,2,0,160,225,0,32,146,229,15,224,160,225,48,240,146,229,255,0,0,226,17,223,139,226,0,13,189,232
	.byte 128,128,189,232

Lme_8e:
.text
ut_143:

	.byte 8,0,128,226
	b System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_GetHashCode

.text
	.align 2
	.no_dead_strip System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_GetHashCode
System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_GetHashCode:
.loc 2 134 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,5,223,77,226,12,0,141,229,12,0,157,229,12,0,208,229,0,15,80,227
	.byte 1,0,0,26
.loc 2 135 0

	.byte 0,15,160,227,24,0,0,234
.loc 2 137 0

	.byte 12,0,157,229,0,16,144,229,0,16,141,229,4,16,144,229,4,16,141,229,8,0,144,229,8,0,141,229,0,0,159,229
	.byte 0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 224
	.byte 0,0,159,231,5,31,160,227
bl _p_1

	.byte 0,16,160,225,2,15,129,226,0,32,157,229,0,32,128,229,4,32,157,229,4,32,128,229,8,32,157,229,8,32,128,229
	.byte 1,0,160,225,0,16,145,229,15,224,160,225,40,240,145,229,5,223,141,226,0,1,189,232,128,128,189,232

Lme_8f:
.text
ut_144:

	.byte 8,0,128,226
	b System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_GetValueOrDefault

.text
	.align 2
	.no_dead_strip System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_GetValueOrDefault
System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_GetValueOrDefault:
.loc 2 142 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,7,223,77,226,0,16,141,229,16,0,141,229,16,0,157,229,0,16,144,229
	.byte 4,16,141,229,4,16,144,229,8,16,141,229,8,0,144,229,12,0,141,229,0,0,157,229,4,16,157,229,0,16,128,229
	.byte 8,16,157,229,4,16,128,229,12,16,157,229,8,16,128,229,7,223,141,226,0,1,189,232,128,128,189,232

Lme_90:
.text
ut_145:

	.byte 8,0,128,226
	b System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_GetValueOrDefault_PInvoke_Kernel32_SECURITY_ATTRIBUTES

.text
	.align 2
	.no_dead_strip System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_GetValueOrDefault_PInvoke_Kernel32_SECURITY_ATTRIBUTES
System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_GetValueOrDefault_PInvoke_Kernel32_SECURITY_ATTRIBUTES:
.loc 2 147 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,0,9,45,233,8,223,77,226,13,176,160,225,0,16,139,229,16,0,139,229,20,32,139,229
	.byte 24,48,139,229,48,224,157,229,28,224,139,229,16,0,155,229,12,0,208,229,0,15,80,227,7,0,0,26,0,0,155,229
	.byte 20,16,155,229,0,16,128,229,24,16,155,229,4,16,128,229,28,16,155,229,8,16,128,229,13,0,0,234,16,0,155,229
	.byte 0,16,144,229,4,16,139,229,4,16,144,229,8,16,139,229,8,0,144,229,12,0,139,229,0,0,155,229,4,16,155,229
	.byte 0,16,128,229,8,16,155,229,4,16,128,229,12,16,155,229,8,16,128,229,8,223,139,226,0,9,189,232,128,128,189,232

Lme_91:
.text
ut_146:

	.byte 8,0,128,226
	b System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_ToString

.text
	.align 2
	.no_dead_strip System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_ToString
System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_ToString:
.loc 2 152 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,5,223,77,226,12,0,141,229,12,0,157,229,12,0,208,229,0,15,80,227
	.byte 25,0,0,10
.loc 2 153 0

	.byte 12,0,157,229,0,16,144,229,0,16,141,229,4,16,144,229,4,16,141,229,8,0,144,229,8,0,141,229,0,0,159,229
	.byte 0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 224
	.byte 0,0,159,231,5,31,160,227
bl _p_1

	.byte 0,16,160,225,2,15,129,226,0,32,157,229,0,32,128,229,4,32,157,229,4,32,128,229,8,32,157,229,8,32,128,229
	.byte 1,0,160,225,0,16,145,229,15,224,160,225,36,240,145,229,4,0,0,234
.loc 2 155 0

	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 104
	.byte 0,0,159,231,0,0,144,229,5,223,141,226,0,1,189,232,128,128,189,232

Lme_92:
.text
ut_147:

	.byte 8,0,128,226
	b System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_Box_System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES

.text
	.align 2
	.no_dead_strip System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_Box_System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES
System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_Box_System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES:
.loc 2 177 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,0,9,45,233,16,223,77,226,13,176,160,225,44,0,139,229,48,16,139,229,52,32,139,229
	.byte 56,48,139,229,44,0,155,229,0,0,139,229,48,0,155,229,4,0,139,229,52,0,155,229,8,0,139,229,56,0,155,229
	.byte 12,0,139,229,12,0,219,229,0,15,80,227,1,0,0,26
.loc 2 178 0

	.byte 0,15,160,227,27,0,0,234
.loc 2 180 0

	.byte 44,0,155,229,16,0,139,229,48,0,155,229,20,0,139,229,52,0,155,229,24,0,139,229,56,0,155,229,28,0,139,229
	.byte 4,15,139,226,0,16,144,229,32,16,139,229,4,16,144,229,36,16,139,229,8,0,144,229,40,0,139,229,0,0,159,229
	.byte 0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 224
	.byte 0,0,159,231,5,31,160,227
bl _p_1

	.byte 2,31,128,226,32,32,155,229,0,32,129,229,36,32,155,229,4,32,129,229,40,32,155,229,8,32,129,229,16,223,139,226
	.byte 0,9,189,232,128,128,189,232

Lme_93:
.text
ut_148:

	.byte 8,0,128,226
	b System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_Unbox_object

.text
	.align 2
	.no_dead_strip System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_Unbox_object
System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_Unbox_object:
.loc 2 185 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,64,1,45,233,20,223,77,226,0,16,141,229,0,96,160,225,0,15,160,227,4,0,141,229
	.byte 0,15,160,227,8,0,141,229,0,15,160,227,12,0,141,229,0,15,160,227,16,0,141,229,0,15,86,227,25,0,0,26
.loc 2 186 0

	.byte 0,15,160,227,4,0,141,229,0,15,160,227,8,0,141,229,0,15,160,227,12,0,141,229,0,15,160,227,16,0,141,229
	.byte 4,0,157,229,36,0,141,229,8,0,157,229,40,0,141,229,12,0,157,229,44,0,141,229,16,0,157,229,48,0,141,229
	.byte 0,0,157,229,36,16,157,229,0,16,128,229,40,16,157,229,4,16,128,229,44,16,157,229,8,16,128,229,48,16,157,229
	.byte 12,16,128,229,52,0,0,234
.loc 2 187 0

	.byte 0,0,150,229,24,16,208,229,0,15,81,227,51,0,0,27,0,0,144,229,0,0,144,229,0,16,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 220
	.byte 1,16,159,231,1,0,80,225,43,0,0,27,2,15,134,226,0,16,144,229,52,16,141,229,4,16,144,229,56,16,141,229
	.byte 8,0,144,229,60,0,141,229,0,15,160,227,20,0,141,229,0,15,160,227,24,0,141,229,0,15,160,227,28,0,141,229
	.byte 0,15,160,227,32,0,141,229,5,15,141,226,0,128,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 108
	.byte 8,128,159,231,52,16,157,229,56,32,157,229,60,48,157,229
bl _p_72

	.byte 20,0,157,229,64,0,141,229,24,0,157,229,68,0,141,229,28,0,157,229,72,0,141,229,32,0,157,229,76,0,141,229
	.byte 0,0,157,229,64,16,157,229,0,16,128,229,68,16,157,229,4,16,128,229,72,16,157,229,8,16,128,229,76,16,157,229
	.byte 12,16,128,229,20,223,141,226,64,1,189,232,128,128,189,232,14,16,160,225,0,0,159,229
bl _p_11

	.byte 239,0,0,0

Lme_94:
.text
	.align 2
	.no_dead_strip wrapper_runtime_invoke__Module_runtime_invoke_bool_object_intptr_int_Nullable_1_int__intptr_object_intptr_intptr_intptr
wrapper_runtime_invoke__Module_runtime_invoke_bool_object_intptr_int_Nullable_1_int__intptr_object_intptr_intptr_intptr:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,96,9,45,233,26,223,77,226,13,176,160,225,64,0,139,229,1,96,160,225,68,32,139,229
	.byte 72,48,139,229,0,15,160,227,8,0,139,229,0,15,160,227,12,0,139,229,0,15,160,227,16,0,139,229,0,15,160,227
	.byte 20,0,139,229,0,15,160,227,24,0,139,229,0,15,160,227,28,0,139,229,68,0,155,229,0,15,80,227,90,0,0,10
	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 228
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,5,0,0,10
bl _p_73

	.byte 0,80,160,225,0,15,80,227,1,0,0,10,5,0,160,225
bl _p_8

	.byte 0,0,150,229,88,0,139,229,1,15,134,226,0,0,144,229,0,0,144,229,92,0,139,229,2,15,134,226,0,0,144,229
	.byte 0,0,144,229,96,0,139,229,3,15,134,226,0,0,144,229,0,128,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 88
	.byte 8,128,159,231,4,31,139,226
bl _p_52

	.byte 88,0,155,229,92,16,155,229,96,32,155,229,4,63,139,226,4,207,134,226,0,192,156,229,0,192,156,229,0,192,141,229
	.byte 72,192,155,229,60,255,47,225,84,0,139,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 232
	.byte 0,0,159,231,144,18,160,227
bl _p_1

	.byte 84,16,155,229,8,16,192,229,8,0,139,229,3,15,134,226,80,0,139,229,16,0,155,229,48,0,139,229,20,0,155,229
	.byte 52,0,139,229,0,128,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 88
	.byte 8,128,159,231,48,0,155,229,52,16,155,229
bl _p_74

	.byte 80,16,155,229,0,0,129,229,161,20,160,225,0,32,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . -4
	.byte 2,32,159,231,2,16,129,224,64,35,160,227,0,32,193,229,13,0,0,234,32,0,139,229,12,0,139,229,68,16,155,229
	.byte 12,0,155,229,0,0,129,229,161,20,160,225,0,32,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . -4
	.byte 2,32,159,231,2,16,129,224,64,35,160,227,0,32,193,229,255,255,255,234,8,0,155,229,69,0,0,234,0,0,159,229
	.byte 0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 228
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,65,0,0,26,255,255,255,234,0,0,150,229,88,0,139,229,1,15,134,226
	.byte 0,0,144,229,0,0,144,229,92,0,139,229,2,15,134,226,0,0,144,229,0,0,144,229,96,0,139,229,3,15,134,226
	.byte 0,0,144,229,0,128,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 88
	.byte 8,128,159,231,6,31,139,226
bl _p_52

	.byte 88,0,155,229,92,16,155,229,96,32,155,229,6,63,139,226,4,207,134,226,0,192,156,229,0,192,156,229,0,192,141,229
	.byte 72,192,155,229,60,255,47,225,84,0,139,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 232
	.byte 0,0,159,231,144,18,160,227
bl _p_1

	.byte 84,16,155,229,8,16,192,229,8,0,139,229,3,15,134,226,80,0,139,229,24,0,155,229,56,0,139,229,28,0,155,229
	.byte 60,0,139,229,0,128,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 88
	.byte 8,128,159,231,56,0,155,229,60,16,155,229
bl _p_74

	.byte 80,16,155,229,0,0,129,229,161,20,160,225,0,32,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . -4
	.byte 2,32,159,231,2,16,129,224,64,35,160,227,0,32,193,229,8,0,155,229,26,223,139,226,96,9,189,232,128,128,189,232
bl _p_73

	.byte 0,80,160,225,0,15,80,227,186,255,255,10,5,0,160,225
bl _p_8

Lme_97:
.text
	.align 2
	.no_dead_strip wrapper_runtime_invoke__Module_runtime_invoke_bool_object_void__int_Nullable_1_int__Kernel32_OVERLAPPED__object_intptr_intptr_intptr
wrapper_runtime_invoke__Module_runtime_invoke_bool_object_void__int_Nullable_1_int__Kernel32_OVERLAPPED__object_intptr_intptr_intptr:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,96,9,45,233,26,223,77,226,13,176,160,225,64,0,139,229,1,96,160,225,68,32,139,229
	.byte 72,48,139,229,0,15,160,227,8,0,139,229,0,15,160,227,12,0,139,229,0,15,160,227,16,0,139,229,0,15,160,227
	.byte 20,0,139,229,0,15,160,227,24,0,139,229,0,15,160,227,28,0,139,229,68,0,155,229,0,15,80,227,88,0,0,10
	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 228
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,5,0,0,10
bl _p_73

	.byte 0,80,160,225,0,15,80,227,1,0,0,10,5,0,160,225
bl _p_8

	.byte 0,0,150,229,88,0,139,229,1,15,134,226,0,0,144,229,92,0,139,229,2,15,134,226,0,0,144,229,0,0,144,229
	.byte 96,0,139,229,3,15,134,226,0,0,144,229,0,128,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 88
	.byte 8,128,159,231,4,31,139,226
bl _p_52

	.byte 88,0,155,229,92,16,155,229,96,32,155,229,4,63,139,226,4,207,134,226,0,192,156,229,0,192,141,229,72,192,155,229
	.byte 60,255,47,225,84,0,139,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 232
	.byte 0,0,159,231,144,18,160,227
bl _p_1

	.byte 84,16,155,229,8,16,192,229,8,0,139,229,3,15,134,226,80,0,139,229,16,0,155,229,48,0,139,229,20,0,155,229
	.byte 52,0,139,229,0,128,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 88
	.byte 8,128,159,231,48,0,155,229,52,16,155,229
bl _p_74

	.byte 80,16,155,229,0,0,129,229,161,20,160,225,0,32,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . -4
	.byte 2,32,159,231,2,16,129,224,64,35,160,227,0,32,193,229,13,0,0,234,32,0,139,229,12,0,139,229,68,16,155,229
	.byte 12,0,155,229,0,0,129,229,161,20,160,225,0,32,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . -4
	.byte 2,32,159,231,2,16,129,224,64,35,160,227,0,32,193,229,255,255,255,234,8,0,155,229,67,0,0,234,0,0,159,229
	.byte 0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 228
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,63,0,0,26,255,255,255,234,0,0,150,229,88,0,139,229,1,15,134,226
	.byte 0,0,144,229,92,0,139,229,2,15,134,226,0,0,144,229,0,0,144,229,96,0,139,229,3,15,134,226,0,0,144,229
	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 88
	.byte 8,128,159,231,6,31,139,226
bl _p_52

	.byte 88,0,155,229,92,16,155,229,96,32,155,229,6,63,139,226,4,207,134,226,0,192,156,229,0,192,141,229,72,192,155,229
	.byte 60,255,47,225,84,0,139,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 232
	.byte 0,0,159,231,144,18,160,227
bl _p_1

	.byte 84,16,155,229,8,16,192,229,8,0,139,229,3,15,134,226,80,0,139,229,24,0,155,229,56,0,139,229,28,0,155,229
	.byte 60,0,139,229,0,128,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 88
	.byte 8,128,159,231,56,0,155,229,60,16,155,229
bl _p_74

	.byte 80,16,155,229,0,0,129,229,161,20,160,225,0,32,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . -4
	.byte 2,32,159,231,2,16,129,224,64,35,160,227,0,32,193,229,8,0,155,229,26,223,139,226,96,9,189,232,128,128,189,232
bl _p_73

	.byte 0,80,160,225,0,15,80,227,188,255,255,10,5,0,160,225
bl _p_8

Lme_98:
.text
	.align 2
	.no_dead_strip wrapper_runtime_invoke__Module_runtime_invoke_object_Nullable_1_Kernel32_SECURITY_ATTRIBUTES_byte_object_object_intptr_intptr_intptr
wrapper_runtime_invoke__Module_runtime_invoke_object_Nullable_1_Kernel32_SECURITY_ATTRIBUTES_byte_object_object_intptr_intptr_intptr:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,96,9,45,233,22,223,77,226,13,176,160,225,64,0,139,229,1,96,160,225,68,32,139,229
	.byte 72,48,139,229,0,15,160,227,8,0,139,229,0,15,160,227,12,0,139,229,68,0,155,229,0,15,80,227,52,0,0,10
	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 228
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,5,0,0,10
bl _p_73

	.byte 0,80,160,225,0,15,80,227,1,0,0,10,5,0,160,225
bl _p_8

	.byte 0,0,150,229,0,128,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 108
	.byte 8,128,159,231,8,31,139,226
bl _p_70

	.byte 1,15,134,226,0,0,144,229,0,0,208,229,2,31,134,226,0,192,145,229,32,16,155,229,80,16,139,229,36,16,155,229
	.byte 40,32,155,229,44,48,155,229,0,0,141,229,80,0,155,229,4,192,141,229,72,192,155,229,60,255,47,225,8,0,139,229
	.byte 13,0,0,234,16,0,139,229,12,0,139,229,68,16,155,229,12,0,155,229,0,0,129,229,161,20,160,225,0,32,159,229
	.byte 0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . -4
	.byte 2,32,159,231,2,16,129,224,64,35,160,227,0,32,193,229,255,255,255,234,8,0,155,229,30,0,0,234,0,0,159,229
	.byte 0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 228
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,26,0,0,26,255,255,255,234,0,0,150,229,0,128,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 108
	.byte 8,128,159,231,12,31,139,226
bl _p_70

	.byte 1,15,134,226,0,0,144,229,0,0,208,229,2,31,134,226,0,192,145,229,48,16,155,229,80,16,139,229,52,16,155,229
	.byte 56,32,155,229,60,48,155,229,0,0,141,229,80,0,155,229,4,192,141,229,72,192,155,229,60,255,47,225,8,0,139,229
	.byte 22,223,139,226,96,9,189,232,128,128,189,232
bl _p_73

	.byte 0,80,160,225,0,15,80,227,225,255,255,10,5,0,160,225
bl _p_8

Lme_99:
.text
	.align 2
	.no_dead_strip wrapper_managed_to_native_PInvoke_Kernel32_FindFirstFileEx_string_PInvoke_Kernel32_FINDEX_INFO_LEVELS_PInvoke_Kernel32_WIN32_FIND_DATA__PInvoke_Kernel32_FINDEX_SEARCH_OPS_void__PInvoke_Kernel32_FindFirstFileExFlags
wrapper_managed_to_native_PInvoke_Kernel32_FindFirstFileEx_string_PInvoke_Kernel32_FINDEX_INFO_LEVELS_PInvoke_Kernel32_WIN32_FIND_DATA__PInvoke_Kernel32_FINDEX_SEARCH_OPS_void__PInvoke_Kernel32_FindFirstFileExFlags:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,13,192,160,225,240,95,45,233,62,223,77,226,13,176,160,225,48,0,139,229,52,16,139,229
	.byte 56,32,139,229,60,48,139,229,40,225,157,229,64,224,139,229,44,225,157,229,68,224,139,229
bl _mono_tls_get_lmf_addr

	.byte 20,31,141,226,4,0,129,229,0,192,144,229,0,192,129,229,0,16,128,229,12,208,129,229,20,176,129,229,15,192,160,225
	.byte 16,192,129,229,48,0,155,229
bl _p_75

	.byte 56,160,155,229,148,31,160,227,0,15,81,227,148,31,160,227,7,96,129,226,7,96,198,227,6,208,77,224,0,224,160,227
	.byte 0,0,0,234,6,224,141,231,4,96,86,226,252,255,255,170,13,96,160,225,2,223,77,226,52,16,155,229,6,32,160,225
	.byte 60,48,155,229,64,192,155,229,0,192,141,229,68,192,155,229,4,192,141,229
bl _p_76

	.byte 76,0,139,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 132
	.byte 0,0,159,231
bl _p_34

	.byte 72,0,139,229
bl _p_35

	.byte 72,0,155,229,76,16,155,229,0,80,160,225,2,15,128,226,0,16,128,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 228
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,100,0,0,26,255,255,255,234,56,64,155,229,4,0,160,225,0,15,80,227
	.byte 84,0,0,10,0,0,150,229,0,0,132,229,1,175,134,226,1,79,132,226,8,160,139,229,12,64,139,229,0,0,154,229
	.byte 0,0,132,229,4,0,154,229,4,0,132,229,8,0,155,229,2,175,128,226,2,79,132,226,16,160,139,229,20,64,139,229
	.byte 0,0,154,229,0,0,132,229,4,0,154,229,4,0,132,229,16,0,155,229,2,175,128,226,2,79,132,226,24,160,139,229
	.byte 28,64,139,229,0,0,154,229,0,0,132,229,4,0,154,229,4,0,132,229,24,0,155,229,2,175,128,226,2,79,132,226
	.byte 0,0,154,229,0,0,132,229,1,175,138,226,1,79,132,226,0,0,154,229,0,0,132,229,1,175,138,226,1,79,132,226
	.byte 0,0,154,229,0,0,132,229,1,175,138,226,1,79,132,226,0,0,154,229,0,0,132,229,1,175,138,226,1,79,132,226
	.byte 32,160,139,229,36,64,139,229,10,0,160,225,65,31,160,227
bl _p_77

	.byte 0,0,132,229,164,20,160,225,0,32,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . -4
	.byte 2,32,159,231,2,16,129,224,64,35,160,227,0,32,193,229,130,175,138,226,1,79,132,226,40,160,139,229,44,64,139,229
	.byte 10,0,160,225,224,18,160,227
bl _p_77

	.byte 0,0,132,229,164,20,160,225,0,32,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . -4
	.byte 2,32,159,231,2,16,129,224,64,35,160,227,0,32,193,229,7,175,138,226,1,79,132,226,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 236
	.byte 0,0,159,231,6,16,160,225
bl _p_78

	.byte 5,0,160,225,20,47,139,226,0,192,146,229,4,224,146,229,0,192,142,229,62,223,139,226,240,31,189,232,4,208,141,226
	.byte 128,128,189,232,10,0,160,225
bl _p_8
bl _p_79

	.byte 0,160,160,225,0,15,80,227,249,255,255,26,150,255,255,234

Lme_9a:
.text
	.align 2
	.no_dead_strip wrapper_managed_to_native_PInvoke_Kernel32_FormatMessage_PInvoke_Kernel32_FormatMessageFlags_void__int_int_System_Text_StringBuilder_int_intptr__
wrapper_managed_to_native_PInvoke_Kernel32_FormatMessage_PInvoke_Kernel32_FormatMessageFlags_void__int_int_System_Text_StringBuilder_int_intptr__:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,13,192,160,225,240,95,45,233,58,223,77,226,13,176,160,225,24,0,139,229,28,16,139,229
	.byte 32,32,139,229,36,48,139,229,24,225,157,229,40,224,139,229,28,225,157,229,44,224,139,229,32,225,157,229,48,224,139,229
bl _mono_tls_get_lmf_addr

	.byte 16,31,141,226,4,0,129,229,0,192,144,229,0,192,129,229,0,16,128,229,12,208,129,229,20,176,129,229,15,192,160,225
	.byte 16,192,129,229,40,0,155,229
bl _p_80

	.byte 0,160,160,225,48,0,155,229
bl _p_81

	.byte 0,80,160,225,24,0,155,229,28,16,155,229,32,32,155,229,36,48,155,229,0,160,141,229,44,192,155,229,4,192,141,229
	.byte 8,80,141,229
bl _p_82

	.byte 56,0,139,229
bl _p_83

	.byte 56,0,155,229,16,0,139,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 228
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,17,0,0,26,255,255,255,234,40,0,155,229,10,16,160,225
bl _p_84

	.byte 48,0,155,229,5,16,160,225
bl _p_85

	.byte 16,0,155,229,16,47,139,226,0,192,146,229,4,224,146,229,0,192,142,229,59,223,139,226,224,31,189,232,4,208,141,226
	.byte 128,128,189,232,20,0,155,229
bl _p_8
bl _p_79

	.byte 0,16,160,225,20,16,139,229,0,15,80,227,248,255,255,26,232,255,255,234

Lme_9b:
.text
	.align 2
	.no_dead_strip wrapper_managed_to_native_PInvoke_Kernel32_GetCurrentThreadId
wrapper_managed_to_native_PInvoke_Kernel32_GetCurrentThreadId:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,13,192,160,225,240,95,45,233,44,223,77,226
bl _mono_tls_get_lmf_addr

	.byte 2,31,141,226,4,0,129,229,0,192,144,229,0,192,129,229,0,16,128,229,12,208,129,229,20,176,129,229,15,192,160,225
	.byte 16,192,129,229
bl _p_86

	.byte 0,0,141,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 228
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,10,0,0,26,255,255,255,234,0,0,157,229,8,192,157,229,12,224,157,229
	.byte 0,192,142,229,48,223,141,226,0,31,189,232,4,208,141,226,128,128,189,232,4,0,157,229
bl _p_8
bl _p_79

	.byte 0,16,160,225,4,16,141,229,0,15,80,227,248,255,255,26,239,255,255,234

Lme_9c:
.text
	.align 2
	.no_dead_strip wrapper_managed_to_native_PInvoke_Kernel32_GetCurrentProcessId
wrapper_managed_to_native_PInvoke_Kernel32_GetCurrentProcessId:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,13,192,160,225,240,95,45,233,44,223,77,226
bl _mono_tls_get_lmf_addr

	.byte 2,31,141,226,4,0,129,229,0,192,144,229,0,192,129,229,0,16,128,229,12,208,129,229,20,176,129,229,15,192,160,225
	.byte 16,192,129,229
bl _p_87

	.byte 0,0,141,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 228
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,10,0,0,26,255,255,255,234,0,0,157,229,8,192,157,229,12,224,157,229
	.byte 0,192,142,229,48,223,141,226,0,31,189,232,4,208,141,226,128,128,189,232,4,0,157,229
bl _p_8
bl _p_79

	.byte 0,16,160,225,4,16,141,229,0,15,80,227,248,255,255,26,239,255,255,234

Lme_9d:
.text
	.align 2
	.no_dead_strip wrapper_managed_to_native_PInvoke_Kernel32_GetCurrentProcess
wrapper_managed_to_native_PInvoke_Kernel32_GetCurrentProcess:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,13,192,160,225,240,95,45,233,46,223,77,226
bl _mono_tls_get_lmf_addr

	.byte 4,31,141,226,4,0,129,229,0,192,144,229,0,192,129,229,0,16,128,229,12,208,129,229,20,176,129,229,15,192,160,225
	.byte 16,192,129,229
bl _p_88

	.byte 12,0,141,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 152
	.byte 0,0,159,231
bl _p_34

	.byte 8,0,141,229
bl _p_40

	.byte 8,0,157,229,12,16,157,229,0,160,160,225,2,15,128,226,0,16,128,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 228
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,10,0,0,26,255,255,255,234,10,0,160,225,16,192,157,229,20,224,157,229
	.byte 0,192,142,229,50,223,141,226,0,31,189,232,4,208,141,226,128,128,189,232,0,0,157,229
bl _p_8
bl _p_79

	.byte 0,16,160,225,0,16,141,229,0,15,80,227,248,255,255,26,239,255,255,234

Lme_9e:
.text
	.align 2
	.no_dead_strip wrapper_managed_to_native_PInvoke_Kernel32_CancelIoEx_PInvoke_Kernel32_SafeObjectHandle_PInvoke_Kernel32_OVERLAPPED_
wrapper_managed_to_native_PInvoke_Kernel32_CancelIoEx_PInvoke_Kernel32_SafeObjectHandle_PInvoke_Kernel32_OVERLAPPED_:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,13,192,160,225,240,95,45,233,48,223,77,226,0,96,160,225,1,160,160,225
bl _mono_tls_get_lmf_addr

	.byte 6,31,141,226,4,0,129,229,0,192,144,229,0,192,129,229,0,16,128,229,12,208,129,229,20,176,129,229,15,192,160,225
	.byte 16,192,129,229,0,15,160,227,8,0,205,229,0,15,86,227,40,0,0,10,0,15,160,227,8,0,205,229,2,31,141,226
	.byte 6,0,160,225
bl _p_89

	.byte 2,15,134,226,0,0,144,229,4,0,141,229,10,16,160,225
bl _p_90

	.byte 16,0,141,229
bl _p_83

	.byte 16,0,157,229,0,0,205,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 228
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,13,0,0,26,255,255,255,234,8,0,221,229,0,15,80,227,1,0,0,10
	.byte 6,0,160,225
bl _p_91

	.byte 0,0,221,229,24,192,157,229,28,224,157,229,0,192,142,229,50,223,141,226,192,31,189,232,4,208,141,226,128,128,189,232
bl _p_79

	.byte 0,160,160,225,0,15,80,227,238,255,255,10,10,0,160,225
bl _p_8

	.byte 148,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_0
bl _p_8

Lme_9f:
.text
	.align 2
	.no_dead_strip wrapper_managed_to_native_PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_void__int_int__PInvoke_Kernel32_OVERLAPPED_
wrapper_managed_to_native_PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_void__int_int__PInvoke_Kernel32_OVERLAPPED_:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,13,192,160,225,240,95,45,233,54,223,77,226,13,176,160,225,0,160,160,225,24,16,139,229
	.byte 28,32,139,229,32,48,139,229,8,225,157,229,36,224,139,229
bl _mono_tls_get_lmf_addr

	.byte 12,31,141,226,4,0,129,229,0,192,144,229,0,192,129,229,0,16,128,229,12,208,129,229,20,176,129,229,15,192,160,225
	.byte 16,192,129,229,0,15,160,227,16,0,203,229,0,15,90,227,46,0,0,10,0,15,160,227,16,0,203,229,4,31,139,226
	.byte 10,0,160,225
bl _p_89

	.byte 2,15,138,226,0,0,144,229,12,0,139,229,24,16,155,229,28,32,155,229,32,48,155,229,36,192,155,229,0,192,141,229
bl _p_92

	.byte 40,0,139,229
bl _p_83

	.byte 40,0,155,229,8,0,203,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 228
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,14,0,0,26,255,255,255,234,16,0,219,229,0,15,80,227,1,0,0,10
	.byte 10,0,160,225
bl _p_91

	.byte 8,0,219,229,12,47,139,226,0,192,146,229,4,224,146,229,0,192,142,229,58,223,139,226,0,31,189,232,4,208,141,226
	.byte 128,128,189,232
bl _p_79

	.byte 0,16,160,225,20,16,139,229,0,15,80,227,236,255,255,10,20,0,155,229
bl _p_8

	.byte 148,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_0
bl _p_8

Lme_a0:
.text
	.align 2
	.no_dead_strip wrapper_managed_to_native_PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_void__int_int__PInvoke_Kernel32_OVERLAPPED_
wrapper_managed_to_native_PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_void__int_int__PInvoke_Kernel32_OVERLAPPED_:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,13,192,160,225,240,95,45,233,54,223,77,226,13,176,160,225,0,160,160,225,24,16,139,229
	.byte 28,32,139,229,32,48,139,229,8,225,157,229,36,224,139,229
bl _mono_tls_get_lmf_addr

	.byte 12,31,141,226,4,0,129,229,0,192,144,229,0,192,129,229,0,16,128,229,12,208,129,229,20,176,129,229,15,192,160,225
	.byte 16,192,129,229,0,15,160,227,16,0,203,229,0,15,90,227,46,0,0,10,0,15,160,227,16,0,203,229,4,31,139,226
	.byte 10,0,160,225
bl _p_89

	.byte 2,15,138,226,0,0,144,229,12,0,139,229,24,16,155,229,28,32,155,229,32,48,155,229,36,192,155,229,0,192,141,229
bl _p_93

	.byte 40,0,139,229
bl _p_83

	.byte 40,0,155,229,8,0,203,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 228
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,14,0,0,26,255,255,255,234,16,0,219,229,0,15,80,227,1,0,0,10
	.byte 10,0,160,225
bl _p_91

	.byte 8,0,219,229,12,47,139,226,0,192,146,229,4,224,146,229,0,192,142,229,58,223,139,226,0,31,189,232,4,208,141,226
	.byte 128,128,189,232
bl _p_79

	.byte 0,16,160,225,20,16,139,229,0,15,80,227,236,255,255,10,20,0,155,229
bl _p_8

	.byte 148,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_0
bl _p_8

Lme_a1:
.text
	.align 2
	.no_dead_strip wrapper_managed_to_native_PInvoke_Kernel32_SuspendThread_PInvoke_Kernel32_SafeObjectHandle
wrapper_managed_to_native_PInvoke_Kernel32_SuspendThread_PInvoke_Kernel32_SafeObjectHandle:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,13,192,160,225,240,95,45,233,46,223,77,226,0,160,160,225
bl _mono_tls_get_lmf_addr

	.byte 4,31,141,226,4,0,129,229,0,192,144,229,0,192,129,229,0,16,128,229,12,208,129,229,20,176,129,229,15,192,160,225
	.byte 16,192,129,229,0,15,160,227,4,0,205,229,0,15,90,227,39,0,0,10,0,15,160,227,4,0,205,229,1,31,141,226
	.byte 10,0,160,225
bl _p_89

	.byte 2,15,138,226,0,80,144,229,5,0,160,225
bl _p_94

	.byte 8,0,141,229
bl _p_83

	.byte 8,0,157,229,0,0,141,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 228
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,13,0,0,26,255,255,255,234,4,0,221,229,0,15,80,227,1,0,0,10
	.byte 10,0,160,225
bl _p_91

	.byte 0,0,157,229,16,192,157,229,20,224,157,229,0,192,142,229,47,223,141,226,224,31,189,232,4,208,141,226,128,128,189,232
bl _p_79

	.byte 0,80,160,225,0,15,80,227,238,255,255,10,5,0,160,225
bl _p_8

	.byte 148,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_0
bl _p_8

Lme_a2:
.text
	.align 2
	.no_dead_strip wrapper_managed_to_native_PInvoke_Kernel32_ResumeThread_PInvoke_Kernel32_SafeObjectHandle
wrapper_managed_to_native_PInvoke_Kernel32_ResumeThread_PInvoke_Kernel32_SafeObjectHandle:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,13,192,160,225,240,95,45,233,46,223,77,226,0,160,160,225
bl _mono_tls_get_lmf_addr

	.byte 4,31,141,226,4,0,129,229,0,192,144,229,0,192,129,229,0,16,128,229,12,208,129,229,20,176,129,229,15,192,160,225
	.byte 16,192,129,229,0,15,160,227,4,0,205,229,0,15,90,227,39,0,0,10,0,15,160,227,4,0,205,229,1,31,141,226
	.byte 10,0,160,225
bl _p_89

	.byte 2,15,138,226,0,80,144,229,5,0,160,225
bl _p_95

	.byte 8,0,141,229
bl _p_83

	.byte 8,0,157,229,0,0,141,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 228
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,13,0,0,26,255,255,255,234,4,0,221,229,0,15,80,227,1,0,0,10
	.byte 10,0,160,225
bl _p_91

	.byte 0,0,157,229,16,192,157,229,20,224,157,229,0,192,142,229,47,223,141,226,224,31,189,232,4,208,141,226,128,128,189,232
bl _p_79

	.byte 0,80,160,225,0,15,80,227,238,255,255,10,5,0,160,225
bl _p_8

	.byte 148,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_0
bl _p_8

Lme_a3:
.text
	.align 2
	.no_dead_strip wrapper_managed_to_native_PInvoke_Kernel32_WaitForSingleObject_System_Runtime_InteropServices_SafeHandle_int
wrapper_managed_to_native_PInvoke_Kernel32_WaitForSingleObject_System_Runtime_InteropServices_SafeHandle_int:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,13,192,160,225,240,95,45,233,48,223,77,226,0,96,160,225,1,160,160,225
bl _mono_tls_get_lmf_addr

	.byte 6,31,141,226,4,0,129,229,0,192,144,229,0,192,129,229,0,16,128,229,12,208,129,229,20,176,129,229,15,192,160,225
	.byte 16,192,129,229,0,15,160,227,8,0,205,229,0,15,86,227,40,0,0,10,0,15,160,227,8,0,205,229,2,31,141,226
	.byte 6,0,160,225
bl _p_89

	.byte 2,15,134,226,0,0,144,229,4,0,141,229,10,16,160,225
bl _p_96

	.byte 16,0,141,229
bl _p_83

	.byte 16,0,157,229,0,0,141,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 228
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,13,0,0,26,255,255,255,234,8,0,221,229,0,15,80,227,1,0,0,10
	.byte 6,0,160,225
bl _p_91

	.byte 0,0,157,229,24,192,157,229,28,224,157,229,0,192,142,229,50,223,141,226,192,31,189,232,4,208,141,226,128,128,189,232
bl _p_79

	.byte 0,160,160,225,0,15,80,227,238,255,255,10,10,0,160,225
bl _p_8

	.byte 148,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_0
bl _p_8

Lme_a4:
.text
	.align 2
	.no_dead_strip wrapper_managed_to_native_PInvoke_Kernel32_CloseHandle_intptr
wrapper_managed_to_native_PInvoke_Kernel32_CloseHandle_intptr:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,13,192,160,225,240,95,45,233,46,223,77,226,0,160,160,225
bl _mono_tls_get_lmf_addr

	.byte 4,31,141,226,4,0,129,229,0,192,144,229,0,192,129,229,0,16,128,229,12,208,129,229,20,176,129,229,15,192,160,225
	.byte 16,192,129,229,10,0,160,225
bl _p_97

	.byte 8,0,141,229
bl _p_83

	.byte 8,0,157,229,0,0,205,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 228
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,10,0,0,26,255,255,255,234,0,0,221,229,16,192,157,229,20,224,157,229
	.byte 0,192,142,229,50,223,141,226,0,31,189,232,4,208,141,226,128,128,189,232,10,0,160,225
bl _p_8
bl _p_79

	.byte 0,160,160,225,0,15,80,227,249,255,255,26,240,255,255,234

Lme_a5:
.text
	.align 2
	.no_dead_strip wrapper_managed_to_native_PInvoke_Kernel32_FlushFileBuffers_PInvoke_Kernel32_SafeObjectHandle
wrapper_managed_to_native_PInvoke_Kernel32_FlushFileBuffers_PInvoke_Kernel32_SafeObjectHandle:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,13,192,160,225,240,95,45,233,46,223,77,226,0,160,160,225
bl _mono_tls_get_lmf_addr

	.byte 4,31,141,226,4,0,129,229,0,192,144,229,0,192,129,229,0,16,128,229,12,208,129,229,20,176,129,229,15,192,160,225
	.byte 16,192,129,229,0,15,160,227,1,0,205,229,0,15,90,227,39,0,0,10,0,15,160,227,1,0,205,229,64,19,141,226
	.byte 10,0,160,225
bl _p_89

	.byte 2,15,138,226,0,96,144,229,6,0,160,225
bl _p_98

	.byte 8,0,141,229
bl _p_83

	.byte 8,0,157,229,0,0,205,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 228
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,13,0,0,26,255,255,255,234,1,0,221,229,0,15,80,227,1,0,0,10
	.byte 10,0,160,225
bl _p_91

	.byte 0,0,221,229,16,192,157,229,20,224,157,229,0,192,142,229,48,223,141,226,192,31,189,232,4,208,141,226,128,128,189,232
bl _p_79

	.byte 0,96,160,225,0,15,80,227,238,255,255,10,6,0,160,225
bl _p_8

	.byte 148,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_0
bl _p_8

Lme_a6:
.text
	.align 2
	.no_dead_strip wrapper_managed_to_native_PInvoke_Kernel32_CreateMutex_PInvoke_Kernel32_SECURITY_ATTRIBUTES__bool_string
wrapper_managed_to_native_PInvoke_Kernel32_CreateMutex_PInvoke_Kernel32_SECURITY_ATTRIBUTES__bool_string:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,13,192,160,225,240,95,45,233,48,223,77,226,4,0,141,229,8,16,205,229,12,32,141,229
bl _mono_tls_get_lmf_addr

	.byte 6,31,141,226,4,0,129,229,0,192,144,229,0,192,129,229,0,16,128,229,12,208,129,229,20,176,129,229,15,192,160,225
	.byte 16,192,129,229,0,79,160,227,8,0,221,229,0,15,80,227,0,0,0,10,64,67,160,227,12,0,157,229
bl _p_75

	.byte 0,176,160,225,4,0,157,229,4,16,160,225,11,32,160,225
bl _p_99

	.byte 20,0,141,229
bl _p_83

	.byte 20,0,157,229,0,0,141,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 152
	.byte 0,0,159,231
bl _p_34

	.byte 16,0,141,229
bl _p_40

	.byte 16,0,157,229,0,80,160,225,2,15,128,226,0,16,157,229,0,16,128,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 228
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,8,0,0,26,255,255,255,234,5,0,160,225,24,192,157,229,28,224,157,229
	.byte 0,192,142,229,48,223,141,226,240,31,189,232,4,208,141,226,128,128,189,232
bl _p_79

	.byte 0,176,160,225,0,15,80,227,243,255,255,10,11,0,160,225
bl _p_8

Lme_a7:
.text
	.align 2
	.no_dead_strip wrapper_managed_to_native_PInvoke_Kernel32_GetProcAddress_PInvoke_Kernel32_SafeLibraryHandle_string
wrapper_managed_to_native_PInvoke_Kernel32_GetProcAddress_PInvoke_Kernel32_SafeLibraryHandle_string:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,13,192,160,225,240,95,45,233,48,223,77,226,0,96,160,225,8,16,141,229
bl _mono_tls_get_lmf_addr

	.byte 6,31,141,226,4,0,129,229,0,192,144,229,0,192,129,229,0,16,128,229,12,208,129,229,20,176,129,229,15,192,160,225
	.byte 16,192,129,229,0,15,160,227,4,0,205,229,0,15,86,227,45,0,0,10,0,15,160,227,4,0,205,229,1,31,141,226
	.byte 6,0,160,225
bl _p_89

	.byte 2,15,134,226,0,64,144,229,8,0,157,229
bl _p_100

	.byte 0,176,160,225,4,0,160,225,11,16,160,225
bl _p_101

	.byte 16,0,141,229
bl _p_83

	.byte 16,0,157,229,0,0,141,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 228
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,15,0,0,26,255,255,255,234,4,0,221,229,0,15,80,227,1,0,0,10
	.byte 6,0,160,225
bl _p_91

	.byte 11,0,160,225
bl _p_102

	.byte 0,0,157,229,24,192,157,229,28,224,157,229,0,192,142,229,48,223,141,226,240,31,189,232,4,208,141,226,128,128,189,232
bl _p_79

	.byte 0,64,160,225,0,15,80,227,236,255,255,10,4,0,160,225
bl _p_8

	.byte 148,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_0
bl _p_8

Lme_a8:
.text
	.align 2
	.no_dead_strip wrapper_managed_to_native_PInvoke_Kernel32_GetTickCount
wrapper_managed_to_native_PInvoke_Kernel32_GetTickCount:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,13,192,160,225,240,95,45,233,44,223,77,226
bl _mono_tls_get_lmf_addr

	.byte 2,31,141,226,4,0,129,229,0,192,144,229,0,192,129,229,0,16,128,229,12,208,129,229,20,176,129,229,15,192,160,225
	.byte 16,192,129,229
bl _p_103

	.byte 0,0,141,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 228
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,10,0,0,26,255,255,255,234,0,0,157,229,8,192,157,229,12,224,157,229
	.byte 0,192,142,229,48,223,141,226,0,31,189,232,4,208,141,226,128,128,189,232,4,0,157,229
bl _p_8
bl _p_79

	.byte 0,16,160,225,4,16,141,229,0,15,80,227,248,255,255,26,239,255,255,234

Lme_a9:
.text
	.align 2
	.no_dead_strip wrapper_managed_to_native_PInvoke_Kernel32_GetTickCount64
wrapper_managed_to_native_PInvoke_Kernel32_GetTickCount64:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,13,192,160,225,240,95,45,233,48,223,77,226
bl _mono_tls_get_lmf_addr

	.byte 6,31,141,226,4,0,129,229,0,192,144,229,0,192,129,229,0,16,128,229,12,208,129,229,20,176,129,229,15,192,160,225
	.byte 16,192,129,229
bl _p_104

	.byte 16,16,141,229,12,0,141,229,0,0,141,229,16,0,157,229,4,0,141,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 228
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,11,0,0,26,255,255,255,234,0,0,157,229,4,16,157,229,24,192,157,229
	.byte 28,224,157,229,0,192,142,229,52,223,141,226,0,31,189,232,4,208,141,226,128,128,189,232,8,0,157,229
bl _p_8
bl _p_79

	.byte 0,16,160,225,8,16,141,229,0,15,80,227,248,255,255,26,238,255,255,234

Lme_aa:
.text
	.align 2
	.no_dead_strip wrapper_managed_to_native_PInvoke_Kernel32_GetSystemTime_PInvoke_Kernel32_SYSTEMTIME_
wrapper_managed_to_native_PInvoke_Kernel32_GetSystemTime_PInvoke_Kernel32_SYSTEMTIME_:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,13,192,160,225,240,95,45,233,42,223,77,226,0,160,160,225
bl _mono_tls_get_lmf_addr

	.byte 0,31,141,226,4,0,129,229,0,192,144,229,0,192,129,229,0,16,128,229,12,208,129,229,20,176,129,229,15,192,160,225
	.byte 16,192,129,229,10,0,160,225
bl _p_105

	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 228
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,9,0,0,26,255,255,255,234,0,192,157,229,4,224,157,229,0,192,142,229
	.byte 46,223,141,226,0,31,189,232,4,208,141,226,128,128,189,232,10,0,160,225
bl _p_8
bl _p_79

	.byte 0,160,160,225,0,15,80,227,249,255,255,26,241,255,255,234

Lme_ab:
.text
	.align 2
	.no_dead_strip wrapper_managed_to_native_PInvoke_Kernel32_SetLastError_uint
wrapper_managed_to_native_PInvoke_Kernel32_SetLastError_uint:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,13,192,160,225,240,95,45,233,42,223,77,226,0,160,160,225
bl _mono_tls_get_lmf_addr

	.byte 0,31,141,226,4,0,129,229,0,192,144,229,0,192,129,229,0,16,128,229,12,208,129,229,20,176,129,229,15,192,160,225
	.byte 16,192,129,229,10,0,160,225
bl _p_106
bl _p_83

	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 228
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,9,0,0,26,255,255,255,234,0,192,157,229,4,224,157,229,0,192,142,229
	.byte 46,223,141,226,0,31,189,232,4,208,141,226,128,128,189,232,10,0,160,225
bl _p_8
bl _p_79

	.byte 0,160,160,225,0,15,80,227,249,255,255,26,241,255,255,234

Lme_ac:
.text
	.align 2
	.no_dead_strip wrapper_managed_to_native_PInvoke_Kernel32_FindClose_intptr
wrapper_managed_to_native_PInvoke_Kernel32_FindClose_intptr:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,13,192,160,225,240,95,45,233,46,223,77,226,0,160,160,225
bl _mono_tls_get_lmf_addr

	.byte 4,31,141,226,4,0,129,229,0,192,144,229,0,192,129,229,0,16,128,229,12,208,129,229,20,176,129,229,15,192,160,225
	.byte 16,192,129,229,10,0,160,225
bl _p_107

	.byte 8,0,141,229
bl _p_83

	.byte 8,0,157,229,0,0,205,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 228
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,10,0,0,26,255,255,255,234,0,0,221,229,16,192,157,229,20,224,157,229
	.byte 0,192,142,229,50,223,141,226,0,31,189,232,4,208,141,226,128,128,189,232,10,0,160,225
bl _p_8
bl _p_79

	.byte 0,160,160,225,0,15,80,227,249,255,255,26,240,255,255,234

Lme_ad:
.text
	.align 2
	.no_dead_strip wrapper_managed_to_native_PInvoke_Kernel32_FreeLibrary_intptr
wrapper_managed_to_native_PInvoke_Kernel32_FreeLibrary_intptr:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,13,192,160,225,240,95,45,233,46,223,77,226,0,160,160,225
bl _mono_tls_get_lmf_addr

	.byte 4,31,141,226,4,0,129,229,0,192,144,229,0,192,129,229,0,16,128,229,12,208,129,229,20,176,129,229,15,192,160,225
	.byte 16,192,129,229,10,0,160,225
bl _p_108

	.byte 8,0,141,229
bl _p_83

	.byte 8,0,157,229,0,0,205,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 228
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,10,0,0,26,255,255,255,234,0,0,221,229,16,192,157,229,20,224,157,229
	.byte 0,192,142,229,50,223,141,226,0,31,189,232,4,208,141,226,128,128,189,232,10,0,160,225
bl _p_8
bl _p_79

	.byte 0,160,160,225,0,15,80,227,249,255,255,26,240,255,255,234

Lme_ae:
.text
ut_175:

	.byte 8,0,128,226
	b wrapper_unknown_PInvoke_Kernel32_ACCESS_MASK_StructureToPtr_object_intptr_bool

.text
	.align 2
	.no_dead_strip wrapper_unknown_PInvoke_Kernel32_ACCESS_MASK_StructureToPtr_object_intptr_bool
wrapper_unknown_PInvoke_Kernel32_ACCESS_MASK_StructureToPtr_object_intptr_bool:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,5,223,77,226,0,0,141,229,4,16,141,229,8,32,205,229,0,0,157,229
	.byte 2,15,128,226,0,16,144,229,4,0,157,229,0,16,128,229,5,223,141,226,0,1,189,232,128,128,189,232

Lme_af:
.text
ut_176:

	.byte 8,0,128,226
	b wrapper_unknown_PInvoke_Kernel32_ACCESS_MASK_PtrToStructure_intptr_object

.text
	.align 2
	.no_dead_strip wrapper_unknown_PInvoke_Kernel32_ACCESS_MASK_PtrToStructure_intptr_object
wrapper_unknown_PInvoke_Kernel32_ACCESS_MASK_PtrToStructure_intptr_object:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,4,16,141,229,4,0,157,229,2,15,128,226
	.byte 0,16,157,229,0,16,145,229,0,16,128,229,3,223,141,226,0,1,189,232,128,128,189,232

Lme_b0:
.text
ut_177:

	.byte 8,0,128,226
	b wrapper_unknown_PInvoke_Kernel32_FILETIME_StructureToPtr_object_intptr_bool

.text
	.align 2
	.no_dead_strip wrapper_unknown_PInvoke_Kernel32_FILETIME_StructureToPtr_object_intptr_bool
wrapper_unknown_PInvoke_Kernel32_FILETIME_StructureToPtr_object_intptr_bool:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,5,223,77,226,0,0,141,229,4,16,141,229,8,32,205,229,0,0,157,229
	.byte 2,31,128,226,0,32,145,229,4,0,157,229,0,32,128,229,4,16,145,229,4,16,128,229,5,223,141,226,0,1,189,232
	.byte 128,128,189,232

Lme_b1:
.text
ut_178:

	.byte 8,0,128,226
	b wrapper_unknown_PInvoke_Kernel32_FILETIME_PtrToStructure_intptr_object

.text
	.align 2
	.no_dead_strip wrapper_unknown_PInvoke_Kernel32_FILETIME_PtrToStructure_intptr_object
wrapper_unknown_PInvoke_Kernel32_FILETIME_PtrToStructure_intptr_object:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,4,16,141,229,4,0,157,229,2,15,128,226
	.byte 0,16,157,229,0,32,145,229,0,32,128,229,4,16,145,229,4,16,128,229,3,223,141,226,0,1,189,232,128,128,189,232

Lme_b2:
.text
ut_179:

	.byte 8,0,128,226
	b wrapper_unknown_PInvoke_Kernel32_OVERLAPPED_StructureToPtr_object_intptr_bool

.text
	.align 2
	.no_dead_strip wrapper_unknown_PInvoke_Kernel32_OVERLAPPED_StructureToPtr_object_intptr_bool
wrapper_unknown_PInvoke_Kernel32_OVERLAPPED_StructureToPtr_object_intptr_bool:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,5,45,233,2,223,77,226,0,0,141,229,1,160,160,225,4,32,205,229,0,0,157,229
	.byte 2,15,128,226,0,16,144,229,0,16,138,229,4,16,144,229,4,16,138,229,8,16,144,229,8,16,138,229,12,16,144,229
	.byte 12,16,138,229,16,0,144,229,16,0,138,229,2,223,141,226,0,5,189,232,128,128,189,232

Lme_b3:
.text
ut_180:

	.byte 8,0,128,226
	b wrapper_unknown_PInvoke_Kernel32_OVERLAPPED_PtrToStructure_intptr_object

.text
	.align 2
	.no_dead_strip wrapper_unknown_PInvoke_Kernel32_OVERLAPPED_PtrToStructure_intptr_object
wrapper_unknown_PInvoke_Kernel32_OVERLAPPED_PtrToStructure_intptr_object:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,1,45,233,2,223,77,226,0,96,160,225,0,16,141,229,0,0,157,229,2,15,128,226
	.byte 0,16,150,229,0,16,128,229,4,16,150,229,4,16,128,229,8,16,150,229,8,16,128,229,12,16,150,229,12,16,128,229
	.byte 16,16,150,229,16,16,128,229,2,223,141,226,64,1,189,232,128,128,189,232

Lme_b4:
.text
ut_181:

	.byte 8,0,128,226
	b wrapper_unknown_PInvoke_Kernel32_SECURITY_ATTRIBUTES_StructureToPtr_object_intptr_bool

.text
	.align 2
	.no_dead_strip wrapper_unknown_PInvoke_Kernel32_SECURITY_ATTRIBUTES_StructureToPtr_object_intptr_bool
wrapper_unknown_PInvoke_Kernel32_SECURITY_ATTRIBUTES_StructureToPtr_object_intptr_bool:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,5,45,233,2,223,77,226,0,0,141,229,1,160,160,225,4,32,205,229,0,0,157,229
	.byte 2,15,128,226,0,16,144,229,0,16,138,229,4,16,144,229,4,16,138,229,8,0,144,229,8,0,138,229,2,223,141,226
	.byte 0,5,189,232,128,128,189,232

Lme_b5:
.text
ut_182:

	.byte 8,0,128,226
	b wrapper_unknown_PInvoke_Kernel32_SECURITY_ATTRIBUTES_PtrToStructure_intptr_object

.text
	.align 2
	.no_dead_strip wrapper_unknown_PInvoke_Kernel32_SECURITY_ATTRIBUTES_PtrToStructure_intptr_object
wrapper_unknown_PInvoke_Kernel32_SECURITY_ATTRIBUTES_PtrToStructure_intptr_object:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,1,45,233,2,223,77,226,0,96,160,225,0,16,141,229,0,0,157,229,2,15,128,226
	.byte 0,16,150,229,0,16,128,229,4,16,150,229,4,16,128,229,8,16,150,229,8,16,128,229,2,223,141,226,64,1,189,232
	.byte 128,128,189,232

Lme_b6:
.text
ut_183:

	.byte 8,0,128,226
	b wrapper_unknown_PInvoke_Kernel32_SECURITY_DESCRIPTOR_StructureToPtr_object_intptr_bool

.text
	.align 2
	.no_dead_strip wrapper_unknown_PInvoke_Kernel32_SECURITY_DESCRIPTOR_StructureToPtr_object_intptr_bool
wrapper_unknown_PInvoke_Kernel32_SECURITY_DESCRIPTOR_StructureToPtr_object_intptr_bool:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,5,45,233,2,223,77,226,0,0,141,229,1,160,160,225,4,32,205,229,0,0,157,229
	.byte 2,15,128,226,0,16,144,229,0,16,138,229,4,16,144,229,4,16,138,229,8,16,144,229,8,16,138,229,12,16,144,229
	.byte 12,16,138,229,16,0,144,229,16,0,138,229,2,223,141,226,0,5,189,232,128,128,189,232

Lme_b7:
.text
ut_184:

	.byte 8,0,128,226
	b wrapper_unknown_PInvoke_Kernel32_SECURITY_DESCRIPTOR_PtrToStructure_intptr_object

.text
	.align 2
	.no_dead_strip wrapper_unknown_PInvoke_Kernel32_SECURITY_DESCRIPTOR_PtrToStructure_intptr_object
wrapper_unknown_PInvoke_Kernel32_SECURITY_DESCRIPTOR_PtrToStructure_intptr_object:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,1,45,233,2,223,77,226,0,96,160,225,0,16,141,229,0,0,157,229,2,15,128,226
	.byte 0,16,150,229,0,16,128,229,4,16,150,229,4,16,128,229,8,16,150,229,8,16,128,229,12,16,150,229,12,16,128,229
	.byte 16,16,150,229,16,16,128,229,2,223,141,226,64,1,189,232,128,128,189,232

Lme_b8:
.text
ut_185:

	.byte 8,0,128,226
	b wrapper_unknown_PInvoke_Kernel32_SYSTEMTIME_StructureToPtr_object_intptr_bool

.text
	.align 2
	.no_dead_strip wrapper_unknown_PInvoke_Kernel32_SYSTEMTIME_StructureToPtr_object_intptr_bool
wrapper_unknown_PInvoke_Kernel32_SYSTEMTIME_StructureToPtr_object_intptr_bool:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,5,45,233,2,223,77,226,0,0,141,229,1,160,160,225,4,32,205,229,0,0,157,229
	.byte 2,15,128,226,0,16,144,229,0,16,138,229,4,16,144,229,4,16,138,229,8,16,144,229,8,16,138,229,12,0,144,229
	.byte 12,0,138,229,2,223,141,226,0,5,189,232,128,128,189,232

Lme_b9:
.text
ut_186:

	.byte 8,0,128,226
	b wrapper_unknown_PInvoke_Kernel32_SYSTEMTIME_PtrToStructure_intptr_object

.text
	.align 2
	.no_dead_strip wrapper_unknown_PInvoke_Kernel32_SYSTEMTIME_PtrToStructure_intptr_object
wrapper_unknown_PInvoke_Kernel32_SYSTEMTIME_PtrToStructure_intptr_object:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,1,45,233,2,223,77,226,0,96,160,225,0,16,141,229,0,0,157,229,2,15,128,226
	.byte 0,16,150,229,0,16,128,229,4,16,150,229,4,16,128,229,8,16,150,229,8,16,128,229,12,16,150,229,12,16,128,229
	.byte 2,223,141,226,64,1,189,232,128,128,189,232

Lme_ba:
.text
ut_187:

	.byte 8,0,128,226
	b wrapper_unknown_PInvoke_Kernel32_WIN32_FIND_DATA_StructureToPtr_object_intptr_bool

.text
	.align 2
	.no_dead_strip wrapper_unknown_PInvoke_Kernel32_WIN32_FIND_DATA_StructureToPtr_object_intptr_bool
wrapper_unknown_PInvoke_Kernel32_WIN32_FIND_DATA_StructureToPtr_object_intptr_bool:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,7,223,77,226,0,0,141,229,4,16,141,229,8,32,205,229,0,0,157,229
	.byte 2,31,128,226,0,32,145,229,4,0,157,229,0,32,128,229,1,31,129,226,1,47,128,226,2,0,160,225,0,48,145,229
	.byte 0,48,130,229,4,48,145,229,4,48,130,229,2,31,129,226,2,47,128,226,2,0,160,225,0,48,145,229,0,48,130,229
	.byte 4,48,145,229,4,48,130,229,2,31,129,226,2,47,128,226,2,0,160,225,0,48,145,229,0,48,130,229,4,48,145,229
	.byte 4,48,130,229,2,31,129,226,2,15,128,226,0,32,145,229,0,32,128,229,1,31,129,226,1,15,128,226,0,32,145,229
	.byte 0,32,128,229,1,31,129,226,1,15,128,226,0,32,145,229,0,32,128,229,1,31,129,226,1,15,128,226,0,32,145,229
	.byte 0,32,128,229,1,31,129,226,1,15,128,226,20,16,141,229,0,16,145,229,16,0,141,229,65,47,160,227
bl _p_109

	.byte 16,0,157,229,20,16,157,229,1,31,129,226,130,15,128,226,0,16,145,229,224,34,160,227
bl _p_109

	.byte 7,223,141,226,0,1,189,232,128,128,189,232

Lme_bb:
.text
ut_188:

	.byte 8,0,128,226
	b wrapper_unknown_PInvoke_Kernel32_WIN32_FIND_DATA_PtrToStructure_intptr_object

.text
	.align 2
	.no_dead_strip wrapper_unknown_PInvoke_Kernel32_WIN32_FIND_DATA_PtrToStructure_intptr_object
wrapper_unknown_PInvoke_Kernel32_WIN32_FIND_DATA_PtrToStructure_intptr_object:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,7,223,77,226,0,0,141,229,4,16,141,229,4,0,157,229,0,16,144,229
	.byte 24,32,209,229,0,15,82,227,81,0,0,27,0,16,145,229,0,16,145,229,0,32,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 236
	.byte 2,32,159,231,2,0,81,225,73,0,0,27,2,31,128,226,0,0,157,229,0,32,144,229,0,32,129,229,1,15,128,226
	.byte 1,31,129,226,0,32,144,229,0,32,129,229,4,32,144,229,4,32,129,229,2,15,128,226,2,31,129,226,0,32,144,229
	.byte 0,32,129,229,4,32,144,229,4,32,129,229,2,15,128,226,2,31,129,226,0,32,144,229,0,32,129,229,4,32,144,229
	.byte 4,32,129,229,2,15,128,226,2,31,129,226,0,32,144,229,0,32,129,229,1,15,128,226,1,31,129,226,0,32,144,229
	.byte 0,32,129,229,1,15,128,226,1,31,129,226,0,32,144,229,0,32,129,229,1,15,128,226,1,31,129,226,0,32,144,229
	.byte 0,32,129,229,1,15,128,226,1,31,129,226,16,16,141,229,12,0,141,229,65,31,160,227
bl _p_77

	.byte 0,32,160,225,12,0,157,229,16,16,157,229,0,32,129,229,161,52,160,225,0,192,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . -4
	.byte 12,192,159,231,12,48,131,224,64,195,160,227,0,192,195,229,130,15,128,226,1,31,129,226,8,16,141,229,224,18,160,227
bl _p_77

	.byte 8,16,157,229,0,0,129,229,161,20,160,225,0,32,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . -4
	.byte 2,32,159,231,2,16,129,224,64,35,160,227,0,32,193,229,7,223,141,226,0,1,189,232,128,128,189,232,14,16,160,225
	.byte 0,0,159,229
bl _p_11

	.byte 239,0,0,0

Lme_bc:
.text
	.align 2
	.no_dead_strip System_Array_IndexOf_T_BYTE_T_BYTE___T_BYTE_int_int
System_Array_IndexOf_T_BYTE_T_BYTE___T_BYTE_int_int:
.file 4 "/Library/Frameworks/Xamarin.iOS.framework/Versions/11.6.1.2/src/mono/external/corert/src/System.Private.CoreLib/src/System/Array.cs"
.loc 4 687 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,96,5,45,233,4,223,77,226,0,128,141,229,0,80,160,225,4,16,205,229,2,96,160,225
	.byte 3,160,160,225,0,15,85,227,26,0,0,10
.loc 4 692 0

	.byte 0,15,86,227,31,0,0,186,12,0,149,229,0,0,86,225,28,0,0,202
.loc 4 697 0

	.byte 0,15,90,227,37,0,0,186,12,0,149,229,6,0,64,224,0,0,90,225,33,0,0,202
.loc 4 702 0

	.byte 0,0,157,229
bl _p_110

	.byte 8,0,141,229,0,0,157,229
bl _p_111

	.byte 0,192,160,225,8,0,157,229,0,128,160,225,5,0,160,225,4,16,221,229,6,32,160,225,10,48,160,225,60,255,47,225
	.byte 4,223,141,226,96,5,189,232,128,128,189,232
.loc 4 689 0

	.byte 155,5,2,227
bl _p_51

	.byte 0,16,160,225,148,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_8
.loc 4 694 0

	.byte 134,9,2,227
bl _p_51

	.byte 8,0,141,229,156,9,2,227
bl _p_51

	.byte 0,32,160,225,8,16,157,229,149,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_2
bl _p_8
.loc 4 699 0

	.byte 75,10,2,227
bl _p_51

	.byte 8,0,141,229,87,10,2,227
bl _p_51

	.byte 0,32,160,225,8,16,157,229,149,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_2
bl _p_8

Lme_bd:
.text
	.align 2
	.no_dead_strip System_ArraySegment_1_ArraySegmentEnumerator_T_BYTE__ctor_System_ArraySegment_1_T_BYTE
System_ArraySegment_1_ArraySegmentEnumerator_T_BYTE__ctor_System_ArraySegment_1_T_BYTE:
.loc 3 299 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,0,9,45,233,14,223,77,226,13,176,160,225,36,0,139,229,40,16,139,229,44,32,139,229
	.byte 48,48,139,229,36,16,155,229,40,0,155,229,0,0,139,229,44,0,155,229,4,0,139,229,48,0,155,229,8,0,139,229
	.byte 0,0,155,229,8,0,129,229,2,31,129,226,161,20,160,225,0,32,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . -4
	.byte 2,32,159,231,2,16,129,224,64,35,160,227,0,32,193,229
.loc 3 300 0

	.byte 36,0,155,229,40,16,155,229,12,16,139,229,44,16,155,229,16,16,139,229,48,16,155,229,20,16,139,229,16,16,155,229
	.byte 12,16,128,229
.loc 3 301 0

	.byte 36,0,155,229,0,16,160,225,12,16,145,229,40,32,155,229,24,32,139,229,44,32,155,229,28,32,139,229,48,32,155,229
	.byte 32,32,139,229,2,16,129,224,16,16,128,229
.loc 3 302 0

	.byte 36,0,155,229,0,16,160,225,12,16,145,229,64,19,65,226,20,16,128,229
.loc 3 303 0

	.byte 14,223,139,226,0,9,189,232,128,128,189,232

Lme_be:
.text
	.align 2
	.no_dead_strip System_Array_IndexOfImpl_T_BYTE_T_BYTE___T_BYTE_int_int
System_Array_IndexOfImpl_T_BYTE_T_BYTE___T_BYTE_int_int:
.file 5 "/Library/Frameworks/Xamarin.iOS.framework/Versions/11.6.1.2/src/mono/mcs/class/corlib/System/Array.cs"
.loc 5 624 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,0,9,45,233,10,223,77,226,13,176,160,225,8,128,139,229,12,0,139,229,16,16,203,229
	.byte 20,32,139,229,24,48,139,229,8,0,155,229
bl _p_112

	.byte 36,0,139,229,8,0,155,229
bl _p_113

	.byte 36,16,155,229,1,128,160,225,48,255,47,225,0,192,160,225,32,0,139,229,12,16,155,229,16,32,219,229,20,48,155,229
	.byte 24,0,155,229,0,0,141,229,32,0,155,229,0,192,156,229,15,224,160,225,72,240,156,229,10,223,139,226,0,9,189,232
	.byte 128,128,189,232

Lme_bf:
.text
	.align 2
	.no_dead_strip System_Collections_Generic_EqualityComparer_1_T_BYTE_get_Default
System_Collections_Generic_EqualityComparer_1_T_BYTE_get_Default:
.file 6 "/Library/Frameworks/Xamarin.iOS.framework/Versions/11.6.1.2/src/mono/mcs/class/referencesource/mscorlib/system/collections/generic/equalitycomparer.cs"
.loc 6 32 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,0,5,45,233,6,223,77,226,0,128,141,229,0,0,157,229
bl _p_114

	.byte 0,160,144,229
.loc 6 33 0

	.byte 10,0,160,225,0,15,80,227,17,0,0,26
.loc 6 34 0

	.byte 0,0,157,229
bl _p_115

	.byte 16,0,141,229,0,0,157,229
bl _p_116

	.byte 16,16,157,229,1,128,160,225,48,255,47,225,0,160,160,225
.loc 6 35 0

	.byte 12,0,141,229,0,0,157,229
bl _p_114

	.byte 8,0,141,229,12,16,157,229,0,0,160,227,186,15,7,238,8,0,157,229,0,16,128,229
.loc 6 37 0

	.byte 10,0,160,225,6,223,141,226,0,5,189,232,128,128,189,232

Lme_c0:
.text
	.align 2
	.no_dead_strip System_Collections_Generic_EqualityComparer_1_T_BYTE_CreateComparer
System_Collections_Generic_EqualityComparer_1_T_BYTE_CreateComparer:
.loc 6 49 0 prologue_end

	.byte 128,64,45,233,13,112,160,225,112,13,45,233,4,223,77,226,0,128,141,229,0,0,157,229
bl _p_117

	.byte 0,64,160,225,0,15,84,227,9,0,0,10,0,0,148,229,0,0,144,229,8,0,144,229,16,0,144,229,0,16,159,229
	.byte 0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 240
	.byte 1,16,159,231,1,0,80,225,43,1,0,27,4,160,160,225
.loc 6 51 0

	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 244
	.byte 0,0,159,231,0,0,84,225,0,0,160,19,1,0,160,3,0,15,80,227,19,0,0,10
.loc 6 52 0

	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 248
	.byte 0,0,159,231,2,31,160,227
bl _p_1

	.byte 0,160,160,225,0,0,157,229
bl _p_118

	.byte 0,80,160,225,0,15,90,227,5,0,0,10,0,0,154,229,0,0,144,229,8,0,144,229,4,0,144,229,5,0,80,225
	.byte 15,1,0,27,10,0,160,225,10,1,0,234
.loc 6 57 0

	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 252
	.byte 0,0,159,231,0,0,90,225,0,0,160,19,1,0,160,3,0,15,80,227,19,0,0,10
.loc 6 58 0

	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 256
	.byte 0,0,159,231,2,31,160,227
bl _p_1

	.byte 0,160,160,225,0,0,157,229
bl _p_118

	.byte 0,80,160,225,0,15,90,227,5,0,0,10,0,0,154,229,0,0,144,229,8,0,144,229,4,0,144,229,5,0,80,225
	.byte 242,0,0,27,10,0,160,225,237,0,0,234
.loc 6 62 0

	.byte 0,0,157,229
bl _p_119

	.byte 0,32,160,225,10,16,160,225,0,32,146,229,15,224,160,225,128,240,146,229,255,0,0,226,0,15,80,227,19,0,0,10
.loc 6 64 0

	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 260
	.byte 0,0,159,231,10,16,160,225
bl _p_120

	.byte 0,160,160,225,0,0,157,229
bl _p_118

	.byte 0,80,160,225,0,15,90,227,5,0,0,10,0,0,154,229,0,0,144,229,8,0,144,229,4,0,144,229,5,0,80,225
	.byte 212,0,0,27,10,0,160,225,207,0,0,234
.loc 6 70 0

	.byte 10,0,160,225,0,16,154,229,15,224,160,225,4,241,145,229,255,0,0,226,0,15,80,227,86,0,0,10,10,0,160,225
	.byte 0,16,154,229,15,224,160,225,168,240,145,229,0,16,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 264
	.byte 1,16,159,231,1,0,80,225,0,0,160,19,1,0,160,3,0,15,80,227,73,0,0,10
.loc 6 71 0

	.byte 10,0,160,225,0,16,154,229,15,224,160,225,176,240,145,229,12,16,144,229,0,15,81,227,187,0,0,155,16,80,144,229
	.byte 0,15,85,227,9,0,0,10,0,0,149,229,0,0,144,229,8,0,144,229,16,0,144,229,0,16,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 240
	.byte 1,16,159,231,1,0,80,225,170,0,0,27,5,96,160,225
.loc 6 72 0

	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 268
	.byte 0,0,159,231,12,0,141,229,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 272
	.byte 0,0,159,231,64,19,160,227
bl _p_14

	.byte 0,48,160,225,8,0,141,229,3,0,160,225,0,31,160,227,5,32,160,225,0,48,147,229,15,224,160,225,132,240,147,229
	.byte 8,16,157,229,12,32,157,229,2,0,160,225,0,32,146,229,15,224,160,225,184,240,146,229,0,32,160,225,5,16,160,225
	.byte 0,32,146,229,15,224,160,225,128,240,146,229,255,0,0,226,0,15,80,227,19,0,0,10
.loc 6 74 0

	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 276
	.byte 0,0,159,231,6,16,160,225
bl _p_120

	.byte 0,96,160,225,0,0,157,229
bl _p_118

	.byte 0,176,160,225,0,15,86,227,5,0,0,10,0,0,150,229,0,0,144,229,8,0,144,229,4,0,144,229,11,0,80,225
	.byte 118,0,0,27,6,0,160,225,113,0,0,234
.loc 6 82 0

	.byte 10,0,160,225,0,16,154,229,15,224,160,225,20,241,145,229,255,0,0,226,0,15,80,227,94,0,0,10
.loc 6 83 0

	.byte 10,0,160,225
bl _p_121
bl _p_122

	.byte 0,80,160,225
.loc 6 88 0

	.byte 80,82,64,226,2,15,85,227,87,0,0,42,5,17,160,225,0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 280
	.byte 0,0,159,231,1,0,128,224,0,0,144,229,0,240,160,225
.loc 6 91 0

	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 284
	.byte 0,0,159,231,10,16,160,225
bl _p_120

	.byte 0,80,160,225,0,0,157,229
bl _p_118

	.byte 0,176,160,225,0,15,85,227,5,0,0,10,0,0,149,229,0,0,144,229,8,0,144,229,4,0,144,229,11,0,80,225
	.byte 76,0,0,27,5,0,160,225,71,0,0,234
.loc 6 97 0

	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 288
	.byte 0,0,159,231,10,16,160,225
bl _p_120

	.byte 0,80,160,225,0,0,157,229
bl _p_118

	.byte 0,176,160,225,0,15,85,227,5,0,0,10,0,0,149,229,0,0,144,229,8,0,144,229,4,0,144,229,11,0,80,225
	.byte 56,0,0,27,5,0,160,225,51,0,0,234
.loc 6 106 0

	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 292
	.byte 0,0,159,231,10,16,160,225
bl _p_120

	.byte 0,80,160,225,0,0,157,229
bl _p_118

	.byte 0,176,160,225,0,15,85,227,5,0,0,10,0,0,149,229,0,0,144,229,8,0,144,229,4,0,144,229,11,0,80,225
	.byte 36,0,0,27,5,0,160,225,31,0,0,234
.loc 6 113 0

	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_PInvoke_Kernel32_got - . + 296
	.byte 0,0,159,231,10,16,160,225
bl _p_120

	.byte 0,80,160,225,0,0,157,229
bl _p_118

	.byte 0,176,160,225,0,15,85,227,5,0,0,10,0,0,149,229,0,0,144,229,8,0,144,229,4,0,144,229,11,0,80,225
	.byte 16,0,0,27,5,0,160,225,11,0,0,234
.loc 6 120 0

	.byte 0,0,157,229
bl _p_123

	.byte 2,31,160,227
bl _p_1

	.byte 12,0,141,229,0,0,157,229
bl _p_124

	.byte 0,16,160,225,12,0,157,229,8,0,141,229,49,255,47,225,8,0,157,229,4,223,141,226,112,13,189,232,128,128,189,232
	.byte 14,16,160,225,0,0,159,229
bl _p_11

	.byte 239,0,0,0,14,16,160,225,0,0,159,229
bl _p_11

	.byte 233,0,0,0

Lme_c1:
.text
	.align 2
	.no_dead_strip System_Collections_Generic_ObjectEqualityComparer_1_T_BYTE__ctor
System_Collections_Generic_ObjectEqualityComparer_1_T_BYTE__ctor:

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,3,223,141,226,0,1,189,232,128,128,189,232

Lme_c2:
.text
	.align 3
jit_code_end:

	.byte 0,0,0,0
.text
	.align 3
method_addresses:
	.no_dead_strip method_addresses
bl ThisAssembly__ctor
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl PInvoke_Kernel32_FormatMessage_PInvoke_Kernel32_FormatMessageFlags_void__int_int_intptr___int
bl PInvoke_Kernel32_GetLastError
bl PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_void__int
bl PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_System_ArraySegment_1_byte
bl PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_void__int
bl PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_System_ArraySegment_1_byte
bl PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_int
bl PInvoke_Kernel32_TryGetErrorMessage_PInvoke_Kernel32_FormatMessageFlags_void__int_int_System_Text_StringBuilder_intptr___string_
bl PInvoke_Kernel32_FindFirstFileEx_string_PInvoke_Kernel32_FINDEX_INFO_LEVELS_PInvoke_Kernel32_WIN32_FIND_DATA__PInvoke_Kernel32_FINDEX_SEARCH_OPS_intptr_PInvoke_Kernel32_FindFirstFileExFlags
bl PInvoke_Kernel32_FormatMessage_PInvoke_Kernel32_FormatMessageFlags_intptr_int_int_System_Text_StringBuilder_int_intptr__
bl PInvoke_Kernel32_CancelIoEx_PInvoke_Kernel32_SafeObjectHandle_intptr
bl PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_intptr_int_intptr_intptr
bl PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_intptr_int_System_Nullable_1_int__intptr
bl PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_void__int_System_Nullable_1_int__PInvoke_Kernel32_OVERLAPPED_
bl PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_intptr_int_intptr_intptr
bl PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_intptr_int_System_Nullable_1_int__intptr
bl PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_void__int_System_Nullable_1_int__PInvoke_Kernel32_OVERLAPPED_
bl PInvoke_Kernel32_CreateMutex_intptr_bool_string
bl PInvoke_Kernel32_CreateMutex_System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_bool_string
bl PInvoke_Kernel32_GetSystemTime_intptr
bl PInvoke_Kernel32_GetSystemTime_PInvoke_Kernel32_SYSTEMTIME_
bl PInvoke_Kernel32_FormatMessage_PInvoke_Kernel32_FormatMessageFlags_intptr_int_int_intptr___int
bl PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_intptr_int
bl PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_intptr_int
bl PInvoke_Kernel32_TryGetErrorMessage_PInvoke_Kernel32_FormatMessageFlags_intptr_int_int_System_Text_StringBuilder_intptr___string_
bl PInvoke_Kernel32__cctor
bl PInvoke_Kernel32_ACCESS_MASK__ctor_uint
bl PInvoke_Kernel32_ACCESS_MASK_get_Value
bl PInvoke_Kernel32_ACCESS_MASK_get_AsInt32
bl PInvoke_Kernel32_ACCESS_MASK_get_GenericRights
bl PInvoke_Kernel32_ACCESS_MASK_get_SpecialRights
bl PInvoke_Kernel32_ACCESS_MASK_get_StandardRights
bl PInvoke_Kernel32_ACCESS_MASK_get_SpecificRights
bl PInvoke_Kernel32_ACCESS_MASK_get_DesktopSpecificRights
bl PInvoke_Kernel32_ACCESS_MASK_get_InteractiveWindowStationGenericRights
bl PInvoke_Kernel32_ACCESS_MASK_get_NonInteractiveWindowStationGenericRights
bl PInvoke_Kernel32_ACCESS_MASK_get_WindowStationSpecificRights
bl PInvoke_Kernel32_ACCESS_MASK_op_Implicit_int
bl PInvoke_Kernel32_ACCESS_MASK_op_Explicit_PInvoke_Kernel32_ACCESS_MASK
bl PInvoke_Kernel32_ACCESS_MASK_op_Implicit_uint
bl PInvoke_Kernel32_ACCESS_MASK_op_Implicit_PInvoke_Kernel32_ACCESS_MASK
bl PInvoke_Kernel32_ACCESS_MASK_op_Implicit_PInvoke_Kernel32_ACCESS_MASK_StandardRight
bl PInvoke_Kernel32_ACCESS_MASK_op_Implicit_PInvoke_Kernel32_ACCESS_MASK_GenericRight
bl PInvoke_Kernel32_ACCESS_MASK_op_Implicit_PInvoke_Kernel32_ACCESS_MASK_SpecificRight
bl PInvoke_Kernel32_ACCESS_MASK_GetHashCode
bl PInvoke_Kernel32_ACCESS_MASK_Equals_PInvoke_Kernel32_ACCESS_MASK
bl PInvoke_Kernel32_ACCESS_MASK_Equals_object
bl PInvoke_Kernel32_ACCESS_MASK_CompareTo_object
bl PInvoke_Kernel32_ACCESS_MASK_CompareTo_PInvoke_Kernel32_ACCESS_MASK
bl PInvoke_Kernel32_ACCESS_MASK_ToString
bl PInvoke_Kernel32_ACCESS_MASK_ToString_string_System_IFormatProvider
bl PInvoke_Kernel32_SafeFindFilesHandle__ctor
bl PInvoke_Kernel32_SafeFindFilesHandle__ctor_intptr_bool
bl PInvoke_Kernel32_SafeFindFilesHandle_get_IsInvalid
bl PInvoke_Kernel32_SafeFindFilesHandle_ReleaseHandle
bl PInvoke_Kernel32_SafeFindFilesHandle__cctor
bl PInvoke_Kernel32_SafeLibraryHandle__ctor
bl PInvoke_Kernel32_SafeLibraryHandle__ctor_intptr_bool
bl PInvoke_Kernel32_SafeLibraryHandle_get_IsInvalid
bl PInvoke_Kernel32_SafeLibraryHandle_ReleaseHandle
bl PInvoke_Kernel32_SafeLibraryHandle__cctor
bl PInvoke_Kernel32_SafeObjectHandle__ctor
bl PInvoke_Kernel32_SafeObjectHandle__ctor_intptr_bool
bl PInvoke_Kernel32_SafeObjectHandle_get_IsInvalid
bl PInvoke_Kernel32_SafeObjectHandle_ReleaseHandle
bl PInvoke_Kernel32_SafeObjectHandle__cctor
bl PInvoke_Kernel32_SECURITY_ATTRIBUTES_get_InheritHandle
bl PInvoke_Kernel32_SECURITY_ATTRIBUTES_Create
bl PInvoke_Kernel32Extensions_GetMessage_PInvoke_Win32ErrorCode
bl PInvoke_Kernel32Extensions_ThrowOnError_PInvoke_Win32ErrorCode
bl PInvoke_Kernel32Extensions_ThrowOnError_PInvoke_NTSTATUS
bl PInvoke_NTStatusException__ctor_PInvoke_NTSTATUS
bl PInvoke_NTStatusException__ctor_PInvoke_NTSTATUS_string
bl PInvoke_NTStatusException__ctor_PInvoke_NTSTATUS_string_System_Exception
bl PInvoke_NTStatusException_get_NativeErrorCode
bl PInvoke_NTStatusException_GetMessage_PInvoke_NTSTATUS
bl PInvoke_NTStatusException_GetSeverityString_PInvoke_NTSTATUS
bl PInvoke_Win32Exception__ctor
bl PInvoke_Win32Exception__ctor_PInvoke_Win32ErrorCode
bl PInvoke_Win32Exception__ctor_int
bl PInvoke_Win32Exception__ctor_PInvoke_Win32ErrorCode_string
bl PInvoke_Win32Exception_get_NativeErrorCode
bl method_addresses
bl System_Nullable_1_int__ctor_int
bl System_Nullable_1_int_get_HasValue
bl System_Nullable_1_int_get_Value
bl System_Nullable_1_int_Equals_object
bl System_Nullable_1_int_Equals_System_Nullable_1_int
bl System_Nullable_1_int_GetHashCode
bl System_Nullable_1_int_GetValueOrDefault
bl System_Nullable_1_int_GetValueOrDefault_int
bl System_Nullable_1_int_ToString
bl System_Nullable_1_int_Box_System_Nullable_1_int
bl System_Nullable_1_int_Unbox_object
bl System_ArraySegment_1_T_BYTE__ctor_T_BYTE__
bl System_ArraySegment_1_T_BYTE__ctor_T_BYTE___int_int
bl System_ArraySegment_1_T_BYTE_get_Array
bl System_ArraySegment_1_T_BYTE_get_Offset
bl System_ArraySegment_1_T_BYTE_get_Count
bl System_ArraySegment_1_T_BYTE_GetHashCode
bl System_ArraySegment_1_T_BYTE_Equals_object
bl System_ArraySegment_1_T_BYTE_Equals_System_ArraySegment_1_T_BYTE
bl System_ArraySegment_1_T_BYTE_System_Collections_Generic_IList_T_get_Item_int
bl System_ArraySegment_1_T_BYTE_System_Collections_Generic_IList_T_set_Item_int_T_BYTE
bl System_ArraySegment_1_T_BYTE_System_Collections_Generic_IList_T_IndexOf_T_BYTE
bl System_ArraySegment_1_T_BYTE_System_Collections_Generic_IList_T_Insert_int_T_BYTE
bl System_ArraySegment_1_T_BYTE_System_Collections_Generic_IList_T_RemoveAt_int
bl System_ArraySegment_1_T_BYTE_System_Collections_Generic_IReadOnlyList_T_get_Item_int
bl System_ArraySegment_1_T_BYTE_System_Collections_Generic_ICollection_T_get_IsReadOnly
bl System_ArraySegment_1_T_BYTE_System_Collections_Generic_ICollection_T_Add_T_BYTE
bl System_ArraySegment_1_T_BYTE_System_Collections_Generic_ICollection_T_Clear
bl System_ArraySegment_1_T_BYTE_System_Collections_Generic_ICollection_T_Contains_T_BYTE
bl System_ArraySegment_1_T_BYTE_System_Collections_Generic_ICollection_T_CopyTo_T_BYTE___int
bl System_ArraySegment_1_T_BYTE_System_Collections_Generic_ICollection_T_Remove_T_BYTE
bl System_ArraySegment_1_T_BYTE_System_Collections_Generic_IEnumerable_T_GetEnumerator
bl System_ArraySegment_1_T_BYTE_System_Collections_IEnumerable_GetEnumerator
bl System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES__ctor_PInvoke_Kernel32_SECURITY_ATTRIBUTES
bl System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_get_HasValue
bl System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_get_Value
bl System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_Equals_object
bl System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_Equals_System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES
bl System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_GetHashCode
bl System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_GetValueOrDefault
bl System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_GetValueOrDefault_PInvoke_Kernel32_SECURITY_ATTRIBUTES
bl System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_ToString
bl System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_Box_System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES
bl System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_Unbox_object
bl method_addresses
bl method_addresses
bl wrapper_runtime_invoke__Module_runtime_invoke_bool_object_intptr_int_Nullable_1_int__intptr_object_intptr_intptr_intptr
bl wrapper_runtime_invoke__Module_runtime_invoke_bool_object_void__int_Nullable_1_int__Kernel32_OVERLAPPED__object_intptr_intptr_intptr
bl wrapper_runtime_invoke__Module_runtime_invoke_object_Nullable_1_Kernel32_SECURITY_ATTRIBUTES_byte_object_object_intptr_intptr_intptr
bl wrapper_managed_to_native_PInvoke_Kernel32_FindFirstFileEx_string_PInvoke_Kernel32_FINDEX_INFO_LEVELS_PInvoke_Kernel32_WIN32_FIND_DATA__PInvoke_Kernel32_FINDEX_SEARCH_OPS_void__PInvoke_Kernel32_FindFirstFileExFlags
bl wrapper_managed_to_native_PInvoke_Kernel32_FormatMessage_PInvoke_Kernel32_FormatMessageFlags_void__int_int_System_Text_StringBuilder_int_intptr__
bl wrapper_managed_to_native_PInvoke_Kernel32_GetCurrentThreadId
bl wrapper_managed_to_native_PInvoke_Kernel32_GetCurrentProcessId
bl wrapper_managed_to_native_PInvoke_Kernel32_GetCurrentProcess
bl wrapper_managed_to_native_PInvoke_Kernel32_CancelIoEx_PInvoke_Kernel32_SafeObjectHandle_PInvoke_Kernel32_OVERLAPPED_
bl wrapper_managed_to_native_PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_void__int_int__PInvoke_Kernel32_OVERLAPPED_
bl wrapper_managed_to_native_PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_void__int_int__PInvoke_Kernel32_OVERLAPPED_
bl wrapper_managed_to_native_PInvoke_Kernel32_SuspendThread_PInvoke_Kernel32_SafeObjectHandle
bl wrapper_managed_to_native_PInvoke_Kernel32_ResumeThread_PInvoke_Kernel32_SafeObjectHandle
bl wrapper_managed_to_native_PInvoke_Kernel32_WaitForSingleObject_System_Runtime_InteropServices_SafeHandle_int
bl wrapper_managed_to_native_PInvoke_Kernel32_CloseHandle_intptr
bl wrapper_managed_to_native_PInvoke_Kernel32_FlushFileBuffers_PInvoke_Kernel32_SafeObjectHandle
bl wrapper_managed_to_native_PInvoke_Kernel32_CreateMutex_PInvoke_Kernel32_SECURITY_ATTRIBUTES__bool_string
bl wrapper_managed_to_native_PInvoke_Kernel32_GetProcAddress_PInvoke_Kernel32_SafeLibraryHandle_string
bl wrapper_managed_to_native_PInvoke_Kernel32_GetTickCount
bl wrapper_managed_to_native_PInvoke_Kernel32_GetTickCount64
bl wrapper_managed_to_native_PInvoke_Kernel32_GetSystemTime_PInvoke_Kernel32_SYSTEMTIME_
bl wrapper_managed_to_native_PInvoke_Kernel32_SetLastError_uint
bl wrapper_managed_to_native_PInvoke_Kernel32_FindClose_intptr
bl wrapper_managed_to_native_PInvoke_Kernel32_FreeLibrary_intptr
bl wrapper_unknown_PInvoke_Kernel32_ACCESS_MASK_StructureToPtr_object_intptr_bool
bl wrapper_unknown_PInvoke_Kernel32_ACCESS_MASK_PtrToStructure_intptr_object
bl wrapper_unknown_PInvoke_Kernel32_FILETIME_StructureToPtr_object_intptr_bool
bl wrapper_unknown_PInvoke_Kernel32_FILETIME_PtrToStructure_intptr_object
bl wrapper_unknown_PInvoke_Kernel32_OVERLAPPED_StructureToPtr_object_intptr_bool
bl wrapper_unknown_PInvoke_Kernel32_OVERLAPPED_PtrToStructure_intptr_object
bl wrapper_unknown_PInvoke_Kernel32_SECURITY_ATTRIBUTES_StructureToPtr_object_intptr_bool
bl wrapper_unknown_PInvoke_Kernel32_SECURITY_ATTRIBUTES_PtrToStructure_intptr_object
bl wrapper_unknown_PInvoke_Kernel32_SECURITY_DESCRIPTOR_StructureToPtr_object_intptr_bool
bl wrapper_unknown_PInvoke_Kernel32_SECURITY_DESCRIPTOR_PtrToStructure_intptr_object
bl wrapper_unknown_PInvoke_Kernel32_SYSTEMTIME_StructureToPtr_object_intptr_bool
bl wrapper_unknown_PInvoke_Kernel32_SYSTEMTIME_PtrToStructure_intptr_object
bl wrapper_unknown_PInvoke_Kernel32_WIN32_FIND_DATA_StructureToPtr_object_intptr_bool
bl wrapper_unknown_PInvoke_Kernel32_WIN32_FIND_DATA_PtrToStructure_intptr_object
bl System_Array_IndexOf_T_BYTE_T_BYTE___T_BYTE_int_int
bl System_ArraySegment_1_ArraySegmentEnumerator_T_BYTE__ctor_System_ArraySegment_1_T_BYTE
bl System_Array_IndexOfImpl_T_BYTE_T_BYTE___T_BYTE_int_int
bl System_Collections_Generic_EqualityComparer_1_T_BYTE_get_Default
bl System_Collections_Generic_EqualityComparer_1_T_BYTE_CreateComparer
bl System_Collections_Generic_ObjectEqualityComparer_1_T_BYTE__ctor
method_addresses_end:

.section __TEXT, __const
	.align 3
unbox_trampolines:

	.long 48,49,50,51,52,53,54,55
	.long 56,57,58,59,60,61,62,63
	.long 64,65,66,67,68,69,70,71
	.long 72,88,89,105,106,107,108,109
	.long 110,111,112,113,114,115,116,117
	.long 118,119,120,121,122,123,124,125
	.long 126,127,128,129,130,131,132,133
	.long 134,135,136,137,138,139,140,141
	.long 142,143,144,145,146,147,148,175
	.long 176,177,178,179,180,181,182,183
	.long 184,185,186,187,188
unbox_trampolines_end:

	.long 0
.text
	.align 3
unbox_trampoline_addresses:
bl ut_48
bl ut_49
bl ut_50
bl ut_51
bl ut_52
bl ut_53
bl ut_54
bl ut_55
bl ut_56
bl ut_57
bl ut_58
bl ut_59
bl ut_60
bl ut_61
bl ut_62
bl ut_63
bl ut_64
bl ut_65
bl ut_66
bl ut_67
bl ut_68
bl ut_69
bl ut_70
bl ut_71
bl ut_72
bl ut_88
bl ut_89
bl ut_105
bl ut_106
bl ut_107
bl ut_108
bl ut_109
bl ut_110
bl ut_111
bl ut_112
bl ut_113
bl ut_114
bl ut_115
bl ut_116
bl ut_117
bl ut_118
bl ut_119
bl ut_120
bl ut_121
bl ut_122
bl ut_123
bl ut_124
bl ut_125
bl ut_126
bl ut_127
bl ut_128
bl ut_129
bl ut_130
bl ut_131
bl ut_132
bl ut_133
bl ut_134
bl ut_135
bl ut_136
bl ut_137
bl ut_138
bl ut_139
bl ut_140
bl ut_141
bl ut_142
bl ut_143
bl ut_144
bl ut_145
bl ut_146
bl ut_147
bl ut_148
bl ut_175
bl ut_176
bl ut_177
bl ut_178
bl ut_179
bl ut_180
bl ut_181
bl ut_182
bl ut_183
bl ut_184
bl ut_185
bl ut_186
bl ut_187
bl ut_188

	.long 0
.section __TEXT, __const
	.align 3
unwind_info:

	.byte 3,12,13,0,30,12,13,0,68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,68,10,68,14,12,68,8,8,14
	.byte 8,68,11,56,12,13,0,68,14,8,135,2,72,14,32,132,8,133,7,134,6,136,5,138,4,139,3,142,1,68,14,72
	.byte 68,13,11,2,236,10,68,13,13,14,32,68,8,4,8,5,8,6,8,8,8,10,8,11,14,8,68,11,30,12,13,0
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,16,68,10,68,14,12,68,8,8,14,8,68,11,40,12,13,0,68
	.byte 14,8,135,2,72,14,16,136,4,139,3,142,1,68,14,56,68,13,11,2,136,10,68,13,13,14,16,68,8,8,8,11
	.byte 14,8,68,11,48,12,13,0,68,14,8,135,2,72,14,24,133,6,134,5,136,4,139,3,142,1,68,14,48,68,13,11
	.byte 2,156,10,68,13,13,14,24,68,8,5,8,6,8,8,8,11,14,8,68,11,48,12,13,0,68,14,8,135,2,72,14
	.byte 24,132,6,134,5,136,4,139,3,142,1,68,14,48,68,13,11,2,144,10,68,13,13,14,24,68,8,4,8,6,8,8
	.byte 8,11,14,8,68,11,32,12,13,0,68,14,8,135,2,72,14,12,136,3,142,1,68,14,88,3,36,1,10,68,14,12
	.byte 68,8,8,14,8,68,11,49,12,13,0,68,14,8,135,2,72,14,24,133,6,136,5,138,4,139,3,142,1,68,14,72
	.byte 68,13,11,3,68,1,10,68,13,13,14,24,68,8,5,8,8,8,10,8,11,14,8,68,11,40,12,13,0,68,14,8
	.byte 135,2,72,14,16,136,4,139,3,142,1,68,14,48,68,13,11,2,68,10,68,13,13,14,16,68,8,8,8,11,14,8
	.byte 68,11,40,12,13,0,68,14,8,135,2,72,14,16,136,4,139,3,142,1,68,14,64,68,13,11,2,84,10,68,13,13
	.byte 14,16,68,8,8,8,11,14,8,68,11,30,12,13,0,68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,88,10
	.byte 68,14,12,68,8,8,14,8,68,11,40,12,13,0,68,14,8,135,2,72,14,16,136,4,139,3,142,1,68,14,48,68
	.byte 13,11,2,56,10,68,13,13,14,16,68,8,8,8,11,14,8,68,11,45,12,13,0,68,14,8,135,2,72,14,20,134
	.byte 5,136,4,139,3,142,1,68,14,96,68,13,11,3,84,1,10,68,13,13,14,20,68,8,6,8,8,8,11,14,8,68
	.byte 11,49,12,13,0,68,14,8,135,2,72,14,24,134,6,136,5,138,4,139,3,142,1,68,14,88,68,13,11,3,60,1
	.byte 10,68,13,13,14,24,68,8,6,8,8,8,10,8,11,14,8,68,11,30,12,13,0,68,14,8,135,2,72,14,12,136
	.byte 3,142,1,68,14,32,92,10,68,14,12,68,8,8,14,8,68,11,45,12,13,0,68,14,8,135,2,72,14,20,134,5
	.byte 136,4,139,3,142,1,68,14,88,68,13,11,3,12,1,10,68,13,13,14,20,68,8,6,8,8,8,11,14,8,68,11
	.byte 30,12,13,0,68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,76,10,68,14,12,68,8,8,14,8,68,11,40
	.byte 12,13,0,68,14,8,135,2,72,14,16,136,4,139,3,142,1,68,14,64,68,13,11,2,88,10,68,13,13,14,16,68
	.byte 8,8,8,11,14,8,68,11,31,12,13,0,68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,2,40,10,68,14
	.byte 12,68,8,8,14,8,68,11,30,12,13,0,68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,84,10,68,14,12
	.byte 68,8,8,14,8,68,11,30,12,13,0,68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,80,10,68,14,12,68
	.byte 8,8,14,8,68,11,31,12,13,0,68,14,8,135,2,72,14,12,136,3,142,1,68,14,32,2,40,10,68,14,12,68
	.byte 8,8,14,8,68,11,39,12,13,0,68,14,8,135,2,72,14,16,136,4,139,3,142,1,68,14,24,68,13,11,72,10
	.byte 68,13,13,14,16,68,8,8,8,11,14,8,68,11,40,12,13,0,68,14,8,135,2,72,14,16,136,4,139,3,142,1
	.byte 68,14,24,68,13,11,2,32,10,68,13,13,14,16,68,8,8,8,11,14,8,68,11,39,12,13,0,68,14,8,135,2
	.byte 72,14,20,133,5,136,4,138,3,142,1,68,14,40,2,168,10,68,14,20,68,8,5,8,8,8,10,14,8,68,11,31
	.byte 12,13,0,68,14,8,135,2,72,14,12,136,3,142,1,68,14,32,2,92,10,68,14,12,68,8,8,14,8,68,11,48
	.byte 12,13,0,68,14,8,135,2,72,14,24,134,6,136,5,138,4,139,3,142,1,68,14,32,68,13,11,2,84,10,68,13
	.byte 13,14,24,68,8,6,8,8,8,10,8,11,14,8,68,11,31,12,13,0,68,14,8,135,2,72,14,12,136,3,142,1
	.byte 68,14,24,2,32,10,68,14,12,68,8,8,14,8,68,11,31,12,13,0,68,14,8,135,2,72,14,12,136,3,142,1
	.byte 68,14,32,2,48,10,68,14,12,68,8,8,14,8,68,11,31,12,13,0,68,14,8,135,2,72,14,12,136,3,142,1
	.byte 68,14,24,2,36,10,68,14,12,68,8,8,14,8,68,11,31,12,13,0,68,14,8,135,2,72,14,12,136,3,142,1
	.byte 68,14,32,2,56,10,68,14,12,68,8,8,14,8,68,11,31,12,13,0,68,14,8,135,2,72,14,12,136,3,142,1
	.byte 68,14,24,2,44,10,68,14,12,68,8,8,14,8,68,11,31,12,13,0,68,14,8,135,2,72,14,12,136,3,142,1
	.byte 68,14,24,2,52,10,68,14,12,68,8,8,14,8,68,11,31,12,13,0,68,14,8,135,2,72,14,12,136,3,142,1
	.byte 68,14,24,2,100,10,68,14,12,68,8,8,14,8,68,11,31,12,13,0,68,14,8,135,2,72,14,12,136,3,142,1
	.byte 68,14,32,2,136,10,68,14,12,68,8,8,14,8,68,11,31,12,13,0,68,14,8,135,2,72,14,12,136,3,142,1
	.byte 68,14,48,2,124,10,68,14,12,68,8,8,14,8,68,11,40,12,13,0,68,14,8,135,2,72,14,16,136,4,139,3
	.byte 142,1,68,14,32,68,13,11,2,40,10,68,13,13,14,16,68,8,8,8,11,14,8,68,11,30,12,13,0,68,14,8
	.byte 135,2,72,14,12,136,3,142,1,68,14,32,80,10,68,14,12,68,8,8,14,8,68,11,39,12,13,0,68,14,8,135
	.byte 2,72,14,16,136,4,139,3,142,1,68,14,32,68,13,11,84,10,68,13,13,14,16,68,8,8,8,11,14,8,68,11
	.byte 40,12,13,0,68,14,8,135,2,72,14,16,136,4,139,3,142,1,68,14,32,68,13,11,2,32,10,68,13,13,14,16
	.byte 68,8,8,8,11,14,8,68,11,44,12,13,0,68,14,8,135,2,72,14,20,136,5,138,4,139,3,142,1,68,14,48
	.byte 68,13,11,2,84,10,68,13,13,14,20,68,8,8,8,10,8,11,14,8,68,11,31,12,13,0,68,14,8,135,2,72
	.byte 14,12,136,3,142,1,68,14,32,2,36,10,68,14,12,68,8,8,14,8,68,11,45,12,13,0,68,14,8,135,2,72
	.byte 14,20,132,5,136,4,139,3,142,1,68,14,80,68,13,11,3,44,2,10,68,13,13,14,20,68,8,4,8,8,8,11
	.byte 14,8,68,11,44,12,13,0,68,14,8,135,2,72,14,20,136,5,138,4,139,3,142,1,68,14,32,68,13,11,2,164
	.byte 10,68,13,13,14,20,68,8,8,8,10,8,11,14,8,68,11,43,12,13,0,68,14,8,135,2,72,14,24,132,6,134
	.byte 5,136,4,138,3,142,1,68,14,48,2,176,10,68,14,24,68,8,4,8,6,8,8,8,10,14,8,68,11,30,12,13
	.byte 0,68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,92,10,68,14,12,68,8,8,14,8,68,11,39,12,13,0
	.byte 68,14,8,135,2,72,14,20,133,5,136,4,138,3,142,1,68,14,40,2,176,10,68,14,20,68,8,5,8,8,8,10
	.byte 14,8,68,11,44,12,13,0,68,14,8,135,2,72,14,20,136,5,138,4,139,3,142,1,68,14,48,68,13,11,2,136
	.byte 10,68,13,13,14,20,68,8,8,8,10,8,11,14,8,68,11,32,12,13,0,68,14,8,135,2,72,14,16,136,4,138
	.byte 3,142,1,2,32,10,68,14,16,68,8,8,8,10,14,8,68,11,40,12,13,0,68,14,8,135,2,72,14,16,136,4
	.byte 139,3,142,1,68,14,48,68,13,11,2,100,10,68,13,13,14,16,68,8,8,8,11,14,8,68,11,35,12,13,0,68
	.byte 14,8,135,2,72,14,16,134,4,136,3,142,1,68,14,56,2,216,10,68,14,16,68,8,6,8,8,14,8,68,11,39
	.byte 12,13,0,68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,32,2,72,10,68,14,20,68,8,6,8
	.byte 8,8,10,14,8,68,11,47,12,13,0,68,14,8,135,2,72,14,28,132,7,133,6,134,5,136,4,138,3,142,1,68
	.byte 14,48,2,104,10,68,14,28,68,8,4,8,5,8,6,8,8,8,10,14,8,68,11,35,12,13,0,68,14,8,135,2
	.byte 72,14,16,136,4,138,3,142,1,68,14,24,2,64,10,68,14,16,68,8,8,8,10,14,8,68,11,39,12,13,0,68
	.byte 14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,48,2,192,10,68,14,20,68,8,6,8,8,8,10,14
	.byte 8,68,11,44,12,13,0,68,14,8,135,2,72,14,20,136,5,138,4,139,3,142,1,68,14,80,68,13,11,2,148,10
	.byte 68,13,13,14,20,68,8,8,8,10,8,11,14,8,68,11,39,12,13,0,68,14,8,135,2,72,14,20,134,5,136,4
	.byte 138,3,142,1,68,14,32,2,80,10,68,14,20,68,8,6,8,8,8,10,14,8,68,11,39,12,13,0,68,14,8,135
	.byte 2,72,14,20,134,5,136,4,138,3,142,1,68,14,32,2,88,10,68,14,20,68,8,6,8,8,8,10,14,8,68,11
	.byte 39,12,13,0,68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,48,2,128,10,68,14,20,68,8,6
	.byte 8,8,8,10,14,8,68,11,31,12,13,0,68,14,8,135,2,72,14,12,136,3,142,1,68,14,32,2,32,10,68,14
	.byte 12,68,8,8,14,8,68,11,35,12,13,0,68,14,8,135,2,72,14,16,136,4,138,3,142,1,68,14,40,2,124,10
	.byte 68,14,16,68,8,8,8,10,14,8,68,11,44,12,13,0,68,14,8,135,2,72,14,20,133,5,136,4,139,3,142,1
	.byte 68,14,48,68,13,11,2,56,10,68,13,13,14,20,68,8,5,8,8,8,11,14,8,68,11,31,12,13,0,68,14,8
	.byte 135,2,72,14,12,136,3,142,1,68,14,48,2,112,10,68,14,12,68,8,8,14,8,68,11,40,12,13,0,68,14,8
	.byte 135,2,72,14,16,136,4,139,3,142,1,68,14,32,68,13,11,2,52,10,68,13,13,14,16,68,8,8,8,11,14,8
	.byte 68,11,31,12,13,0,68,14,8,135,2,72,14,12,136,3,142,1,68,14,40,2,80,10,68,14,12,68,8,8,14,8
	.byte 68,11,48,12,13,0,68,14,8,135,2,72,14,24,133,6,136,5,138,4,139,3,142,1,68,14,56,68,13,11,2,188
	.byte 10,68,13,13,14,24,68,8,5,8,8,8,10,8,11,14,8,68,11,45,12,13,0,68,14,8,135,2,72,14,20,136
	.byte 5,138,4,139,3,142,1,68,14,88,68,13,11,3,44,1,10,68,13,13,14,20,68,8,8,8,10,8,11,14,8,68
	.byte 11,31,12,13,0,68,14,8,135,2,72,14,12,136,3,142,1,68,14,32,2,128,10,68,14,12,68,8,8,14,8,68
	.byte 11,31,12,13,0,68,14,8,135,2,72,14,12,136,3,142,1,68,14,40,2,64,10,68,14,12,68,8,8,14,8,68
	.byte 11,40,12,13,0,68,14,8,135,2,72,14,16,136,4,139,3,142,1,68,14,48,68,13,11,2,128,10,68,13,13,14
	.byte 16,68,8,8,8,11,14,8,68,11,31,12,13,0,68,14,8,135,2,72,14,12,136,3,142,1,68,14,32,2,144,10
	.byte 68,14,12,68,8,8,14,8,68,11,40,12,13,0,68,14,8,135,2,72,14,16,136,4,139,3,142,1,68,14,80,68
	.byte 13,11,2,180,10,68,13,13,14,16,68,8,8,8,11,14,8,68,11,36,12,13,0,68,14,8,135,2,72,14,16,134
	.byte 4,136,3,142,1,68,14,96,3,108,1,10,68,14,16,68,8,6,8,8,14,8,68,11,50,12,13,0,68,14,8,135
	.byte 2,72,14,24,133,6,134,5,136,4,139,3,142,1,68,14,128,1,68,13,11,3,208,2,10,68,13,13,14,24,68,8
	.byte 5,8,6,8,8,8,11,14,8,68,11,50,12,13,0,68,14,8,135,2,72,14,24,133,6,134,5,136,4,139,3,142
	.byte 1,68,14,128,1,68,13,11,3,192,2,10,68,13,13,14,24,68,8,5,8,6,8,8,8,11,14,8,68,11,49,12
	.byte 13,0,68,14,8,135,2,72,14,24,133,6,134,5,136,4,139,3,142,1,68,14,112,68,13,11,3,124,1,10,68,13
	.byte 13,14,24,68,8,5,8,6,8,8,8,11,14,8,68,11,70,12,13,0,68,14,8,135,2,76,14,48,132,12,133,11
	.byte 134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,168,2,68,13,11,3,100,2,10,84,12,13,48,68,8,4
	.byte 8,5,8,6,8,7,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11,67,12,13,0,68,14,8,135,2
	.byte 76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,152,2,68,13,11,2,216,10,84
	.byte 12,13,44,68,8,5,8,6,8,7,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11,58,12,13,0,68
	.byte 14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,224,1,2,84,10
	.byte 80,12,13,32,68,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11,58,12,13,0,68,14,8,135,2,76
	.byte 14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,232,1,2,132,10,80,12,13,32,68
	.byte 8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11,62,12,13,0,68,14,8,135,2,76,14,48,132,12,133
	.byte 11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,240,1,2,176,10,80,12,13,40,68,8,6,8,7,8
	.byte 8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11,61,12,13,0,68,14,8,135,2,76,14,48,132,12,133,11
	.byte 134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,136,2,68,13,11,2,208,10,84,12,13,32,68,8,8,8
	.byte 9,8,10,8,11,8,12,14,12,68,14,8,68,11,64,12,13,0,68,14,8,135,2,76,14,48,132,12,133,11,134,10
	.byte 136,8,137,7,138,6,139,5,140,4,142,3,68,14,232,1,2,168,10,80,12,13,44,68,8,5,8,6,8,7,8,8
	.byte 8,9,8,10,8,11,8,12,14,12,68,14,8,68,11,58,12,13,0,68,14,8,135,2,76,14,48,132,12,133,11,134
	.byte 10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,232,1,2,104,10,80,12,13,32,68,8,8,8,9,8,10,8
	.byte 11,8,12,14,12,68,14,8,68,11,62,12,13,0,68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7
	.byte 138,6,139,5,140,4,142,3,68,14,232,1,2,168,10,80,12,13,40,68,8,6,8,7,8,8,8,9,8,10,8,11
	.byte 8,12,14,12,68,14,8,68,11,66,12,13,0,68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138
	.byte 6,139,5,140,4,142,3,68,14,240,1,2,200,10,80,12,13,48,68,8,4,8,5,8,6,8,7,8,8,8,9,8
	.byte 10,8,11,8,12,14,12,68,14,8,68,11,66,12,13,0,68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8
	.byte 137,7,138,6,139,5,140,4,142,3,68,14,240,1,2,196,10,80,12,13,48,68,8,4,8,5,8,6,8,7,8,8
	.byte 8,9,8,10,8,11,8,12,14,12,68,14,8,68,11,58,12,13,0,68,14,8,135,2,76,14,48,132,12,133,11,134
	.byte 10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,240,1,2,104,10,80,12,13,32,68,8,8,8,9,8,10,8
	.byte 11,8,12,14,12,68,14,8,68,11,58,12,13,0,68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7
	.byte 138,6,139,5,140,4,142,3,68,14,216,1,2,84,10,80,12,13,32,68,8,8,8,9,8,10,8,11,8,12,14,12
	.byte 68,14,8,68,11,58,12,13,0,68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140
	.byte 4,142,3,68,14,216,1,2,88,10,80,12,13,32,68,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11
	.byte 35,12,13,0,68,14,8,135,2,72,14,16,136,4,138,3,142,1,68,14,24,2,60,10,68,14,16,68,8,8,8,10
	.byte 14,8,68,11,35,12,13,0,68,14,8,135,2,72,14,16,134,4,136,3,142,1,68,14,24,2,56,10,68,14,16,68
	.byte 8,6,8,8,14,8,68,11,35,12,13,0,68,14,8,135,2,72,14,16,136,4,138,3,142,1,68,14,24,2,44,10
	.byte 68,14,16,68,8,8,8,10,14,8,68,11,35,12,13,0,68,14,8,135,2,72,14,16,134,4,136,3,142,1,68,14
	.byte 24,2,40,10,68,14,16,68,8,6,8,8,14,8,68,11,35,12,13,0,68,14,8,135,2,72,14,16,136,4,138,3
	.byte 142,1,68,14,24,2,52,10,68,14,16,68,8,8,8,10,14,8,68,11,35,12,13,0,68,14,8,135,2,72,14,16
	.byte 134,4,136,3,142,1,68,14,24,2,48,10,68,14,16,68,8,6,8,8,14,8,68,11,31,12,13,0,68,14,8,135
	.byte 2,72,14,12,136,3,142,1,68,14,40,2,236,10,68,14,12,68,8,8,14,8,68,11,32,12,13,0,68,14,8,135
	.byte 2,72,14,12,136,3,142,1,68,14,40,3,88,1,10,68,14,12,68,8,8,14,8,68,11,43,12,13,0,68,14,8
	.byte 135,2,72,14,24,133,6,134,5,136,4,138,3,142,1,68,14,40,2,124,10,68,14,24,68,8,5,8,6,8,8,8
	.byte 10,14,8,68,11,40,12,13,0,68,14,8,135,2,72,14,16,136,4,139,3,142,1,68,14,72,68,13,11,2,188,10
	.byte 68,13,13,14,16,68,8,8,8,11,14,8,68,11,40,12,13,0,68,14,8,135,2,72,14,16,136,4,139,3,142,1
	.byte 68,14,56,68,13,11,2,96,10,68,13,13,14,16,68,8,8,8,11,14,8,68,11,35,12,13,0,68,14,8,135,2
	.byte 72,14,16,136,4,138,3,142,1,68,14,40,2,104,10,68,14,16,68,8,8,8,10,14,8,68,11,52,12,13,0,68
	.byte 14,8,135,2,72,14,32,132,8,133,7,134,6,136,5,138,4,139,3,142,1,68,14,48,3,228,4,10,68,14,32,68
	.byte 8,4,8,5,8,6,8,8,8,10,8,11,14,8,68,11

.text
	.align 4
plt:
mono_aot_PInvoke_Kernel32_plt:
	.no_dead_strip plt_wrapper_alloc_object_AllocSmall_intptr_intptr
plt_wrapper_alloc_object_AllocSmall_intptr_intptr:
_p_1:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 312,2627
	.no_dead_strip plt_System_Text_StringBuilder__ctor_int
plt_System_Text_StringBuilder__ctor_int:
_p_2:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 316,2635
	.no_dead_strip plt_PInvoke_Kernel32_TryGetErrorMessage_PInvoke_Kernel32_FormatMessageFlags_void__int_int_System_Text_StringBuilder_intptr___string_
plt_PInvoke_Kernel32_TryGetErrorMessage_PInvoke_Kernel32_FormatMessageFlags_void__int_int_System_Text_StringBuilder_intptr___string_:
_p_3:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 320,2640
	.no_dead_strip plt_System_Text_StringBuilder_set_Capacity_int
plt_System_Text_StringBuilder_set_Capacity_int:
_p_4:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 324,2642
	.no_dead_strip plt_System_Runtime_InteropServices_Marshal_GetLastWin32Error
plt_System_Runtime_InteropServices_Marshal_GetLastWin32Error:
_p_5:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 328,2647
	.no_dead_strip plt_PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_void__int_System_Nullable_1_int__PInvoke_Kernel32_OVERLAPPED_
plt_PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_void__int_System_Nullable_1_int__PInvoke_Kernel32_OVERLAPPED_:
_p_6:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 332,2652
	.no_dead_strip plt_System_Nullable_1_int_get_Value
plt_System_Nullable_1_int_get_Value:
_p_7:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 336,2654
	.no_dead_strip plt__jit_icall_mono_arch_throw_exception
plt__jit_icall_mono_arch_throw_exception:
_p_8:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 340,2665
	.no_dead_strip plt__jit_icall_mono_helper_ldstr
plt__jit_icall_mono_helper_ldstr:
_p_9:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 344,2693
	.no_dead_strip plt_PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_void__int
plt_PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_void__int:
_p_10:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 348,2713
	.no_dead_strip plt__jit_icall_mono_arch_throw_corlib_exception
plt__jit_icall_mono_arch_throw_corlib_exception:
_p_11:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 352,2715
	.no_dead_strip plt_PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_void__int_System_Nullable_1_int__PInvoke_Kernel32_OVERLAPPED_
plt_PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_void__int_System_Nullable_1_int__PInvoke_Kernel32_OVERLAPPED_:
_p_12:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 356,2750
	.no_dead_strip plt_PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_void__int
plt_PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_void__int:
_p_13:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 360,2752
	.no_dead_strip plt_wrapper_alloc_object_AllocVector_intptr_intptr
plt_wrapper_alloc_object_AllocVector_intptr_intptr:
_p_14:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 364,2754
	.no_dead_strip plt_System_ArraySegment_1_byte__ctor_byte__
plt_System_ArraySegment_1_byte__ctor_byte__:
_p_15:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 368,2762
	.no_dead_strip plt_PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_System_ArraySegment_1_byte
plt_PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_System_ArraySegment_1_byte:
_p_16:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 372,2773
	.no_dead_strip plt_System_ArraySegment_1_byte__ctor_byte___int_int
plt_System_ArraySegment_1_byte__ctor_byte___int_int:
_p_17:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 376,2775
	.no_dead_strip plt_PInvoke_Kernel32_FormatMessage_PInvoke_Kernel32_FormatMessageFlags_void__int_int_System_Text_StringBuilder_int_intptr__
plt_PInvoke_Kernel32_FormatMessage_PInvoke_Kernel32_FormatMessageFlags_void__int_int_System_Text_StringBuilder_int_intptr__:
_p_18:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 380,2786
	.no_dead_strip plt_System_Text_StringBuilder_get_Chars_int
plt_System_Text_StringBuilder_get_Chars_int:
_p_19:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 384,2788
	.no_dead_strip plt_System_Text_StringBuilder_ToString_int_int
plt_System_Text_StringBuilder_ToString_int_int:
_p_20:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 388,2793
	.no_dead_strip plt_PInvoke_Kernel32_FindFirstFileEx_string_PInvoke_Kernel32_FINDEX_INFO_LEVELS_PInvoke_Kernel32_WIN32_FIND_DATA__PInvoke_Kernel32_FINDEX_SEARCH_OPS_void__PInvoke_Kernel32_FindFirstFileExFlags
plt_PInvoke_Kernel32_FindFirstFileEx_string_PInvoke_Kernel32_FINDEX_INFO_LEVELS_PInvoke_Kernel32_WIN32_FIND_DATA__PInvoke_Kernel32_FINDEX_SEARCH_OPS_void__PInvoke_Kernel32_FindFirstFileExFlags:
_p_21:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 392,2798
	.no_dead_strip plt_PInvoke_Kernel32_CancelIoEx_PInvoke_Kernel32_SafeObjectHandle_PInvoke_Kernel32_OVERLAPPED_
plt_PInvoke_Kernel32_CancelIoEx_PInvoke_Kernel32_SafeObjectHandle_PInvoke_Kernel32_OVERLAPPED_:
_p_22:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 396,2800
	.no_dead_strip plt_PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_void__int_int__PInvoke_Kernel32_OVERLAPPED_
plt_PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_void__int_int__PInvoke_Kernel32_OVERLAPPED_:
_p_23:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 400,2802
	.no_dead_strip plt_System_Nullable_1_int__ctor_int
plt_System_Nullable_1_int__ctor_int:
_p_24:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 404,2804
	.no_dead_strip plt_PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_void__int_int__PInvoke_Kernel32_OVERLAPPED_
plt_PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_void__int_int__PInvoke_Kernel32_OVERLAPPED_:
_p_25:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 408,2815
	.no_dead_strip plt_PInvoke_Kernel32_CreateMutex_PInvoke_Kernel32_SECURITY_ATTRIBUTES__bool_string
plt_PInvoke_Kernel32_CreateMutex_PInvoke_Kernel32_SECURITY_ATTRIBUTES__bool_string:
_p_26:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 412,2817
	.no_dead_strip plt_System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_get_Value
plt_System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_get_Value:
_p_27:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 416,2819
	.no_dead_strip plt_PInvoke_Kernel32_GetSystemTime_PInvoke_Kernel32_SYSTEMTIME_
plt_PInvoke_Kernel32_GetSystemTime_PInvoke_Kernel32_SYSTEMTIME_:
_p_28:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 420,2830
	.no_dead_strip plt_PInvoke_Kernel32_FormatMessage_PInvoke_Kernel32_FormatMessageFlags_void__int_int_intptr___int
plt_PInvoke_Kernel32_FormatMessage_PInvoke_Kernel32_FormatMessageFlags_void__int_int_intptr___int:
_p_29:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 424,2832
	.no_dead_strip plt_uint_ToString
plt_uint_ToString:
_p_30:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 428,2834
	.no_dead_strip plt_uint_ToString_string_System_IFormatProvider
plt_uint_ToString_string_System_IFormatProvider:
_p_31:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 432,2839
	.no_dead_strip plt_System_Runtime_InteropServices_SafeHandle__ctor_intptr_bool
plt_System_Runtime_InteropServices_SafeHandle__ctor_intptr_bool:
_p_32:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 436,2844
	.no_dead_strip plt_PInvoke_Kernel32_FindClose_intptr
plt_PInvoke_Kernel32_FindClose_intptr:
_p_33:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 440,2849
	.no_dead_strip plt__jit_icall_ves_icall_object_new_specific
plt__jit_icall_ves_icall_object_new_specific:
_p_34:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 444,2851
	.no_dead_strip plt_PInvoke_Kernel32_SafeFindFilesHandle__ctor
plt_PInvoke_Kernel32_SafeFindFilesHandle__ctor:
_p_35:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 448,2883
	.no_dead_strip plt_PInvoke_Kernel32_FreeLibrary_intptr
plt_PInvoke_Kernel32_FreeLibrary_intptr:
_p_36:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 452,2885
	.no_dead_strip plt_PInvoke_Kernel32_SafeLibraryHandle__ctor_intptr_bool
plt_PInvoke_Kernel32_SafeLibraryHandle__ctor_intptr_bool:
_p_37:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 456,2887
	.no_dead_strip plt_PInvoke_Kernel32_SafeLibraryHandle__ctor
plt_PInvoke_Kernel32_SafeLibraryHandle__ctor:
_p_38:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 460,2889
	.no_dead_strip plt_PInvoke_Kernel32_CloseHandle_intptr
plt_PInvoke_Kernel32_CloseHandle_intptr:
_p_39:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 464,2891
	.no_dead_strip plt_PInvoke_Kernel32_SafeObjectHandle__ctor
plt_PInvoke_Kernel32_SafeObjectHandle__ctor:
_p_40:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 468,2893
	.no_dead_strip plt_PInvoke_Kernel32_SafeObjectHandle__ctor_intptr_bool
plt_PInvoke_Kernel32_SafeObjectHandle__ctor_intptr_bool:
_p_41:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 472,2895
	.no_dead_strip plt_System_Runtime_InteropServices_Marshal_SizeOf_System_Type
plt_System_Runtime_InteropServices_Marshal_SizeOf_System_Type:
_p_42:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 476,2897
	.no_dead_strip plt_PInvoke_Win32Exception__ctor_PInvoke_Win32ErrorCode
plt_PInvoke_Win32Exception__ctor_PInvoke_Win32ErrorCode:
_p_43:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 480,2902
	.no_dead_strip plt_PInvoke_NTStatusException_GetMessage_PInvoke_NTSTATUS
plt_PInvoke_NTStatusException_GetMessage_PInvoke_NTSTATUS:
_p_44:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 484,2904
	.no_dead_strip plt_System_Exception__ctor_string_System_Exception
plt_System_Exception__ctor_string_System_Exception:
_p_45:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 488,2906
	.no_dead_strip plt_string_Format_string_object__
plt_string_Format_string_object__:
_p_46:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 492,2911
	.no_dead_strip plt_System_Enum_GetName_System_Type_object
plt_System_Enum_GetName_System_Type_object:
_p_47:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 496,2916
	.no_dead_strip plt_string_op_Inequality_string_string
plt_string_op_Inequality_string_string:
_p_48:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 500,2921
	.no_dead_strip plt_PInvoke_NTStatusException_GetSeverityString_PInvoke_NTSTATUS
plt_PInvoke_NTStatusException_GetSeverityString_PInvoke_NTSTATUS:
_p_49:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 504,2926
	.no_dead_strip plt_System_Exception__ctor_string
plt_System_Exception__ctor_string:
_p_50:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 508,2928
	.no_dead_strip plt__jit_icall_mono_helper_ldstr_mscorlib
plt__jit_icall_mono_helper_ldstr_mscorlib:
_p_51:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 512,2933
	.no_dead_strip plt_System_Nullable_1_int_Unbox_object
plt_System_Nullable_1_int_Unbox_object:
_p_52:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 516,2962
	.no_dead_strip plt_System_Nullable_1_int_Equals_System_Nullable_1_int
plt_System_Nullable_1_int_Equals_System_Nullable_1_int:
_p_53:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 520,2984
	.no_dead_strip plt_int_Equals_object
plt_int_Equals_object:
_p_54:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 524,3006
	.no_dead_strip plt_int_ToString
plt_int_ToString:
_p_55:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 528,3011
	.no_dead_strip plt__rgctx_fetch_0
plt__rgctx_fetch_0:
_p_56:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 532,3034
	.no_dead_strip plt_wrapper_castclass_object___isinst_with_cache_object_intptr_intptr
plt_wrapper_castclass_object___isinst_with_cache_object_intptr_intptr:
_p_57:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 536,3042
	.no_dead_strip plt__rgctx_fetch_1
plt__rgctx_fetch_1:
_p_58:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 540,3050
	.no_dead_strip plt__rgctx_fetch_2
plt__rgctx_fetch_2:
_p_59:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 544,3058
	.no_dead_strip plt__rgctx_fetch_3
plt__rgctx_fetch_3:
_p_60:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 548,3066
	.no_dead_strip plt__rgctx_fetch_4
plt__rgctx_fetch_4:
_p_61:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 552,3107
	.no_dead_strip plt__rgctx_fetch_5
plt__rgctx_fetch_5:
_p_62:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 556,3130
	.no_dead_strip plt__rgctx_fetch_6
plt__rgctx_fetch_6:
_p_63:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 560,3171
	.no_dead_strip plt__rgctx_fetch_7
plt__rgctx_fetch_7:
_p_64:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 564,3194
	.no_dead_strip plt_System_Array_Copy_System_Array_int_System_Array_int_int
plt_System_Array_Copy_System_Array_int_System_Array_int_int:
_p_65:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 568,3217
	.no_dead_strip plt__rgctx_fetch_8
plt__rgctx_fetch_8:
_p_66:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 572,3249
	.no_dead_strip plt__rgctx_fetch_9
plt__rgctx_fetch_9:
_p_67:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 576,3257
	.no_dead_strip plt__rgctx_fetch_10
plt__rgctx_fetch_10:
_p_68:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 580,3298
	.no_dead_strip plt__rgctx_fetch_11
plt__rgctx_fetch_11:
_p_69:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 584,3306
	.no_dead_strip plt_System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_Unbox_object
plt_System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_Unbox_object:
_p_70:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 588,3329
	.no_dead_strip plt_System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_Equals_System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES
plt_System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_Equals_System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES:
_p_71:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 592,3349
	.no_dead_strip plt_System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES__ctor_PInvoke_Kernel32_SECURITY_ATTRIBUTES
plt_System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES__ctor_PInvoke_Kernel32_SECURITY_ATTRIBUTES:
_p_72:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 596,3369
	.no_dead_strip plt__jit_icall_mono_thread_force_interruption_checkpoint_noraise
plt__jit_icall_mono_thread_force_interruption_checkpoint_noraise:
_p_73:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 600,3389
	.no_dead_strip plt_System_Nullable_1_int_Box_System_Nullable_1_int
plt_System_Nullable_1_int_Box_System_Nullable_1_int:
_p_74:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 604,3441
	.no_dead_strip plt__jit_icall_mono_marshal_string_to_utf16
plt__jit_icall_mono_marshal_string_to_utf16:
_p_75:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 608,3463
	.no_dead_strip plt__icall_native_PInvoke_Kernel32_FindFirstFileEx_string_PInvoke_Kernel32_FINDEX_INFO_LEVELS_PInvoke_Kernel32_WIN32_FIND_DATA__PInvoke_Kernel32_FINDEX_SEARCH_OPS_void__PInvoke_Kernel32_FindFirstFileExFlags
plt__icall_native_PInvoke_Kernel32_FindFirstFileEx_string_PInvoke_Kernel32_FINDEX_INFO_LEVELS_PInvoke_Kernel32_WIN32_FIND_DATA__PInvoke_Kernel32_FINDEX_SEARCH_OPS_void__PInvoke_Kernel32_FindFirstFileExFlags:
_p_76:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 612,3494
	.no_dead_strip plt__jit_icall_mono_string_from_byvalwstr
plt__jit_icall_mono_string_from_byvalwstr:
_p_77:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 616,3496
	.no_dead_strip plt__jit_icall_mono_struct_delete_old
plt__jit_icall_mono_struct_delete_old:
_p_78:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 620,3525
	.no_dead_strip plt__jit_icall_mono_thread_interruption_checkpoint
plt__jit_icall_mono_thread_interruption_checkpoint:
_p_79:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 624,3550
	.no_dead_strip plt__jit_icall_mono_string_builder_to_utf16
plt__jit_icall_mono_string_builder_to_utf16:
_p_80:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 628,3588
	.no_dead_strip plt__jit_icall_mono_array_to_lparray
plt__jit_icall_mono_array_to_lparray:
_p_81:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 632,3619
	.no_dead_strip plt__icall_native_PInvoke_Kernel32_FormatMessage_PInvoke_Kernel32_FormatMessageFlags_void__int_int_System_Text_StringBuilder_int_intptr__
plt__icall_native_PInvoke_Kernel32_FormatMessage_PInvoke_Kernel32_FormatMessageFlags_void__int_int_System_Text_StringBuilder_int_intptr__:
_p_82:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 636,3643
	.no_dead_strip plt__jit_icall_mono_marshal_set_last_error
plt__jit_icall_mono_marshal_set_last_error:
_p_83:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 640,3645
	.no_dead_strip plt__jit_icall_mono_string_utf16_to_builder
plt__jit_icall_mono_string_utf16_to_builder:
_p_84:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 644,3675
	.no_dead_strip plt__jit_icall_mono_free_lparray
plt__jit_icall_mono_free_lparray:
_p_85:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 648,3706
	.no_dead_strip plt__icall_native_PInvoke_Kernel32_GetCurrentThreadId
plt__icall_native_PInvoke_Kernel32_GetCurrentThreadId:
_p_86:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 652,3726
	.no_dead_strip plt__icall_native_PInvoke_Kernel32_GetCurrentProcessId
plt__icall_native_PInvoke_Kernel32_GetCurrentProcessId:
_p_87:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 656,3728
	.no_dead_strip plt__icall_native_PInvoke_Kernel32_GetCurrentProcess
plt__icall_native_PInvoke_Kernel32_GetCurrentProcess:
_p_88:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 660,3730
	.no_dead_strip plt_System_Runtime_InteropServices_SafeHandle_DangerousAddRef_bool_
plt_System_Runtime_InteropServices_SafeHandle_DangerousAddRef_bool_:
_p_89:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 664,3732
	.no_dead_strip plt__icall_native_PInvoke_Kernel32_CancelIoEx_PInvoke_Kernel32_SafeObjectHandle_PInvoke_Kernel32_OVERLAPPED_
plt__icall_native_PInvoke_Kernel32_CancelIoEx_PInvoke_Kernel32_SafeObjectHandle_PInvoke_Kernel32_OVERLAPPED_:
_p_90:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 668,3737
	.no_dead_strip plt_System_Runtime_InteropServices_SafeHandle_DangerousRelease
plt_System_Runtime_InteropServices_SafeHandle_DangerousRelease:
_p_91:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 672,3739
	.no_dead_strip plt__icall_native_PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_void__int_int__PInvoke_Kernel32_OVERLAPPED_
plt__icall_native_PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_void__int_int__PInvoke_Kernel32_OVERLAPPED_:
_p_92:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 676,3744
	.no_dead_strip plt__icall_native_PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_void__int_int__PInvoke_Kernel32_OVERLAPPED_
plt__icall_native_PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_void__int_int__PInvoke_Kernel32_OVERLAPPED_:
_p_93:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 680,3746
	.no_dead_strip plt__icall_native_PInvoke_Kernel32_SuspendThread_PInvoke_Kernel32_SafeObjectHandle
plt__icall_native_PInvoke_Kernel32_SuspendThread_PInvoke_Kernel32_SafeObjectHandle:
_p_94:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 684,3748
	.no_dead_strip plt__icall_native_PInvoke_Kernel32_ResumeThread_PInvoke_Kernel32_SafeObjectHandle
plt__icall_native_PInvoke_Kernel32_ResumeThread_PInvoke_Kernel32_SafeObjectHandle:
_p_95:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 688,3750
	.no_dead_strip plt__icall_native_PInvoke_Kernel32_WaitForSingleObject_System_Runtime_InteropServices_SafeHandle_int
plt__icall_native_PInvoke_Kernel32_WaitForSingleObject_System_Runtime_InteropServices_SafeHandle_int:
_p_96:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 692,3752
	.no_dead_strip plt__icall_native_PInvoke_Kernel32_CloseHandle_intptr
plt__icall_native_PInvoke_Kernel32_CloseHandle_intptr:
_p_97:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 696,3754
	.no_dead_strip plt__icall_native_PInvoke_Kernel32_FlushFileBuffers_PInvoke_Kernel32_SafeObjectHandle
plt__icall_native_PInvoke_Kernel32_FlushFileBuffers_PInvoke_Kernel32_SafeObjectHandle:
_p_98:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 700,3756
	.no_dead_strip plt__icall_native_PInvoke_Kernel32_CreateMutex_PInvoke_Kernel32_SECURITY_ATTRIBUTES__bool_string
plt__icall_native_PInvoke_Kernel32_CreateMutex_PInvoke_Kernel32_SECURITY_ATTRIBUTES__bool_string:
_p_99:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 704,3758
	.no_dead_strip plt__jit_icall_mono_string_to_utf8str
plt__jit_icall_mono_string_to_utf8str:
_p_100:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 708,3760
	.no_dead_strip plt__icall_native_PInvoke_Kernel32_GetProcAddress_PInvoke_Kernel32_SafeLibraryHandle_string
plt__icall_native_PInvoke_Kernel32_GetProcAddress_PInvoke_Kernel32_SafeLibraryHandle_string:
_p_101:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 712,3785
	.no_dead_strip plt__jit_icall_mono_marshal_free
plt__jit_icall_mono_marshal_free:
_p_102:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 716,3787
	.no_dead_strip plt__icall_native_PInvoke_Kernel32_GetTickCount
plt__icall_native_PInvoke_Kernel32_GetTickCount:
_p_103:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 720,3807
	.no_dead_strip plt__icall_native_PInvoke_Kernel32_GetTickCount64
plt__icall_native_PInvoke_Kernel32_GetTickCount64:
_p_104:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 724,3809
	.no_dead_strip plt__icall_native_PInvoke_Kernel32_GetSystemTime_PInvoke_Kernel32_SYSTEMTIME_
plt__icall_native_PInvoke_Kernel32_GetSystemTime_PInvoke_Kernel32_SYSTEMTIME_:
_p_105:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 728,3811
	.no_dead_strip plt__icall_native_PInvoke_Kernel32_SetLastError_uint
plt__icall_native_PInvoke_Kernel32_SetLastError_uint:
_p_106:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 732,3813
	.no_dead_strip plt__icall_native_PInvoke_Kernel32_FindClose_intptr
plt__icall_native_PInvoke_Kernel32_FindClose_intptr:
_p_107:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 736,3815
	.no_dead_strip plt__icall_native_PInvoke_Kernel32_FreeLibrary_intptr
plt__icall_native_PInvoke_Kernel32_FreeLibrary_intptr:
_p_108:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 740,3817
	.no_dead_strip plt__jit_icall_mono_string_to_byvalwstr
plt__jit_icall_mono_string_to_byvalwstr:
_p_109:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 744,3819
	.no_dead_strip plt__rgctx_fetch_12
plt__rgctx_fetch_12:
_p_110:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 748,3864
	.no_dead_strip plt__rgctx_fetch_13
plt__rgctx_fetch_13:
_p_111:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 752,3887
	.no_dead_strip plt__rgctx_fetch_14
plt__rgctx_fetch_14:
_p_112:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 756,3937
	.no_dead_strip plt__rgctx_fetch_15
plt__rgctx_fetch_15:
_p_113:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 760,3945
	.no_dead_strip plt__rgctx_fetch_16
plt__rgctx_fetch_16:
_p_114:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 764,3986
	.no_dead_strip plt__rgctx_fetch_17
plt__rgctx_fetch_17:
_p_115:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 768,3994
	.no_dead_strip plt__rgctx_fetch_18
plt__rgctx_fetch_18:
_p_116:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 772,4002
	.no_dead_strip plt__rgctx_fetch_19
plt__rgctx_fetch_19:
_p_117:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 776,4043
	.no_dead_strip plt__rgctx_fetch_20
plt__rgctx_fetch_20:
_p_118:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 780,4051
	.no_dead_strip plt__rgctx_fetch_21
plt__rgctx_fetch_21:
_p_119:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 784,4068
	.no_dead_strip plt_System_RuntimeType_CreateInstanceForAnotherGenericParameter_System_Type_System_RuntimeType
plt_System_RuntimeType_CreateInstanceForAnotherGenericParameter_System_Type_System_RuntimeType:
_p_120:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 788,4076
	.no_dead_strip plt_System_Enum_GetUnderlyingType_System_Type
plt_System_Enum_GetUnderlyingType_System_Type:
_p_121:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 792,4081
	.no_dead_strip plt_System_Type_GetTypeCode_System_Type
plt_System_Type_GetTypeCode_System_Type:
_p_122:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 796,4086
	.no_dead_strip plt__rgctx_fetch_22
plt__rgctx_fetch_22:
_p_123:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 800,4100
	.no_dead_strip plt__rgctx_fetch_23
plt__rgctx_fetch_23:
_p_124:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_PInvoke_Kernel32_got - . + 804,4108
plt_end:
.section __DATA, __bss
	.align 3
.lcomm mono_aot_PInvoke_Kernel32_got, 812
got_end:
.section __TEXT, __const
	.align 3
Lglobals_hash:

	.short 11, 0, 0, 0, 0, 0, 0, 0
	.short 0, 0, 0, 0, 0, 1, 0, 0
	.short 0, 0, 0, 0, 0, 0, 0
.section __TEXT, __const
	.align 2
name_0:
	.asciz "_unbox_trampoline_p"
.data
	.align 3
globals:
	.align 2
	.long Lglobals_hash
	.align 2
	.long name_0
	.align 2
	.long _unbox_trampoline_p

	.long 0,0
.section __TEXT, __const
	.align 2
runtime_version:
	.asciz ""
.section __TEXT, __const
	.align 2
assembly_guid:
	.asciz "E95DF42E-4381-437C-87FE-E9A7C46F622B"
.section __TEXT, __const
	.align 2
assembly_name:
	.asciz "PInvoke.Kernel32"
.data
	.align 3
_mono_aot_file_info:

	.long 140,0
	.align 2
	.long mono_aot_PInvoke_Kernel32_got
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long jit_code_start
	.align 2
	.long jit_code_end
	.align 2
	.long method_addresses
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long mem_end
	.align 2
	.long assembly_guid
	.align 2
	.long runtime_version
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long globals
	.align 2
	.long assembly_name
	.align 2
	.long plt
	.align 2
	.long plt_end
	.align 2
	.long unwind_info
	.align 2
	.long unbox_trampolines
	.align 2
	.long unbox_trampolines_end
	.align 2
	.long unbox_trampoline_addresses

	.long 78,812,125,195,66,391195135,0,7862
	.long 128,4,4,10,0,24,12200,4328
	.long 4136,3336,0,3776,4064,3656,0,2608
	.long 280,0,0,0,0,0,0,0
	.long 0,0,0,0,0,0,0,0
	.long 0
	.byte 76,218,242,74,27,194,242,40,168,61,149,133,73,5,250,2
	.globl _mono_aot_module_PInvoke_Kernel32_info
	.align 2
_mono_aot_module_PInvoke_Kernel32_info:
	.align 2
	.long _mono_aot_file_info
.section __DWARF, __debug_info,regular,debug
LTDIE_1:

	.byte 17
	.asciz "System_Object"

	.byte 8,7
	.asciz "System_Object"

LDIFF_SYM4=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM4
LTDIE_1_POINTER:

	.byte 13
LDIFF_SYM5=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM5
LTDIE_1_REFERENCE:

	.byte 14
LDIFF_SYM6=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM6
LTDIE_0:

	.byte 5
	.asciz "_ThisAssembly"

	.byte 8,16
LDIFF_SYM7=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM7
	.byte 2,35,0,0,7
	.asciz "_ThisAssembly"

LDIFF_SYM8=LTDIE_0 - Ldebug_info_start
	.long LDIFF_SYM8
LTDIE_0_POINTER:

	.byte 13
LDIFF_SYM9=LTDIE_0 - Ldebug_info_start
	.long LDIFF_SYM9
LTDIE_0_REFERENCE:

	.byte 14
LDIFF_SYM10=LTDIE_0 - Ldebug_info_start
	.long LDIFF_SYM10
	.byte 2
	.asciz "ThisAssembly:.ctor"
	.asciz "ThisAssembly__ctor"

	.byte 0,0
	.long ThisAssembly__ctor
	.long Lme_0

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM11=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM11
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM12=Lfde0_end - Lfde0_start
	.long LDIFF_SYM12
Lfde0_start:

	.long 0
	.align 2
	.long ThisAssembly__ctor

LDIFF_SYM13=Lme_0 - ThisAssembly__ctor
	.long LDIFF_SYM13
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,68,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde0_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_2:

	.byte 8
	.asciz "_FormatMessageFlags"

	.byte 4
LDIFF_SYM14=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM14
	.byte 9
	.asciz "FORMAT_MESSAGE_ALLOCATE_BUFFER"

	.byte 128,2,9
	.asciz "FORMAT_MESSAGE_ARGUMENT_ARRAY"

	.byte 128,192,0,9
	.asciz "FORMAT_MESSAGE_FROM_HMODULE"

	.byte 128,16,9
	.asciz "FORMAT_MESSAGE_FROM_STRING"

	.byte 128,8,9
	.asciz "FORMAT_MESSAGE_FROM_SYSTEM"

	.byte 128,32,9
	.asciz "FORMAT_MESSAGE_IGNORE_INSERTS"

	.byte 128,4,9
	.asciz "FORMAT_MESSAGE_MAX_WIDTH_MASK"

	.byte 255,1,0,7
	.asciz "_FormatMessageFlags"

LDIFF_SYM15=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM15
LTDIE_2_POINTER:

	.byte 13
LDIFF_SYM16=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM16
LTDIE_2_REFERENCE:

	.byte 14
LDIFF_SYM17=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM17
LTDIE_4:

	.byte 5
	.asciz "System_ValueType"

	.byte 8,16
LDIFF_SYM18=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM18
	.byte 2,35,0,0,7
	.asciz "System_ValueType"

LDIFF_SYM19=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM19
LTDIE_4_POINTER:

	.byte 13
LDIFF_SYM20=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM20
LTDIE_4_REFERENCE:

	.byte 14
LDIFF_SYM21=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM21
LTDIE_3:

	.byte 5
	.asciz "System_Int32"

	.byte 12,16
LDIFF_SYM22=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM22
	.byte 2,35,0,6
	.asciz "m_value"

LDIFF_SYM23=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM23
	.byte 2,35,8,0,7
	.asciz "System_Int32"

LDIFF_SYM24=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM24
LTDIE_3_POINTER:

	.byte 13
LDIFF_SYM25=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM25
LTDIE_3_REFERENCE:

	.byte 14
LDIFF_SYM26=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM26
LTDIE_5:

	.byte 5
	.asciz "System_Text_StringBuilder"

	.byte 28,16
LDIFF_SYM27=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM27
	.byte 2,35,0,6
	.asciz "m_ChunkChars"

LDIFF_SYM28=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM28
	.byte 2,35,8,6
	.asciz "m_ChunkPrevious"

LDIFF_SYM29=LTDIE_5_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM29
	.byte 2,35,12,6
	.asciz "m_ChunkLength"

LDIFF_SYM30=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM30
	.byte 2,35,16,6
	.asciz "m_ChunkOffset"

LDIFF_SYM31=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM31
	.byte 2,35,20,6
	.asciz "m_MaxCapacity"

LDIFF_SYM32=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM32
	.byte 2,35,24,0,7
	.asciz "System_Text_StringBuilder"

LDIFF_SYM33=LTDIE_5 - Ldebug_info_start
	.long LDIFF_SYM33
LTDIE_5_POINTER:

	.byte 13
LDIFF_SYM34=LTDIE_5 - Ldebug_info_start
	.long LDIFF_SYM34
LTDIE_5_REFERENCE:

	.byte 14
LDIFF_SYM35=LTDIE_5 - Ldebug_info_start
	.long LDIFF_SYM35
	.byte 2
	.asciz "PInvoke.Kernel32:FormatMessage"
	.asciz "PInvoke_Kernel32_FormatMessage_PInvoke_Kernel32_FormatMessageFlags_void__int_int_intptr___int"

	.byte 0,0
	.long PInvoke_Kernel32_FormatMessage_PInvoke_Kernel32_FormatMessageFlags_void__int_int_intptr___int
	.long Lme_16

	.byte 2,118,16,3
	.asciz "dwFlags"

LDIFF_SYM36=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM36
	.byte 2,123,20,3
	.asciz "lpSource"

LDIFF_SYM37=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM37
	.byte 2,123,24,3
	.asciz "dwMessageId"

LDIFF_SYM38=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM38
	.byte 1,84,3
	.asciz "dwLanguageId"

LDIFF_SYM39=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM39
	.byte 1,85,3
	.asciz "Arguments"

LDIFF_SYM40=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM40
	.byte 1,86,3
	.asciz "maxAllowedBufferSize"

LDIFF_SYM41=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM41
	.byte 2,123,28,11
	.asciz "V_0"

LDIFF_SYM42=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM42
	.byte 2,123,16,11
	.asciz "V_1"

LDIFF_SYM43=LTDIE_5_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM43
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM44=Lfde1_end - Lfde1_start
	.long LDIFF_SYM44
Lfde1_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_FormatMessage_PInvoke_Kernel32_FormatMessageFlags_void__int_int_intptr___int

LDIFF_SYM45=Lme_16 - PInvoke_Kernel32_FormatMessage_PInvoke_Kernel32_FormatMessageFlags_void__int_int_intptr___int
	.long LDIFF_SYM45
	.byte 68,14,8,135,2,72,14,32,132,8,133,7,134,6,136,5,138,4,139,3,142,1,68,14,72,68,13,11,2,236,10,68
	.byte 13,13,14,32,68,8,4,8,5,8,6,8,8,8,10,8,11,14,8,68,11
	.align 2
Lfde1_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32:GetLastError"
	.asciz "PInvoke_Kernel32_GetLastError"

	.byte 0,0
	.long PInvoke_Kernel32_GetLastError
	.long Lme_17

	.byte 2,118,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM46=Lfde2_end - Lfde2_start
	.long LDIFF_SYM46
Lfde2_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_GetLastError

LDIFF_SYM47=Lme_17 - PInvoke_Kernel32_GetLastError
	.long LDIFF_SYM47
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,16,68,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde2_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_8:

	.byte 5
	.asciz "System_Runtime_ConstrainedExecution_CriticalFinalizerObject"

	.byte 8,16
LDIFF_SYM48=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM48
	.byte 2,35,0,0,7
	.asciz "System_Runtime_ConstrainedExecution_CriticalFinalizerObject"

LDIFF_SYM49=LTDIE_8 - Ldebug_info_start
	.long LDIFF_SYM49
LTDIE_8_POINTER:

	.byte 13
LDIFF_SYM50=LTDIE_8 - Ldebug_info_start
	.long LDIFF_SYM50
LTDIE_8_REFERENCE:

	.byte 14
LDIFF_SYM51=LTDIE_8 - Ldebug_info_start
	.long LDIFF_SYM51
LTDIE_9:

	.byte 5
	.asciz "System_Boolean"

	.byte 9,16
LDIFF_SYM52=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM52
	.byte 2,35,0,6
	.asciz "m_value"

LDIFF_SYM53=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM53
	.byte 2,35,8,0,7
	.asciz "System_Boolean"

LDIFF_SYM54=LTDIE_9 - Ldebug_info_start
	.long LDIFF_SYM54
LTDIE_9_POINTER:

	.byte 13
LDIFF_SYM55=LTDIE_9 - Ldebug_info_start
	.long LDIFF_SYM55
LTDIE_9_REFERENCE:

	.byte 14
LDIFF_SYM56=LTDIE_9 - Ldebug_info_start
	.long LDIFF_SYM56
LTDIE_7:

	.byte 5
	.asciz "System_Runtime_InteropServices_SafeHandle"

	.byte 20,16
LDIFF_SYM57=LTDIE_8 - Ldebug_info_start
	.long LDIFF_SYM57
	.byte 2,35,0,6
	.asciz "handle"

LDIFF_SYM58=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM58
	.byte 2,35,8,6
	.asciz "_state"

LDIFF_SYM59=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM59
	.byte 2,35,12,6
	.asciz "_ownsHandle"

LDIFF_SYM60=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM60
	.byte 2,35,16,6
	.asciz "_fullyInitialized"

LDIFF_SYM61=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM61
	.byte 2,35,17,0,7
	.asciz "System_Runtime_InteropServices_SafeHandle"

LDIFF_SYM62=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM62
LTDIE_7_POINTER:

	.byte 13
LDIFF_SYM63=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM63
LTDIE_7_REFERENCE:

	.byte 14
LDIFF_SYM64=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM64
LTDIE_6:

	.byte 5
	.asciz "_SafeObjectHandle"

	.byte 20,16
LDIFF_SYM65=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM65
	.byte 2,35,0,0,7
	.asciz "_SafeObjectHandle"

LDIFF_SYM66=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM66
LTDIE_6_POINTER:

	.byte 13
LDIFF_SYM67=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM67
LTDIE_6_REFERENCE:

	.byte 14
LDIFF_SYM68=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM68
	.byte 2
	.asciz "PInvoke.Kernel32:WriteFile"
	.asciz "PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_void__int"

	.byte 0,0
	.long PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_void__int
	.long Lme_18

	.byte 2,118,16,3
	.asciz "hFile"

LDIFF_SYM69=LTDIE_6_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM69
	.byte 2,123,16,3
	.asciz "lpBuffer"

LDIFF_SYM70=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM70
	.byte 2,123,20,3
	.asciz "nNumberOfBytesToWrite"

LDIFF_SYM71=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM71
	.byte 2,123,24,11
	.asciz "V_0"

LDIFF_SYM72=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM72
	.byte 2,123,8,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM73=Lfde3_end - Lfde3_start
	.long LDIFF_SYM73
Lfde3_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_void__int

LDIFF_SYM74=Lme_18 - PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_void__int
	.long LDIFF_SYM74
	.byte 68,14,8,135,2,72,14,16,136,4,139,3,142,1,68,14,56,68,13,11,2,136,10,68,13,13,14,16,68,8,8,8
	.byte 11,14,8,68,11
	.align 2
Lfde3_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_10:

	.byte 5
	.asciz "System_Byte"

	.byte 9,16
LDIFF_SYM75=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM75
	.byte 2,35,0,6
	.asciz "m_value"

LDIFF_SYM76=LDIE_U1 - Ldebug_info_start
	.long LDIFF_SYM76
	.byte 2,35,8,0,7
	.asciz "System_Byte"

LDIFF_SYM77=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM77
LTDIE_10_POINTER:

	.byte 13
LDIFF_SYM78=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM78
LTDIE_10_REFERENCE:

	.byte 14
LDIFF_SYM79=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM79
	.byte 2
	.asciz "PInvoke.Kernel32:WriteFile"
	.asciz "PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_System_ArraySegment_1_byte"

	.byte 0,0
	.long PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_System_ArraySegment_1_byte
	.long Lme_19

	.byte 2,118,16,3
	.asciz "hFile"

LDIFF_SYM80=LTDIE_6_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM80
	.byte 2,123,4,3
	.asciz "lpBuffer"

LDIFF_SYM81=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM81
	.byte 2,123,8,11
	.asciz "V_0"

LDIFF_SYM82=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM82
	.byte 1,86,11
	.asciz "V_1"

LDIFF_SYM83=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM83
	.byte 1,85,11
	.asciz "V_2"

LDIFF_SYM84=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM84
	.byte 2,123,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM85=Lfde4_end - Lfde4_start
	.long LDIFF_SYM85
Lfde4_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_System_ArraySegment_1_byte

LDIFF_SYM86=Lme_19 - PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_System_ArraySegment_1_byte
	.long LDIFF_SYM86
	.byte 68,14,8,135,2,72,14,24,133,6,134,5,136,4,139,3,142,1,68,14,48,68,13,11,2,156,10,68,13,13,14,24
	.byte 68,8,5,8,6,8,8,8,11,14,8,68,11
	.align 2
Lfde4_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32:ReadFile"
	.asciz "PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_void__int"

	.byte 0,0
	.long PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_void__int
	.long Lme_1a

	.byte 2,118,16,3
	.asciz "hFile"

LDIFF_SYM87=LTDIE_6_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM87
	.byte 2,123,16,3
	.asciz "lpBuffer"

LDIFF_SYM88=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM88
	.byte 2,123,20,3
	.asciz "nNumberOfBytesToRead"

LDIFF_SYM89=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM89
	.byte 2,123,24,11
	.asciz "V_0"

LDIFF_SYM90=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM90
	.byte 2,123,8,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM91=Lfde5_end - Lfde5_start
	.long LDIFF_SYM91
Lfde5_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_void__int

LDIFF_SYM92=Lme_1a - PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_void__int
	.long LDIFF_SYM92
	.byte 68,14,8,135,2,72,14,16,136,4,139,3,142,1,68,14,56,68,13,11,2,136,10,68,13,13,14,16,68,8,8,8
	.byte 11,14,8,68,11
	.align 2
Lfde5_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32:ReadFile"
	.asciz "PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_System_ArraySegment_1_byte"

	.byte 0,0
	.long PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_System_ArraySegment_1_byte
	.long Lme_1b

	.byte 2,118,16,3
	.asciz "hFile"

LDIFF_SYM93=LTDIE_6_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM93
	.byte 2,123,4,3
	.asciz "lpBuffer"

LDIFF_SYM94=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM94
	.byte 2,123,8,11
	.asciz "V_0"

LDIFF_SYM95=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM95
	.byte 1,86,11
	.asciz "V_1"

LDIFF_SYM96=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM96
	.byte 1,84,11
	.asciz "V_2"

LDIFF_SYM97=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM97
	.byte 2,123,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM98=Lfde6_end - Lfde6_start
	.long LDIFF_SYM98
Lfde6_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_System_ArraySegment_1_byte

LDIFF_SYM99=Lme_1b - PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_System_ArraySegment_1_byte
	.long LDIFF_SYM99
	.byte 68,14,8,135,2,72,14,24,132,6,134,5,136,4,139,3,142,1,68,14,48,68,13,11,2,144,10,68,13,13,14,24
	.byte 68,8,4,8,6,8,8,8,11,14,8,68,11
	.align 2
Lfde6_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32:ReadFile"
	.asciz "PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_int"

	.byte 0,0
	.long PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_int
	.long Lme_1c

	.byte 2,118,16,3
	.asciz "hFile"

LDIFF_SYM100=LTDIE_6_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM100
	.byte 2,125,52,3
	.asciz "nNumberOfBytesToRead"

LDIFF_SYM101=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM101
	.byte 2,125,56,11
	.asciz "V_0"

LDIFF_SYM102=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM102
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM103=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM103
	.byte 2,125,4,11
	.asciz "V_2"

LDIFF_SYM104=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM104
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM105=Lfde7_end - Lfde7_start
	.long LDIFF_SYM105
Lfde7_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_int

LDIFF_SYM106=Lme_1c - PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_int
	.long LDIFF_SYM106
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,88,3,36,1,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde7_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_11:

	.byte 5
	.asciz "System_Char"

	.byte 10,16
LDIFF_SYM107=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM107
	.byte 2,35,0,6
	.asciz "m_value"

LDIFF_SYM108=LDIE_CHAR - Ldebug_info_start
	.long LDIFF_SYM108
	.byte 2,35,8,0,7
	.asciz "System_Char"

LDIFF_SYM109=LTDIE_11 - Ldebug_info_start
	.long LDIFF_SYM109
LTDIE_11_POINTER:

	.byte 13
LDIFF_SYM110=LTDIE_11 - Ldebug_info_start
	.long LDIFF_SYM110
LTDIE_11_REFERENCE:

	.byte 14
LDIFF_SYM111=LTDIE_11 - Ldebug_info_start
	.long LDIFF_SYM111
	.byte 2
	.asciz "PInvoke.Kernel32:TryGetErrorMessage"
	.asciz "PInvoke_Kernel32_TryGetErrorMessage_PInvoke_Kernel32_FormatMessageFlags_void__int_int_System_Text_StringBuilder_intptr___string_"

	.byte 0,0
	.long PInvoke_Kernel32_TryGetErrorMessage_PInvoke_Kernel32_FormatMessageFlags_void__int_int_System_Text_StringBuilder_intptr___string_
	.long Lme_1d

	.byte 2,118,16,3
	.asciz "flags"

LDIFF_SYM112=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM112
	.byte 2,123,20,3
	.asciz "source"

LDIFF_SYM113=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM113
	.byte 2,123,24,3
	.asciz "messageId"

LDIFF_SYM114=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM114
	.byte 2,123,28,3
	.asciz "languageId"

LDIFF_SYM115=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM115
	.byte 2,123,32,3
	.asciz "sb"

LDIFF_SYM116=LTDIE_5_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM116
	.byte 1,85,3
	.asciz "arguments"

LDIFF_SYM117=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM117
	.byte 2,123,36,3
	.asciz "errorMsg"

LDIFF_SYM118=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM118
	.byte 2,123,40,11
	.asciz "V_0"

LDIFF_SYM119=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM119
	.byte 1,90,11
	.asciz "V_1"

LDIFF_SYM120=LDIE_CHAR - Ldebug_info_start
	.long LDIFF_SYM120
	.byte 2,123,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM121=Lfde8_end - Lfde8_start
	.long LDIFF_SYM121
Lfde8_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_TryGetErrorMessage_PInvoke_Kernel32_FormatMessageFlags_void__int_int_System_Text_StringBuilder_intptr___string_

LDIFF_SYM122=Lme_1d - PInvoke_Kernel32_TryGetErrorMessage_PInvoke_Kernel32_FormatMessageFlags_void__int_int_System_Text_StringBuilder_intptr___string_
	.long LDIFF_SYM122
	.byte 68,14,8,135,2,72,14,24,133,6,136,5,138,4,139,3,142,1,68,14,72,68,13,11,3,68,1,10,68,13,13,14
	.byte 24,68,8,5,8,8,8,10,8,11,14,8,68,11
	.align 2
Lfde8_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_12:

	.byte 8
	.asciz "_FINDEX_INFO_LEVELS"

	.byte 4
LDIFF_SYM123=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM123
	.byte 9
	.asciz "FindExInfoStandard"

	.byte 0,9
	.asciz "FindExInfoMaxInfoLevel"

	.byte 1,0,7
	.asciz "_FINDEX_INFO_LEVELS"

LDIFF_SYM124=LTDIE_12 - Ldebug_info_start
	.long LDIFF_SYM124
LTDIE_12_POINTER:

	.byte 13
LDIFF_SYM125=LTDIE_12 - Ldebug_info_start
	.long LDIFF_SYM125
LTDIE_12_REFERENCE:

	.byte 14
LDIFF_SYM126=LTDIE_12 - Ldebug_info_start
	.long LDIFF_SYM126
LTDIE_14:

	.byte 8
	.asciz "_FileAttribute"

	.byte 4
LDIFF_SYM127=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM127
	.byte 9
	.asciz "FILE_ATTRIBUTE_ARCHIVE"

	.byte 32,9
	.asciz "FILE_ATTRIBUTE_COMPRESSED"

	.byte 128,16,9
	.asciz "FILE_ATTRIBUTE_DEVICE"

	.byte 192,0,9
	.asciz "FILE_ATTRIBUTE_DIRECTORY"

	.byte 16,9
	.asciz "FILE_ATTRIBUTE_ENCRYPTED"

	.byte 128,128,1,9
	.asciz "FILE_ATTRIBUTE_HIDDEN"

	.byte 2,9
	.asciz "FILE_ATTRIBUTE_INTEGRITY_STREAM"

	.byte 128,128,2,9
	.asciz "FILE_ATTRIBUTE_NORMAL"

	.byte 128,1,9
	.asciz "FILE_ATTRIBUTE_NOT_CONTENT_INDEXED"

	.byte 128,192,0,9
	.asciz "FILE_ATTRIBUTE_NO_SCRUB_DATA"

	.byte 128,128,8,9
	.asciz "FILE_ATTRIBUTE_OFFLINE"

	.byte 128,32,9
	.asciz "FILE_ATTRIBUTE_READONLY"

	.byte 1,9
	.asciz "FILE_ATTRIBUTE_REPARSE_POINT"

	.byte 128,8,9
	.asciz "FILE_ATTRIBUTE_SPARSE_FILE"

	.byte 128,4,9
	.asciz "FILE_ATTRIBUTE_SYSTEM"

	.byte 4,9
	.asciz "FILE_ATTRIBUTE_TEMPORARY"

	.byte 128,2,9
	.asciz "FILE_ATTRIBUTE_VIRTUAL"

	.byte 128,128,4,0,7
	.asciz "_FileAttribute"

LDIFF_SYM128=LTDIE_14 - Ldebug_info_start
	.long LDIFF_SYM128
LTDIE_14_POINTER:

	.byte 13
LDIFF_SYM129=LTDIE_14 - Ldebug_info_start
	.long LDIFF_SYM129
LTDIE_14_REFERENCE:

	.byte 14
LDIFF_SYM130=LTDIE_14 - Ldebug_info_start
	.long LDIFF_SYM130
LTDIE_15:

	.byte 5
	.asciz "System_UInt32"

	.byte 12,16
LDIFF_SYM131=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM131
	.byte 2,35,0,6
	.asciz "m_value"

LDIFF_SYM132=LDIE_U4 - Ldebug_info_start
	.long LDIFF_SYM132
	.byte 2,35,8,0,7
	.asciz "System_UInt32"

LDIFF_SYM133=LTDIE_15 - Ldebug_info_start
	.long LDIFF_SYM133
LTDIE_15_POINTER:

	.byte 13
LDIFF_SYM134=LTDIE_15 - Ldebug_info_start
	.long LDIFF_SYM134
LTDIE_15_REFERENCE:

	.byte 14
LDIFF_SYM135=LTDIE_15 - Ldebug_info_start
	.long LDIFF_SYM135
LTDIE_13:

	.byte 5
	.asciz "_WIN32_FIND_DATA"

	.byte 60,16
LDIFF_SYM136=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM136
	.byte 2,35,0,6
	.asciz "dwFileAttributes"

LDIFF_SYM137=LTDIE_14 - Ldebug_info_start
	.long LDIFF_SYM137
	.byte 2,35,0,6
	.asciz "ftCreationTime"

LDIFF_SYM138=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM138
	.byte 2,35,4,6
	.asciz "ftLastAccessTime"

LDIFF_SYM139=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM139
	.byte 2,35,12,6
	.asciz "ftLastWriteTime"

LDIFF_SYM140=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM140
	.byte 2,35,20,6
	.asciz "nFileSizeHigh"

LDIFF_SYM141=LDIE_U4 - Ldebug_info_start
	.long LDIFF_SYM141
	.byte 2,35,28,6
	.asciz "nFileSizeLow"

LDIFF_SYM142=LDIE_U4 - Ldebug_info_start
	.long LDIFF_SYM142
	.byte 2,35,32,6
	.asciz "dwReserved0"

LDIFF_SYM143=LDIE_U4 - Ldebug_info_start
	.long LDIFF_SYM143
	.byte 2,35,36,6
	.asciz "dwReserved1"

LDIFF_SYM144=LDIE_U4 - Ldebug_info_start
	.long LDIFF_SYM144
	.byte 2,35,40,6
	.asciz "cFileName"

LDIFF_SYM145=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM145
	.byte 2,35,44,6
	.asciz "cAlternateFileName"

LDIFF_SYM146=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM146
	.byte 2,35,48,0,7
	.asciz "_WIN32_FIND_DATA"

LDIFF_SYM147=LTDIE_13 - Ldebug_info_start
	.long LDIFF_SYM147
LTDIE_13_POINTER:

	.byte 13
LDIFF_SYM148=LTDIE_13 - Ldebug_info_start
	.long LDIFF_SYM148
LTDIE_13_REFERENCE:

	.byte 14
LDIFF_SYM149=LTDIE_13 - Ldebug_info_start
	.long LDIFF_SYM149
LTDIE_16:

	.byte 8
	.asciz "_FINDEX_SEARCH_OPS"

	.byte 4
LDIFF_SYM150=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM150
	.byte 9
	.asciz "FindExSearchNameMatch"

	.byte 0,9
	.asciz "FindExSearchLimitToDirectories"

	.byte 1,9
	.asciz "FindExSearchLimitToDevices"

	.byte 2,9
	.asciz "FindExSearchMaxSearchOp"

	.byte 3,0,7
	.asciz "_FINDEX_SEARCH_OPS"

LDIFF_SYM151=LTDIE_16 - Ldebug_info_start
	.long LDIFF_SYM151
LTDIE_16_POINTER:

	.byte 13
LDIFF_SYM152=LTDIE_16 - Ldebug_info_start
	.long LDIFF_SYM152
LTDIE_16_REFERENCE:

	.byte 14
LDIFF_SYM153=LTDIE_16 - Ldebug_info_start
	.long LDIFF_SYM153
LTDIE_17:

	.byte 8
	.asciz "_FindFirstFileExFlags"

	.byte 4
LDIFF_SYM154=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM154
	.byte 9
	.asciz "None"

	.byte 0,9
	.asciz "FIND_FIRST_EX_CASE_SENSITIVE"

	.byte 1,9
	.asciz "FIND_FIRST_EX_LARGE_FETCH"

	.byte 2,0,7
	.asciz "_FindFirstFileExFlags"

LDIFF_SYM155=LTDIE_17 - Ldebug_info_start
	.long LDIFF_SYM155
LTDIE_17_POINTER:

	.byte 13
LDIFF_SYM156=LTDIE_17 - Ldebug_info_start
	.long LDIFF_SYM156
LTDIE_17_REFERENCE:

	.byte 14
LDIFF_SYM157=LTDIE_17 - Ldebug_info_start
	.long LDIFF_SYM157
	.byte 2
	.asciz "PInvoke.Kernel32:FindFirstFileEx"
	.asciz "PInvoke_Kernel32_FindFirstFileEx_string_PInvoke_Kernel32_FINDEX_INFO_LEVELS_PInvoke_Kernel32_WIN32_FIND_DATA__PInvoke_Kernel32_FINDEX_SEARCH_OPS_intptr_PInvoke_Kernel32_FindFirstFileExFlags"

	.byte 0,0
	.long PInvoke_Kernel32_FindFirstFileEx_string_PInvoke_Kernel32_FINDEX_INFO_LEVELS_PInvoke_Kernel32_WIN32_FIND_DATA__PInvoke_Kernel32_FINDEX_SEARCH_OPS_intptr_PInvoke_Kernel32_FindFirstFileExFlags
	.long Lme_1e

	.byte 2,118,16,3
	.asciz "lpFileName"

LDIFF_SYM158=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM158
	.byte 2,123,8,3
	.asciz "fInfoLevelId"

LDIFF_SYM159=LTDIE_12 - Ldebug_info_start
	.long LDIFF_SYM159
	.byte 2,123,12,3
	.asciz "lpFindFileData"

LDIFF_SYM160=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM160
	.byte 2,123,16,3
	.asciz "fSearchOp"

LDIFF_SYM161=LTDIE_16 - Ldebug_info_start
	.long LDIFF_SYM161
	.byte 2,123,20,3
	.asciz "lpSearchFilter"

LDIFF_SYM162=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM162
	.byte 2,123,24,3
	.asciz "dwAdditionalFlags"

LDIFF_SYM163=LTDIE_17 - Ldebug_info_start
	.long LDIFF_SYM163
	.byte 2,123,28,11
	.asciz "V_0"

LDIFF_SYM164=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM164
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM165=Lfde9_end - Lfde9_start
	.long LDIFF_SYM165
Lfde9_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_FindFirstFileEx_string_PInvoke_Kernel32_FINDEX_INFO_LEVELS_PInvoke_Kernel32_WIN32_FIND_DATA__PInvoke_Kernel32_FINDEX_SEARCH_OPS_intptr_PInvoke_Kernel32_FindFirstFileExFlags

LDIFF_SYM166=Lme_1e - PInvoke_Kernel32_FindFirstFileEx_string_PInvoke_Kernel32_FINDEX_INFO_LEVELS_PInvoke_Kernel32_WIN32_FIND_DATA__PInvoke_Kernel32_FINDEX_SEARCH_OPS_intptr_PInvoke_Kernel32_FindFirstFileExFlags
	.long LDIFF_SYM166
	.byte 68,14,8,135,2,72,14,16,136,4,139,3,142,1,68,14,48,68,13,11,2,68,10,68,13,13,14,16,68,8,8,8
	.byte 11,14,8,68,11
	.align 2
Lfde9_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32:FormatMessage"
	.asciz "PInvoke_Kernel32_FormatMessage_PInvoke_Kernel32_FormatMessageFlags_intptr_int_int_System_Text_StringBuilder_int_intptr__"

	.byte 0,0
	.long PInvoke_Kernel32_FormatMessage_PInvoke_Kernel32_FormatMessageFlags_intptr_int_int_System_Text_StringBuilder_int_intptr__
	.long Lme_1f

	.byte 2,118,16,3
	.asciz "dwFlags"

LDIFF_SYM167=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM167
	.byte 2,123,16,3
	.asciz "lpSource"

LDIFF_SYM168=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM168
	.byte 2,123,20,3
	.asciz "dwMessageId"

LDIFF_SYM169=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM169
	.byte 2,123,24,3
	.asciz "dwLanguageId"

LDIFF_SYM170=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM170
	.byte 2,123,28,3
	.asciz "lpBuffer"

LDIFF_SYM171=LTDIE_5_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM171
	.byte 2,123,32,3
	.asciz "nSize"

LDIFF_SYM172=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM172
	.byte 2,123,36,3
	.asciz "Arguments"

LDIFF_SYM173=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM173
	.byte 2,123,40,11
	.asciz "V_0"

LDIFF_SYM174=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM174
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM175=Lfde10_end - Lfde10_start
	.long LDIFF_SYM175
Lfde10_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_FormatMessage_PInvoke_Kernel32_FormatMessageFlags_intptr_int_int_System_Text_StringBuilder_int_intptr__

LDIFF_SYM176=Lme_1f - PInvoke_Kernel32_FormatMessage_PInvoke_Kernel32_FormatMessageFlags_intptr_int_int_System_Text_StringBuilder_int_intptr__
	.long LDIFF_SYM176
	.byte 68,14,8,135,2,72,14,16,136,4,139,3,142,1,68,14,64,68,13,11,2,84,10,68,13,13,14,16,68,8,8,8
	.byte 11,14,8,68,11
	.align 2
Lfde10_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32:CancelIoEx"
	.asciz "PInvoke_Kernel32_CancelIoEx_PInvoke_Kernel32_SafeObjectHandle_intptr"

	.byte 0,0
	.long PInvoke_Kernel32_CancelIoEx_PInvoke_Kernel32_SafeObjectHandle_intptr
	.long Lme_20

	.byte 2,118,16,3
	.asciz "hFile"

LDIFF_SYM177=LTDIE_6_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM177
	.byte 2,125,0,3
	.asciz "lpOverlapped"

LDIFF_SYM178=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM178
	.byte 2,125,4,11
	.asciz "V_0"

LDIFF_SYM179=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM179
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM180=Lfde11_end - Lfde11_start
	.long LDIFF_SYM180
Lfde11_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_CancelIoEx_PInvoke_Kernel32_SafeObjectHandle_intptr

LDIFF_SYM181=Lme_20 - PInvoke_Kernel32_CancelIoEx_PInvoke_Kernel32_SafeObjectHandle_intptr
	.long LDIFF_SYM181
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,88,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde11_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32:ReadFile"
	.asciz "PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_intptr_int_intptr_intptr"

	.byte 0,0
	.long PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_intptr_int_intptr_intptr
	.long Lme_21

	.byte 2,118,16,3
	.asciz "hFile"

LDIFF_SYM182=LTDIE_6_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM182
	.byte 2,123,8,3
	.asciz "lpBuffer"

LDIFF_SYM183=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM183
	.byte 2,123,12,3
	.asciz "nNumberOfBytesToRead"

LDIFF_SYM184=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM184
	.byte 2,123,16,3
	.asciz "lpNumberOfBytesRead"

LDIFF_SYM185=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM185
	.byte 2,123,20,3
	.asciz "lpOverlapped"

LDIFF_SYM186=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM186
	.byte 2,123,24,11
	.asciz "V_0"

LDIFF_SYM187=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM187
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM188=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM188
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM189=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM189
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM190=Lfde12_end - Lfde12_start
	.long LDIFF_SYM190
Lfde12_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_intptr_int_intptr_intptr

LDIFF_SYM191=Lme_21 - PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_intptr_int_intptr_intptr
	.long LDIFF_SYM191
	.byte 68,14,8,135,2,72,14,16,136,4,139,3,142,1,68,14,48,68,13,11,2,56,10,68,13,13,14,16,68,8,8,8
	.byte 11,14,8,68,11
	.align 2
Lfde12_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_18:

	.byte 5
	.asciz "System_Nullable`1"

	.byte 16,16
LDIFF_SYM192=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM192
	.byte 2,35,0,6
	.asciz "value"

LDIFF_SYM193=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM193
	.byte 2,35,8,6
	.asciz "has_value"

LDIFF_SYM194=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM194
	.byte 2,35,12,0,7
	.asciz "System_Nullable`1"

LDIFF_SYM195=LTDIE_18 - Ldebug_info_start
	.long LDIFF_SYM195
LTDIE_18_POINTER:

	.byte 13
LDIFF_SYM196=LTDIE_18 - Ldebug_info_start
	.long LDIFF_SYM196
LTDIE_18_REFERENCE:

	.byte 14
LDIFF_SYM197=LTDIE_18 - Ldebug_info_start
	.long LDIFF_SYM197
	.byte 2
	.asciz "PInvoke.Kernel32:ReadFile"
	.asciz "PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_intptr_int_System_Nullable_1_int__intptr"

	.byte 0,0
	.long PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_intptr_int_System_Nullable_1_int__intptr
	.long Lme_22

	.byte 2,118,16,3
	.asciz "hFile"

LDIFF_SYM198=LTDIE_6_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM198
	.byte 2,123,56,3
	.asciz "lpBuffer"

LDIFF_SYM199=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM199
	.byte 2,123,60,3
	.asciz "nNumberOfBytesToRead"

LDIFF_SYM200=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM200
	.byte 3,123,192,0,3
	.asciz "lpNumberOfBytesRead"

LDIFF_SYM201=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM201
	.byte 1,86,3
	.asciz "lpOverlapped"

LDIFF_SYM202=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM202
	.byte 3,123,196,0,11
	.asciz "V_0"

LDIFF_SYM203=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM203
	.byte 2,123,8,11
	.asciz "V_1"

LDIFF_SYM204=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM204
	.byte 2,123,12,11
	.asciz "V_2"

LDIFF_SYM205=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM205
	.byte 2,123,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM206=Lfde13_end - Lfde13_start
	.long LDIFF_SYM206
Lfde13_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_intptr_int_System_Nullable_1_int__intptr

LDIFF_SYM207=Lme_22 - PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_intptr_int_System_Nullable_1_int__intptr
	.long LDIFF_SYM207
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,139,3,142,1,68,14,96,68,13,11,3,84,1,10,68,13,13,14,20,68
	.byte 8,6,8,8,8,11,14,8,68,11
	.align 2
Lfde13_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32:ReadFile"
	.asciz "PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_void__int_System_Nullable_1_int__PInvoke_Kernel32_OVERLAPPED_"

	.byte 0,0
	.long PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_void__int_System_Nullable_1_int__PInvoke_Kernel32_OVERLAPPED_
	.long Lme_23

	.byte 2,118,16,3
	.asciz "hFile"

LDIFF_SYM208=LTDIE_6_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM208
	.byte 2,123,44,3
	.asciz "lpBuffer"

LDIFF_SYM209=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM209
	.byte 2,123,48,3
	.asciz "nNumberOfBytesToRead"

LDIFF_SYM210=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM210
	.byte 2,123,52,3
	.asciz "lpNumberOfBytesRead"

LDIFF_SYM211=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM211
	.byte 1,86,3
	.asciz "lpOverlapped"

LDIFF_SYM212=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM212
	.byte 2,123,56,11
	.asciz "V_0"

LDIFF_SYM213=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM213
	.byte 2,123,8,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM214=Lfde14_end - Lfde14_start
	.long LDIFF_SYM214
Lfde14_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_void__int_System_Nullable_1_int__PInvoke_Kernel32_OVERLAPPED_

LDIFF_SYM215=Lme_23 - PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_void__int_System_Nullable_1_int__PInvoke_Kernel32_OVERLAPPED_
	.long LDIFF_SYM215
	.byte 68,14,8,135,2,72,14,24,134,6,136,5,138,4,139,3,142,1,68,14,88,68,13,11,3,60,1,10,68,13,13,14
	.byte 24,68,8,6,8,8,8,10,8,11,14,8,68,11
	.align 2
Lfde14_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32:WriteFile"
	.asciz "PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_intptr_int_intptr_intptr"

	.byte 0,0
	.long PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_intptr_int_intptr_intptr
	.long Lme_24

	.byte 2,118,16,3
	.asciz "hFile"

LDIFF_SYM216=LTDIE_6_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM216
	.byte 2,123,8,3
	.asciz "lpBuffer"

LDIFF_SYM217=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM217
	.byte 2,123,12,3
	.asciz "nNumberOfBytesToWrite"

LDIFF_SYM218=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM218
	.byte 2,123,16,3
	.asciz "lpNumberOfBytesWritten"

LDIFF_SYM219=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM219
	.byte 2,123,20,3
	.asciz "lpOverlapped"

LDIFF_SYM220=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM220
	.byte 2,123,24,11
	.asciz "V_0"

LDIFF_SYM221=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM221
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM222=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM222
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM223=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM223
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM224=Lfde15_end - Lfde15_start
	.long LDIFF_SYM224
Lfde15_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_intptr_int_intptr_intptr

LDIFF_SYM225=Lme_24 - PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_intptr_int_intptr_intptr
	.long LDIFF_SYM225
	.byte 68,14,8,135,2,72,14,16,136,4,139,3,142,1,68,14,48,68,13,11,2,56,10,68,13,13,14,16,68,8,8,8
	.byte 11,14,8,68,11
	.align 2
Lfde15_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32:WriteFile"
	.asciz "PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_intptr_int_System_Nullable_1_int__intptr"

	.byte 0,0
	.long PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_intptr_int_System_Nullable_1_int__intptr
	.long Lme_25

	.byte 2,118,16,3
	.asciz "hFile"

LDIFF_SYM226=LTDIE_6_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM226
	.byte 2,123,56,3
	.asciz "lpBuffer"

LDIFF_SYM227=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM227
	.byte 2,123,60,3
	.asciz "nNumberOfBytesToWrite"

LDIFF_SYM228=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM228
	.byte 3,123,192,0,3
	.asciz "lpNumberOfBytesWritten"

LDIFF_SYM229=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM229
	.byte 1,86,3
	.asciz "lpOverlapped"

LDIFF_SYM230=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM230
	.byte 3,123,196,0,11
	.asciz "V_0"

LDIFF_SYM231=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM231
	.byte 2,123,8,11
	.asciz "V_1"

LDIFF_SYM232=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM232
	.byte 2,123,12,11
	.asciz "V_2"

LDIFF_SYM233=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM233
	.byte 2,123,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM234=Lfde16_end - Lfde16_start
	.long LDIFF_SYM234
Lfde16_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_intptr_int_System_Nullable_1_int__intptr

LDIFF_SYM235=Lme_25 - PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_intptr_int_System_Nullable_1_int__intptr
	.long LDIFF_SYM235
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,139,3,142,1,68,14,96,68,13,11,3,84,1,10,68,13,13,14,20,68
	.byte 8,6,8,8,8,11,14,8,68,11
	.align 2
Lfde16_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32:WriteFile"
	.asciz "PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_void__int_System_Nullable_1_int__PInvoke_Kernel32_OVERLAPPED_"

	.byte 0,0
	.long PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_void__int_System_Nullable_1_int__PInvoke_Kernel32_OVERLAPPED_
	.long Lme_26

	.byte 2,118,16,3
	.asciz "hFile"

LDIFF_SYM236=LTDIE_6_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM236
	.byte 2,123,44,3
	.asciz "lpBuffer"

LDIFF_SYM237=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM237
	.byte 2,123,48,3
	.asciz "nNumberOfBytesToWrite"

LDIFF_SYM238=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM238
	.byte 2,123,52,3
	.asciz "lpNumberOfBytesWritten"

LDIFF_SYM239=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM239
	.byte 1,86,3
	.asciz "lpOverlapped"

LDIFF_SYM240=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM240
	.byte 2,123,56,11
	.asciz "V_0"

LDIFF_SYM241=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM241
	.byte 2,123,8,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM242=Lfde17_end - Lfde17_start
	.long LDIFF_SYM242
Lfde17_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_void__int_System_Nullable_1_int__PInvoke_Kernel32_OVERLAPPED_

LDIFF_SYM243=Lme_26 - PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_void__int_System_Nullable_1_int__PInvoke_Kernel32_OVERLAPPED_
	.long LDIFF_SYM243
	.byte 68,14,8,135,2,72,14,24,134,6,136,5,138,4,139,3,142,1,68,14,88,68,13,11,3,60,1,10,68,13,13,14
	.byte 24,68,8,6,8,8,8,10,8,11,14,8,68,11
	.align 2
Lfde17_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32:CreateMutex"
	.asciz "PInvoke_Kernel32_CreateMutex_intptr_bool_string"

	.byte 0,0
	.long PInvoke_Kernel32_CreateMutex_intptr_bool_string
	.long Lme_27

	.byte 2,118,16,3
	.asciz "lpMutexAttributes"

LDIFF_SYM244=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM244
	.byte 2,125,0,3
	.asciz "bInitialOwner"

LDIFF_SYM245=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM245
	.byte 2,125,4,3
	.asciz "lpName"

LDIFF_SYM246=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM246
	.byte 2,125,8,11
	.asciz "V_0"

LDIFF_SYM247=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM247
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM248=Lfde18_end - Lfde18_start
	.long LDIFF_SYM248
Lfde18_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_CreateMutex_intptr_bool_string

LDIFF_SYM249=Lme_27 - PInvoke_Kernel32_CreateMutex_intptr_bool_string
	.long LDIFF_SYM249
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,32,92,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde18_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32:CreateMutex"
	.asciz "PInvoke_Kernel32_CreateMutex_System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_bool_string"

	.byte 0,0
	.long PInvoke_Kernel32_CreateMutex_System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_bool_string
	.long Lme_28

	.byte 2,118,16,3
	.asciz "lpMutexAttributes"

LDIFF_SYM250=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM250
	.byte 2,123,36,3
	.asciz "bInitialOwner"

LDIFF_SYM251=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM251
	.byte 2,123,52,3
	.asciz "lpName"

LDIFF_SYM252=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM252
	.byte 2,123,56,11
	.asciz "V_0"

LDIFF_SYM253=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM253
	.byte 2,123,0,11
	.asciz "V_1"

LDIFF_SYM254=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM254
	.byte 2,123,12,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM255=Lfde19_end - Lfde19_start
	.long LDIFF_SYM255
Lfde19_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_CreateMutex_System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_bool_string

LDIFF_SYM256=Lme_28 - PInvoke_Kernel32_CreateMutex_System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_bool_string
	.long LDIFF_SYM256
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,139,3,142,1,68,14,88,68,13,11,3,12,1,10,68,13,13,14,20,68
	.byte 8,6,8,8,8,11,14,8,68,11
	.align 2
Lfde19_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32:GetSystemTime"
	.asciz "PInvoke_Kernel32_GetSystemTime_intptr"

	.byte 0,0
	.long PInvoke_Kernel32_GetSystemTime_intptr
	.long Lme_29

	.byte 2,118,16,3
	.asciz "lpSystemTime"

LDIFF_SYM257=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM257
	.byte 2,125,0,11
	.asciz "V_0"

LDIFF_SYM258=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM258
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM259=Lfde20_end - Lfde20_start
	.long LDIFF_SYM259
Lfde20_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_GetSystemTime_intptr

LDIFF_SYM260=Lme_29 - PInvoke_Kernel32_GetSystemTime_intptr
	.long LDIFF_SYM260
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,76,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde20_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_20:

	.byte 5
	.asciz "System_Int16"

	.byte 10,16
LDIFF_SYM261=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM261
	.byte 2,35,0,6
	.asciz "m_value"

LDIFF_SYM262=LDIE_I2 - Ldebug_info_start
	.long LDIFF_SYM262
	.byte 2,35,8,0,7
	.asciz "System_Int16"

LDIFF_SYM263=LTDIE_20 - Ldebug_info_start
	.long LDIFF_SYM263
LTDIE_20_POINTER:

	.byte 13
LDIFF_SYM264=LTDIE_20 - Ldebug_info_start
	.long LDIFF_SYM264
LTDIE_20_REFERENCE:

	.byte 14
LDIFF_SYM265=LTDIE_20 - Ldebug_info_start
	.long LDIFF_SYM265
LTDIE_19:

	.byte 5
	.asciz "_SYSTEMTIME"

	.byte 24,16
LDIFF_SYM266=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM266
	.byte 2,35,0,6
	.asciz "wYear"

LDIFF_SYM267=LDIE_I2 - Ldebug_info_start
	.long LDIFF_SYM267
	.byte 2,35,0,6
	.asciz "wMonth"

LDIFF_SYM268=LDIE_I2 - Ldebug_info_start
	.long LDIFF_SYM268
	.byte 2,35,2,6
	.asciz "wDayOfWeek"

LDIFF_SYM269=LDIE_I2 - Ldebug_info_start
	.long LDIFF_SYM269
	.byte 2,35,4,6
	.asciz "wDay"

LDIFF_SYM270=LDIE_I2 - Ldebug_info_start
	.long LDIFF_SYM270
	.byte 2,35,6,6
	.asciz "wHour"

LDIFF_SYM271=LDIE_I2 - Ldebug_info_start
	.long LDIFF_SYM271
	.byte 2,35,8,6
	.asciz "wMinute"

LDIFF_SYM272=LDIE_I2 - Ldebug_info_start
	.long LDIFF_SYM272
	.byte 2,35,10,6
	.asciz "wSecond"

LDIFF_SYM273=LDIE_I2 - Ldebug_info_start
	.long LDIFF_SYM273
	.byte 2,35,12,6
	.asciz "wMilliseconds"

LDIFF_SYM274=LDIE_I2 - Ldebug_info_start
	.long LDIFF_SYM274
	.byte 2,35,14,0,7
	.asciz "_SYSTEMTIME"

LDIFF_SYM275=LTDIE_19 - Ldebug_info_start
	.long LDIFF_SYM275
LTDIE_19_POINTER:

	.byte 13
LDIFF_SYM276=LTDIE_19 - Ldebug_info_start
	.long LDIFF_SYM276
LTDIE_19_REFERENCE:

	.byte 14
LDIFF_SYM277=LTDIE_19 - Ldebug_info_start
	.long LDIFF_SYM277
	.byte 2
	.asciz "PInvoke.Kernel32:GetSystemTime"
	.asciz "PInvoke_Kernel32_GetSystemTime_PInvoke_Kernel32_SYSTEMTIME_"

	.byte 0,0
	.long PInvoke_Kernel32_GetSystemTime_PInvoke_Kernel32_SYSTEMTIME_
	.long Lme_2a

	.byte 2,118,16,3
	.asciz "lpSystemTime"

LDIFF_SYM278=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM278
	.byte 2,125,0,11
	.asciz "V_0"

LDIFF_SYM279=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM279
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM280=Lfde21_end - Lfde21_start
	.long LDIFF_SYM280
Lfde21_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_GetSystemTime_PInvoke_Kernel32_SYSTEMTIME_

LDIFF_SYM281=Lme_2a - PInvoke_Kernel32_GetSystemTime_PInvoke_Kernel32_SYSTEMTIME_
	.long LDIFF_SYM281
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,76,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde21_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32:FormatMessage"
	.asciz "PInvoke_Kernel32_FormatMessage_PInvoke_Kernel32_FormatMessageFlags_intptr_int_int_intptr___int"

	.byte 0,0
	.long PInvoke_Kernel32_FormatMessage_PInvoke_Kernel32_FormatMessageFlags_intptr_int_int_intptr___int
	.long Lme_2b

	.byte 2,118,16,3
	.asciz "dwFlags"

LDIFF_SYM282=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM282
	.byte 2,123,8,3
	.asciz "lpSource"

LDIFF_SYM283=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM283
	.byte 2,123,12,3
	.asciz "dwMessageId"

LDIFF_SYM284=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM284
	.byte 2,123,16,3
	.asciz "dwLanguageId"

LDIFF_SYM285=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM285
	.byte 2,123,20,3
	.asciz "Arguments"

LDIFF_SYM286=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM286
	.byte 2,123,24,3
	.asciz "maxAllowedBufferSize"

LDIFF_SYM287=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM287
	.byte 2,123,28,11
	.asciz "V_0"

LDIFF_SYM288=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM288
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM289=Lfde22_end - Lfde22_start
	.long LDIFF_SYM289
Lfde22_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_FormatMessage_PInvoke_Kernel32_FormatMessageFlags_intptr_int_int_intptr___int

LDIFF_SYM290=Lme_2b - PInvoke_Kernel32_FormatMessage_PInvoke_Kernel32_FormatMessageFlags_intptr_int_int_intptr___int
	.long LDIFF_SYM290
	.byte 68,14,8,135,2,72,14,16,136,4,139,3,142,1,68,14,48,68,13,11,2,68,10,68,13,13,14,16,68,8,8,8
	.byte 11,14,8,68,11
	.align 2
Lfde22_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32:WriteFile"
	.asciz "PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_intptr_int"

	.byte 0,0
	.long PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_intptr_int
	.long Lme_2c

	.byte 2,118,16,3
	.asciz "hFile"

LDIFF_SYM291=LTDIE_6_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM291
	.byte 2,125,0,3
	.asciz "lpBuffer"

LDIFF_SYM292=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM292
	.byte 2,125,4,3
	.asciz "nNumberOfBytesToWrite"

LDIFF_SYM293=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM293
	.byte 2,125,8,11
	.asciz "V_0"

LDIFF_SYM294=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM294
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM295=Lfde23_end - Lfde23_start
	.long LDIFF_SYM295
Lfde23_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_intptr_int

LDIFF_SYM296=Lme_2c - PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_intptr_int
	.long LDIFF_SYM296
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,32,92,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde23_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32:ReadFile"
	.asciz "PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_intptr_int"

	.byte 0,0
	.long PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_intptr_int
	.long Lme_2d

	.byte 2,118,16,3
	.asciz "hFile"

LDIFF_SYM297=LTDIE_6_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM297
	.byte 2,125,0,3
	.asciz "lpBuffer"

LDIFF_SYM298=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM298
	.byte 2,125,4,3
	.asciz "nNumberOfBytesToRead"

LDIFF_SYM299=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM299
	.byte 2,125,8,11
	.asciz "V_0"

LDIFF_SYM300=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM300
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM301=Lfde24_end - Lfde24_start
	.long LDIFF_SYM301
Lfde24_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_intptr_int

LDIFF_SYM302=Lme_2d - PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_intptr_int
	.long LDIFF_SYM302
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,32,92,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde24_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32:TryGetErrorMessage"
	.asciz "PInvoke_Kernel32_TryGetErrorMessage_PInvoke_Kernel32_FormatMessageFlags_intptr_int_int_System_Text_StringBuilder_intptr___string_"

	.byte 0,0
	.long PInvoke_Kernel32_TryGetErrorMessage_PInvoke_Kernel32_FormatMessageFlags_intptr_int_int_System_Text_StringBuilder_intptr___string_
	.long Lme_2e

	.byte 2,118,16,3
	.asciz "flags"

LDIFF_SYM303=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM303
	.byte 2,123,16,3
	.asciz "source"

LDIFF_SYM304=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM304
	.byte 2,123,20,3
	.asciz "messageId"

LDIFF_SYM305=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM305
	.byte 2,123,24,3
	.asciz "languageId"

LDIFF_SYM306=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM306
	.byte 2,123,28,3
	.asciz "sb"

LDIFF_SYM307=LTDIE_5_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM307
	.byte 2,123,32,3
	.asciz "arguments"

LDIFF_SYM308=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM308
	.byte 2,123,36,3
	.asciz "errorMsg"

LDIFF_SYM309=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM309
	.byte 2,123,40,11
	.asciz "V_0"

LDIFF_SYM310=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM310
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM311=Lfde25_end - Lfde25_start
	.long LDIFF_SYM311
Lfde25_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_TryGetErrorMessage_PInvoke_Kernel32_FormatMessageFlags_intptr_int_int_System_Text_StringBuilder_intptr___string_

LDIFF_SYM312=Lme_2e - PInvoke_Kernel32_TryGetErrorMessage_PInvoke_Kernel32_FormatMessageFlags_intptr_int_int_System_Text_StringBuilder_intptr___string_
	.long LDIFF_SYM312
	.byte 68,14,8,135,2,72,14,16,136,4,139,3,142,1,68,14,64,68,13,11,2,88,10,68,13,13,14,16,68,8,8,8
	.byte 11,14,8,68,11
	.align 2
Lfde25_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32:.cctor"
	.asciz "PInvoke_Kernel32__cctor"

	.byte 0,0
	.long PInvoke_Kernel32__cctor
	.long Lme_2f

	.byte 2,118,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM313=Lfde26_end - Lfde26_start
	.long LDIFF_SYM313
Lfde26_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32__cctor

LDIFF_SYM314=Lme_2f - PInvoke_Kernel32__cctor
	.long LDIFF_SYM314
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,2,40,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde26_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_21:

	.byte 5
	.asciz "_ACCESS_MASK"

	.byte 12,16
LDIFF_SYM315=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM315
	.byte 2,35,0,6
	.asciz "<Value>k__BackingField"

LDIFF_SYM316=LDIE_U4 - Ldebug_info_start
	.long LDIFF_SYM316
	.byte 2,35,0,0,7
	.asciz "_ACCESS_MASK"

LDIFF_SYM317=LTDIE_21 - Ldebug_info_start
	.long LDIFF_SYM317
LTDIE_21_POINTER:

	.byte 13
LDIFF_SYM318=LTDIE_21 - Ldebug_info_start
	.long LDIFF_SYM318
LTDIE_21_REFERENCE:

	.byte 14
LDIFF_SYM319=LTDIE_21 - Ldebug_info_start
	.long LDIFF_SYM319
	.byte 2
	.asciz "PInvoke.Kernel32/ACCESS_MASK:.ctor"
	.asciz "PInvoke_Kernel32_ACCESS_MASK__ctor_uint"

	.byte 0,0
	.long PInvoke_Kernel32_ACCESS_MASK__ctor_uint
	.long Lme_30

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM320=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM320
	.byte 2,125,0,3
	.asciz "value"

LDIFF_SYM321=LDIE_U4 - Ldebug_info_start
	.long LDIFF_SYM321
	.byte 2,125,4,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM322=Lfde27_end - Lfde27_start
	.long LDIFF_SYM322
Lfde27_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_ACCESS_MASK__ctor_uint

LDIFF_SYM323=Lme_30 - PInvoke_Kernel32_ACCESS_MASK__ctor_uint
	.long LDIFF_SYM323
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,84,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde27_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32/ACCESS_MASK:get_Value"
	.asciz "PInvoke_Kernel32_ACCESS_MASK_get_Value"

	.byte 0,0
	.long PInvoke_Kernel32_ACCESS_MASK_get_Value
	.long Lme_31

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM324=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM324
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM325=Lfde28_end - Lfde28_start
	.long LDIFF_SYM325
Lfde28_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_ACCESS_MASK_get_Value

LDIFF_SYM326=Lme_31 - PInvoke_Kernel32_ACCESS_MASK_get_Value
	.long LDIFF_SYM326
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,76,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde28_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32/ACCESS_MASK:get_AsInt32"
	.asciz "PInvoke_Kernel32_ACCESS_MASK_get_AsInt32"

	.byte 0,0
	.long PInvoke_Kernel32_ACCESS_MASK_get_AsInt32
	.long Lme_32

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM327=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM327
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM328=Lfde29_end - Lfde29_start
	.long LDIFF_SYM328
Lfde29_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_ACCESS_MASK_get_AsInt32

LDIFF_SYM329=Lme_32 - PInvoke_Kernel32_ACCESS_MASK_get_AsInt32
	.long LDIFF_SYM329
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,76,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde29_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32/ACCESS_MASK:get_GenericRights"
	.asciz "PInvoke_Kernel32_ACCESS_MASK_get_GenericRights"

	.byte 0,0
	.long PInvoke_Kernel32_ACCESS_MASK_get_GenericRights
	.long Lme_33

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM330=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM330
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM331=Lfde30_end - Lfde30_start
	.long LDIFF_SYM331
Lfde30_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_ACCESS_MASK_get_GenericRights

LDIFF_SYM332=Lme_33 - PInvoke_Kernel32_ACCESS_MASK_get_GenericRights
	.long LDIFF_SYM332
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,80,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde30_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32/ACCESS_MASK:get_SpecialRights"
	.asciz "PInvoke_Kernel32_ACCESS_MASK_get_SpecialRights"

	.byte 0,0
	.long PInvoke_Kernel32_ACCESS_MASK_get_SpecialRights
	.long Lme_34

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM333=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM333
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM334=Lfde31_end - Lfde31_start
	.long LDIFF_SYM334
Lfde31_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_ACCESS_MASK_get_SpecialRights

LDIFF_SYM335=Lme_34 - PInvoke_Kernel32_ACCESS_MASK_get_SpecialRights
	.long LDIFF_SYM335
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,80,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde31_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32/ACCESS_MASK:get_StandardRights"
	.asciz "PInvoke_Kernel32_ACCESS_MASK_get_StandardRights"

	.byte 0,0
	.long PInvoke_Kernel32_ACCESS_MASK_get_StandardRights
	.long Lme_35

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM336=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM336
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM337=Lfde32_end - Lfde32_start
	.long LDIFF_SYM337
Lfde32_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_ACCESS_MASK_get_StandardRights

LDIFF_SYM338=Lme_35 - PInvoke_Kernel32_ACCESS_MASK_get_StandardRights
	.long LDIFF_SYM338
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,80,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde32_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32/ACCESS_MASK:get_SpecificRights"
	.asciz "PInvoke_Kernel32_ACCESS_MASK_get_SpecificRights"

	.byte 0,0
	.long PInvoke_Kernel32_ACCESS_MASK_get_SpecificRights
	.long Lme_36

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM339=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM339
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM340=Lfde33_end - Lfde33_start
	.long LDIFF_SYM340
Lfde33_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_ACCESS_MASK_get_SpecificRights

LDIFF_SYM341=Lme_36 - PInvoke_Kernel32_ACCESS_MASK_get_SpecificRights
	.long LDIFF_SYM341
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,84,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde33_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32/ACCESS_MASK:get_DesktopSpecificRights"
	.asciz "PInvoke_Kernel32_ACCESS_MASK_get_DesktopSpecificRights"

	.byte 0,0
	.long PInvoke_Kernel32_ACCESS_MASK_get_DesktopSpecificRights
	.long Lme_37

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM342=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM342
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM343=Lfde34_end - Lfde34_start
	.long LDIFF_SYM343
Lfde34_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_ACCESS_MASK_get_DesktopSpecificRights

LDIFF_SYM344=Lme_37 - PInvoke_Kernel32_ACCESS_MASK_get_DesktopSpecificRights
	.long LDIFF_SYM344
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,84,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde34_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32/ACCESS_MASK:get_InteractiveWindowStationGenericRights"
	.asciz "PInvoke_Kernel32_ACCESS_MASK_get_InteractiveWindowStationGenericRights"

	.byte 0,0
	.long PInvoke_Kernel32_ACCESS_MASK_get_InteractiveWindowStationGenericRights
	.long Lme_38

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM345=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM345
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM346=Lfde35_end - Lfde35_start
	.long LDIFF_SYM346
Lfde35_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_ACCESS_MASK_get_InteractiveWindowStationGenericRights

LDIFF_SYM347=Lme_38 - PInvoke_Kernel32_ACCESS_MASK_get_InteractiveWindowStationGenericRights
	.long LDIFF_SYM347
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,80,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde35_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32/ACCESS_MASK:get_NonInteractiveWindowStationGenericRights"
	.asciz "PInvoke_Kernel32_ACCESS_MASK_get_NonInteractiveWindowStationGenericRights"

	.byte 0,0
	.long PInvoke_Kernel32_ACCESS_MASK_get_NonInteractiveWindowStationGenericRights
	.long Lme_39

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM348=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM348
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM349=Lfde36_end - Lfde36_start
	.long LDIFF_SYM349
Lfde36_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_ACCESS_MASK_get_NonInteractiveWindowStationGenericRights

LDIFF_SYM350=Lme_39 - PInvoke_Kernel32_ACCESS_MASK_get_NonInteractiveWindowStationGenericRights
	.long LDIFF_SYM350
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,80,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde36_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32/ACCESS_MASK:get_WindowStationSpecificRights"
	.asciz "PInvoke_Kernel32_ACCESS_MASK_get_WindowStationSpecificRights"

	.byte 0,0
	.long PInvoke_Kernel32_ACCESS_MASK_get_WindowStationSpecificRights
	.long Lme_3a

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM351=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM351
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM352=Lfde37_end - Lfde37_start
	.long LDIFF_SYM352
Lfde37_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_ACCESS_MASK_get_WindowStationSpecificRights

LDIFF_SYM353=Lme_3a - PInvoke_Kernel32_ACCESS_MASK_get_WindowStationSpecificRights
	.long LDIFF_SYM353
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,84,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde37_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32/ACCESS_MASK:op_Implicit"
	.asciz "PInvoke_Kernel32_ACCESS_MASK_op_Implicit_int"

	.byte 0,0
	.long PInvoke_Kernel32_ACCESS_MASK_op_Implicit_int
	.long Lme_3b

	.byte 2,118,16,3
	.asciz "value"

LDIFF_SYM354=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM354
	.byte 2,125,12,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM355=Lfde38_end - Lfde38_start
	.long LDIFF_SYM355
Lfde38_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_ACCESS_MASK_op_Implicit_int

LDIFF_SYM356=Lme_3b - PInvoke_Kernel32_ACCESS_MASK_op_Implicit_int
	.long LDIFF_SYM356
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,32,2,40,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde38_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32/ACCESS_MASK:op_Explicit"
	.asciz "PInvoke_Kernel32_ACCESS_MASK_op_Explicit_PInvoke_Kernel32_ACCESS_MASK"

	.byte 0,0
	.long PInvoke_Kernel32_ACCESS_MASK_op_Explicit_PInvoke_Kernel32_ACCESS_MASK
	.long Lme_3c

	.byte 2,118,16,3
	.asciz "value"

LDIFF_SYM357=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM357
	.byte 2,123,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM358=Lfde39_end - Lfde39_start
	.long LDIFF_SYM358
Lfde39_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_ACCESS_MASK_op_Explicit_PInvoke_Kernel32_ACCESS_MASK

LDIFF_SYM359=Lme_3c - PInvoke_Kernel32_ACCESS_MASK_op_Explicit_PInvoke_Kernel32_ACCESS_MASK
	.long LDIFF_SYM359
	.byte 68,14,8,135,2,72,14,16,136,4,139,3,142,1,68,14,24,68,13,11,72,10,68,13,13,14,16,68,8,8,8,11
	.byte 14,8,68,11
	.align 2
Lfde39_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32/ACCESS_MASK:op_Implicit"
	.asciz "PInvoke_Kernel32_ACCESS_MASK_op_Implicit_uint"

	.byte 0,0
	.long PInvoke_Kernel32_ACCESS_MASK_op_Implicit_uint
	.long Lme_3d

	.byte 2,118,16,3
	.asciz "value"

LDIFF_SYM360=LDIE_U4 - Ldebug_info_start
	.long LDIFF_SYM360
	.byte 2,125,12,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM361=Lfde40_end - Lfde40_start
	.long LDIFF_SYM361
Lfde40_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_ACCESS_MASK_op_Implicit_uint

LDIFF_SYM362=Lme_3d - PInvoke_Kernel32_ACCESS_MASK_op_Implicit_uint
	.long LDIFF_SYM362
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,32,2,40,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde40_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32/ACCESS_MASK:op_Implicit"
	.asciz "PInvoke_Kernel32_ACCESS_MASK_op_Implicit_PInvoke_Kernel32_ACCESS_MASK"

	.byte 0,0
	.long PInvoke_Kernel32_ACCESS_MASK_op_Implicit_PInvoke_Kernel32_ACCESS_MASK
	.long Lme_3e

	.byte 2,118,16,3
	.asciz "value"

LDIFF_SYM363=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM363
	.byte 2,123,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM364=Lfde41_end - Lfde41_start
	.long LDIFF_SYM364
Lfde41_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_ACCESS_MASK_op_Implicit_PInvoke_Kernel32_ACCESS_MASK

LDIFF_SYM365=Lme_3e - PInvoke_Kernel32_ACCESS_MASK_op_Implicit_PInvoke_Kernel32_ACCESS_MASK
	.long LDIFF_SYM365
	.byte 68,14,8,135,2,72,14,16,136,4,139,3,142,1,68,14,24,68,13,11,72,10,68,13,13,14,16,68,8,8,8,11
	.byte 14,8,68,11
	.align 2
Lfde41_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_22:

	.byte 8
	.asciz "_StandardRight"

	.byte 4
LDIFF_SYM366=LDIE_U4 - Ldebug_info_start
	.long LDIFF_SYM366
	.byte 9
	.asciz "DELETE"

	.byte 128,128,4,9
	.asciz "READ_CONTROL"

	.byte 128,128,8,9
	.asciz "WRITE_DAC"

	.byte 128,128,16,9
	.asciz "WRITE_OWNER"

	.byte 128,128,32,9
	.asciz "SYNCHRONIZE"

	.byte 128,128,192,0,9
	.asciz "STANDARD_RIGHTS_REQUIRED"

	.byte 128,128,60,9
	.asciz "STANDARD_RIGHTS_READ"

	.byte 128,128,8,9
	.asciz "STANDARD_RIGHTS_WRITE"

	.byte 128,128,8,9
	.asciz "STANDARD_RIGHTS_EXECUTE"

	.byte 128,128,8,9
	.asciz "STANDARD_RIGHTS_ALL"

	.byte 128,128,252,0,0,7
	.asciz "_StandardRight"

LDIFF_SYM367=LTDIE_22 - Ldebug_info_start
	.long LDIFF_SYM367
LTDIE_22_POINTER:

	.byte 13
LDIFF_SYM368=LTDIE_22 - Ldebug_info_start
	.long LDIFF_SYM368
LTDIE_22_REFERENCE:

	.byte 14
LDIFF_SYM369=LTDIE_22 - Ldebug_info_start
	.long LDIFF_SYM369
	.byte 2
	.asciz "PInvoke.Kernel32/ACCESS_MASK:op_Implicit"
	.asciz "PInvoke_Kernel32_ACCESS_MASK_op_Implicit_PInvoke_Kernel32_ACCESS_MASK_StandardRight"

	.byte 0,0
	.long PInvoke_Kernel32_ACCESS_MASK_op_Implicit_PInvoke_Kernel32_ACCESS_MASK_StandardRight
	.long Lme_3f

	.byte 2,118,16,3
	.asciz "value"

LDIFF_SYM370=LTDIE_22 - Ldebug_info_start
	.long LDIFF_SYM370
	.byte 2,125,12,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM371=Lfde42_end - Lfde42_start
	.long LDIFF_SYM371
Lfde42_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_ACCESS_MASK_op_Implicit_PInvoke_Kernel32_ACCESS_MASK_StandardRight

LDIFF_SYM372=Lme_3f - PInvoke_Kernel32_ACCESS_MASK_op_Implicit_PInvoke_Kernel32_ACCESS_MASK_StandardRight
	.long LDIFF_SYM372
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,32,2,40,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde42_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_23:

	.byte 8
	.asciz "_GenericRight"

	.byte 4
LDIFF_SYM373=LDIE_U4 - Ldebug_info_start
	.long LDIFF_SYM373
	.byte 9
	.asciz "GENERIC_ALL"

	.byte 128,128,128,128,1,9
	.asciz "GENERIC_EXECUTE"

	.byte 128,128,128,128,2,9
	.asciz "GENERIC_WRITE"

	.byte 128,128,128,128,4,9
	.asciz "GENERIC_READ"

	.byte 128,128,128,128,8,0,7
	.asciz "_GenericRight"

LDIFF_SYM374=LTDIE_23 - Ldebug_info_start
	.long LDIFF_SYM374
LTDIE_23_POINTER:

	.byte 13
LDIFF_SYM375=LTDIE_23 - Ldebug_info_start
	.long LDIFF_SYM375
LTDIE_23_REFERENCE:

	.byte 14
LDIFF_SYM376=LTDIE_23 - Ldebug_info_start
	.long LDIFF_SYM376
	.byte 2
	.asciz "PInvoke.Kernel32/ACCESS_MASK:op_Implicit"
	.asciz "PInvoke_Kernel32_ACCESS_MASK_op_Implicit_PInvoke_Kernel32_ACCESS_MASK_GenericRight"

	.byte 0,0
	.long PInvoke_Kernel32_ACCESS_MASK_op_Implicit_PInvoke_Kernel32_ACCESS_MASK_GenericRight
	.long Lme_40

	.byte 2,118,16,3
	.asciz "value"

LDIFF_SYM377=LTDIE_23 - Ldebug_info_start
	.long LDIFF_SYM377
	.byte 2,125,12,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM378=Lfde43_end - Lfde43_start
	.long LDIFF_SYM378
Lfde43_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_ACCESS_MASK_op_Implicit_PInvoke_Kernel32_ACCESS_MASK_GenericRight

LDIFF_SYM379=Lme_40 - PInvoke_Kernel32_ACCESS_MASK_op_Implicit_PInvoke_Kernel32_ACCESS_MASK_GenericRight
	.long LDIFF_SYM379
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,32,2,40,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde43_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_24:

	.byte 8
	.asciz "_SpecificRight"

	.byte 4
LDIFF_SYM380=LDIE_U4 - Ldebug_info_start
	.long LDIFF_SYM380
	.byte 9
	.asciz "SPECIFIC_RIGHTS_ALL"

	.byte 255,255,3,0,7
	.asciz "_SpecificRight"

LDIFF_SYM381=LTDIE_24 - Ldebug_info_start
	.long LDIFF_SYM381
LTDIE_24_POINTER:

	.byte 13
LDIFF_SYM382=LTDIE_24 - Ldebug_info_start
	.long LDIFF_SYM382
LTDIE_24_REFERENCE:

	.byte 14
LDIFF_SYM383=LTDIE_24 - Ldebug_info_start
	.long LDIFF_SYM383
	.byte 2
	.asciz "PInvoke.Kernel32/ACCESS_MASK:op_Implicit"
	.asciz "PInvoke_Kernel32_ACCESS_MASK_op_Implicit_PInvoke_Kernel32_ACCESS_MASK_SpecificRight"

	.byte 0,0
	.long PInvoke_Kernel32_ACCESS_MASK_op_Implicit_PInvoke_Kernel32_ACCESS_MASK_SpecificRight
	.long Lme_41

	.byte 2,118,16,3
	.asciz "value"

LDIFF_SYM384=LTDIE_24 - Ldebug_info_start
	.long LDIFF_SYM384
	.byte 2,125,12,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM385=Lfde44_end - Lfde44_start
	.long LDIFF_SYM385
Lfde44_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_ACCESS_MASK_op_Implicit_PInvoke_Kernel32_ACCESS_MASK_SpecificRight

LDIFF_SYM386=Lme_41 - PInvoke_Kernel32_ACCESS_MASK_op_Implicit_PInvoke_Kernel32_ACCESS_MASK_SpecificRight
	.long LDIFF_SYM386
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,32,2,40,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde44_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32/ACCESS_MASK:GetHashCode"
	.asciz "PInvoke_Kernel32_ACCESS_MASK_GetHashCode"

	.byte 0,0
	.long PInvoke_Kernel32_ACCESS_MASK_GetHashCode
	.long Lme_42

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM387=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM387
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM388=Lfde45_end - Lfde45_start
	.long LDIFF_SYM388
Lfde45_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_ACCESS_MASK_GetHashCode

LDIFF_SYM389=Lme_42 - PInvoke_Kernel32_ACCESS_MASK_GetHashCode
	.long LDIFF_SYM389
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,76,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde45_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32/ACCESS_MASK:Equals"
	.asciz "PInvoke_Kernel32_ACCESS_MASK_Equals_PInvoke_Kernel32_ACCESS_MASK"

	.byte 0,0
	.long PInvoke_Kernel32_ACCESS_MASK_Equals_PInvoke_Kernel32_ACCESS_MASK
	.long Lme_43

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM390=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM390
	.byte 2,123,0,3
	.asciz "other"

LDIFF_SYM391=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM391
	.byte 2,123,4,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM392=Lfde46_end - Lfde46_start
	.long LDIFF_SYM392
Lfde46_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_ACCESS_MASK_Equals_PInvoke_Kernel32_ACCESS_MASK

LDIFF_SYM393=Lme_43 - PInvoke_Kernel32_ACCESS_MASK_Equals_PInvoke_Kernel32_ACCESS_MASK
	.long LDIFF_SYM393
	.byte 68,14,8,135,2,72,14,16,136,4,139,3,142,1,68,14,24,68,13,11,2,32,10,68,13,13,14,16,68,8,8,8
	.byte 11,14,8,68,11
	.align 2
Lfde46_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32/ACCESS_MASK:Equals"
	.asciz "PInvoke_Kernel32_ACCESS_MASK_Equals_object"

	.byte 0,0
	.long PInvoke_Kernel32_ACCESS_MASK_Equals_object
	.long Lme_44

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM394=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM394
	.byte 2,125,8,3
	.asciz "obj"

LDIFF_SYM395=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM395
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM396=Lfde47_end - Lfde47_start
	.long LDIFF_SYM396
Lfde47_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_ACCESS_MASK_Equals_object

LDIFF_SYM397=Lme_44 - PInvoke_Kernel32_ACCESS_MASK_Equals_object
	.long LDIFF_SYM397
	.byte 68,14,8,135,2,72,14,20,133,5,136,4,138,3,142,1,68,14,40,2,168,10,68,14,20,68,8,5,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde47_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32/ACCESS_MASK:CompareTo"
	.asciz "PInvoke_Kernel32_ACCESS_MASK_CompareTo_object"

	.byte 0,0
	.long PInvoke_Kernel32_ACCESS_MASK_CompareTo_object
	.long Lme_45

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM398=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM398
	.byte 2,125,0,3
	.asciz "obj"

LDIFF_SYM399=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM399
	.byte 2,125,4,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM400=Lfde48_end - Lfde48_start
	.long LDIFF_SYM400
Lfde48_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_ACCESS_MASK_CompareTo_object

LDIFF_SYM401=Lme_45 - PInvoke_Kernel32_ACCESS_MASK_CompareTo_object
	.long LDIFF_SYM401
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,32,2,92,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde48_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32/ACCESS_MASK:CompareTo"
	.asciz "PInvoke_Kernel32_ACCESS_MASK_CompareTo_PInvoke_Kernel32_ACCESS_MASK"

	.byte 0,0
	.long PInvoke_Kernel32_ACCESS_MASK_CompareTo_PInvoke_Kernel32_ACCESS_MASK
	.long Lme_46

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM402=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM402
	.byte 1,90,3
	.asciz "other"

LDIFF_SYM403=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM403
	.byte 2,123,4,11
	.asciz "V_0"

LDIFF_SYM404=LDIE_U4 - Ldebug_info_start
	.long LDIFF_SYM404
	.byte 2,123,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM405=Lfde49_end - Lfde49_start
	.long LDIFF_SYM405
Lfde49_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_ACCESS_MASK_CompareTo_PInvoke_Kernel32_ACCESS_MASK

LDIFF_SYM406=Lme_46 - PInvoke_Kernel32_ACCESS_MASK_CompareTo_PInvoke_Kernel32_ACCESS_MASK
	.long LDIFF_SYM406
	.byte 68,14,8,135,2,72,14,24,134,6,136,5,138,4,139,3,142,1,68,14,32,68,13,11,2,84,10,68,13,13,14,24
	.byte 68,8,6,8,8,8,10,8,11,14,8,68,11
	.align 2
Lfde49_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32/ACCESS_MASK:ToString"
	.asciz "PInvoke_Kernel32_ACCESS_MASK_ToString"

	.byte 0,0
	.long PInvoke_Kernel32_ACCESS_MASK_ToString
	.long Lme_47

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM407=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM407
	.byte 2,125,4,11
	.asciz "V_0"

LDIFF_SYM408=LDIE_U4 - Ldebug_info_start
	.long LDIFF_SYM408
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM409=Lfde50_end - Lfde50_start
	.long LDIFF_SYM409
Lfde50_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_ACCESS_MASK_ToString

LDIFF_SYM410=Lme_47 - PInvoke_Kernel32_ACCESS_MASK_ToString
	.long LDIFF_SYM410
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,2,32,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde50_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_25:

	.byte 17
	.asciz "System_IFormatProvider"

	.byte 8,7
	.asciz "System_IFormatProvider"

LDIFF_SYM411=LTDIE_25 - Ldebug_info_start
	.long LDIFF_SYM411
LTDIE_25_POINTER:

	.byte 13
LDIFF_SYM412=LTDIE_25 - Ldebug_info_start
	.long LDIFF_SYM412
LTDIE_25_REFERENCE:

	.byte 14
LDIFF_SYM413=LTDIE_25 - Ldebug_info_start
	.long LDIFF_SYM413
	.byte 2
	.asciz "PInvoke.Kernel32/ACCESS_MASK:ToString"
	.asciz "PInvoke_Kernel32_ACCESS_MASK_ToString_string_System_IFormatProvider"

	.byte 0,0
	.long PInvoke_Kernel32_ACCESS_MASK_ToString_string_System_IFormatProvider
	.long Lme_48

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM414=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM414
	.byte 2,125,4,3
	.asciz "format"

LDIFF_SYM415=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM415
	.byte 2,125,8,3
	.asciz "formatProvider"

LDIFF_SYM416=LTDIE_25_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM416
	.byte 2,125,12,11
	.asciz "V_0"

LDIFF_SYM417=LDIE_U4 - Ldebug_info_start
	.long LDIFF_SYM417
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM418=Lfde51_end - Lfde51_start
	.long LDIFF_SYM418
Lfde51_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_ACCESS_MASK_ToString_string_System_IFormatProvider

LDIFF_SYM419=Lme_48 - PInvoke_Kernel32_ACCESS_MASK_ToString_string_System_IFormatProvider
	.long LDIFF_SYM419
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,32,2,48,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde51_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_26:

	.byte 5
	.asciz "_SafeFindFilesHandle"

	.byte 20,16
LDIFF_SYM420=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM420
	.byte 2,35,0,0,7
	.asciz "_SafeFindFilesHandle"

LDIFF_SYM421=LTDIE_26 - Ldebug_info_start
	.long LDIFF_SYM421
LTDIE_26_POINTER:

	.byte 13
LDIFF_SYM422=LTDIE_26 - Ldebug_info_start
	.long LDIFF_SYM422
LTDIE_26_REFERENCE:

	.byte 14
LDIFF_SYM423=LTDIE_26 - Ldebug_info_start
	.long LDIFF_SYM423
	.byte 2
	.asciz "PInvoke.Kernel32/SafeFindFilesHandle:.ctor"
	.asciz "PInvoke_Kernel32_SafeFindFilesHandle__ctor"

	.byte 0,0
	.long PInvoke_Kernel32_SafeFindFilesHandle__ctor
	.long Lme_49

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM424=LTDIE_26_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM424
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM425=Lfde52_end - Lfde52_start
	.long LDIFF_SYM425
Lfde52_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_SafeFindFilesHandle__ctor

LDIFF_SYM426=Lme_49 - PInvoke_Kernel32_SafeFindFilesHandle__ctor
	.long LDIFF_SYM426
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,2,36,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde52_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32/SafeFindFilesHandle:.ctor"
	.asciz "PInvoke_Kernel32_SafeFindFilesHandle__ctor_intptr_bool"

	.byte 0,0
	.long PInvoke_Kernel32_SafeFindFilesHandle__ctor_intptr_bool
	.long Lme_4a

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM427=LTDIE_26_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM427
	.byte 2,125,0,3
	.asciz "preexistingHandle"

LDIFF_SYM428=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM428
	.byte 2,125,4,3
	.asciz "ownsHandle"

LDIFF_SYM429=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM429
	.byte 2,125,8,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM430=Lfde53_end - Lfde53_start
	.long LDIFF_SYM430
Lfde53_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_SafeFindFilesHandle__ctor_intptr_bool

LDIFF_SYM431=Lme_4a - PInvoke_Kernel32_SafeFindFilesHandle__ctor_intptr_bool
	.long LDIFF_SYM431
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,32,2,56,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde53_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32/SafeFindFilesHandle:get_IsInvalid"
	.asciz "PInvoke_Kernel32_SafeFindFilesHandle_get_IsInvalid"

	.byte 0,0
	.long PInvoke_Kernel32_SafeFindFilesHandle_get_IsInvalid
	.long Lme_4b

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM432=LTDIE_26_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM432
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM433=Lfde54_end - Lfde54_start
	.long LDIFF_SYM433
Lfde54_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_SafeFindFilesHandle_get_IsInvalid

LDIFF_SYM434=Lme_4b - PInvoke_Kernel32_SafeFindFilesHandle_get_IsInvalid
	.long LDIFF_SYM434
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,2,44,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde54_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32/SafeFindFilesHandle:ReleaseHandle"
	.asciz "PInvoke_Kernel32_SafeFindFilesHandle_ReleaseHandle"

	.byte 0,0
	.long PInvoke_Kernel32_SafeFindFilesHandle_ReleaseHandle
	.long Lme_4c

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM435=LTDIE_26_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM435
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM436=Lfde55_end - Lfde55_start
	.long LDIFF_SYM436
Lfde55_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_SafeFindFilesHandle_ReleaseHandle

LDIFF_SYM437=Lme_4c - PInvoke_Kernel32_SafeFindFilesHandle_ReleaseHandle
	.long LDIFF_SYM437
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,84,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde55_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32/SafeFindFilesHandle:.cctor"
	.asciz "PInvoke_Kernel32_SafeFindFilesHandle__cctor"

	.byte 0,0
	.long PInvoke_Kernel32_SafeFindFilesHandle__cctor
	.long Lme_4d

	.byte 2,118,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM438=Lfde56_end - Lfde56_start
	.long LDIFF_SYM438
Lfde56_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_SafeFindFilesHandle__cctor

LDIFF_SYM439=Lme_4d - PInvoke_Kernel32_SafeFindFilesHandle__cctor
	.long LDIFF_SYM439
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,2,52,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde56_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_27:

	.byte 5
	.asciz "_SafeLibraryHandle"

	.byte 20,16
LDIFF_SYM440=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM440
	.byte 2,35,0,0,7
	.asciz "_SafeLibraryHandle"

LDIFF_SYM441=LTDIE_27 - Ldebug_info_start
	.long LDIFF_SYM441
LTDIE_27_POINTER:

	.byte 13
LDIFF_SYM442=LTDIE_27 - Ldebug_info_start
	.long LDIFF_SYM442
LTDIE_27_REFERENCE:

	.byte 14
LDIFF_SYM443=LTDIE_27 - Ldebug_info_start
	.long LDIFF_SYM443
	.byte 2
	.asciz "PInvoke.Kernel32/SafeLibraryHandle:.ctor"
	.asciz "PInvoke_Kernel32_SafeLibraryHandle__ctor"

	.byte 0,0
	.long PInvoke_Kernel32_SafeLibraryHandle__ctor
	.long Lme_4e

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM444=LTDIE_27_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM444
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM445=Lfde57_end - Lfde57_start
	.long LDIFF_SYM445
Lfde57_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_SafeLibraryHandle__ctor

LDIFF_SYM446=Lme_4e - PInvoke_Kernel32_SafeLibraryHandle__ctor
	.long LDIFF_SYM446
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,2,36,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde57_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32/SafeLibraryHandle:.ctor"
	.asciz "PInvoke_Kernel32_SafeLibraryHandle__ctor_intptr_bool"

	.byte 0,0
	.long PInvoke_Kernel32_SafeLibraryHandle__ctor_intptr_bool
	.long Lme_4f

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM447=LTDIE_27_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM447
	.byte 2,125,0,3
	.asciz "preexistingHandle"

LDIFF_SYM448=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM448
	.byte 2,125,4,3
	.asciz "ownsHandle"

LDIFF_SYM449=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM449
	.byte 2,125,8,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM450=Lfde58_end - Lfde58_start
	.long LDIFF_SYM450
Lfde58_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_SafeLibraryHandle__ctor_intptr_bool

LDIFF_SYM451=Lme_4f - PInvoke_Kernel32_SafeLibraryHandle__ctor_intptr_bool
	.long LDIFF_SYM451
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,32,2,56,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde58_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32/SafeLibraryHandle:get_IsInvalid"
	.asciz "PInvoke_Kernel32_SafeLibraryHandle_get_IsInvalid"

	.byte 0,0
	.long PInvoke_Kernel32_SafeLibraryHandle_get_IsInvalid
	.long Lme_50

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM452=LTDIE_27_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM452
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM453=Lfde59_end - Lfde59_start
	.long LDIFF_SYM453
Lfde59_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_SafeLibraryHandle_get_IsInvalid

LDIFF_SYM454=Lme_50 - PInvoke_Kernel32_SafeLibraryHandle_get_IsInvalid
	.long LDIFF_SYM454
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,2,100,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde59_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32/SafeLibraryHandle:ReleaseHandle"
	.asciz "PInvoke_Kernel32_SafeLibraryHandle_ReleaseHandle"

	.byte 0,0
	.long PInvoke_Kernel32_SafeLibraryHandle_ReleaseHandle
	.long Lme_51

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM455=LTDIE_27_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM455
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM456=Lfde60_end - Lfde60_start
	.long LDIFF_SYM456
Lfde60_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_SafeLibraryHandle_ReleaseHandle

LDIFF_SYM457=Lme_51 - PInvoke_Kernel32_SafeLibraryHandle_ReleaseHandle
	.long LDIFF_SYM457
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,84,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde60_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32/SafeLibraryHandle:.cctor"
	.asciz "PInvoke_Kernel32_SafeLibraryHandle__cctor"

	.byte 0,0
	.long PInvoke_Kernel32_SafeLibraryHandle__cctor
	.long Lme_52

	.byte 2,118,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM458=Lfde61_end - Lfde61_start
	.long LDIFF_SYM458
Lfde61_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_SafeLibraryHandle__cctor

LDIFF_SYM459=Lme_52 - PInvoke_Kernel32_SafeLibraryHandle__cctor
	.long LDIFF_SYM459
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,32,2,136,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde61_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32/SafeObjectHandle:.ctor"
	.asciz "PInvoke_Kernel32_SafeObjectHandle__ctor"

	.byte 0,0
	.long PInvoke_Kernel32_SafeObjectHandle__ctor
	.long Lme_53

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM460=LTDIE_6_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM460
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM461=Lfde62_end - Lfde62_start
	.long LDIFF_SYM461
Lfde62_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_SafeObjectHandle__ctor

LDIFF_SYM462=Lme_53 - PInvoke_Kernel32_SafeObjectHandle__ctor
	.long LDIFF_SYM462
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,2,36,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde62_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32/SafeObjectHandle:.ctor"
	.asciz "PInvoke_Kernel32_SafeObjectHandle__ctor_intptr_bool"

	.byte 0,0
	.long PInvoke_Kernel32_SafeObjectHandle__ctor_intptr_bool
	.long Lme_54

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM463=LTDIE_6_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM463
	.byte 2,125,0,3
	.asciz "preexistingHandle"

LDIFF_SYM464=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM464
	.byte 2,125,4,3
	.asciz "ownsHandle"

LDIFF_SYM465=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM465
	.byte 2,125,8,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM466=Lfde63_end - Lfde63_start
	.long LDIFF_SYM466
Lfde63_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_SafeObjectHandle__ctor_intptr_bool

LDIFF_SYM467=Lme_54 - PInvoke_Kernel32_SafeObjectHandle__ctor_intptr_bool
	.long LDIFF_SYM467
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,32,2,56,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde63_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32/SafeObjectHandle:get_IsInvalid"
	.asciz "PInvoke_Kernel32_SafeObjectHandle_get_IsInvalid"

	.byte 0,0
	.long PInvoke_Kernel32_SafeObjectHandle_get_IsInvalid
	.long Lme_55

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM468=LTDIE_6_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM468
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM469=Lfde64_end - Lfde64_start
	.long LDIFF_SYM469
Lfde64_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_SafeObjectHandle_get_IsInvalid

LDIFF_SYM470=Lme_55 - PInvoke_Kernel32_SafeObjectHandle_get_IsInvalid
	.long LDIFF_SYM470
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,2,100,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde64_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32/SafeObjectHandle:ReleaseHandle"
	.asciz "PInvoke_Kernel32_SafeObjectHandle_ReleaseHandle"

	.byte 0,0
	.long PInvoke_Kernel32_SafeObjectHandle_ReleaseHandle
	.long Lme_56

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM471=LTDIE_6_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM471
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM472=Lfde65_end - Lfde65_start
	.long LDIFF_SYM472
Lfde65_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_SafeObjectHandle_ReleaseHandle

LDIFF_SYM473=Lme_56 - PInvoke_Kernel32_SafeObjectHandle_ReleaseHandle
	.long LDIFF_SYM473
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,84,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde65_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32/SafeObjectHandle:.cctor"
	.asciz "PInvoke_Kernel32_SafeObjectHandle__cctor"

	.byte 0,0
	.long PInvoke_Kernel32_SafeObjectHandle__cctor
	.long Lme_57

	.byte 2,118,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM474=Lfde66_end - Lfde66_start
	.long LDIFF_SYM474
Lfde66_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_SafeObjectHandle__cctor

LDIFF_SYM475=Lme_57 - PInvoke_Kernel32_SafeObjectHandle__cctor
	.long LDIFF_SYM475
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,32,2,136,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde66_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_28:

	.byte 5
	.asciz "_SECURITY_ATTRIBUTES"

	.byte 20,16
LDIFF_SYM476=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM476
	.byte 2,35,0,6
	.asciz "nLength"

LDIFF_SYM477=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM477
	.byte 2,35,0,6
	.asciz "lpSecurityDescriptor"

LDIFF_SYM478=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM478
	.byte 2,35,4,6
	.asciz "bInheritHandle"

LDIFF_SYM479=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM479
	.byte 2,35,8,0,7
	.asciz "_SECURITY_ATTRIBUTES"

LDIFF_SYM480=LTDIE_28 - Ldebug_info_start
	.long LDIFF_SYM480
LTDIE_28_POINTER:

	.byte 13
LDIFF_SYM481=LTDIE_28 - Ldebug_info_start
	.long LDIFF_SYM481
LTDIE_28_REFERENCE:

	.byte 14
LDIFF_SYM482=LTDIE_28 - Ldebug_info_start
	.long LDIFF_SYM482
	.byte 2
	.asciz "PInvoke.Kernel32/SECURITY_ATTRIBUTES:get_InheritHandle"
	.asciz "PInvoke_Kernel32_SECURITY_ATTRIBUTES_get_InheritHandle"

	.byte 0,0
	.long PInvoke_Kernel32_SECURITY_ATTRIBUTES_get_InheritHandle
	.long Lme_58

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM483=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM483
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM484=Lfde67_end - Lfde67_start
	.long LDIFF_SYM484
Lfde67_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_SECURITY_ATTRIBUTES_get_InheritHandle

LDIFF_SYM485=Lme_58 - PInvoke_Kernel32_SECURITY_ATTRIBUTES_get_InheritHandle
	.long LDIFF_SYM485
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,88,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde67_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32/SECURITY_ATTRIBUTES:Create"
	.asciz "PInvoke_Kernel32_SECURITY_ATTRIBUTES_Create"

	.byte 0,0
	.long PInvoke_Kernel32_SECURITY_ATTRIBUTES_Create
	.long Lme_59

	.byte 2,118,16,11
	.asciz "V_0"

LDIFF_SYM486=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM486
	.byte 2,125,4,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM487=Lfde68_end - Lfde68_start
	.long LDIFF_SYM487
Lfde68_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32_SECURITY_ATTRIBUTES_Create

LDIFF_SYM488=Lme_59 - PInvoke_Kernel32_SECURITY_ATTRIBUTES_Create
	.long LDIFF_SYM488
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,48,2,124,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde68_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_29:

	.byte 8
	.asciz "PInvoke_Win32ErrorCode"

	.byte 4
LDIFF_SYM489=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM489
	.byte 9
	.asciz "ERROR_SUCCESS"

	.byte 0,9
	.asciz "ERROR_INVALID_FUNCTION"

	.byte 1,9
	.asciz "ERROR_FILE_NOT_FOUND"

	.byte 2,9
	.asciz "ERROR_PATH_NOT_FOUND"

	.byte 3,9
	.asciz "ERROR_TOO_MANY_OPEN_FILES"

	.byte 4,9
	.asciz "ERROR_ACCESS_DENIED"

	.byte 5,9
	.asciz "ERROR_INVALID_HANDLE"

	.byte 6,9
	.asciz "ERROR_ARENA_TRASHED"

	.byte 7,9
	.asciz "ERROR_NOT_ENOUGH_MEMORY"

	.byte 8,9
	.asciz "ERROR_INVALID_BLOCK"

	.byte 9,9
	.asciz "ERROR_BAD_ENVIRONMENT"

	.byte 10,9
	.asciz "ERROR_BAD_FORMAT"

	.byte 11,9
	.asciz "ERROR_INVALID_ACCESS"

	.byte 12,9
	.asciz "ERROR_INVALID_DATA"

	.byte 13,9
	.asciz "ERROR_OUTOFMEMORY"

	.byte 14,9
	.asciz "ERROR_INVALID_DRIVE"

	.byte 15,9
	.asciz "ERROR_CURRENT_DIRECTORY"

	.byte 16,9
	.asciz "ERROR_NOT_SAME_DEVICE"

	.byte 17,9
	.asciz "ERROR_NO_MORE_FILES"

	.byte 18,9
	.asciz "ERROR_WRITE_PROTECT"

	.byte 19,9
	.asciz "ERROR_BAD_UNIT"

	.byte 20,9
	.asciz "ERROR_NOT_READY"

	.byte 21,9
	.asciz "ERROR_BAD_COMMAND"

	.byte 22,9
	.asciz "ERROR_CRC"

	.byte 23,9
	.asciz "ERROR_BAD_LENGTH"

	.byte 24,9
	.asciz "ERROR_SEEK"

	.byte 25,9
	.asciz "ERROR_NOT_DOS_DISK"

	.byte 26,9
	.asciz "ERROR_SECTOR_NOT_FOUND"

	.byte 27,9
	.asciz "ERROR_OUT_OF_PAPER"

	.byte 28,9
	.asciz "ERROR_WRITE_FAULT"

	.byte 29,9
	.asciz "ERROR_READ_FAULT"

	.byte 30,9
	.asciz "ERROR_GEN_FAILURE"

	.byte 31,9
	.asciz "ERROR_SHARING_VIOLATION"

	.byte 32,9
	.asciz "ERROR_LOCK_VIOLATION"

	.byte 33,9
	.asciz "ERROR_WRONG_DISK"

	.byte 34,9
	.asciz "ERROR_SHARING_BUFFER_EXCEEDED"

	.byte 36,9
	.asciz "ERROR_HANDLE_EOF"

	.byte 38,9
	.asciz "ERROR_HANDLE_DISK_FULL"

	.byte 39,9
	.asciz "ERROR_NOT_SUPPORTED"

	.byte 50,9
	.asciz "ERROR_REM_NOT_LIST"

	.byte 51,9
	.asciz "ERROR_DUP_NAME"

	.byte 52,9
	.asciz "ERROR_BAD_NETPATH"

	.byte 53,9
	.asciz "ERROR_NETWORK_BUSY"

	.byte 54,9
	.asciz "ERROR_DEV_NOT_EXIST"

	.byte 55,9
	.asciz "ERROR_TOO_MANY_CMDS"

	.byte 56,9
	.asciz "ERROR_ADAP_HDW_ERR"

	.byte 57,9
	.asciz "ERROR_BAD_NET_RESP"

	.byte 58,9
	.asciz "ERROR_UNEXP_NET_ERR"

	.byte 59,9
	.asciz "ERROR_BAD_REM_ADAP"

	.byte 60,9
	.asciz "ERROR_PRINTQ_FULL"

	.byte 61,9
	.asciz "ERROR_NO_SPOOL_SPACE"

	.byte 62,9
	.asciz "ERROR_PRINT_CANCELLED"

	.byte 63,9
	.asciz "ERROR_NETNAME_DELETED"

	.byte 192,0,9
	.asciz "ERROR_NETWORK_ACCESS_DENIED"

	.byte 193,0,9
	.asciz "ERROR_BAD_DEV_TYPE"

	.byte 194,0,9
	.asciz "ERROR_BAD_NET_NAME"

	.byte 195,0,9
	.asciz "ERROR_TOO_MANY_NAMES"

	.byte 196,0,9
	.asciz "ERROR_TOO_MANY_SESS"

	.byte 197,0,9
	.asciz "ERROR_SHARING_PAUSED"

	.byte 198,0,9
	.asciz "ERROR_REQ_NOT_ACCEP"

	.byte 199,0,9
	.asciz "ERROR_REDIR_PAUSED"

	.byte 200,0,9
	.asciz "ERROR_FILE_EXISTS"

	.byte 208,0,9
	.asciz "ERROR_CANNOT_MAKE"

	.byte 210,0,9
	.asciz "ERROR_FAIL_I24"

	.byte 211,0,9
	.asciz "ERROR_OUT_OF_STRUCTURES"

	.byte 212,0,9
	.asciz "ERROR_ALREADY_ASSIGNED"

	.byte 213,0,9
	.asciz "ERROR_INVALID_PASSWORD"

	.byte 214,0,9
	.asciz "ERROR_INVALID_PARAMETER"

	.byte 215,0,9
	.asciz "ERROR_NET_WRITE_FAULT"

	.byte 216,0,9
	.asciz "ERROR_NO_PROC_SLOTS"

	.byte 217,0,9
	.asciz "ERROR_TOO_MANY_SEMAPHORES"

	.byte 228,0,9
	.asciz "ERROR_EXCL_SEM_ALREADY_OWNED"

	.byte 229,0,9
	.asciz "ERROR_SEM_IS_SET"

	.byte 230,0,9
	.asciz "ERROR_TOO_MANY_SEM_REQUESTS"

	.byte 231,0,9
	.asciz "ERROR_INVALID_AT_INTERRUPT_TIME"

	.byte 232,0,9
	.asciz "ERROR_SEM_OWNER_DIED"

	.byte 233,0,9
	.asciz "ERROR_SEM_USER_LIMIT"

	.byte 234,0,9
	.asciz "ERROR_DISK_CHANGE"

	.byte 235,0,9
	.asciz "ERROR_DRIVE_LOCKED"

	.byte 236,0,9
	.asciz "ERROR_BROKEN_PIPE"

	.byte 237,0,9
	.asciz "ERROR_OPEN_FAILED"

	.byte 238,0,9
	.asciz "ERROR_BUFFER_OVERFLOW"

	.byte 239,0,9
	.asciz "ERROR_DISK_FULL"

	.byte 240,0,9
	.asciz "ERROR_NO_MORE_SEARCH_HANDLES"

	.byte 241,0,9
	.asciz "ERROR_INVALID_TARGET_HANDLE"

	.byte 242,0,9
	.asciz "ERROR_INVALID_CATEGORY"

	.byte 245,0,9
	.asciz "ERROR_INVALID_VERIFY_SWITCH"

	.byte 246,0,9
	.asciz "ERROR_BAD_DRIVER_LEVEL"

	.byte 247,0,9
	.asciz "ERROR_CALL_NOT_IMPLEMENTED"

	.byte 248,0,9
	.asciz "ERROR_SEM_TIMEOUT"

	.byte 249,0,9
	.asciz "ERROR_INSUFFICIENT_BUFFER"

	.byte 250,0,9
	.asciz "ERROR_INVALID_NAME"

	.byte 251,0,9
	.asciz "ERROR_INVALID_LEVEL"

	.byte 252,0,9
	.asciz "ERROR_NO_VOLUME_LABEL"

	.byte 253,0,9
	.asciz "ERROR_MOD_NOT_FOUND"

	.byte 254,0,9
	.asciz "ERROR_PROC_NOT_FOUND"

	.byte 255,0,9
	.asciz "ERROR_WAIT_NO_CHILDREN"

	.byte 128,1,9
	.asciz "ERROR_CHILD_NOT_COMPLETE"

	.byte 129,1,9
	.asciz "ERROR_DIRECT_ACCESS_HANDLE"

	.byte 130,1,9
	.asciz "ERROR_NEGATIVE_SEEK"

	.byte 131,1,9
	.asciz "ERROR_SEEK_ON_DEVICE"

	.byte 132,1,9
	.asciz "ERROR_IS_JOIN_TARGET"

	.byte 133,1,9
	.asciz "ERROR_IS_JOINED"

	.byte 134,1,9
	.asciz "ERROR_IS_SUBSTED"

	.byte 135,1,9
	.asciz "ERROR_NOT_JOINED"

	.byte 136,1,9
	.asciz "ERROR_NOT_SUBSTED"

	.byte 137,1,9
	.asciz "ERROR_JOIN_TO_JOIN"

	.byte 138,1,9
	.asciz "ERROR_SUBST_TO_SUBST"

	.byte 139,1,9
	.asciz "ERROR_JOIN_TO_SUBST"

	.byte 140,1,9
	.asciz "ERROR_SUBST_TO_JOIN"

	.byte 141,1,9
	.asciz "ERROR_BUSY_DRIVE"

	.byte 142,1,9
	.asciz "ERROR_SAME_DRIVE"

	.byte 143,1,9
	.asciz "ERROR_DIR_NOT_ROOT"

	.byte 144,1,9
	.asciz "ERROR_DIR_NOT_EMPTY"

	.byte 145,1,9
	.asciz "ERROR_IS_SUBST_PATH"

	.byte 146,1,9
	.asciz "ERROR_IS_JOIN_PATH"

	.byte 147,1,9
	.asciz "ERROR_PATH_BUSY"

	.byte 148,1,9
	.asciz "ERROR_IS_SUBST_TARGET"

	.byte 149,1,9
	.asciz "ERROR_SYSTEM_TRACE"

	.byte 150,1,9
	.asciz "ERROR_INVALID_EVENT_COUNT"

	.byte 151,1,9
	.asciz "ERROR_TOO_MANY_MUXWAITERS"

	.byte 152,1,9
	.asciz "ERROR_INVALID_LIST_FORMAT"

	.byte 153,1,9
	.asciz "ERROR_LABEL_TOO_LONG"

	.byte 154,1,9
	.asciz "ERROR_TOO_MANY_TCBS"

	.byte 155,1,9
	.asciz "ERROR_SIGNAL_REFUSED"

	.byte 156,1,9
	.asciz "ERROR_DISCARDED"

	.byte 157,1,9
	.asciz "ERROR_NOT_LOCKED"

	.byte 158,1,9
	.asciz "ERROR_BAD_THREADID_ADDR"

	.byte 159,1,9
	.asciz "ERROR_BAD_ARGUMENTS"

	.byte 160,1,9
	.asciz "ERROR_BAD_PATHNAME"

	.byte 161,1,9
	.asciz "ERROR_SIGNAL_PENDING"

	.byte 162,1,9
	.asciz "ERROR_MAX_THRDS_REACHED"

	.byte 164,1,9
	.asciz "ERROR_LOCK_FAILED"

	.byte 167,1,9
	.asciz "ERROR_BUSY"

	.byte 170,1,9
	.asciz "ERROR_CANCEL_VIOLATION"

	.byte 173,1,9
	.asciz "ERROR_INVALID_SEGMENT_NUMBER"

	.byte 180,1,9
	.asciz "ERROR_INVALID_ORDINAL"

	.byte 182,1,9
	.asciz "ERROR_ALREADY_EXISTS"

	.byte 183,1,9
	.asciz "ERROR_INVALID_FLAG_NUMBER"

	.byte 186,1,9
	.asciz "ERROR_SEM_NOT_FOUND"

	.byte 187,1,9
	.asciz "ERROR_INVALID_STARTING_CODESEG"

	.byte 188,1,9
	.asciz "ERROR_INVALID_STACKSEG"

	.byte 189,1,9
	.asciz "ERROR_INVALID_MODULETYPE"

	.byte 190,1,9
	.asciz "ERROR_INVALID_EXE_SIGNATURE"

	.byte 191,1,9
	.asciz "ERROR_EXE_MARKED_INVALID"

	.byte 192,1,9
	.asciz "ERROR_BAD_EXE_FORMAT"

	.byte 193,1,9
	.asciz "ERROR_ITERATED_DATA_EXCEEDS_64k"

	.byte 194,1,9
	.asciz "ERROR_INVALID_MINALLOCSIZE"

	.byte 195,1,9
	.asciz "ERROR_DYNLINK_FROM_INVALID_RING"

	.byte 196,1,9
	.asciz "ERROR_IOPL_NOT_ENABLED"

	.byte 197,1,9
	.asciz "ERROR_INVALID_SEGDPL"

	.byte 198,1,9
	.asciz "ERROR_AUTODATASEG_EXCEEDS_64k"

	.byte 199,1,9
	.asciz "ERROR_RING2SEG_MUST_BE_MOVABLE"

	.byte 200,1,9
	.asciz "ERROR_RELOC_CHAIN_XEEDS_SEGLIM"

	.byte 201,1,9
	.asciz "ERROR_INFLOOP_IN_RELOC_CHAIN"

	.byte 202,1,9
	.asciz "ERROR_ENVVAR_NOT_FOUND"

	.byte 203,1,9
	.asciz "ERROR_NO_SIGNAL_SENT"

	.byte 205,1,9
	.asciz "ERROR_FILENAME_EXCED_RANGE"

	.byte 206,1,9
	.asciz "ERROR_RING2_STACK_IN_USE"

	.byte 207,1,9
	.asciz "ERROR_META_EXPANSION_TOO_LONG"

	.byte 208,1,9
	.asciz "ERROR_INVALID_SIGNAL_NUMBER"

	.byte 209,1,9
	.asciz "ERROR_THREAD_1_INACTIVE"

	.byte 210,1,9
	.asciz "ERROR_LOCKED"

	.byte 212,1,9
	.asciz "ERROR_TOO_MANY_MODULES"

	.byte 214,1,9
	.asciz "ERROR_NESTING_NOT_ALLOWED"

	.byte 215,1,9
	.asciz "ERROR_EXE_MACHINE_TYPE_MISMATCH"

	.byte 216,1,9
	.asciz "ERROR_FILE_CHECKED_OUT"

	.byte 220,1,9
	.asciz "ERROR_CHECKOUT_REQUIRED"

	.byte 221,1,9
	.asciz "ERROR_BAD_FILE_TYPE"

	.byte 222,1,9
	.asciz "ERROR_FILE_TOO_LARGE"

	.byte 223,1,9
	.asciz "ERROR_FORMS_AUTH_REQUIRED"

	.byte 224,1,9
	.asciz "ERROR_VIRUS_INFECTED"

	.byte 225,1,9
	.asciz "ERROR_VIRUS_DELETED"

	.byte 226,1,9
	.asciz "ERROR_PIPE_LOCAL"

	.byte 229,1,9
	.asciz "ERROR_BAD_PIPE"

	.byte 230,1,9
	.asciz "ERROR_PIPE_BUSY"

	.byte 231,1,9
	.asciz "ERROR_NO_DATA"

	.byte 232,1,9
	.asciz "ERROR_PIPE_NOT_CONNECTED"

	.byte 233,1,9
	.asciz "ERROR_MORE_DATA"

	.byte 234,1,9
	.asciz "ERROR_VC_DISCONNECTED"

	.byte 240,1,9
	.asciz "ERROR_INVALID_EA_NAME"

	.byte 254,1,9
	.asciz "ERROR_EA_LIST_INCONSISTENT"

	.byte 255,1,9
	.asciz "WAIT_TIMEOUT"

	.byte 130,2,9
	.asciz "ERROR_NO_MORE_ITEMS"

	.byte 131,2,9
	.asciz "ERROR_CANNOT_COPY"

	.byte 138,2,9
	.asciz "ERROR_DIRECTORY"

	.byte 139,2,9
	.asciz "ERROR_EAS_DIDNT_FIT"

	.byte 147,2,9
	.asciz "ERROR_EA_FILE_CORRUPT"

	.byte 148,2,9
	.asciz "ERROR_EA_TABLE_FULL"

	.byte 149,2,9
	.asciz "ERROR_INVALID_EA_HANDLE"

	.byte 150,2,9
	.asciz "ERROR_EAS_NOT_SUPPORTED"

	.byte 154,2,9
	.asciz "ERROR_NOT_OWNER"

	.byte 160,2,9
	.asciz "ERROR_TOO_MANY_POSTS"

	.byte 170,2,9
	.asciz "ERROR_PARTIAL_COPY"

	.byte 171,2,9
	.asciz "ERROR_OPLOCK_NOT_GRANTED"

	.byte 172,2,9
	.asciz "ERROR_INVALID_OPLOCK_PROTOCOL"

	.byte 173,2,9
	.asciz "ERROR_DISK_TOO_FRAGMENTED"

	.byte 174,2,9
	.asciz "ERROR_DELETE_PENDING"

	.byte 175,2,9
	.asciz "ERROR_INVALID_LOCK_RANGE"

	.byte 179,2,9
	.asciz "ERROR_INVALID_EXCEPTION_HANDLER"

	.byte 182,2,9
	.asciz "ERROR_DUPLICATE_PRIVILEGES"

	.byte 183,2,9
	.asciz "ERROR_NO_RANGES_PROCESSED"

	.byte 184,2,9
	.asciz "ERROR_DISK_RESOURCES_EXHAUSTED"

	.byte 186,2,9
	.asciz "ERROR_INVALID_TOKEN"

	.byte 187,2,9
	.asciz "ERROR_MR_MID_NOT_FOUND"

	.byte 189,2,9
	.asciz "ERROR_SCOPE_NOT_FOUND"

	.byte 190,2,9
	.asciz "ERROR_UNDEFINED_SCOPE"

	.byte 191,2,9
	.asciz "ERROR_INVALID_CAP"

	.byte 192,2,9
	.asciz "ERROR_DEVICE_UNREACHABLE"

	.byte 193,2,9
	.asciz "ERROR_DEVICE_NO_RESOURCES"

	.byte 194,2,9
	.asciz "ERROR_DATA_CHECKSUM_ERROR"

	.byte 195,2,9
	.asciz "ERROR_OPERATION_IN_PROGRESS"

	.byte 201,2,9
	.asciz "ERROR_BAD_DEVICE_PATH"

	.byte 202,2,9
	.asciz "ERROR_TOO_MANY_DESCRIPTORS"

	.byte 203,2,9
	.asciz "ERROR_SCRUB_DATA_DISABLED"

	.byte 204,2,9
	.asciz "ERROR_NOT_REDUNDANT_STORAGE"

	.byte 205,2,9
	.asciz "ERROR_DIRECTORY_NOT_SUPPORTED"

	.byte 208,2,9
	.asciz "ERROR_NOT_READ_FROM_COPY"

	.byte 209,2,9
	.asciz "ERROR_FT_WRITE_FAILURE"

	.byte 210,2,9
	.asciz "ERROR_FT_DI_SCAN_REQUIRED"

	.byte 211,2,9
	.asciz "ERROR_INVALID_PEP_INFO_VERSION"

	.byte 213,2,9
	.asciz "ERROR_BLOCK_TOO_MANY_REFERENCES"

	.byte 219,2,9
	.asciz "ERROR_FAIL_NOACTION_REBOOT"

	.byte 222,2,9
	.asciz "ERROR_FAIL_SHUTDOWN"

	.byte 223,2,9
	.asciz "ERROR_FAIL_RESTART"

	.byte 224,2,9
	.asciz "ERROR_MAX_SESSIONS_REACHED"

	.byte 225,2,9
	.asciz "ERROR_DEVICE_HARDWARE_ERROR"

	.byte 227,3,9
	.asciz "ERROR_INVALID_ADDRESS"

	.byte 231,3,9
	.asciz "ERROR_USER_PROFILE_LOAD"

	.byte 244,3,9
	.asciz "ERROR_ARITHMETIC_OVERFLOW"

	.byte 150,4,9
	.asciz "ERROR_PIPE_CONNECTED"

	.byte 151,4,9
	.asciz "ERROR_PIPE_LISTENING"

	.byte 152,4,9
	.asciz "ERROR_VERIFIER_STOP"

	.byte 153,4,9
	.asciz "ERROR_ABIOS_ERROR"

	.byte 154,4,9
	.asciz "ERROR_WX86_WARNING"

	.byte 155,4,9
	.asciz "ERROR_WX86_ERROR"

	.byte 156,4,9
	.asciz "ERROR_TIMER_NOT_CANCELED"

	.byte 157,4,9
	.asciz "ERROR_UNWIND"

	.byte 158,4,9
	.asciz "ERROR_BAD_STACK"

	.byte 159,4,9
	.asciz "ERROR_INVALID_UNWIND_TARGET"

	.byte 160,4,9
	.asciz "ERROR_INVALID_PORT_ATTRIBUTES"

	.byte 161,4,9
	.asciz "ERROR_PORT_MESSAGE_TOO_LONG"

	.byte 162,4,9
	.asciz "ERROR_INVALID_QUOTA_LOWER"

	.byte 163,4,9
	.asciz "ERROR_DEVICE_ALREADY_ATTACHED"

	.byte 164,4,9
	.asciz "ERROR_INSTRUCTION_MISALIGNMENT"

	.byte 165,4,9
	.asciz "ERROR_PROFILING_NOT_STARTED"

	.byte 166,4,9
	.asciz "ERROR_PROFILING_NOT_STOPPED"

	.byte 167,4,9
	.asciz "ERROR_COULD_NOT_INTERPRET"

	.byte 168,4,9
	.asciz "ERROR_PROFILING_AT_LIMIT"

	.byte 169,4,9
	.asciz "ERROR_CANT_WAIT"

	.byte 170,4,9
	.asciz "ERROR_CANT_TERMINATE_SELF"

	.byte 171,4,9
	.asciz "ERROR_UNEXPECTED_MM_CREATE_ERR"

	.byte 172,4,9
	.asciz "ERROR_UNEXPECTED_MM_MAP_ERROR"

	.byte 173,4,9
	.asciz "ERROR_UNEXPECTED_MM_EXTEND_ERR"

	.byte 174,4,9
	.asciz "ERROR_BAD_FUNCTION_TABLE"

	.byte 175,4,9
	.asciz "ERROR_NO_GUID_TRANSLATION"

	.byte 176,4,9
	.asciz "ERROR_INVALID_LDT_SIZE"

	.byte 177,4,9
	.asciz "ERROR_INVALID_LDT_OFFSET"

	.byte 179,4,9
	.asciz "ERROR_INVALID_LDT_DESCRIPTOR"

	.byte 180,4,9
	.asciz "ERROR_TOO_MANY_THREADS"

	.byte 181,4,9
	.asciz "ERROR_THREAD_NOT_IN_PROCESS"

	.byte 182,4,9
	.asciz "ERROR_PAGEFILE_QUOTA_EXCEEDED"

	.byte 183,4,9
	.asciz "ERROR_LOGON_SERVER_CONFLICT"

	.byte 184,4,9
	.asciz "ERROR_SYNCHRONIZATION_REQUIRED"

	.byte 185,4,9
	.asciz "ERROR_NET_OPEN_FAILED"

	.byte 186,4,9
	.asciz "ERROR_IO_PRIVILEGE_FAILED"

	.byte 187,4,9
	.asciz "ERROR_CONTROL_C_EXIT"

	.byte 188,4,9
	.asciz "ERROR_MISSING_SYSTEMFILE"

	.byte 189,4,9
	.asciz "ERROR_UNHANDLED_EXCEPTION"

	.byte 190,4,9
	.asciz "ERROR_APP_INIT_FAILURE"

	.byte 191,4,9
	.asciz "ERROR_PAGEFILE_CREATE_FAILED"

	.byte 192,4,9
	.asciz "ERROR_INVALID_IMAGE_HASH"

	.byte 193,4,9
	.asciz "ERROR_NO_PAGEFILE"

	.byte 194,4,9
	.asciz "ERROR_ILLEGAL_FLOAT_CONTEXT"

	.byte 195,4,9
	.asciz "ERROR_NO_EVENT_PAIR"

	.byte 196,4,9
	.asciz "ERROR_DOMAIN_CTRLR_CONFIG_ERROR"

	.byte 197,4,9
	.asciz "ERROR_ILLEGAL_CHARACTER"

	.byte 198,4,9
	.asciz "ERROR_UNDEFINED_CHARACTER"

	.byte 199,4,9
	.asciz "ERROR_FLOPPY_VOLUME"

	.byte 200,4,9
	.asciz "ERROR_BACKUP_CONTROLLER"

	.byte 202,4,9
	.asciz "ERROR_MUTANT_LIMIT_EXCEEDED"

	.byte 203,4,9
	.asciz "ERROR_FS_DRIVER_REQUIRED"

	.byte 204,4,9
	.asciz "ERROR_CANNOT_LOAD_REGISTRY_FILE"

	.byte 205,4,9
	.asciz "ERROR_DEBUG_ATTACH_FAILED"

	.byte 206,4,9
	.asciz "ERROR_SYSTEM_PROCESS_TERMINATED"

	.byte 207,4,9
	.asciz "ERROR_DATA_NOT_ACCEPTED"

	.byte 208,4,9
	.asciz "ERROR_VDM_HARD_ERROR"

	.byte 209,4,9
	.asciz "ERROR_DRIVER_CANCEL_TIMEOUT"

	.byte 210,4,9
	.asciz "ERROR_REPLY_MESSAGE_MISMATCH"

	.byte 211,4,9
	.asciz "ERROR_LOST_WRITEBEHIND_DATA"

	.byte 212,4,9
	.asciz "ERROR_NOT_TINY_STREAM"

	.byte 214,4,9
	.asciz "ERROR_STACK_OVERFLOW_READ"

	.byte 215,4,9
	.asciz "ERROR_CONVERT_TO_LARGE"

	.byte 216,4,9
	.asciz "ERROR_FOUND_OUT_OF_SCOPE"

	.byte 217,4,9
	.asciz "ERROR_ALLOCATE_BUCKET"

	.byte 218,4,9
	.asciz "ERROR_MARSHALL_OVERFLOW"

	.byte 219,4,9
	.asciz "ERROR_INVALID_VARIANT"

	.byte 220,4,9
	.asciz "ERROR_BAD_COMPRESSION_BUFFER"

	.byte 221,4,9
	.asciz "ERROR_AUDIT_FAILED"

	.byte 222,4,9
	.asciz "ERROR_TIMER_RESOLUTION_NOT_SET"

	.byte 223,4,9
	.asciz "ERROR_INSUFFICIENT_LOGON_INFO"

	.byte 224,4,9
	.asciz "ERROR_BAD_DLL_ENTRYPOINT"

	.byte 225,4,9
	.asciz "ERROR_BAD_SERVICE_ENTRYPOINT"

	.byte 226,4,9
	.asciz "ERROR_IP_ADDRESS_CONFLICT1"

	.byte 227,4,9
	.asciz "ERROR_IP_ADDRESS_CONFLICT2"

	.byte 228,4,9
	.asciz "ERROR_REGISTRY_QUOTA_LIMIT"

	.byte 229,4,9
	.asciz "ERROR_NO_CALLBACK_ACTIVE"

	.byte 230,4,9
	.asciz "ERROR_PWD_TOO_SHORT"

	.byte 231,4,9
	.asciz "ERROR_PWD_TOO_RECENT"

	.byte 232,4,9
	.asciz "ERROR_PWD_HISTORY_CONFLICT"

	.byte 233,4,9
	.asciz "ERROR_UNSUPPORTED_COMPRESSION"

	.byte 234,4,9
	.asciz "ERROR_INVALID_HW_PROFILE"

	.byte 235,4,9
	.asciz "ERROR_QUOTA_LIST_INCONSISTENT"

	.byte 237,4,9
	.asciz "ERROR_EVALUATION_EXPIRATION"

	.byte 238,4,9
	.asciz "ERROR_ILLEGAL_DLL_RELOCATION"

	.byte 239,4,9
	.asciz "ERROR_DLL_INIT_FAILED_LOGOFF"

	.byte 240,4,9
	.asciz "ERROR_VALIDATE_CONTINUE"

	.byte 241,4,9
	.asciz "ERROR_NO_MORE_MATCHES"

	.byte 242,4,9
	.asciz "ERROR_RANGE_LIST_CONFLICT"

	.byte 243,4,9
	.asciz "ERROR_SERVER_SID_MISMATCH"

	.byte 244,4,9
	.asciz "ERROR_CANT_ENABLE_DENY_ONLY"

	.byte 245,4,9
	.asciz "ERROR_FLOAT_MULTIPLE_FAULTS"

	.byte 246,4,9
	.asciz "ERROR_FLOAT_MULTIPLE_TRAPS"

	.byte 247,4,9
	.asciz "ERROR_NOINTERFACE"

	.byte 248,4,9
	.asciz "ERROR_DRIVER_FAILED_SLEEP"

	.byte 249,4,9
	.asciz "ERROR_CORRUPT_SYSTEM_FILE"

	.byte 250,4,9
	.asciz "ERROR_COMMITMENT_MINIMUM"

	.byte 251,4,9
	.asciz "ERROR_PNP_RESTART_ENUMERATION"

	.byte 252,4,9
	.asciz "ERROR_PNP_REBOOT_REQUIRED"

	.byte 254,4,9
	.asciz "ERROR_INSUFFICIENT_POWER"

	.byte 255,4,9
	.asciz "ERROR_MULTIPLE_FAULT_VIOLATION"

	.byte 128,5,9
	.asciz "ERROR_SYSTEM_SHUTDOWN"

	.byte 129,5,9
	.asciz "ERROR_PORT_NOT_SET"

	.byte 130,5,9
	.asciz "ERROR_DS_VERSION_CHECK_FAILURE"

	.byte 131,5,9
	.asciz "ERROR_RANGE_NOT_FOUND"

	.byte 132,5,9
	.asciz "ERROR_NOT_SAFE_MODE_DRIVER"

	.byte 134,5,9
	.asciz "ERROR_FAILED_DRIVER_ENTRY"

	.byte 135,5,9
	.asciz "ERROR_DEVICE_ENUMERATION_ERROR"

	.byte 136,5,9
	.asciz "ERROR_MOUNT_POINT_NOT_RESOLVED"

	.byte 137,5,9
	.asciz "ERROR_MCA_OCCURED"

	.byte 139,5,9
	.asciz "ERROR_DRIVER_DATABASE_ERROR"

	.byte 140,5,9
	.asciz "ERROR_SYSTEM_HIVE_TOO_LARGE"

	.byte 141,5,9
	.asciz "ERROR_VOLSNAP_PREPARE_HIBERNATE"

	.byte 143,5,9
	.asciz "ERROR_HIBERNATION_FAILURE"

	.byte 144,5,9
	.asciz "ERROR_PWD_TOO_LONG"

	.byte 145,5,9
	.asciz "ERROR_FILE_SYSTEM_LIMITATION"

	.byte 153,5,9
	.asciz "ERROR_ASSERTION_FAILURE"

	.byte 156,5,9
	.asciz "ERROR_ACPI_ERROR"

	.byte 157,5,9
	.asciz "ERROR_WOW_ASSERTION"

	.byte 158,5,9
	.asciz "ERROR_PNP_BAD_MPS_TABLE"

	.byte 159,5,9
	.asciz "ERROR_PNP_TRANSLATION_FAILED"

	.byte 160,5,9
	.asciz "ERROR_PNP_INVALID_ID"

	.byte 162,5,9
	.asciz "ERROR_WAKE_SYSTEM_DEBUGGER"

	.byte 163,5,9
	.asciz "ERROR_HANDLES_CLOSED"

	.byte 164,5,9
	.asciz "ERROR_EXTRANEOUS_INFORMATION"

	.byte 165,5,9
	.asciz "ERROR_RXACT_COMMIT_NECESSARY"

	.byte 166,5,9
	.asciz "ERROR_MEDIA_CHECK"

	.byte 167,5,9
	.asciz "ERROR_GUID_SUBSTITUTION_MADE"

	.byte 168,5,9
	.asciz "ERROR_STOPPED_ON_SYMLINK"

	.byte 169,5,9
	.asciz "ERROR_LONGJUMP"

	.byte 170,5,9
	.asciz "ERROR_PLUGPLAY_QUERY_VETOED"

	.byte 171,5,9
	.asciz "ERROR_UNWIND_CONSOLIDATE"

	.byte 172,5,9
	.asciz "ERROR_REGISTRY_HIVE_RECOVERED"

	.byte 173,5,9
	.asciz "ERROR_DLL_MIGHT_BE_INSECURE"

	.byte 174,5,9
	.asciz "ERROR_DLL_MIGHT_BE_INCOMPATIBLE"

	.byte 175,5,9
	.asciz "ERROR_DBG_EXCEPTION_NOT_HANDLED"

	.byte 176,5,9
	.asciz "ERROR_DBG_REPLY_LATER"

	.byte 177,5,9
	.asciz "ERROR_DBG_TERMINATE_THREAD"

	.byte 179,5,9
	.asciz "ERROR_DBG_TERMINATE_PROCESS"

	.byte 180,5,9
	.asciz "ERROR_DBG_CONTROL_C"

	.byte 181,5,9
	.asciz "ERROR_DBG_PRINTEXCEPTION_C"

	.byte 182,5,9
	.asciz "ERROR_DBG_RIPEXCEPTION"

	.byte 183,5,9
	.asciz "ERROR_DBG_CONTROL_BREAK"

	.byte 184,5,9
	.asciz "ERROR_DBG_COMMAND_EXCEPTION"

	.byte 185,5,9
	.asciz "ERROR_OBJECT_NAME_EXISTS"

	.byte 186,5,9
	.asciz "ERROR_THREAD_WAS_SUSPENDED"

	.byte 187,5,9
	.asciz "ERROR_IMAGE_NOT_AT_BASE"

	.byte 188,5,9
	.asciz "ERROR_RXACT_STATE_CREATED"

	.byte 189,5,9
	.asciz "ERROR_SEGMENT_NOTIFICATION"

	.byte 190,5,9
	.asciz "ERROR_BAD_CURRENT_DIRECTORY"

	.byte 191,5,9
	.asciz "ERROR_FT_WRITE_RECOVERY"

	.byte 193,5,9
	.asciz "ERROR_RECEIVE_PARTIAL"

	.byte 195,5,9
	.asciz "ERROR_RECEIVE_EXPEDITED"

	.byte 196,5,9
	.asciz "ERROR_RECEIVE_PARTIAL_EXPEDITED"

	.byte 197,5,9
	.asciz "ERROR_EVENT_DONE"

	.byte 198,5,9
	.asciz "ERROR_EVENT_PENDING"

	.byte 199,5,9
	.asciz "ERROR_CHECKING_FILE_SYSTEM"

	.byte 200,5,9
	.asciz "ERROR_FATAL_APP_EXIT"

	.byte 201,5,9
	.asciz "ERROR_PREDEFINED_HANDLE"

	.byte 202,5,9
	.asciz "ERROR_WAS_UNLOCKED"

	.byte 203,5,9
	.asciz "ERROR_SERVICE_NOTIFICATION"

	.byte 204,5,9
	.asciz "ERROR_WAS_LOCKED"

	.byte 205,5,9
	.asciz "ERROR_LOG_HARD_ERROR"

	.byte 206,5,9
	.asciz "ERROR_ALREADY_WIN32"

	.byte 207,5,9
	.asciz "ERROR_NO_YIELD_PERFORMED"

	.byte 209,5,9
	.asciz "ERROR_TIMER_RESUME_IGNORED"

	.byte 210,5,9
	.asciz "ERROR_ARBITRATION_UNHANDLED"

	.byte 211,5,9
	.asciz "ERROR_CARDBUS_NOT_SUPPORTED"

	.byte 212,5,9
	.asciz "ERROR_MP_PROCESSOR_MISMATCH"

	.byte 213,5,9
	.asciz "ERROR_HIBERNATED"

	.byte 214,5,9
	.asciz "ERROR_RESUME_HIBERNATION"

	.byte 215,5,9
	.asciz "ERROR_FIRMWARE_UPDATED"

	.byte 216,5,9
	.asciz "ERROR_WAKE_SYSTEM"

	.byte 218,5,9
	.asciz "ERROR_WAIT_1"

	.byte 219,5,9
	.asciz "ERROR_WAIT_2"

	.byte 220,5,9
	.asciz "ERROR_WAIT_3"

	.byte 221,5,9
	.asciz "ERROR_WAIT_63"

	.byte 222,5,9
	.asciz "ERROR_ABANDONED_WAIT_0"

	.byte 223,5,9
	.asciz "ERROR_ABANDONED_WAIT_63"

	.byte 224,5,9
	.asciz "ERROR_USER_APC"

	.byte 225,5,9
	.asciz "ERROR_KERNEL_APC"

	.byte 226,5,9
	.asciz "ERROR_ALERTED"

	.byte 227,5,9
	.asciz "ERROR_ELEVATION_REQUIRED"

	.byte 228,5,9
	.asciz "ERROR_REPARSE"

	.byte 229,5,9
	.asciz "ERROR_OPLOCK_BREAK_IN_PROGRESS"

	.byte 230,5,9
	.asciz "ERROR_VOLUME_MOUNTED"

	.byte 231,5,9
	.asciz "ERROR_RXACT_COMMITTED"

	.byte 232,5,9
	.asciz "ERROR_NOTIFY_CLEANUP"

	.byte 233,5,9
	.asciz "ERROR_PAGE_FAULT_TRANSITION"

	.byte 235,5,9
	.asciz "ERROR_PAGE_FAULT_DEMAND_ZERO"

	.byte 236,5,9
	.asciz "ERROR_PAGE_FAULT_COPY_ON_WRITE"

	.byte 237,5,9
	.asciz "ERROR_PAGE_FAULT_GUARD_PAGE"

	.byte 238,5,9
	.asciz "ERROR_PAGE_FAULT_PAGING_FILE"

	.byte 239,5,9
	.asciz "ERROR_CACHE_PAGE_LOCKED"

	.byte 240,5,9
	.asciz "ERROR_CRASH_DUMP"

	.byte 241,5,9
	.asciz "ERROR_BUFFER_ALL_ZEROS"

	.byte 242,5,9
	.asciz "ERROR_REPARSE_OBJECT"

	.byte 243,5,9
	.asciz "ERROR_TRANSLATION_COMPLETE"

	.byte 245,5,9
	.asciz "ERROR_NOTHING_TO_TERMINATE"

	.byte 246,5,9
	.asciz "ERROR_PROCESS_NOT_IN_JOB"

	.byte 247,5,9
	.asciz "ERROR_PROCESS_IN_JOB"

	.byte 248,5,9
	.asciz "ERROR_VOLSNAP_HIBERNATE_READY"

	.byte 249,5,9
	.asciz "ERROR_INTERRUPT_STILL_CONNECTED"

	.byte 252,5,9
	.asciz "ERROR_WAIT_FOR_OPLOCK"

	.byte 253,5,9
	.asciz "ERROR_DBG_EXCEPTION_HANDLED"

	.byte 254,5,9
	.asciz "ERROR_DBG_CONTINUE"

	.byte 255,5,9
	.asciz "ERROR_CALLBACK_POP_STACK"

	.byte 128,6,9
	.asciz "ERROR_COMPRESSION_DISABLED"

	.byte 129,6,9
	.asciz "ERROR_CANTFETCHBACKWARDS"

	.byte 130,6,9
	.asciz "ERROR_CANTSCROLLBACKWARDS"

	.byte 131,6,9
	.asciz "ERROR_ROWSNOTRELEASED"

	.byte 132,6,9
	.asciz "ERROR_BAD_ACCESSOR_FLAGS"

	.byte 133,6,9
	.asciz "ERROR_ERRORS_ENCOUNTERED"

	.byte 134,6,9
	.asciz "ERROR_NOT_CAPABLE"

	.byte 135,6,9
	.asciz "ERROR_REQUEST_OUT_OF_SEQUENCE"

	.byte 136,6,9
	.asciz "ERROR_VERSION_PARSE_ERROR"

	.byte 137,6,9
	.asciz "ERROR_BADSTARTPOSITION"

	.byte 138,6,9
	.asciz "ERROR_MEMORY_HARDWARE"

	.byte 139,6,9
	.asciz "ERROR_DISK_REPAIR_DISABLED"

	.byte 140,6,9
	.asciz "ERROR_MCA_EXCEPTION"

	.byte 144,6,9
	.asciz "ERROR_ACCESS_AUDIT_BY_POLICY"

	.byte 145,6,9
	.asciz "ERROR_ABANDON_HIBERFILE"

	.byte 147,6,9
	.asciz "ERROR_BAD_MCFG_TABLE"

	.byte 151,6,9
	.asciz "ERROR_DISK_REPAIR_REDIRECTED"

	.byte 152,6,9
	.asciz "ERROR_DISK_REPAIR_UNSUCCESSFUL"

	.byte 153,6,9
	.asciz "ERROR_CORRUPT_LOG_OVERFULL"

	.byte 154,6,9
	.asciz "ERROR_CORRUPT_LOG_CORRUPTED"

	.byte 155,6,9
	.asciz "ERROR_CORRUPT_LOG_UNAVAILABLE"

	.byte 156,6,9
	.asciz "ERROR_CORRUPT_LOG_DELETED_FULL"

	.byte 157,6,9
	.asciz "ERROR_CORRUPT_LOG_CLEARED"

	.byte 158,6,9
	.asciz "ERROR_ORPHAN_NAME_EXHAUSTED"

	.byte 159,6,9
	.asciz "ERROR_CANNOT_BREAK_OPLOCK"

	.byte 162,6,9
	.asciz "ERROR_OPLOCK_HANDLE_CLOSED"

	.byte 163,6,9
	.asciz "ERROR_NO_ACE_CONDITION"

	.byte 164,6,9
	.asciz "ERROR_INVALID_ACE_CONDITION"

	.byte 165,6,9
	.asciz "ERROR_FILE_HANDLE_REVOKED"

	.byte 166,6,9
	.asciz "ERROR_IMAGE_AT_DIFFERENT_BASE"

	.byte 167,6,9
	.asciz "ERROR_ENCRYPTED_IO_NOT_POSSIBLE"

	.byte 168,6,9
	.asciz "ERROR_QUOTA_ACTIVITY"

	.byte 170,6,9
	.asciz "ERROR_HANDLE_REVOKED"

	.byte 171,6,9
	.asciz "ERROR_CALLBACK_INVOKE_INLINE"

	.byte 172,6,9
	.asciz "ERROR_CPU_SET_INVALID"

	.byte 173,6,9
	.asciz "ERROR_EA_ACCESS_DENIED"

	.byte 226,7,9
	.asciz "ERROR_OPERATION_ABORTED"

	.byte 227,7,9
	.asciz "ERROR_IO_INCOMPLETE"

	.byte 228,7,9
	.asciz "ERROR_IO_PENDING"

	.byte 229,7,9
	.asciz "ERROR_NOACCESS"

	.byte 230,7,9
	.asciz "ERROR_SWAPERROR"

	.byte 231,7,9
	.asciz "ERROR_STACK_OVERFLOW"

	.byte 233,7,9
	.asciz "ERROR_INVALID_MESSAGE"

	.byte 234,7,9
	.asciz "ERROR_CAN_NOT_COMPLETE"

	.byte 235,7,9
	.asciz "ERROR_INVALID_FLAGS"

	.byte 236,7,9
	.asciz "ERROR_UNRECOGNIZED_VOLUME"

	.byte 237,7,9
	.asciz "ERROR_FILE_INVALID"

	.byte 238,7,9
	.asciz "ERROR_FULLSCREEN_MODE"

	.byte 239,7,9
	.asciz "ERROR_NO_TOKEN"

	.byte 240,7,9
	.asciz "ERROR_BADDB"

	.byte 241,7,9
	.asciz "ERROR_BADKEY"

	.byte 242,7,9
	.asciz "ERROR_CANTOPEN"

	.byte 243,7,9
	.asciz "ERROR_CANTREAD"

	.byte 244,7,9
	.asciz "ERROR_CANTWRITE"

	.byte 245,7,9
	.asciz "ERROR_REGISTRY_RECOVERED"

	.byte 246,7,9
	.asciz "ERROR_REGISTRY_CORRUPT"

	.byte 247,7,9
	.asciz "ERROR_REGISTRY_IO_FAILED"

	.byte 248,7,9
	.asciz "ERROR_NOT_REGISTRY_FILE"

	.byte 249,7,9
	.asciz "ERROR_KEY_DELETED"

	.byte 250,7,9
	.asciz "ERROR_NO_LOG_SPACE"

	.byte 251,7,9
	.asciz "ERROR_KEY_HAS_CHILDREN"

	.byte 252,7,9
	.asciz "ERROR_CHILD_MUST_BE_VOLATILE"

	.byte 253,7,9
	.asciz "ERROR_NOTIFY_ENUM_DIR"

	.byte 254,7,9
	.asciz "ERROR_INVALID_SERVICE_CONTROL"

	.byte 156,8,9
	.asciz "ERROR_SERVICE_REQUEST_TIMEOUT"

	.byte 157,8,9
	.asciz "ERROR_SERVICE_NO_THREAD"

	.byte 158,8,9
	.asciz "ERROR_SERVICE_DATABASE_LOCKED"

	.byte 159,8,9
	.asciz "ERROR_SERVICE_ALREADY_RUNNING"

	.byte 160,8,9
	.asciz "ERROR_INVALID_SERVICE_ACCOUNT"

	.byte 161,8,9
	.asciz "ERROR_SERVICE_DISABLED"

	.byte 162,8,9
	.asciz "ERROR_CIRCULAR_DEPENDENCY"

	.byte 163,8,9
	.asciz "ERROR_SERVICE_DOES_NOT_EXIST"

	.byte 164,8,9
	.asciz "ERROR_SERVICE_NOT_ACTIVE"

	.byte 166,8,9
	.asciz "ERROR_EXCEPTION_IN_SERVICE"

	.byte 168,8,9
	.asciz "ERROR_DATABASE_DOES_NOT_EXIST"

	.byte 169,8,9
	.asciz "ERROR_SERVICE_SPECIFIC_ERROR"

	.byte 170,8,9
	.asciz "ERROR_PROCESS_ABORTED"

	.byte 171,8,9
	.asciz "ERROR_SERVICE_DEPENDENCY_FAIL"

	.byte 172,8,9
	.asciz "ERROR_SERVICE_LOGON_FAILED"

	.byte 173,8,9
	.asciz "ERROR_SERVICE_START_HANG"

	.byte 174,8,9
	.asciz "ERROR_INVALID_SERVICE_LOCK"

	.byte 175,8,9
	.asciz "ERROR_SERVICE_MARKED_FOR_DELETE"

	.byte 176,8,9
	.asciz "ERROR_SERVICE_EXISTS"

	.byte 177,8,9
	.asciz "ERROR_ALREADY_RUNNING_LKG"

	.byte 178,8,9
	.asciz "ERROR_BOOT_ALREADY_ACCEPTED"

	.byte 180,8,9
	.asciz "ERROR_SERVICE_NEVER_STARTED"

	.byte 181,8,9
	.asciz "ERROR_DUPLICATE_SERVICE_NAME"

	.byte 182,8,9
	.asciz "ERROR_DIFFERENT_SERVICE_ACCOUNT"

	.byte 183,8,9
	.asciz "ERROR_NO_RECOVERY_PROGRAM"

	.byte 186,8,9
	.asciz "ERROR_SERVICE_NOT_IN_EXE"

	.byte 187,8,9
	.asciz "ERROR_NOT_SAFEBOOT_SERVICE"

	.byte 188,8,9
	.asciz "ERROR_END_OF_MEDIA"

	.byte 204,8,9
	.asciz "ERROR_FILEMARK_DETECTED"

	.byte 205,8,9
	.asciz "ERROR_BEGINNING_OF_MEDIA"

	.byte 206,8,9
	.asciz "ERROR_SETMARK_DETECTED"

	.byte 207,8,9
	.asciz "ERROR_NO_DATA_DETECTED"

	.byte 208,8,9
	.asciz "ERROR_PARTITION_FAILURE"

	.byte 209,8,9
	.asciz "ERROR_INVALID_BLOCK_LENGTH"

	.byte 210,8,9
	.asciz "ERROR_DEVICE_NOT_PARTITIONED"

	.byte 211,8,9
	.asciz "ERROR_UNABLE_TO_LOCK_MEDIA"

	.byte 212,8,9
	.asciz "ERROR_UNABLE_TO_UNLOAD_MEDIA"

	.byte 213,8,9
	.asciz "ERROR_MEDIA_CHANGED"

	.byte 214,8,9
	.asciz "ERROR_BUS_RESET"

	.byte 215,8,9
	.asciz "ERROR_NO_MEDIA_IN_DRIVE"

	.byte 216,8,9
	.asciz "ERROR_NO_UNICODE_TRANSLATION"

	.byte 217,8,9
	.asciz "ERROR_DLL_INIT_FAILED"

	.byte 218,8,9
	.asciz "ERROR_SHUTDOWN_IN_PROGRESS"

	.byte 219,8,9
	.asciz "ERROR_NO_SHUTDOWN_IN_PROGRESS"

	.byte 220,8,9
	.asciz "ERROR_IO_DEVICE"

	.byte 221,8,9
	.asciz "ERROR_SERIAL_NO_DEVICE"

	.byte 222,8,9
	.asciz "ERROR_IRQ_BUSY"

	.byte 223,8,9
	.asciz "ERROR_MORE_WRITES"

	.byte 224,8,9
	.asciz "ERROR_COUNTER_TIMEOUT"

	.byte 225,8,9
	.asciz "ERROR_FLOPPY_ID_MARK_NOT_FOUND"

	.byte 226,8,9
	.asciz "ERROR_FLOPPY_WRONG_CYLINDER"

	.byte 227,8,9
	.asciz "ERROR_FLOPPY_UNKNOWN_ERROR"

	.byte 228,8,9
	.asciz "ERROR_FLOPPY_BAD_REGISTERS"

	.byte 229,8,9
	.asciz "ERROR_DISK_RECALIBRATE_FAILED"

	.byte 230,8,9
	.asciz "ERROR_DISK_OPERATION_FAILED"

	.byte 231,8,9
	.asciz "ERROR_DISK_RESET_FAILED"

	.byte 232,8,9
	.asciz "ERROR_EOM_OVERFLOW"

	.byte 233,8,9
	.asciz "ERROR_NOT_ENOUGH_SERVER_MEMORY"

	.byte 234,8,9
	.asciz "ERROR_POSSIBLE_DEADLOCK"

	.byte 235,8,9
	.asciz "ERROR_MAPPED_ALIGNMENT"

	.byte 236,8,9
	.asciz "ERROR_SET_POWER_STATE_VETOED"

	.byte 244,8,9
	.asciz "ERROR_SET_POWER_STATE_FAILED"

	.byte 245,8,9
	.asciz "ERROR_TOO_MANY_LINKS"

	.byte 246,8,9
	.asciz "ERROR_OLD_WIN_VERSION"

	.byte 254,8,9
	.asciz "ERROR_APP_WRONG_OS"

	.byte 255,8,9
	.asciz "ERROR_SINGLE_INSTANCE_APP"

	.byte 128,9,9
	.asciz "ERROR_RMODE_APP"

	.byte 129,9,9
	.asciz "ERROR_INVALID_DLL"

	.byte 130,9,9
	.asciz "ERROR_NO_ASSOCIATION"

	.byte 131,9,9
	.asciz "ERROR_DDE_FAIL"

	.byte 132,9,9
	.asciz "ERROR_DLL_NOT_FOUND"

	.byte 133,9,9
	.asciz "ERROR_NO_MORE_USER_HANDLES"

	.byte 134,9,9
	.asciz "ERROR_MESSAGE_SYNC_ONLY"

	.byte 135,9,9
	.asciz "ERROR_SOURCE_ELEMENT_EMPTY"

	.byte 136,9,9
	.asciz "ERROR_DESTINATION_ELEMENT_FULL"

	.byte 137,9,9
	.asciz "ERROR_ILLEGAL_ELEMENT_ADDRESS"

	.byte 138,9,9
	.asciz "ERROR_MAGAZINE_NOT_PRESENT"

	.byte 139,9,9
	.asciz "ERROR_DEVICE_REQUIRES_CLEANING"

	.byte 141,9,9
	.asciz "ERROR_DEVICE_DOOR_OPEN"

	.byte 142,9,9
	.asciz "ERROR_DEVICE_NOT_CONNECTED"

	.byte 143,9,9
	.asciz "ERROR_NOT_FOUND"

	.byte 144,9,9
	.asciz "ERROR_NO_MATCH"

	.byte 145,9,9
	.asciz "ERROR_SET_NOT_FOUND"

	.byte 146,9,9
	.asciz "ERROR_POINT_NOT_FOUND"

	.byte 147,9,9
	.asciz "ERROR_NO_TRACKING_SERVICE"

	.byte 148,9,9
	.asciz "ERROR_NO_VOLUME_ID"

	.byte 149,9,9
	.asciz "ERROR_UNABLE_TO_REMOVE_REPLACED"

	.byte 151,9,9
	.asciz "ERROR_JOURNAL_NOT_ACTIVE"

	.byte 155,9,9
	.asciz "ERROR_POTENTIAL_FILE_FOUND"

	.byte 156,9,9
	.asciz "ERROR_JOURNAL_ENTRY_DELETED"

	.byte 157,9,9
	.asciz "ERROR_SHUTDOWN_IS_SCHEDULED"

	.byte 166,9,9
	.asciz "ERROR_SHUTDOWN_USERS_LOGGED_ON"

	.byte 167,9,9
	.asciz "ERROR_BAD_DEVICE"

	.byte 176,9,9
	.asciz "ERROR_CONNECTION_UNAVAIL"

	.byte 177,9,9
	.asciz "ERROR_DEVICE_ALREADY_REMEMBERED"

	.byte 178,9,9
	.asciz "ERROR_NO_NET_OR_BAD_PATH"

	.byte 179,9,9
	.asciz "ERROR_BAD_PROVIDER"

	.byte 180,9,9
	.asciz "ERROR_CANNOT_OPEN_PROFILE"

	.byte 181,9,9
	.asciz "ERROR_BAD_PROFILE"

	.byte 182,9,9
	.asciz "ERROR_NOT_CONTAINER"

	.byte 183,9,9
	.asciz "ERROR_EXTENDED_ERROR"

	.byte 184,9,9
	.asciz "ERROR_INVALID_GROUPNAME"

	.byte 185,9,9
	.asciz "ERROR_INVALID_COMPUTERNAME"

	.byte 186,9,9
	.asciz "ERROR_INVALID_EVENTNAME"

	.byte 187,9,9
	.asciz "ERROR_INVALID_DOMAINNAME"

	.byte 188,9,9
	.asciz "ERROR_INVALID_SERVICENAME"

	.byte 189,9,9
	.asciz "ERROR_INVALID_NETNAME"

	.byte 190,9,9
	.asciz "ERROR_INVALID_SHARENAME"

	.byte 191,9,9
	.asciz "ERROR_INVALID_PASSWORDNAME"

	.byte 192,9,9
	.asciz "ERROR_INVALID_MESSAGENAME"

	.byte 193,9,9
	.asciz "ERROR_INVALID_MESSAGEDEST"

	.byte 194,9,9
	.asciz "ERROR_DUP_DOMAINNAME"

	.byte 197,9,9
	.asciz "ERROR_NO_NETWORK"

	.byte 198,9,9
	.asciz "ERROR_CANCELLED"

	.byte 199,9,9
	.asciz "ERROR_USER_MAPPED_FILE"

	.byte 200,9,9
	.asciz "ERROR_CONNECTION_REFUSED"

	.byte 201,9,9
	.asciz "ERROR_GRACEFUL_DISCONNECT"

	.byte 202,9,9
	.asciz "ERROR_ADDRESS_NOT_ASSOCIATED"

	.byte 204,9,9
	.asciz "ERROR_CONNECTION_INVALID"

	.byte 205,9,9
	.asciz "ERROR_CONNECTION_ACTIVE"

	.byte 206,9,9
	.asciz "ERROR_NETWORK_UNREACHABLE"

	.byte 207,9,9
	.asciz "ERROR_HOST_UNREACHABLE"

	.byte 208,9,9
	.asciz "ERROR_PROTOCOL_UNREACHABLE"

	.byte 209,9,9
	.asciz "ERROR_PORT_UNREACHABLE"

	.byte 210,9,9
	.asciz "ERROR_REQUEST_ABORTED"

	.byte 211,9,9
	.asciz "ERROR_CONNECTION_ABORTED"

	.byte 212,9,9
	.asciz "ERROR_RETRY"

	.byte 213,9,9
	.asciz "ERROR_CONNECTION_COUNT_LIMIT"

	.byte 214,9,9
	.asciz "ERROR_LOGIN_TIME_RESTRICTION"

	.byte 215,9,9
	.asciz "ERROR_LOGIN_WKSTA_RESTRICTION"

	.byte 216,9,9
	.asciz "ERROR_INCORRECT_ADDRESS"

	.byte 217,9,9
	.asciz "ERROR_ALREADY_REGISTERED"

	.byte 218,9,9
	.asciz "ERROR_SERVICE_NOT_FOUND"

	.byte 219,9,9
	.asciz "ERROR_NOT_AUTHENTICATED"

	.byte 220,9,9
	.asciz "ERROR_NOT_LOGGED_ON"

	.byte 221,9,9
	.asciz "ERROR_CONTINUE"

	.byte 222,9,9
	.asciz "ERROR_ALREADY_INITIALIZED"

	.byte 223,9,9
	.asciz "ERROR_NO_MORE_DEVICES"

	.byte 224,9,9
	.asciz "ERROR_NO_SUCH_SITE"

	.byte 225,9,9
	.asciz "ERROR_DOMAIN_CONTROLLER_EXISTS"

	.byte 226,9,9
	.asciz "ERROR_ONLY_IF_CONNECTED"

	.byte 227,9,9
	.asciz "ERROR_OVERRIDE_NOCHANGES"

	.byte 228,9,9
	.asciz "ERROR_BAD_USER_PROFILE"

	.byte 229,9,9
	.asciz "ERROR_NOT_SUPPORTED_ON_SBS"

	.byte 230,9,9
	.asciz "ERROR_HOST_DOWN"

	.byte 232,9,9
	.asciz "ERROR_NON_ACCOUNT_SID"

	.byte 233,9,9
	.asciz "ERROR_NON_DOMAIN_SID"

	.byte 234,9,9
	.asciz "ERROR_APPHELP_BLOCK"

	.byte 235,9,9
	.asciz "ERROR_ACCESS_DISABLED_BY_POLICY"

	.byte 236,9,9
	.asciz "ERROR_REG_NAT_CONSUMPTION"

	.byte 237,9,9
	.asciz "ERROR_CSCSHARE_OFFLINE"

	.byte 238,9,9
	.asciz "ERROR_PKINIT_FAILURE"

	.byte 239,9,9
	.asciz "ERROR_DOWNGRADE_DETECTED"

	.byte 241,9,9
	.asciz "ERROR_MACHINE_LOCKED"

	.byte 247,9,9
	.asciz "ERROR_DRIVER_BLOCKED"

	.byte 251,9,9
	.asciz "ERROR_INVALID_IMPORT_OF_NON_DLL"

	.byte 252,9,9
	.asciz "ERROR_ACCESS_DISABLED_WEBBLADE"

	.byte 253,9,9
	.asciz "ERROR_RECOVERY_FAILURE"

	.byte 255,9,9
	.asciz "ERROR_ALREADY_FIBER"

	.byte 128,10,9
	.asciz "ERROR_ALREADY_THREAD"

	.byte 129,10,9
	.asciz "ERROR_STACK_BUFFER_OVERRUN"

	.byte 130,10,9
	.asciz "ERROR_PARAMETER_QUOTA_EXCEEDED"

	.byte 131,10,9
	.asciz "ERROR_DEBUGGER_INACTIVE"

	.byte 132,10,9
	.asciz "ERROR_DELAY_LOAD_FAILED"

	.byte 133,10,9
	.asciz "ERROR_VDM_DISALLOWED"

	.byte 134,10,9
	.asciz "ERROR_UNIDENTIFIED_ERROR"

	.byte 135,10,9
	.asciz "ERROR_BEYOND_VDL"

	.byte 137,10,9
	.asciz "ERROR_DRIVER_PROCESS_TERMINATED"

	.byte 139,10,9
	.asciz "ERROR_IMPLEMENTATION_LIMIT"

	.byte 140,10,9
	.asciz "ERROR_PROCESS_IS_PROTECTED"

	.byte 141,10,9
	.asciz "ERROR_DISK_QUOTA_EXCEEDED"

	.byte 143,10,9
	.asciz "ERROR_CONTENT_BLOCKED"

	.byte 144,10,9
	.asciz "ERROR_APP_HANG"

	.byte 146,10,9
	.asciz "ERROR_INVALID_LABEL"

	.byte 147,10,9
	.asciz "ERROR_NOT_ALL_ASSIGNED"

	.byte 148,10,9
	.asciz "ERROR_SOME_NOT_MAPPED"

	.byte 149,10,9
	.asciz "ERROR_NO_QUOTAS_FOR_ACCOUNT"

	.byte 150,10,9
	.asciz "ERROR_LOCAL_USER_SESSION_KEY"

	.byte 151,10,9
	.asciz "ERROR_NULL_LM_PASSWORD"

	.byte 152,10,9
	.asciz "ERROR_UNKNOWN_REVISION"

	.byte 153,10,9
	.asciz "ERROR_REVISION_MISMATCH"

	.byte 154,10,9
	.asciz "ERROR_INVALID_OWNER"

	.byte 155,10,9
	.asciz "ERROR_INVALID_PRIMARY_GROUP"

	.byte 156,10,9
	.asciz "ERROR_NO_IMPERSONATION_TOKEN"

	.byte 157,10,9
	.asciz "ERROR_CANT_DISABLE_MANDATORY"

	.byte 158,10,9
	.asciz "ERROR_NO_LOGON_SERVERS"

	.byte 159,10,9
	.asciz "ERROR_NO_SUCH_LOGON_SESSION"

	.byte 160,10,9
	.asciz "ERROR_NO_SUCH_PRIVILEGE"

	.byte 161,10,9
	.asciz "ERROR_PRIVILEGE_NOT_HELD"

	.byte 162,10,9
	.asciz "ERROR_INVALID_ACCOUNT_NAME"

	.byte 163,10,9
	.asciz "ERROR_USER_EXISTS"

	.byte 164,10,9
	.asciz "ERROR_NO_SUCH_USER"

	.byte 165,10,9
	.asciz "ERROR_GROUP_EXISTS"

	.byte 166,10,9
	.asciz "ERROR_NO_SUCH_GROUP"

	.byte 167,10,9
	.asciz "ERROR_MEMBER_IN_GROUP"

	.byte 168,10,9
	.asciz "ERROR_MEMBER_NOT_IN_GROUP"

	.byte 169,10,9
	.asciz "ERROR_LAST_ADMIN"

	.byte 170,10,9
	.asciz "ERROR_WRONG_PASSWORD"

	.byte 171,10,9
	.asciz "ERROR_ILL_FORMED_PASSWORD"

	.byte 172,10,9
	.asciz "ERROR_PASSWORD_RESTRICTION"

	.byte 173,10,9
	.asciz "ERROR_LOGON_FAILURE"

	.byte 174,10,9
	.asciz "ERROR_ACCOUNT_RESTRICTION"

	.byte 175,10,9
	.asciz "ERROR_INVALID_LOGON_HOURS"

	.byte 176,10,9
	.asciz "ERROR_INVALID_WORKSTATION"

	.byte 177,10,9
	.asciz "ERROR_PASSWORD_EXPIRED"

	.byte 178,10,9
	.asciz "ERROR_ACCOUNT_DISABLED"

	.byte 179,10,9
	.asciz "ERROR_NONE_MAPPED"

	.byte 180,10,9
	.asciz "ERROR_TOO_MANY_LUIDS_REQUESTED"

	.byte 181,10,9
	.asciz "ERROR_LUIDS_EXHAUSTED"

	.byte 182,10,9
	.asciz "ERROR_INVALID_SUB_AUTHORITY"

	.byte 183,10,9
	.asciz "ERROR_INVALID_ACL"

	.byte 184,10,9
	.asciz "ERROR_INVALID_SID"

	.byte 185,10,9
	.asciz "ERROR_INVALID_SECURITY_DESCR"

	.byte 186,10,9
	.asciz "ERROR_BAD_INHERITANCE_ACL"

	.byte 188,10,9
	.asciz "ERROR_SERVER_DISABLED"

	.byte 189,10,9
	.asciz "ERROR_SERVER_NOT_DISABLED"

	.byte 190,10,9
	.asciz "ERROR_INVALID_ID_AUTHORITY"

	.byte 191,10,9
	.asciz "ERROR_ALLOTTED_SPACE_EXCEEDED"

	.byte 192,10,9
	.asciz "ERROR_INVALID_GROUP_ATTRIBUTES"

	.byte 193,10,9
	.asciz "ERROR_BAD_IMPERSONATION_LEVEL"

	.byte 194,10,9
	.asciz "ERROR_CANT_OPEN_ANONYMOUS"

	.byte 195,10,9
	.asciz "ERROR_BAD_VALIDATION_CLASS"

	.byte 196,10,9
	.asciz "ERROR_BAD_TOKEN_TYPE"

	.byte 197,10,9
	.asciz "ERROR_NO_SECURITY_ON_OBJECT"

	.byte 198,10,9
	.asciz "ERROR_CANT_ACCESS_DOMAIN_INFO"

	.byte 199,10,9
	.asciz "ERROR_INVALID_SERVER_STATE"

	.byte 200,10,9
	.asciz "ERROR_INVALID_DOMAIN_STATE"

	.byte 201,10,9
	.asciz "ERROR_INVALID_DOMAIN_ROLE"

	.byte 202,10,9
	.asciz "ERROR_NO_SUCH_DOMAIN"

	.byte 203,10,9
	.asciz "ERROR_DOMAIN_EXISTS"

	.byte 204,10,9
	.asciz "ERROR_DOMAIN_LIMIT_EXCEEDED"

	.byte 205,10,9
	.asciz "ERROR_INTERNAL_DB_CORRUPTION"

	.byte 206,10,9
	.asciz "ERROR_INTERNAL_ERROR"

	.byte 207,10,9
	.asciz "ERROR_GENERIC_NOT_MAPPED"

	.byte 208,10,9
	.asciz "ERROR_BAD_DESCRIPTOR_FORMAT"

	.byte 209,10,9
	.asciz "ERROR_NOT_LOGON_PROCESS"

	.byte 210,10,9
	.asciz "ERROR_LOGON_SESSION_EXISTS"

	.byte 211,10,9
	.asciz "ERROR_NO_SUCH_PACKAGE"

	.byte 212,10,9
	.asciz "ERROR_BAD_LOGON_SESSION_STATE"

	.byte 213,10,9
	.asciz "ERROR_LOGON_SESSION_COLLISION"

	.byte 214,10,9
	.asciz "ERROR_INVALID_LOGON_TYPE"

	.byte 215,10,9
	.asciz "ERROR_CANNOT_IMPERSONATE"

	.byte 216,10,9
	.asciz "ERROR_RXACT_INVALID_STATE"

	.byte 217,10,9
	.asciz "ERROR_RXACT_COMMIT_FAILURE"

	.byte 218,10,9
	.asciz "ERROR_SPECIAL_ACCOUNT"

	.byte 219,10,9
	.asciz "ERROR_SPECIAL_GROUP"

	.byte 220,10,9
	.asciz "ERROR_SPECIAL_USER"

	.byte 221,10,9
	.asciz "ERROR_MEMBERS_PRIMARY_GROUP"

	.byte 222,10,9
	.asciz "ERROR_TOKEN_ALREADY_IN_USE"

	.byte 223,10,9
	.asciz "ERROR_NO_SUCH_ALIAS"

	.byte 224,10,9
	.asciz "ERROR_MEMBER_NOT_IN_ALIAS"

	.byte 225,10,9
	.asciz "ERROR_MEMBER_IN_ALIAS"

	.byte 226,10,9
	.asciz "ERROR_ALIAS_EXISTS"

	.byte 227,10,9
	.asciz "ERROR_LOGON_NOT_GRANTED"

	.byte 228,10,9
	.asciz "ERROR_TOO_MANY_SECRETS"

	.byte 229,10,9
	.asciz "ERROR_SECRET_TOO_LONG"

	.byte 230,10,9
	.asciz "ERROR_INTERNAL_DB_ERROR"

	.byte 231,10,9
	.asciz "ERROR_TOO_MANY_CONTEXT_IDS"

	.byte 232,10,9
	.asciz "ERROR_LOGON_TYPE_NOT_GRANTED"

	.byte 233,10,9
	.asciz "ERROR_NO_SUCH_MEMBER"

	.byte 235,10,9
	.asciz "ERROR_INVALID_MEMBER"

	.byte 236,10,9
	.asciz "ERROR_TOO_MANY_SIDS"

	.byte 237,10,9
	.asciz "ERROR_NO_INHERITANCE"

	.byte 239,10,9
	.asciz "ERROR_FILE_CORRUPT"

	.byte 240,10,9
	.asciz "ERROR_DISK_CORRUPT"

	.byte 241,10,9
	.asciz "ERROR_NO_USER_SESSION_KEY"

	.byte 242,10,9
	.asciz "ERROR_LICENSE_QUOTA_EXCEEDED"

	.byte 243,10,9
	.asciz "ERROR_WRONG_TARGET_NAME"

	.byte 244,10,9
	.asciz "ERROR_MUTUAL_AUTH_FAILED"

	.byte 245,10,9
	.asciz "ERROR_TIME_SKEW"

	.byte 246,10,9
	.asciz "ERROR_INVALID_WINDOW_HANDLE"

	.byte 248,10,9
	.asciz "ERROR_INVALID_MENU_HANDLE"

	.byte 249,10,9
	.asciz "ERROR_INVALID_CURSOR_HANDLE"

	.byte 250,10,9
	.asciz "ERROR_INVALID_ACCEL_HANDLE"

	.byte 251,10,9
	.asciz "ERROR_INVALID_HOOK_HANDLE"

	.byte 252,10,9
	.asciz "ERROR_INVALID_DWP_HANDLE"

	.byte 253,10,9
	.asciz "ERROR_TLW_WITH_WSCHILD"

	.byte 254,10,9
	.asciz "ERROR_CANNOT_FIND_WND_CLASS"

	.byte 255,10,9
	.asciz "ERROR_WINDOW_OF_OTHER_THREAD"

	.byte 128,11,9
	.asciz "ERROR_HOTKEY_ALREADY_REGISTERED"

	.byte 129,11,9
	.asciz "ERROR_CLASS_ALREADY_EXISTS"

	.byte 130,11,9
	.asciz "ERROR_CLASS_DOES_NOT_EXIST"

	.byte 131,11,9
	.asciz "ERROR_CLASS_HAS_WINDOWS"

	.byte 132,11,9
	.asciz "ERROR_INVALID_INDEX"

	.byte 133,11,9
	.asciz "ERROR_INVALID_ICON_HANDLE"

	.byte 134,11,9
	.asciz "ERROR_PRIVATE_DIALOG_INDEX"

	.byte 135,11,9
	.asciz "ERROR_LISTBOX_ID_NOT_FOUND"

	.byte 136,11,9
	.asciz "ERROR_NO_WILDCARD_CHARACTERS"

	.byte 137,11,9
	.asciz "ERROR_CLIPBOARD_NOT_OPEN"

	.byte 138,11,9
	.asciz "ERROR_HOTKEY_NOT_REGISTERED"

	.byte 139,11,9
	.asciz "ERROR_WINDOW_NOT_DIALOG"

	.byte 140,11,9
	.asciz "ERROR_CONTROL_ID_NOT_FOUND"

	.byte 141,11,9
	.asciz "ERROR_INVALID_COMBOBOX_MESSAGE"

	.byte 142,11,9
	.asciz "ERROR_WINDOW_NOT_COMBOBOX"

	.byte 143,11,9
	.asciz "ERROR_INVALID_EDIT_HEIGHT"

	.byte 144,11,9
	.asciz "ERROR_DC_NOT_FOUND"

	.byte 145,11,9
	.asciz "ERROR_INVALID_HOOK_FILTER"

	.byte 146,11,9
	.asciz "ERROR_INVALID_FILTER_PROC"

	.byte 147,11,9
	.asciz "ERROR_HOOK_NEEDS_HMOD"

	.byte 148,11,9
	.asciz "ERROR_GLOBAL_ONLY_HOOK"

	.byte 149,11,9
	.asciz "ERROR_JOURNAL_HOOK_SET"

	.byte 150,11,9
	.asciz "ERROR_HOOK_NOT_INSTALLED"

	.byte 151,11,9
	.asciz "ERROR_INVALID_LB_MESSAGE"

	.byte 152,11,9
	.asciz "ERROR_SETCOUNT_ON_BAD_LB"

	.byte 153,11,9
	.asciz "ERROR_LB_WITHOUT_TABSTOPS"

	.byte 154,11,9
	.asciz "ERROR_CHILD_WINDOW_MENU"

	.byte 156,11,9
	.asciz "ERROR_NO_SYSTEM_MENU"

	.byte 157,11,9
	.asciz "ERROR_INVALID_MSGBOX_STYLE"

	.byte 158,11,9
	.asciz "ERROR_INVALID_SPI_VALUE"

	.byte 159,11,9
	.asciz "ERROR_SCREEN_ALREADY_LOCKED"

	.byte 160,11,9
	.asciz "ERROR_HWNDS_HAVE_DIFF_PARENT"

	.byte 161,11,9
	.asciz "ERROR_NOT_CHILD_WINDOW"

	.byte 162,11,9
	.asciz "ERROR_INVALID_GW_COMMAND"

	.byte 163,11,9
	.asciz "ERROR_INVALID_THREAD_ID"

	.byte 164,11,9
	.asciz "ERROR_NON_MDICHILD_WINDOW"

	.byte 165,11,9
	.asciz "ERROR_POPUP_ALREADY_ACTIVE"

	.byte 166,11,9
	.asciz "ERROR_NO_SCROLLBARS"

	.byte 167,11,9
	.asciz "ERROR_INVALID_SCROLLBAR_RANGE"

	.byte 168,11,9
	.asciz "ERROR_INVALID_SHOWWIN_COMMAND"

	.byte 169,11,9
	.asciz "ERROR_NO_SYSTEM_RESOURCES"

	.byte 170,11,9
	.asciz "ERROR_NONPAGED_SYSTEM_RESOURCES"

	.byte 171,11,9
	.asciz "ERROR_PAGED_SYSTEM_RESOURCES"

	.byte 172,11,9
	.asciz "ERROR_WORKING_SET_QUOTA"

	.byte 173,11,9
	.asciz "ERROR_PAGEFILE_QUOTA"

	.byte 174,11,9
	.asciz "ERROR_COMMITMENT_LIMIT"

	.byte 175,11,9
	.asciz "ERROR_MENU_ITEM_NOT_FOUND"

	.byte 176,11,9
	.asciz "ERROR_INVALID_KEYBOARD_HANDLE"

	.byte 177,11,9
	.asciz "ERROR_HOOK_TYPE_NOT_ALLOWED"

	.byte 178,11,9
	.asciz "ERROR_TIMEOUT"

	.byte 180,11,9
	.asciz "ERROR_INVALID_MONITOR_HANDLE"

	.byte 181,11,9
	.asciz "ERROR_INCORRECT_SIZE"

	.byte 182,11,9
	.asciz "ERROR_SYMLINK_CLASS_DISABLED"

	.byte 183,11,9
	.asciz "ERROR_SYMLINK_NOT_SUPPORTED"

	.byte 184,11,9
	.asciz "ERROR_XML_PARSE_ERROR"

	.byte 185,11,9
	.asciz "ERROR_XMLDSIG_ERROR"

	.byte 186,11,9
	.asciz "ERROR_RESTART_APPLICATION"

	.byte 187,11,9
	.asciz "ERROR_WRONG_COMPARTMENT"

	.byte 188,11,9
	.asciz "ERROR_AUTHIP_FAILURE"

	.byte 189,11,9
	.asciz "ERROR_NO_NVRAM_RESOURCES"

	.byte 190,11,9
	.asciz "ERROR_NOT_GUI_PROCESS"

	.byte 191,11,9
	.asciz "ERROR_EVENTLOG_FILE_CORRUPT"

	.byte 220,11,9
	.asciz "ERROR_EVENTLOG_CANT_START"

	.byte 221,11,9
	.asciz "ERROR_LOG_FILE_FULL"

	.byte 222,11,9
	.asciz "ERROR_EVENTLOG_FILE_CHANGED"

	.byte 223,11,9
	.asciz "ERROR_CONTAINER_ASSIGNED"

	.byte 224,11,9
	.asciz "ERROR_JOB_NO_CONTAINER"

	.byte 225,11,9
	.asciz "ERROR_INVALID_TASK_NAME"

	.byte 142,12,9
	.asciz "ERROR_INVALID_TASK_INDEX"

	.byte 143,12,9
	.asciz "ERROR_THREAD_ALREADY_IN_TASK"

	.byte 144,12,9
	.asciz "ERROR_INSTALL_SERVICE_FAILURE"

	.byte 193,12,9
	.asciz "ERROR_INSTALL_USEREXIT"

	.byte 194,12,9
	.asciz "ERROR_INSTALL_FAILURE"

	.byte 195,12,9
	.asciz "ERROR_INSTALL_SUSPEND"

	.byte 196,12,9
	.asciz "ERROR_UNKNOWN_PRODUCT"

	.byte 197,12,9
	.asciz "ERROR_UNKNOWN_FEATURE"

	.byte 198,12,9
	.asciz "ERROR_UNKNOWN_COMPONENT"

	.byte 199,12,9
	.asciz "ERROR_UNKNOWN_PROPERTY"

	.byte 200,12,9
	.asciz "ERROR_INVALID_HANDLE_STATE"

	.byte 201,12,9
	.asciz "ERROR_BAD_CONFIGURATION"

	.byte 202,12,9
	.asciz "ERROR_INDEX_ABSENT"

	.byte 203,12,9
	.asciz "ERROR_INSTALL_SOURCE_ABSENT"

	.byte 204,12,9
	.asciz "ERROR_INSTALL_PACKAGE_VERSION"

	.byte 205,12,9
	.asciz "ERROR_PRODUCT_UNINSTALLED"

	.byte 206,12,9
	.asciz "ERROR_BAD_QUERY_SYNTAX"

	.byte 207,12,9
	.asciz "ERROR_INVALID_FIELD"

	.byte 208,12,9
	.asciz "ERROR_DEVICE_REMOVED"

	.byte 209,12,9
	.asciz "ERROR_INSTALL_ALREADY_RUNNING"

	.byte 210,12,9
	.asciz "ERROR_INSTALL_PACKAGE_INVALID"

	.byte 212,12,9
	.asciz "ERROR_INSTALL_UI_FAILURE"

	.byte 213,12,9
	.asciz "ERROR_INSTALL_LOG_FAILURE"

	.byte 214,12,9
	.asciz "ERROR_INSTALL_TRANSFORM_FAILURE"

	.byte 216,12,9
	.asciz "ERROR_INSTALL_PACKAGE_REJECTED"

	.byte 217,12,9
	.asciz "ERROR_FUNCTION_NOT_CALLED"

	.byte 218,12,9
	.asciz "ERROR_FUNCTION_FAILED"

	.byte 219,12,9
	.asciz "ERROR_INVALID_TABLE"

	.byte 220,12,9
	.asciz "ERROR_DATATYPE_MISMATCH"

	.byte 221,12,9
	.asciz "ERROR_UNSUPPORTED_TYPE"

	.byte 222,12,9
	.asciz "ERROR_CREATE_FAILED"

	.byte 223,12,9
	.asciz "ERROR_INSTALL_TEMP_UNWRITABLE"

	.byte 224,12,9
	.asciz "ERROR_INSTALL_NOTUSED"

	.byte 226,12,9
	.asciz "ERROR_PATCH_PACKAGE_OPEN_FAILED"

	.byte 227,12,9
	.asciz "ERROR_PATCH_PACKAGE_INVALID"

	.byte 228,12,9
	.asciz "ERROR_PATCH_PACKAGE_UNSUPPORTED"

	.byte 229,12,9
	.asciz "ERROR_PRODUCT_VERSION"

	.byte 230,12,9
	.asciz "ERROR_INVALID_COMMAND_LINE"

	.byte 231,12,9
	.asciz "ERROR_INSTALL_REMOTE_DISALLOWED"

	.byte 232,12,9
	.asciz "ERROR_SUCCESS_REBOOT_INITIATED"

	.byte 233,12,9
	.asciz "ERROR_PATCH_TARGET_NOT_FOUND"

	.byte 234,12,9
	.asciz "ERROR_PATCH_PACKAGE_REJECTED"

	.byte 235,12,9
	.asciz "ERROR_INSTALL_REMOTE_PROHIBITED"

	.byte 237,12,9
	.asciz "ERROR_PATCH_REMOVAL_UNSUPPORTED"

	.byte 238,12,9
	.asciz "ERROR_UNKNOWN_PATCH"

	.byte 239,12,9
	.asciz "ERROR_PATCH_NO_SEQUENCE"

	.byte 240,12,9
	.asciz "ERROR_PATCH_REMOVAL_DISALLOWED"

	.byte 241,12,9
	.asciz "ERROR_INVALID_PATCH_XML"

	.byte 242,12,9
	.asciz "ERROR_INSTALL_SERVICE_SAFEBOOT"

	.byte 244,12,9
	.asciz "ERROR_FAIL_FAST_EXCEPTION"

	.byte 245,12,9
	.asciz "ERROR_INSTALL_REJECTED"

	.byte 246,12,9
	.asciz "ERROR_DYNAMIC_CODE_BLOCKED"

	.byte 247,12,9
	.asciz "ERROR_NOT_SAME_OBJECT"

	.byte 248,12,9
	.asciz "RPC_S_INVALID_STRING_BINDING"

	.byte 164,13,9
	.asciz "RPC_S_WRONG_KIND_OF_BINDING"

	.byte 165,13,9
	.asciz "RPC_S_INVALID_BINDING"

	.byte 166,13,9
	.asciz "RPC_S_PROTSEQ_NOT_SUPPORTED"

	.byte 167,13,9
	.asciz "RPC_S_INVALID_RPC_PROTSEQ"

	.byte 168,13,9
	.asciz "RPC_S_INVALID_STRING_UUID"

	.byte 169,13,9
	.asciz "RPC_S_INVALID_ENDPOINT_FORMAT"

	.byte 170,13,9
	.asciz "RPC_S_INVALID_NET_ADDR"

	.byte 171,13,9
	.asciz "RPC_S_NO_ENDPOINT_FOUND"

	.byte 172,13,9
	.asciz "RPC_S_INVALID_TIMEOUT"

	.byte 173,13,9
	.asciz "RPC_S_OBJECT_NOT_FOUND"

	.byte 174,13,9
	.asciz "RPC_S_ALREADY_REGISTERED"

	.byte 175,13,9
	.asciz "RPC_S_TYPE_ALREADY_REGISTERED"

	.byte 176,13,9
	.asciz "RPC_S_ALREADY_LISTENING"

	.byte 177,13,9
	.asciz "RPC_S_NO_PROTSEQS_REGISTERED"

	.byte 178,13,9
	.asciz "RPC_S_NOT_LISTENING"

	.byte 179,13,9
	.asciz "RPC_S_UNKNOWN_MGR_TYPE"

	.byte 180,13,9
	.asciz "RPC_S_UNKNOWN_IF"

	.byte 181,13,9
	.asciz "RPC_S_NO_BINDINGS"

	.byte 182,13,9
	.asciz "RPC_S_NO_PROTSEQS"

	.byte 183,13,9
	.asciz "RPC_S_CANT_CREATE_ENDPOINT"

	.byte 184,13,9
	.asciz "RPC_S_OUT_OF_RESOURCES"

	.byte 185,13,9
	.asciz "RPC_S_SERVER_UNAVAILABLE"

	.byte 186,13,9
	.asciz "RPC_S_SERVER_TOO_BUSY"

	.byte 187,13,9
	.asciz "RPC_S_INVALID_NETWORK_OPTIONS"

	.byte 188,13,9
	.asciz "RPC_S_NO_CALL_ACTIVE"

	.byte 189,13,9
	.asciz "RPC_S_CALL_FAILED"

	.byte 190,13,9
	.asciz "RPC_S_CALL_FAILED_DNE"

	.byte 191,13,9
	.asciz "RPC_S_PROTOCOL_ERROR"

	.byte 192,13,9
	.asciz "RPC_S_PROXY_ACCESS_DENIED"

	.byte 193,13,9
	.asciz "RPC_S_UNSUPPORTED_TRANS_SYN"

	.byte 194,13,9
	.asciz "RPC_S_UNSUPPORTED_TYPE"

	.byte 196,13,9
	.asciz "RPC_S_INVALID_TAG"

	.byte 197,13,9
	.asciz "RPC_S_INVALID_BOUND"

	.byte 198,13,9
	.asciz "RPC_S_NO_ENTRY_NAME"

	.byte 199,13,9
	.asciz "RPC_S_INVALID_NAME_SYNTAX"

	.byte 200,13,9
	.asciz "RPC_S_UNSUPPORTED_NAME_SYNTAX"

	.byte 201,13,9
	.asciz "RPC_S_UUID_NO_ADDRESS"

	.byte 203,13,9
	.asciz "RPC_S_DUPLICATE_ENDPOINT"

	.byte 204,13,9
	.asciz "RPC_S_UNKNOWN_AUTHN_TYPE"

	.byte 205,13,9
	.asciz "RPC_S_MAX_CALLS_TOO_SMALL"

	.byte 206,13,9
	.asciz "RPC_S_STRING_TOO_LONG"

	.byte 207,13,9
	.asciz "RPC_S_PROTSEQ_NOT_FOUND"

	.byte 208,13,9
	.asciz "RPC_S_PROCNUM_OUT_OF_RANGE"

	.byte 209,13,9
	.asciz "RPC_S_BINDING_HAS_NO_AUTH"

	.byte 210,13,9
	.asciz "RPC_S_UNKNOWN_AUTHN_SERVICE"

	.byte 211,13,9
	.asciz "RPC_S_UNKNOWN_AUTHN_LEVEL"

	.byte 212,13,9
	.asciz "RPC_S_INVALID_AUTH_IDENTITY"

	.byte 213,13,9
	.asciz "RPC_S_UNKNOWN_AUTHZ_SERVICE"

	.byte 214,13,9
	.asciz "EPT_S_INVALID_ENTRY"

	.byte 215,13,9
	.asciz "EPT_S_CANT_PERFORM_OP"

	.byte 216,13,9
	.asciz "EPT_S_NOT_REGISTERED"

	.byte 217,13,9
	.asciz "RPC_S_NOTHING_TO_EXPORT"

	.byte 218,13,9
	.asciz "RPC_S_INCOMPLETE_NAME"

	.byte 219,13,9
	.asciz "RPC_S_INVALID_VERS_OPTION"

	.byte 220,13,9
	.asciz "RPC_S_NO_MORE_MEMBERS"

	.byte 221,13,9
	.asciz "RPC_S_NOT_ALL_OBJS_UNEXPORTED"

	.byte 222,13,9
	.asciz "RPC_S_INTERFACE_NOT_FOUND"

	.byte 223,13,9
	.asciz "RPC_S_ENTRY_ALREADY_EXISTS"

	.byte 224,13,9
	.asciz "RPC_S_ENTRY_NOT_FOUND"

	.byte 225,13,9
	.asciz "RPC_S_NAME_SERVICE_UNAVAILABLE"

	.byte 226,13,9
	.asciz "RPC_S_INVALID_NAF_ID"

	.byte 227,13,9
	.asciz "RPC_S_CANNOT_SUPPORT"

	.byte 228,13,9
	.asciz "RPC_S_NO_CONTEXT_AVAILABLE"

	.byte 229,13,9
	.asciz "RPC_S_INTERNAL_ERROR"

	.byte 230,13,9
	.asciz "RPC_S_ZERO_DIVIDE"

	.byte 231,13,9
	.asciz "RPC_S_ADDRESS_ERROR"

	.byte 232,13,9
	.asciz "RPC_S_FP_DIV_ZERO"

	.byte 233,13,9
	.asciz "RPC_S_FP_UNDERFLOW"

	.byte 234,13,9
	.asciz "RPC_S_FP_OVERFLOW"

	.byte 235,13,9
	.asciz "RPC_X_NO_MORE_ENTRIES"

	.byte 236,13,9
	.asciz "RPC_X_SS_CHAR_TRANS_OPEN_FAIL"

	.byte 237,13,9
	.asciz "RPC_X_SS_CHAR_TRANS_SHORT_FILE"

	.byte 238,13,9
	.asciz "RPC_X_SS_IN_NULL_CONTEXT"

	.byte 239,13,9
	.asciz "RPC_X_SS_CONTEXT_DAMAGED"

	.byte 241,13,9
	.asciz "RPC_X_SS_HANDLES_MISMATCH"

	.byte 242,13,9
	.asciz "RPC_X_SS_CANNOT_GET_CALL_HANDLE"

	.byte 243,13,9
	.asciz "RPC_X_NULL_REF_POINTER"

	.byte 244,13,9
	.asciz "RPC_X_ENUM_VALUE_OUT_OF_RANGE"

	.byte 245,13,9
	.asciz "RPC_X_BYTE_COUNT_TOO_SMALL"

	.byte 246,13,9
	.asciz "RPC_X_BAD_STUB_DATA"

	.byte 247,13,9
	.asciz "ERROR_INVALID_USER_BUFFER"

	.byte 248,13,9
	.asciz "ERROR_UNRECOGNIZED_MEDIA"

	.byte 249,13,9
	.asciz "ERROR_NO_TRUST_LSA_SECRET"

	.byte 250,13,9
	.asciz "ERROR_NO_TRUST_SAM_ACCOUNT"

	.byte 251,13,9
	.asciz "ERROR_TRUSTED_DOMAIN_FAILURE"

	.byte 252,13,9
	.asciz "ERROR_TRUST_FAILURE"

	.byte 254,13,9
	.asciz "RPC_S_CALL_IN_PROGRESS"

	.byte 255,13,9
	.asciz "ERROR_NETLOGON_NOT_STARTED"

	.byte 128,14,9
	.asciz "ERROR_ACCOUNT_EXPIRED"

	.byte 129,14,9
	.asciz "ERROR_UNKNOWN_PORT"

	.byte 132,14,9
	.asciz "ERROR_UNKNOWN_PRINTER_DRIVER"

	.byte 133,14,9
	.asciz "ERROR_UNKNOWN_PRINTPROCESSOR"

	.byte 134,14,9
	.asciz "ERROR_INVALID_SEPARATOR_FILE"

	.byte 135,14,9
	.asciz "ERROR_INVALID_PRIORITY"

	.byte 136,14,9
	.asciz "ERROR_INVALID_PRINTER_NAME"

	.byte 137,14,9
	.asciz "ERROR_PRINTER_ALREADY_EXISTS"

	.byte 138,14,9
	.asciz "ERROR_INVALID_PRINTER_COMMAND"

	.byte 139,14,9
	.asciz "ERROR_INVALID_DATATYPE"

	.byte 140,14,9
	.asciz "ERROR_INVALID_ENVIRONMENT"

	.byte 141,14,9
	.asciz "RPC_S_NO_MORE_BINDINGS"

	.byte 142,14,9
	.asciz "ERROR_DOMAIN_TRUST_INCONSISTENT"

	.byte 146,14,9
	.asciz "ERROR_SERVER_HAS_OPEN_HANDLES"

	.byte 147,14,9
	.asciz "ERROR_RESOURCE_DATA_NOT_FOUND"

	.byte 148,14,9
	.asciz "ERROR_RESOURCE_TYPE_NOT_FOUND"

	.byte 149,14,9
	.asciz "ERROR_RESOURCE_NAME_NOT_FOUND"

	.byte 150,14,9
	.asciz "ERROR_RESOURCE_LANG_NOT_FOUND"

	.byte 151,14,9
	.asciz "ERROR_NOT_ENOUGH_QUOTA"

	.byte 152,14,9
	.asciz "RPC_S_NO_INTERFACES"

	.byte 153,14,9
	.asciz "RPC_S_CALL_CANCELLED"

	.byte 154,14,9
	.asciz "RPC_S_BINDING_INCOMPLETE"

	.byte 155,14,9
	.asciz "RPC_S_COMM_FAILURE"

	.byte 156,14,9
	.asciz "RPC_S_UNSUPPORTED_AUTHN_LEVEL"

	.byte 157,14,9
	.asciz "RPC_S_NO_PRINC_NAME"

	.byte 158,14,9
	.asciz "RPC_S_NOT_RPC_ERROR"

	.byte 159,14,9
	.asciz "RPC_S_UUID_LOCAL_ONLY"

	.byte 160,14,9
	.asciz "RPC_S_SEC_PKG_ERROR"

	.byte 161,14,9
	.asciz "RPC_S_NOT_CANCELLED"

	.byte 162,14,9
	.asciz "RPC_X_INVALID_ES_ACTION"

	.byte 163,14,9
	.asciz "RPC_X_WRONG_ES_VERSION"

	.byte 164,14,9
	.asciz "RPC_X_WRONG_STUB_VERSION"

	.byte 165,14,9
	.asciz "RPC_X_INVALID_PIPE_OBJECT"

	.byte 166,14,9
	.asciz "RPC_X_WRONG_PIPE_ORDER"

	.byte 167,14,9
	.asciz "RPC_X_WRONG_PIPE_VERSION"

	.byte 168,14,9
	.asciz "RPC_S_COOKIE_AUTH_FAILED"

	.byte 169,14,9
	.asciz "RPC_S_DO_NOT_DISTURB"

	.byte 170,14,9
	.asciz "RPC_S_GROUP_MEMBER_NOT_FOUND"

	.byte 234,14,9
	.asciz "EPT_S_CANT_CREATE"

	.byte 235,14,9
	.asciz "RPC_S_INVALID_OBJECT"

	.byte 236,14,9
	.asciz "ERROR_INVALID_TIME"

	.byte 237,14,9
	.asciz "ERROR_INVALID_FORM_NAME"

	.byte 238,14,9
	.asciz "ERROR_INVALID_FORM_SIZE"

	.byte 239,14,9
	.asciz "ERROR_ALREADY_WAITING"

	.byte 240,14,9
	.asciz "ERROR_PRINTER_DELETED"

	.byte 241,14,9
	.asciz "ERROR_INVALID_PRINTER_STATE"

	.byte 242,14,9
	.asciz "ERROR_PASSWORD_MUST_CHANGE"

	.byte 243,14,9
	.asciz "ERROR_ACCOUNT_LOCKED_OUT"

	.byte 245,14,9
	.asciz "OR_INVALID_OXID"

	.byte 246,14,9
	.asciz "OR_INVALID_OID"

	.byte 247,14,9
	.asciz "OR_INVALID_SET"

	.byte 248,14,9
	.asciz "RPC_S_SEND_INCOMPLETE"

	.byte 249,14,9
	.asciz "RPC_S_INVALID_ASYNC_HANDLE"

	.byte 250,14,9
	.asciz "RPC_S_INVALID_ASYNC_CALL"

	.byte 251,14,9
	.asciz "RPC_X_PIPE_CLOSED"

	.byte 252,14,9
	.asciz "RPC_X_PIPE_DISCIPLINE_ERROR"

	.byte 253,14,9
	.asciz "RPC_X_PIPE_EMPTY"

	.byte 254,14,9
	.asciz "ERROR_NO_SITENAME"

	.byte 255,14,9
	.asciz "ERROR_CANT_ACCESS_FILE"

	.byte 128,15,9
	.asciz "ERROR_CANT_RESOLVE_FILENAME"

	.byte 129,15,9
	.asciz "RPC_S_ENTRY_TYPE_MISMATCH"

	.byte 130,15,9
	.asciz "RPC_S_NOT_ALL_OBJS_EXPORTED"

	.byte 131,15,9
	.asciz "RPC_S_INTERFACE_NOT_EXPORTED"

	.byte 132,15,9
	.asciz "RPC_S_PROFILE_NOT_ADDED"

	.byte 133,15,9
	.asciz "RPC_S_PRF_ELT_NOT_ADDED"

	.byte 134,15,9
	.asciz "RPC_S_PRF_ELT_NOT_REMOVED"

	.byte 135,15,9
	.asciz "RPC_S_GRP_ELT_NOT_ADDED"

	.byte 136,15,9
	.asciz "RPC_S_GRP_ELT_NOT_REMOVED"

	.byte 137,15,9
	.asciz "ERROR_KM_DRIVER_BLOCKED"

	.byte 138,15,9
	.asciz "ERROR_CONTEXT_EXPIRED"

	.byte 139,15,9
	.asciz "ERROR_NTLM_BLOCKED"

	.byte 145,15,9
	.asciz "ERROR_PASSWORD_CHANGE_REQUIRED"

	.byte 146,15,9
	.asciz "ERROR_INVALID_PIXEL_FORMAT"

	.byte 208,15,9
	.asciz "ERROR_BAD_DRIVER"

	.byte 209,15,9
	.asciz "ERROR_INVALID_WINDOW_STYLE"

	.byte 210,15,9
	.asciz "ERROR_METAFILE_NOT_SUPPORTED"

	.byte 211,15,9
	.asciz "ERROR_TRANSFORM_NOT_SUPPORTED"

	.byte 212,15,9
	.asciz "ERROR_CLIPPING_NOT_SUPPORTED"

	.byte 213,15,9
	.asciz "ERROR_INVALID_CMM"

	.byte 218,15,9
	.asciz "ERROR_INVALID_PROFILE"

	.byte 219,15,9
	.asciz "ERROR_TAG_NOT_FOUND"

	.byte 220,15,9
	.asciz "ERROR_TAG_NOT_PRESENT"

	.byte 221,15,9
	.asciz "ERROR_DUPLICATE_TAG"

	.byte 222,15,9
	.asciz "ERROR_PROFILE_NOT_FOUND"

	.byte 224,15,9
	.asciz "ERROR_INVALID_COLORSPACE"

	.byte 225,15,9
	.asciz "ERROR_ICM_NOT_ENABLED"

	.byte 226,15,9
	.asciz "ERROR_DELETING_ICM_XFORM"

	.byte 227,15,9
	.asciz "ERROR_INVALID_TRANSFORM"

	.byte 228,15,9
	.asciz "ERROR_COLORSPACE_MISMATCH"

	.byte 229,15,9
	.asciz "ERROR_INVALID_COLORINDEX"

	.byte 230,15,9
	.asciz "ERROR_CONNECTED_OTHER_PASSWORD"

	.byte 188,16,9
	.asciz "ERROR_BAD_USERNAME"

	.byte 154,17,9
	.asciz "ERROR_NOT_CONNECTED"

	.byte 202,17,9
	.asciz "ERROR_OPEN_FILES"

	.byte 225,18,9
	.asciz "ERROR_ACTIVE_CONNECTIONS"

	.byte 226,18,9
	.asciz "ERROR_DEVICE_IN_USE"

	.byte 228,18,9
	.asciz "ERROR_UNKNOWN_PRINT_MONITOR"

	.byte 184,23,9
	.asciz "ERROR_PRINTER_DRIVER_IN_USE"

	.byte 185,23,9
	.asciz "ERROR_SPOOL_FILE_NOT_FOUND"

	.byte 186,23,9
	.asciz "ERROR_SPL_NO_STARTDOC"

	.byte 187,23,9
	.asciz "ERROR_SPL_NO_ADDJOB"

	.byte 188,23,9
	.asciz "ERROR_INVALID_PRINT_MONITOR"

	.byte 191,23,9
	.asciz "ERROR_PRINT_MONITOR_IN_USE"

	.byte 192,23,9
	.asciz "ERROR_PRINTER_HAS_JOBS_QUEUED"

	.byte 193,23,9
	.asciz "ERROR_SUCCESS_REBOOT_REQUIRED"

	.byte 194,23,9
	.asciz "ERROR_SUCCESS_RESTART_REQUIRED"

	.byte 195,23,9
	.asciz "ERROR_PRINTER_NOT_FOUND"

	.byte 196,23,9
	.asciz "ERROR_PRINTER_DRIVER_WARNED"

	.byte 197,23,9
	.asciz "ERROR_PRINTER_DRIVER_BLOCKED"

	.byte 198,23,9
	.asciz "ERROR_FAIL_REBOOT_REQUIRED"

	.byte 201,23,9
	.asciz "ERROR_FAIL_REBOOT_INITIATED"

	.byte 202,23,9
	.asciz "ERROR_PRINTER_NOT_SHAREABLE"

	.byte 206,23,9
	.asciz "ERROR_REQUEST_PAUSED"

	.byte 234,23,9
	.asciz "ERROR_IO_REISSUE_AS_CACHED"

	.byte 238,30,9
	.asciz "ERROR_WINS_INTERNAL"

	.byte 160,31,9
	.asciz "ERROR_CAN_NOT_DEL_LOCAL_WINS"

	.byte 161,31,9
	.asciz "ERROR_STATIC_INIT"

	.byte 162,31,9
	.asciz "ERROR_INC_BACKUP"

	.byte 163,31,9
	.asciz "ERROR_FULL_BACKUP"

	.byte 164,31,9
	.asciz "ERROR_REC_NON_EXISTENT"

	.byte 165,31,9
	.asciz "ERROR_RPL_NOT_ALLOWED"

	.byte 166,31,9
	.asciz "PEERDIST_ERROR_MISSING_DATA"

	.byte 212,31,9
	.asciz "PEERDIST_ERROR_NO_MORE"

	.byte 213,31,9
	.asciz "PEERDIST_ERROR_NOT_INITIALIZED"

	.byte 214,31,9
	.asciz "PEERDIST_ERROR_INVALIDATED"

	.byte 217,31,9
	.asciz "PEERDIST_ERROR_ALREADY_EXISTS"

	.byte 218,31,9
	.asciz "PEERDIST_ERROR_OUT_OF_BOUNDS"

	.byte 221,31,9
	.asciz "PEERDIST_ERROR_NOT_LICENSED"

	.byte 224,31,9
	.asciz "PEERDIST_ERROR_TRUST_FAILURE"

	.byte 226,31,9
	.asciz "ERROR_DHCP_ADDRESS_CONFLICT"

	.byte 132,32,9
	.asciz "ERROR_WMI_GUID_NOT_FOUND"

	.byte 232,32,9
	.asciz "ERROR_WMI_INSTANCE_NOT_FOUND"

	.byte 233,32,9
	.asciz "ERROR_WMI_ITEMID_NOT_FOUND"

	.byte 234,32,9
	.asciz "ERROR_WMI_TRY_AGAIN"

	.byte 235,32,9
	.asciz "ERROR_WMI_DP_NOT_FOUND"

	.byte 236,32,9
	.asciz "ERROR_WMI_ALREADY_ENABLED"

	.byte 238,32,9
	.asciz "ERROR_WMI_GUID_DISCONNECTED"

	.byte 239,32,9
	.asciz "ERROR_WMI_SERVER_UNAVAILABLE"

	.byte 240,32,9
	.asciz "ERROR_WMI_DP_FAILED"

	.byte 241,32,9
	.asciz "ERROR_WMI_INVALID_MOF"

	.byte 242,32,9
	.asciz "ERROR_WMI_INVALID_REGINFO"

	.byte 243,32,9
	.asciz "ERROR_WMI_ALREADY_DISABLED"

	.byte 244,32,9
	.asciz "ERROR_WMI_READ_ONLY"

	.byte 245,32,9
	.asciz "ERROR_WMI_SET_FAILURE"

	.byte 246,32,9
	.asciz "ERROR_NOT_APPCONTAINER"

	.byte 154,33,9
	.asciz "ERROR_APPCONTAINER_REQUIRED"

	.byte 155,33,9
	.asciz "ERROR_INVALID_MEDIA"

	.byte 204,33,9
	.asciz "ERROR_INVALID_LIBRARY"

	.byte 205,33,9
	.asciz "ERROR_INVALID_MEDIA_POOL"

	.byte 206,33,9
	.asciz "ERROR_DRIVE_MEDIA_MISMATCH"

	.byte 207,33,9
	.asciz "ERROR_MEDIA_OFFLINE"

	.byte 208,33,9
	.asciz "ERROR_LIBRARY_OFFLINE"

	.byte 209,33,9
	.asciz "ERROR_EMPTY"

	.byte 210,33,9
	.asciz "ERROR_NOT_EMPTY"

	.byte 211,33,9
	.asciz "ERROR_MEDIA_UNAVAILABLE"

	.byte 212,33,9
	.asciz "ERROR_RESOURCE_DISABLED"

	.byte 213,33,9
	.asciz "ERROR_INVALID_CLEANER"

	.byte 214,33,9
	.asciz "ERROR_UNABLE_TO_CLEAN"

	.byte 215,33,9
	.asciz "ERROR_OBJECT_NOT_FOUND"

	.byte 216,33,9
	.asciz "ERROR_DATABASE_FAILURE"

	.byte 217,33,9
	.asciz "ERROR_DATABASE_FULL"

	.byte 218,33,9
	.asciz "ERROR_MEDIA_INCOMPATIBLE"

	.byte 219,33,9
	.asciz "ERROR_RESOURCE_NOT_PRESENT"

	.byte 220,33,9
	.asciz "ERROR_INVALID_OPERATION"

	.byte 221,33,9
	.asciz "ERROR_MEDIA_NOT_AVAILABLE"

	.byte 222,33,9
	.asciz "ERROR_DEVICE_NOT_AVAILABLE"

	.byte 223,33,9
	.asciz "ERROR_REQUEST_REFUSED"

	.byte 224,33,9
	.asciz "ERROR_INVALID_DRIVE_OBJECT"

	.byte 225,33,9
	.asciz "ERROR_LIBRARY_FULL"

	.byte 226,33,9
	.asciz "ERROR_MEDIUM_NOT_ACCESSIBLE"

	.byte 227,33,9
	.asciz "ERROR_UNABLE_TO_LOAD_MEDIUM"

	.byte 228,33,9
	.asciz "ERROR_UNABLE_TO_INVENTORY_DRIVE"

	.byte 229,33,9
	.asciz "ERROR_UNABLE_TO_INVENTORY_SLOT"

	.byte 230,33,9
	.asciz "ERROR_TRANSPORT_FULL"

	.byte 232,33,9
	.asciz "ERROR_CONTROLLING_IEPORT"

	.byte 233,33,9
	.asciz "ERROR_CLEANER_SLOT_SET"

	.byte 235,33,9
	.asciz "ERROR_CLEANER_SLOT_NOT_SET"

	.byte 236,33,9
	.asciz "ERROR_CLEANER_CARTRIDGE_SPENT"

	.byte 237,33,9
	.asciz "ERROR_UNEXPECTED_OMID"

	.byte 238,33,9
	.asciz "ERROR_CANT_DELETE_LAST_ITEM"

	.byte 239,33,9
	.asciz "ERROR_MESSAGE_EXCEEDS_MAX_SIZE"

	.byte 240,33,9
	.asciz "ERROR_VOLUME_CONTAINS_SYS_FILES"

	.byte 241,33,9
	.asciz "ERROR_INDIGENOUS_TYPE"

	.byte 242,33,9
	.asciz "ERROR_NO_SUPPORTING_DRIVES"

	.byte 243,33,9
	.asciz "ERROR_IEPORT_FULL"

	.byte 245,33,9
	.asciz "ERROR_FILE_OFFLINE"

	.byte 254,33,9
	.asciz "ERROR_REMOTE_STORAGE_NOT_ACTIVE"

	.byte 255,33,9
	.asciz "ERROR_NOT_A_REPARSE_POINT"

	.byte 166,34,9
	.asciz "ERROR_INVALID_REPARSE_DATA"

	.byte 168,34,9
	.asciz "ERROR_REPARSE_TAG_INVALID"

	.byte 169,34,9
	.asciz "ERROR_REPARSE_TAG_MISMATCH"

	.byte 170,34,9
	.asciz "ERROR_APP_DATA_NOT_FOUND"

	.byte 176,34,9
	.asciz "ERROR_APP_DATA_EXPIRED"

	.byte 177,34,9
	.asciz "ERROR_APP_DATA_CORRUPT"

	.byte 178,34,9
	.asciz "ERROR_APP_DATA_LIMIT_EXCEEDED"

	.byte 179,34,9
	.asciz "ERROR_APP_DATA_REBOOT_REQUIRED"

	.byte 180,34,9
	.asciz "ERROR_SECUREBOOT_INVALID_POLICY"

	.byte 198,34,9
	.asciz "ERROR_SECUREBOOT_NOT_ENABLED"

	.byte 201,34,9
	.asciz "ERROR_SECUREBOOT_FILE_REPLACED"

	.byte 202,34,9
	.asciz "ERROR_VOLUME_NOT_SIS_ENABLED"

	.byte 148,35,9
	.asciz "ERROR_VSM_NOT_INITIALIZED"

	.byte 208,35,9
	.asciz "ERROR_DEPENDENT_RESOURCE_EXISTS"

	.byte 137,39,9
	.asciz "ERROR_DEPENDENCY_NOT_FOUND"

	.byte 138,39,9
	.asciz "ERROR_DEPENDENCY_ALREADY_EXISTS"

	.byte 139,39,9
	.asciz "ERROR_RESOURCE_NOT_ONLINE"

	.byte 140,39,9
	.asciz "ERROR_HOST_NODE_NOT_AVAILABLE"

	.byte 141,39,9
	.asciz "ERROR_RESOURCE_NOT_AVAILABLE"

	.byte 142,39,9
	.asciz "ERROR_RESOURCE_NOT_FOUND"

	.byte 143,39,9
	.asciz "ERROR_SHUTDOWN_CLUSTER"

	.byte 144,39,9
	.asciz "ERROR_CANT_EVICT_ACTIVE_NODE"

	.byte 145,39,9
	.asciz "ERROR_OBJECT_ALREADY_EXISTS"

	.byte 146,39,9
	.asciz "ERROR_OBJECT_IN_LIST"

	.byte 147,39,9
	.asciz "ERROR_GROUP_NOT_AVAILABLE"

	.byte 148,39,9
	.asciz "ERROR_GROUP_NOT_FOUND"

	.byte 149,39,9
	.asciz "ERROR_GROUP_NOT_ONLINE"

	.byte 150,39,9
	.asciz "ERROR_HOST_NODE_NOT_GROUP_OWNER"

	.byte 152,39,9
	.asciz "ERROR_RESMON_CREATE_FAILED"

	.byte 153,39,9
	.asciz "ERROR_RESMON_ONLINE_FAILED"

	.byte 154,39,9
	.asciz "ERROR_RESOURCE_ONLINE"

	.byte 155,39,9
	.asciz "ERROR_QUORUM_RESOURCE"

	.byte 156,39,9
	.asciz "ERROR_NOT_QUORUM_CAPABLE"

	.byte 157,39,9
	.asciz "ERROR_CLUSTER_SHUTTING_DOWN"

	.byte 158,39,9
	.asciz "ERROR_INVALID_STATE"

	.byte 159,39,9
	.asciz "ERROR_NOT_QUORUM_CLASS"

	.byte 161,39,9
	.asciz "ERROR_CORE_RESOURCE"

	.byte 162,39,9
	.asciz "ERROR_QUORUMLOG_OPEN_FAILED"

	.byte 164,39,9
	.asciz "ERROR_CLUSTERLOG_CORRUPT"

	.byte 165,39,9
	.asciz "ERROR_QUORUM_OWNER_ALIVE"

	.byte 170,39,9
	.asciz "ERROR_NETWORK_NOT_AVAILABLE"

	.byte 171,39,9
	.asciz "ERROR_NODE_NOT_AVAILABLE"

	.byte 172,39,9
	.asciz "ERROR_ALL_NODES_NOT_AVAILABLE"

	.byte 173,39,9
	.asciz "ERROR_RESOURCE_FAILED"

	.byte 174,39,9
	.asciz "ERROR_CLUSTER_INVALID_NODE"

	.byte 175,39,9
	.asciz "ERROR_CLUSTER_NODE_EXISTS"

	.byte 176,39,9
	.asciz "ERROR_CLUSTER_JOIN_IN_PROGRESS"

	.byte 177,39,9
	.asciz "ERROR_CLUSTER_NODE_NOT_FOUND"

	.byte 178,39,9
	.asciz "ERROR_CLUSTER_NETWORK_EXISTS"

	.byte 180,39,9
	.asciz "ERROR_CLUSTER_NETWORK_NOT_FOUND"

	.byte 181,39,9
	.asciz "ERROR_CLUSTER_INVALID_REQUEST"

	.byte 184,39,9
	.asciz "ERROR_CLUSTER_NODE_DOWN"

	.byte 186,39,9
	.asciz "ERROR_CLUSTER_NODE_UNREACHABLE"

	.byte 187,39,9
	.asciz "ERROR_CLUSTER_NODE_NOT_MEMBER"

	.byte 188,39,9
	.asciz "ERROR_CLUSTER_INVALID_NETWORK"

	.byte 190,39,9
	.asciz "ERROR_CLUSTER_NODE_UP"

	.byte 192,39,9
	.asciz "ERROR_CLUSTER_IPADDR_IN_USE"

	.byte 193,39,9
	.asciz "ERROR_CLUSTER_NODE_NOT_PAUSED"

	.byte 194,39,9
	.asciz "ERROR_CLUSTER_NODE_ALREADY_UP"

	.byte 197,39,9
	.asciz "ERROR_CLUSTER_NODE_ALREADY_DOWN"

	.byte 198,39,9
	.asciz "ERROR_DEPENDENCY_NOT_ALLOWED"

	.byte 205,39,9
	.asciz "ERROR_CLUSTER_NODE_PAUSED"

	.byte 206,39,9
	.asciz "ERROR_NODE_CANT_HOST_RESOURCE"

	.byte 207,39,9
	.asciz "ERROR_CLUSTER_NODE_NOT_READY"

	.byte 208,39,9
	.asciz "ERROR_CLUSTER_JOIN_ABORTED"

	.byte 210,39,9
	.asciz "ERROR_CLUSTER_RESNAME_NOT_FOUND"

	.byte 216,39,9
	.asciz "ERROR_RESMON_INVALID_STATE"

	.byte 220,39,9
	.asciz "ERROR_CLUSTER_GUM_NOT_LOCKER"

	.byte 221,39,9
	.asciz "ERROR_QUORUM_DISK_NOT_FOUND"

	.byte 222,39,9
	.asciz "ERROR_DATABASE_BACKUP_CORRUPT"

	.byte 223,39,9
	.asciz "ERROR_NO_ADMIN_ACCESS_POINT"

	.byte 226,39,9
	.asciz "ERROR_CLUSTER_MEMBERSHIP_HALT"

	.byte 132,46,9
	.asciz "ERROR_NODE_CANNOT_BE_CLUSTERED"

	.byte 138,46,9
	.asciz "ERROR_CLUSTER_WRONG_OS_VERSION"

	.byte 139,46,9
	.asciz "ERROR_CLUSCFG_ALREADY_COMMITTED"

	.byte 141,46,9
	.asciz "ERROR_CLUSCFG_ROLLBACK_FAILED"

	.byte 142,46,9
	.asciz "ERROR_CLUSTER_OLD_VERSION"

	.byte 144,46,9
	.asciz "ERROR_CLUSTER_NO_NET_ADAPTERS"

	.byte 146,46,9
	.asciz "ERROR_CLUSTER_POISONED"

	.byte 147,46,9
	.asciz "ERROR_CLUSTER_GROUP_MOVING"

	.byte 148,46,9
	.asciz "ERROR_RESOURCE_CALL_TIMED_OUT"

	.byte 150,46,9
	.asciz "ERROR_CLUSTER_PARTIAL_SEND"

	.byte 154,46,9
	.asciz "ERROR_CLUSTER_NULL_DATA"

	.byte 160,46,9
	.asciz "ERROR_CLUSTER_PARTIAL_READ"

	.byte 161,46,9
	.asciz "ERROR_CLUSTER_PARTIAL_WRITE"

	.byte 162,46,9
	.asciz "ERROR_CLUSTER_NO_QUORUM"

	.byte 165,46,9
	.asciz "ERROR_CLUSTER_NOT_INSTALLED"

	.byte 172,46,9
	.asciz "ERROR_CLUSTER_TOO_MANY_NODES"

	.byte 175,46,9
	.asciz "ERROR_NONCORE_GROUPS_FOUND"

	.byte 177,46,9
	.asciz "ERROR_CLUSTER_GROUP_BUSY"

	.byte 184,46,9
	.asciz "ERROR_CLUSTER_NOT_SHARED_VOLUME"

	.byte 185,46,9
	.asciz "ERROR_NON_CSV_PATH"

	.byte 190,46,9
	.asciz "ERROR_CSV_VOLUME_NOT_LOCAL"

	.byte 191,46,9
	.asciz "ERROR_CLUSTER_GROUP_QUEUED"

	.byte 199,46,9
	.asciz "ERROR_DISK_NOT_CSV_CAPABLE"

	.byte 204,46,9
	.asciz "ERROR_CLUSTER_AFFINITY_CONFLICT"

	.byte 211,46,9
	.asciz "ERROR_CLUSTER_NODE_ISOLATED"

	.byte 224,46,9
	.asciz "ERROR_CLUSTER_NODE_QUARANTINED"

	.byte 225,46,9
	.asciz "ERROR_CLUSTER_SPACE_DEGRADED"

	.byte 227,46,9
	.asciz "ERROR_ENCRYPTION_FAILED"

	.byte 240,46,9
	.asciz "ERROR_DECRYPTION_FAILED"

	.byte 241,46,9
	.asciz "ERROR_FILE_ENCRYPTED"

	.byte 242,46,9
	.asciz "ERROR_NO_RECOVERY_POLICY"

	.byte 243,46,9
	.asciz "ERROR_NO_EFS"

	.byte 244,46,9
	.asciz "ERROR_WRONG_EFS"

	.byte 245,46,9
	.asciz "ERROR_NO_USER_KEYS"

	.byte 246,46,9
	.asciz "ERROR_FILE_NOT_ENCRYPTED"

	.byte 247,46,9
	.asciz "ERROR_NOT_EXPORT_FORMAT"

	.byte 248,46,9
	.asciz "ERROR_FILE_READ_ONLY"

	.byte 249,46,9
	.asciz "ERROR_DIR_EFS_DISALLOWED"

	.byte 250,46,9
	.asciz "ERROR_EFS_SERVER_NOT_TRUSTED"

	.byte 251,46,9
	.asciz "ERROR_BAD_RECOVERY_POLICY"

	.byte 252,46,9
	.asciz "ERROR_EFS_ALG_BLOB_TOO_BIG"

	.byte 253,46,9
	.asciz "ERROR_VOLUME_NOT_SUPPORT_EFS"

	.byte 254,46,9
	.asciz "ERROR_EFS_DISABLED"

	.byte 255,46,9
	.asciz "ERROR_EFS_VERSION_NOT_SUPPORT"

	.byte 128,47,9
	.asciz "ERROR_NO_BROWSER_SERVERS_FOUND"

	.byte 230,47,9
	.asciz "SCHED_E_SERVICE_NOT_LOCALSYSTEM"

	.byte 184,48,9
	.asciz "ERROR_LOG_SECTOR_INVALID"

	.byte 200,51,9
	.asciz "ERROR_LOG_SECTOR_PARITY_INVALID"

	.byte 201,51,9
	.asciz "ERROR_LOG_SECTOR_REMAPPED"

	.byte 202,51,9
	.asciz "ERROR_LOG_BLOCK_INCOMPLETE"

	.byte 203,51,9
	.asciz "ERROR_LOG_INVALID_RANGE"

	.byte 204,51,9
	.asciz "ERROR_LOG_BLOCKS_EXHAUSTED"

	.byte 205,51,9
	.asciz "ERROR_LOG_READ_CONTEXT_INVALID"

	.byte 206,51,9
	.asciz "ERROR_LOG_RESTART_INVALID"

	.byte 207,51,9
	.asciz "ERROR_LOG_BLOCK_VERSION"

	.byte 208,51,9
	.asciz "ERROR_LOG_BLOCK_INVALID"

	.byte 209,51,9
	.asciz "ERROR_LOG_READ_MODE_INVALID"

	.byte 210,51,9
	.asciz "ERROR_LOG_NO_RESTART"

	.byte 211,51,9
	.asciz "ERROR_LOG_METADATA_CORRUPT"

	.byte 212,51,9
	.asciz "ERROR_LOG_METADATA_INVALID"

	.byte 213,51,9
	.asciz "ERROR_LOG_METADATA_INCONSISTENT"

	.byte 214,51,9
	.asciz "ERROR_LOG_RESERVATION_INVALID"

	.byte 215,51,9
	.asciz "ERROR_LOG_CANT_DELETE"

	.byte 216,51,9
	.asciz "ERROR_LOG_START_OF_LOG"

	.byte 218,51,9
	.asciz "ERROR_LOG_POLICY_NOT_INSTALLED"

	.byte 220,51,9
	.asciz "ERROR_LOG_POLICY_INVALID"

	.byte 221,51,9
	.asciz "ERROR_LOG_POLICY_CONFLICT"

	.byte 222,51,9
	.asciz "ERROR_LOG_PINNED_ARCHIVE_TAIL"

	.byte 223,51,9
	.asciz "ERROR_LOG_RECORD_NONEXISTENT"

	.byte 224,51,9
	.asciz "ERROR_LOG_TAIL_INVALID"

	.byte 227,51,9
	.asciz "ERROR_LOG_FULL"

	.byte 228,51,9
	.asciz "ERROR_COULD_NOT_RESIZE_LOG"

	.byte 229,51,9
	.asciz "ERROR_LOG_MULTIPLEXED"

	.byte 230,51,9
	.asciz "ERROR_LOG_DEDICATED"

	.byte 231,51,9
	.asciz "ERROR_LOG_ARCHIVE_IN_PROGRESS"

	.byte 233,51,9
	.asciz "ERROR_LOG_EPHEMERAL"

	.byte 234,51,9
	.asciz "ERROR_LOG_NOT_ENOUGH_CONTAINERS"

	.byte 235,51,9
	.asciz "ERROR_LOG_CLIENT_NOT_REGISTERED"

	.byte 237,51,9
	.asciz "ERROR_LOG_CONTAINER_READ_FAILED"

	.byte 239,51,9
	.asciz "ERROR_LOG_CONTAINER_OPEN_FAILED"

	.byte 241,51,9
	.asciz "ERROR_LOG_STATE_INVALID"

	.byte 243,51,9
	.asciz "ERROR_LOG_PINNED"

	.byte 244,51,9
	.asciz "ERROR_LOG_METADATA_FLUSH_FAILED"

	.byte 245,51,9
	.asciz "ERROR_LOG_INCONSISTENT_SECURITY"

	.byte 246,51,9
	.asciz "ERROR_LOG_APPENDED_FLUSH_FAILED"

	.byte 247,51,9
	.asciz "ERROR_LOG_PINNED_RESERVATION"

	.byte 248,51,9
	.asciz "ERROR_INVALID_TRANSACTION"

	.byte 172,52,9
	.asciz "ERROR_TRANSACTION_NOT_ACTIVE"

	.byte 173,52,9
	.asciz "ERROR_TRANSACTION_NOT_REQUESTED"

	.byte 175,52,9
	.asciz "ERROR_TM_INITIALIZATION_FAILED"

	.byte 178,52,9
	.asciz "ERROR_RESOURCEMANAGER_READ_ONLY"

	.byte 179,52,9
	.asciz "ERROR_TRANSACTION_NOT_JOINED"

	.byte 180,52,9
	.asciz "ERROR_CRM_PROTOCOL_NOT_FOUND"

	.byte 184,52,9
	.asciz "ERROR_TRANSACTION_NOT_FOUND"

	.byte 187,52,9
	.asciz "ERROR_RESOURCEMANAGER_NOT_FOUND"

	.byte 188,52,9
	.asciz "ERROR_ENLISTMENT_NOT_FOUND"

	.byte 189,52,9
	.asciz "ERROR_TRANSACTION_NOT_ROOT"

	.byte 193,52,9
	.asciz "ERROR_TRANSACTION_NO_SUPERIOR"

	.byte 202,52,9
	.asciz "ERROR_HEURISTIC_DAMAGE_POSSIBLE"

	.byte 203,52,9
	.asciz "ERROR_TRANSACTIONAL_CONFLICT"

	.byte 144,53,9
	.asciz "ERROR_RM_NOT_ACTIVE"

	.byte 145,53,9
	.asciz "ERROR_RM_METADATA_CORRUPT"

	.byte 146,53,9
	.asciz "ERROR_DIRECTORY_NOT_RM"

	.byte 147,53,9
	.asciz "ERROR_LOG_RESIZE_INVALID_SIZE"

	.byte 150,53,9
	.asciz "ERROR_OBJECT_NO_LONGER_EXISTS"

	.byte 151,53,9
	.asciz "ERROR_HANDLE_NO_LONGER_VALID"

	.byte 159,53,9
	.asciz "ERROR_NO_TXF_METADATA"

	.byte 160,53,9
	.asciz "ERROR_LOG_CORRUPTION_DETECTED"

	.byte 161,53,9
	.asciz "ERROR_RM_DISCONNECTED"

	.byte 163,53,9
	.asciz "ERROR_ENLISTMENT_NOT_SUPERIOR"

	.byte 164,53,9
	.asciz "ERROR_RECOVERY_NOT_NEEDED"

	.byte 165,53,9
	.asciz "ERROR_RM_ALREADY_STARTED"

	.byte 166,53,9
	.asciz "ERROR_CANT_CROSS_RM_BOUNDARY"

	.byte 169,53,9
	.asciz "ERROR_TXF_DIR_NOT_EMPTY"

	.byte 170,53,9
	.asciz "ERROR_TM_VOLATILE"

	.byte 172,53,9
	.asciz "ERROR_ROLLBACK_TIMER_EXPIRED"

	.byte 173,53,9
	.asciz "ERROR_TXF_ATTRIBUTE_CORRUPT"

	.byte 174,53,9
	.asciz "ERROR_LOG_GROWTH_FAILED"

	.byte 177,53,9
	.asciz "ERROR_TRANSACTIONS_NOT_FROZEN"

	.byte 183,53,9
	.asciz "ERROR_NOT_SNAPSHOT_VOLUME"

	.byte 185,53,9
	.asciz "ERROR_DATA_LOST_REPAIR"

	.byte 187,53,9
	.asciz "ERROR_TM_IDENTITY_MISMATCH"

	.byte 189,53,9
	.asciz "ERROR_FLOATED_SECTION"

	.byte 190,53,9
	.asciz "ERROR_CANNOT_ABORT_TRANSACTIONS"

	.byte 192,53,9
	.asciz "ERROR_BAD_CLUSTERS"

	.byte 193,53,9
	.asciz "ERROR_VOLUME_DIRTY"

	.byte 195,53,9
	.asciz "ERROR_EXPIRED_HANDLE"

	.byte 198,53,9
	.asciz "ERROR_TRANSACTION_NOT_ENLISTED"

	.byte 199,53,9
	.asciz "ERROR_CTX_INVALID_PD"

	.byte 218,54,9
	.asciz "ERROR_CTX_PD_NOT_FOUND"

	.byte 219,54,9
	.asciz "ERROR_CTX_WD_NOT_FOUND"

	.byte 220,54,9
	.asciz "ERROR_CTX_CLOSE_PENDING"

	.byte 223,54,9
	.asciz "ERROR_CTX_NO_OUTBUF"

	.byte 224,54,9
	.asciz "ERROR_CTX_MODEM_INF_NOT_FOUND"

	.byte 225,54,9
	.asciz "ERROR_CTX_INVALID_MODEMNAME"

	.byte 226,54,9
	.asciz "ERROR_CTX_MODEM_RESPONSE_ERROR"

	.byte 227,54,9
	.asciz "ERROR_CTX_MODEM_RESPONSE_BUSY"

	.byte 231,54,9
	.asciz "ERROR_CTX_MODEM_RESPONSE_VOICE"

	.byte 232,54,9
	.asciz "ERROR_CTX_TD_ERROR"

	.byte 233,54,9
	.asciz "ERROR_CTX_WINSTATION_NOT_FOUND"

	.byte 238,54,9
	.asciz "ERROR_CTX_WINSTATION_BUSY"

	.byte 240,54,9
	.asciz "ERROR_CTX_BAD_VIDEO_MODE"

	.byte 241,54,9
	.asciz "ERROR_CTX_GRAPHICS_INVALID"

	.byte 251,54,9
	.asciz "ERROR_CTX_LOGON_DISABLED"

	.byte 253,54,9
	.asciz "ERROR_CTX_NOT_CONSOLE"

	.byte 254,54,9
	.asciz "ERROR_CTX_CLIENT_QUERY_TIMEOUT"

	.byte 128,55,9
	.asciz "ERROR_CTX_CONSOLE_DISCONNECT"

	.byte 129,55,9
	.asciz "ERROR_CTX_CONSOLE_CONNECT"

	.byte 130,55,9
	.asciz "ERROR_CTX_SHADOW_DENIED"

	.byte 132,55,9
	.asciz "ERROR_CTX_INVALID_WD"

	.byte 137,55,9
	.asciz "ERROR_CTX_SHADOW_INVALID"

	.byte 138,55,9
	.asciz "ERROR_CTX_SHADOW_DISABLED"

	.byte 139,55,9
	.asciz "ERROR_CTX_CLIENT_LICENSE_IN_USE"

	.byte 140,55,9
	.asciz "ERROR_CTX_LICENSE_NOT_AVAILABLE"

	.byte 142,55,9
	.asciz "ERROR_CTX_LICENSE_EXPIRED"

	.byte 144,55,9
	.asciz "ERROR_CTX_SHADOW_NOT_RUNNING"

	.byte 145,55,9
	.asciz "ERROR_ACTIVATION_COUNT_EXCEEDED"

	.byte 147,55,9
	.asciz "ERROR_CTX_WINSTATIONS_DISABLED"

	.byte 148,55,9
	.asciz "ERROR_CTX_SESSION_IN_USE"

	.byte 150,55,9
	.asciz "ERROR_CTX_NO_FORCE_LOGOFF"

	.byte 151,55,9
	.asciz "ERROR_CTX_ACCOUNT_RESTRICTION"

	.byte 152,55,9
	.asciz "ERROR_RDP_PROTOCOL_ERROR"

	.byte 153,55,9
	.asciz "ERROR_CTX_CDM_CONNECT"

	.byte 154,55,9
	.asciz "ERROR_CTX_CDM_DISCONNECT"

	.byte 155,55,9
	.asciz "ERROR_CTX_SECURITY_LAYER_ERROR"

	.byte 156,55,9
	.asciz "ERROR_TS_INCOMPATIBLE_SESSIONS"

	.byte 157,55,9
	.asciz "ERROR_TS_VIDEO_SUBSYSTEM_ERROR"

	.byte 158,55,9
	.asciz "FRS_ERR_INVALID_API_SEQUENCE"

	.byte 193,62,9
	.asciz "FRS_ERR_STARTING_SERVICE"

	.byte 194,62,9
	.asciz "FRS_ERR_STOPPING_SERVICE"

	.byte 195,62,9
	.asciz "FRS_ERR_INTERNAL_API"

	.byte 196,62,9
	.asciz "FRS_ERR_INTERNAL"

	.byte 197,62,9
	.asciz "FRS_ERR_SERVICE_COMM"

	.byte 198,62,9
	.asciz "FRS_ERR_INSUFFICIENT_PRIV"

	.byte 199,62,9
	.asciz "FRS_ERR_AUTHENTICATION"

	.byte 200,62,9
	.asciz "FRS_ERR_PARENT_AUTHENTICATION"

	.byte 202,62,9
	.asciz "FRS_ERR_CHILD_TO_PARENT_COMM"

	.byte 203,62,9
	.asciz "FRS_ERR_PARENT_TO_CHILD_COMM"

	.byte 204,62,9
	.asciz "FRS_ERR_SYSVOL_POPULATE"

	.byte 205,62,9
	.asciz "FRS_ERR_SYSVOL_POPULATE_TIMEOUT"

	.byte 206,62,9
	.asciz "FRS_ERR_SYSVOL_IS_BUSY"

	.byte 207,62,9
	.asciz "FRS_ERR_SYSVOL_DEMOTE"

	.byte 208,62,9
	.asciz "ERROR_DS_NOT_INSTALLED"

	.byte 136,192,0,9
	.asciz "ERROR_DS_NO_ATTRIBUTE_OR_VALUE"

	.byte 138,192,0,9
	.asciz "ERROR_DS_BUSY"

	.byte 142,192,0,9
	.asciz "ERROR_DS_UNAVAILABLE"

	.byte 143,192,0,9
	.asciz "ERROR_DS_NO_RIDS_ALLOCATED"

	.byte 144,192,0,9
	.asciz "ERROR_DS_NO_MORE_RIDS"

	.byte 145,192,0,9
	.asciz "ERROR_DS_INCORRECT_ROLE_OWNER"

	.byte 146,192,0,9
	.asciz "ERROR_DS_RIDMGR_INIT_ERROR"

	.byte 147,192,0,9
	.asciz "ERROR_DS_OBJ_CLASS_VIOLATION"

	.byte 148,192,0,9
	.asciz "ERROR_DS_CANT_ON_NON_LEAF"

	.byte 149,192,0,9
	.asciz "ERROR_DS_CANT_ON_RDN"

	.byte 150,192,0,9
	.asciz "ERROR_DS_CANT_MOD_OBJ_CLASS"

	.byte 151,192,0,9
	.asciz "ERROR_DS_CROSS_DOM_MOVE_ERROR"

	.byte 152,192,0,9
	.asciz "ERROR_DS_GC_NOT_AVAILABLE"

	.byte 153,192,0,9
	.asciz "ERROR_SHARED_POLICY"

	.byte 154,192,0,9
	.asciz "ERROR_POLICY_OBJECT_NOT_FOUND"

	.byte 155,192,0,9
	.asciz "ERROR_POLICY_ONLY_IN_DS"

	.byte 156,192,0,9
	.asciz "ERROR_PROMOTION_ACTIVE"

	.byte 157,192,0,9
	.asciz "ERROR_NO_PROMOTION_ACTIVE"

	.byte 158,192,0,9
	.asciz "ERROR_DS_OPERATIONS_ERROR"

	.byte 160,192,0,9
	.asciz "ERROR_DS_PROTOCOL_ERROR"

	.byte 161,192,0,9
	.asciz "ERROR_DS_TIMELIMIT_EXCEEDED"

	.byte 162,192,0,9
	.asciz "ERROR_DS_SIZELIMIT_EXCEEDED"

	.byte 163,192,0,9
	.asciz "ERROR_DS_ADMIN_LIMIT_EXCEEDED"

	.byte 164,192,0,9
	.asciz "ERROR_DS_COMPARE_FALSE"

	.byte 165,192,0,9
	.asciz "ERROR_DS_COMPARE_TRUE"

	.byte 166,192,0,9
	.asciz "ERROR_DS_STRONG_AUTH_REQUIRED"

	.byte 168,192,0,9
	.asciz "ERROR_DS_INAPPROPRIATE_AUTH"

	.byte 169,192,0,9
	.asciz "ERROR_DS_AUTH_UNKNOWN"

	.byte 170,192,0,9
	.asciz "ERROR_DS_REFERRAL"

	.byte 171,192,0,9
	.asciz "ERROR_DS_INAPPROPRIATE_MATCHING"

	.byte 174,192,0,9
	.asciz "ERROR_DS_CONSTRAINT_VIOLATION"

	.byte 175,192,0,9
	.asciz "ERROR_DS_NO_SUCH_OBJECT"

	.byte 176,192,0,9
	.asciz "ERROR_DS_ALIAS_PROBLEM"

	.byte 177,192,0,9
	.asciz "ERROR_DS_INVALID_DN_SYNTAX"

	.byte 178,192,0,9
	.asciz "ERROR_DS_IS_LEAF"

	.byte 179,192,0,9
	.asciz "ERROR_DS_ALIAS_DEREF_PROBLEM"

	.byte 180,192,0,9
	.asciz "ERROR_DS_UNWILLING_TO_PERFORM"

	.byte 181,192,0,9
	.asciz "ERROR_DS_LOOP_DETECT"

	.byte 182,192,0,9
	.asciz "ERROR_DS_NAMING_VIOLATION"

	.byte 183,192,0,9
	.asciz "ERROR_DS_AFFECTS_MULTIPLE_DSAS"

	.byte 185,192,0,9
	.asciz "ERROR_DS_SERVER_DOWN"

	.byte 186,192,0,9
	.asciz "ERROR_DS_LOCAL_ERROR"

	.byte 187,192,0,9
	.asciz "ERROR_DS_ENCODING_ERROR"

	.byte 188,192,0,9
	.asciz "ERROR_DS_DECODING_ERROR"

	.byte 189,192,0,9
	.asciz "ERROR_DS_FILTER_UNKNOWN"

	.byte 190,192,0,9
	.asciz "ERROR_DS_PARAM_ERROR"

	.byte 191,192,0,9
	.asciz "ERROR_DS_NOT_SUPPORTED"

	.byte 192,192,0,9
	.asciz "ERROR_DS_NO_RESULTS_RETURNED"

	.byte 193,192,0,9
	.asciz "ERROR_DS_CONTROL_NOT_FOUND"

	.byte 194,192,0,9
	.asciz "ERROR_DS_CLIENT_LOOP"

	.byte 195,192,0,9
	.asciz "ERROR_DS_SORT_CONTROL_MISSING"

	.byte 197,192,0,9
	.asciz "ERROR_DS_OFFSET_RANGE_ERROR"

	.byte 198,192,0,9
	.asciz "ERROR_DS_RIDMGR_DISABLED"

	.byte 199,192,0,9
	.asciz "ERROR_DS_ROOT_MUST_BE_NC"

	.byte 237,192,0,9
	.asciz "ERROR_DS_ADD_REPLICA_INHIBITED"

	.byte 238,192,0,9
	.asciz "ERROR_DS_ATT_NOT_DEF_IN_SCHEMA"

	.byte 239,192,0,9
	.asciz "ERROR_DS_MAX_OBJ_SIZE_EXCEEDED"

	.byte 240,192,0,9
	.asciz "ERROR_DS_OBJ_STRING_NAME_EXISTS"

	.byte 241,192,0,9
	.asciz "ERROR_DS_USER_BUFFER_TO_SMALL"

	.byte 245,192,0,9
	.asciz "ERROR_DS_ATT_IS_NOT_ON_OBJ"

	.byte 246,192,0,9
	.asciz "ERROR_DS_ILLEGAL_MOD_OPERATION"

	.byte 247,192,0,9
	.asciz "ERROR_DS_OBJ_TOO_LARGE"

	.byte 248,192,0,9
	.asciz "ERROR_DS_BAD_INSTANCE_TYPE"

	.byte 249,192,0,9
	.asciz "ERROR_DS_MASTERDSA_REQUIRED"

	.byte 250,192,0,9
	.asciz "ERROR_DS_OBJECT_CLASS_REQUIRED"

	.byte 251,192,0,9
	.asciz "ERROR_DS_MISSING_REQUIRED_ATT"

	.byte 252,192,0,9
	.asciz "ERROR_DS_ATT_NOT_DEF_FOR_CLASS"

	.byte 253,192,0,9
	.asciz "ERROR_DS_ATT_ALREADY_EXISTS"

	.byte 254,192,0,9
	.asciz "ERROR_DS_CANT_ADD_ATT_VALUES"

	.byte 128,193,0,9
	.asciz "ERROR_DS_RANGE_CONSTRAINT"

	.byte 130,193,0,9
	.asciz "ERROR_DS_ATT_VAL_ALREADY_EXISTS"

	.byte 131,193,0,9
	.asciz "ERROR_DS_CANT_REM_MISSING_ATT"

	.byte 132,193,0,9
	.asciz "ERROR_DS_ROOT_CANT_BE_SUBREF"

	.byte 134,193,0,9
	.asciz "ERROR_DS_NO_CHAINING"

	.byte 135,193,0,9
	.asciz "ERROR_DS_NO_CHAINED_EVAL"

	.byte 136,193,0,9
	.asciz "ERROR_DS_NO_PARENT_OBJECT"

	.byte 137,193,0,9
	.asciz "ERROR_DS_PARENT_IS_AN_ALIAS"

	.byte 138,193,0,9
	.asciz "ERROR_DS_CHILDREN_EXIST"

	.byte 140,193,0,9
	.asciz "ERROR_DS_OBJ_NOT_FOUND"

	.byte 141,193,0,9
	.asciz "ERROR_DS_ALIASED_OBJ_MISSING"

	.byte 142,193,0,9
	.asciz "ERROR_DS_BAD_NAME_SYNTAX"

	.byte 143,193,0,9
	.asciz "ERROR_DS_ALIAS_POINTS_TO_ALIAS"

	.byte 144,193,0,9
	.asciz "ERROR_DS_CANT_DEREF_ALIAS"

	.byte 145,193,0,9
	.asciz "ERROR_DS_OUT_OF_SCOPE"

	.byte 146,193,0,9
	.asciz "ERROR_DS_OBJECT_BEING_REMOVED"

	.byte 147,193,0,9
	.asciz "ERROR_DS_CANT_DELETE_DSA_OBJ"

	.byte 148,193,0,9
	.asciz "ERROR_DS_GENERIC_ERROR"

	.byte 149,193,0,9
	.asciz "ERROR_DS_DSA_MUST_BE_INT_MASTER"

	.byte 150,193,0,9
	.asciz "ERROR_DS_CLASS_NOT_DSA"

	.byte 151,193,0,9
	.asciz "ERROR_DS_INSUFF_ACCESS_RIGHTS"

	.byte 152,193,0,9
	.asciz "ERROR_DS_ILLEGAL_SUPERIOR"

	.byte 153,193,0,9
	.asciz "ERROR_DS_ATTRIBUTE_OWNED_BY_SAM"

	.byte 154,193,0,9
	.asciz "ERROR_DS_NAME_TOO_MANY_PARTS"

	.byte 155,193,0,9
	.asciz "ERROR_DS_NAME_TOO_LONG"

	.byte 156,193,0,9
	.asciz "ERROR_DS_NAME_VALUE_TOO_LONG"

	.byte 157,193,0,9
	.asciz "ERROR_DS_NAME_UNPARSEABLE"

	.byte 158,193,0,9
	.asciz "ERROR_DS_NAME_TYPE_UNKNOWN"

	.byte 159,193,0,9
	.asciz "ERROR_DS_NOT_AN_OBJECT"

	.byte 160,193,0,9
	.asciz "ERROR_DS_SEC_DESC_TOO_SHORT"

	.byte 161,193,0,9
	.asciz "ERROR_DS_SEC_DESC_INVALID"

	.byte 162,193,0,9
	.asciz "ERROR_DS_NO_DELETED_NAME"

	.byte 163,193,0,9
	.asciz "ERROR_DS_NCNAME_MUST_BE_NC"

	.byte 165,193,0,9
	.asciz "ERROR_DS_CANT_ADD_SYSTEM_ONLY"

	.byte 166,193,0,9
	.asciz "ERROR_DS_CLASS_MUST_BE_CONCRETE"

	.byte 167,193,0,9
	.asciz "ERROR_DS_INVALID_DMD"

	.byte 168,193,0,9
	.asciz "ERROR_DS_OBJ_GUID_EXISTS"

	.byte 169,193,0,9
	.asciz "ERROR_DS_NOT_ON_BACKLINK"

	.byte 170,193,0,9
	.asciz "ERROR_DS_NO_CROSSREF_FOR_NC"

	.byte 171,193,0,9
	.asciz "ERROR_DS_SHUTTING_DOWN"

	.byte 172,193,0,9
	.asciz "ERROR_DS_UNKNOWN_OPERATION"

	.byte 173,193,0,9
	.asciz "ERROR_DS_INVALID_ROLE_OWNER"

	.byte 174,193,0,9
	.asciz "ERROR_DS_COULDNT_CONTACT_FSMO"

	.byte 175,193,0,9
	.asciz "ERROR_DS_CROSS_NC_DN_RENAME"

	.byte 176,193,0,9
	.asciz "ERROR_DS_CANT_MOD_SYSTEM_ONLY"

	.byte 177,193,0,9
	.asciz "ERROR_DS_REPLICATOR_ONLY"

	.byte 178,193,0,9
	.asciz "ERROR_DS_OBJ_CLASS_NOT_DEFINED"

	.byte 179,193,0,9
	.asciz "ERROR_DS_OBJ_CLASS_NOT_SUBCLASS"

	.byte 180,193,0,9
	.asciz "ERROR_DS_NAME_REFERENCE_INVALID"

	.byte 181,193,0,9
	.asciz "ERROR_DS_CROSS_REF_EXISTS"

	.byte 182,193,0,9
	.asciz "ERROR_DS_DUP_RDN"

	.byte 186,193,0,9
	.asciz "ERROR_DS_DUP_OID"

	.byte 187,193,0,9
	.asciz "ERROR_DS_DUP_MAPI_ID"

	.byte 188,193,0,9
	.asciz "ERROR_DS_DUP_SCHEMA_ID_GUID"

	.byte 189,193,0,9
	.asciz "ERROR_DS_DUP_LDAP_DISPLAY_NAME"

	.byte 190,193,0,9
	.asciz "ERROR_DS_SEMANTIC_ATT_TEST"

	.byte 191,193,0,9
	.asciz "ERROR_DS_SYNTAX_MISMATCH"

	.byte 192,193,0,9
	.asciz "ERROR_DS_EXISTS_IN_MUST_HAVE"

	.byte 193,193,0,9
	.asciz "ERROR_DS_EXISTS_IN_MAY_HAVE"

	.byte 194,193,0,9
	.asciz "ERROR_DS_NONEXISTENT_MAY_HAVE"

	.byte 195,193,0,9
	.asciz "ERROR_DS_NONEXISTENT_MUST_HAVE"

	.byte 196,193,0,9
	.asciz "ERROR_DS_AUX_CLS_TEST_FAIL"

	.byte 197,193,0,9
	.asciz "ERROR_DS_NONEXISTENT_POSS_SUP"

	.byte 198,193,0,9
	.asciz "ERROR_DS_SUB_CLS_TEST_FAIL"

	.byte 199,193,0,9
	.asciz "ERROR_DS_BAD_RDN_ATT_ID_SYNTAX"

	.byte 200,193,0,9
	.asciz "ERROR_DS_EXISTS_IN_AUX_CLS"

	.byte 201,193,0,9
	.asciz "ERROR_DS_EXISTS_IN_SUB_CLS"

	.byte 202,193,0,9
	.asciz "ERROR_DS_EXISTS_IN_POSS_SUP"

	.byte 203,193,0,9
	.asciz "ERROR_DS_RECALCSCHEMA_FAILED"

	.byte 204,193,0,9
	.asciz "ERROR_DS_CANT_DELETE"

	.byte 206,193,0,9
	.asciz "ERROR_DS_ATT_SCHEMA_REQ_ID"

	.byte 207,193,0,9
	.asciz "ERROR_DS_BAD_ATT_SCHEMA_SYNTAX"

	.byte 208,193,0,9
	.asciz "ERROR_DS_CANT_CACHE_ATT"

	.byte 209,193,0,9
	.asciz "ERROR_DS_CANT_CACHE_CLASS"

	.byte 210,193,0,9
	.asciz "ERROR_DS_CANT_REMOVE_ATT_CACHE"

	.byte 211,193,0,9
	.asciz "ERROR_DS_CANT_RETRIEVE_DN"

	.byte 213,193,0,9
	.asciz "ERROR_DS_MISSING_SUPREF"

	.byte 214,193,0,9
	.asciz "ERROR_DS_CANT_RETRIEVE_INSTANCE"

	.byte 215,193,0,9
	.asciz "ERROR_DS_CODE_INCONSISTENCY"

	.byte 216,193,0,9
	.asciz "ERROR_DS_DATABASE_ERROR"

	.byte 217,193,0,9
	.asciz "ERROR_DS_GOVERNSID_MISSING"

	.byte 218,193,0,9
	.asciz "ERROR_DS_MISSING_EXPECTED_ATT"

	.byte 219,193,0,9
	.asciz "ERROR_DS_NCNAME_MISSING_CR_REF"

	.byte 220,193,0,9
	.asciz "ERROR_DS_SCHEMA_NOT_LOADED"

	.byte 222,193,0,9
	.asciz "ERROR_DS_SCHEMA_ALLOC_FAILED"

	.byte 223,193,0,9
	.asciz "ERROR_DS_ATT_SCHEMA_REQ_SYNTAX"

	.byte 224,193,0,9
	.asciz "ERROR_DS_GCVERIFY_ERROR"

	.byte 225,193,0,9
	.asciz "ERROR_DS_DRA_SCHEMA_MISMATCH"

	.byte 226,193,0,9
	.asciz "ERROR_DS_CANT_FIND_DSA_OBJ"

	.byte 227,193,0,9
	.asciz "ERROR_DS_CANT_FIND_EXPECTED_NC"

	.byte 228,193,0,9
	.asciz "ERROR_DS_CANT_FIND_NC_IN_CACHE"

	.byte 229,193,0,9
	.asciz "ERROR_DS_CANT_RETRIEVE_CHILD"

	.byte 230,193,0,9
	.asciz "ERROR_DS_BAD_HIERARCHY_FILE"

	.byte 233,193,0,9
	.asciz "ERROR_DS_CONFIG_PARAM_MISSING"

	.byte 235,193,0,9
	.asciz "ERROR_DS_INTERNAL_FAILURE"

	.byte 238,193,0,9
	.asciz "ERROR_DS_UNKNOWN_ERROR"

	.byte 239,193,0,9
	.asciz "ERROR_DS_REFUSING_FSMO_ROLES"

	.byte 241,193,0,9
	.asciz "ERROR_DS_MISSING_FSMO_SETTINGS"

	.byte 242,193,0,9
	.asciz "ERROR_DS_DRA_GENERIC"

	.byte 244,193,0,9
	.asciz "ERROR_DS_DRA_INVALID_PARAMETER"

	.byte 245,193,0,9
	.asciz "ERROR_DS_DRA_BUSY"

	.byte 246,193,0,9
	.asciz "ERROR_DS_DRA_BAD_DN"

	.byte 247,193,0,9
	.asciz "ERROR_DS_DRA_BAD_NC"

	.byte 248,193,0,9
	.asciz "ERROR_DS_DRA_DN_EXISTS"

	.byte 249,193,0,9
	.asciz "ERROR_DS_DRA_INTERNAL_ERROR"

	.byte 250,193,0,9
	.asciz "ERROR_DS_DRA_INCONSISTENT_DIT"

	.byte 251,193,0,9
	.asciz "ERROR_DS_DRA_CONNECTION_FAILED"

	.byte 252,193,0,9
	.asciz "ERROR_DS_DRA_BAD_INSTANCE_TYPE"

	.byte 253,193,0,9
	.asciz "ERROR_DS_DRA_OUT_OF_MEM"

	.byte 254,193,0,9
	.asciz "ERROR_DS_DRA_MAIL_PROBLEM"

	.byte 255,193,0,9
	.asciz "ERROR_DS_DRA_REF_ALREADY_EXISTS"

	.byte 128,194,0,9
	.asciz "ERROR_DS_DRA_REF_NOT_FOUND"

	.byte 129,194,0,9
	.asciz "ERROR_DS_DRA_OBJ_IS_REP_SOURCE"

	.byte 130,194,0,9
	.asciz "ERROR_DS_DRA_DB_ERROR"

	.byte 131,194,0,9
	.asciz "ERROR_DS_DRA_NO_REPLICA"

	.byte 132,194,0,9
	.asciz "ERROR_DS_DRA_ACCESS_DENIED"

	.byte 133,194,0,9
	.asciz "ERROR_DS_DRA_NOT_SUPPORTED"

	.byte 134,194,0,9
	.asciz "ERROR_DS_DRA_RPC_CANCELLED"

	.byte 135,194,0,9
	.asciz "ERROR_DS_DRA_SOURCE_DISABLED"

	.byte 136,194,0,9
	.asciz "ERROR_DS_DRA_SINK_DISABLED"

	.byte 137,194,0,9
	.asciz "ERROR_DS_DRA_NAME_COLLISION"

	.byte 138,194,0,9
	.asciz "ERROR_DS_DRA_SOURCE_REINSTALLED"

	.byte 139,194,0,9
	.asciz "ERROR_DS_DRA_MISSING_PARENT"

	.byte 140,194,0,9
	.asciz "ERROR_DS_DRA_PREEMPTED"

	.byte 141,194,0,9
	.asciz "ERROR_DS_DRA_ABANDON_SYNC"

	.byte 142,194,0,9
	.asciz "ERROR_DS_DRA_SHUTDOWN"

	.byte 143,194,0,9
	.asciz "ERROR_DS_DUP_LINK_ID"

	.byte 148,194,0,9
	.asciz "ERROR_DS_NAME_ERROR_RESOLVING"

	.byte 149,194,0,9
	.asciz "ERROR_DS_NAME_ERROR_NOT_FOUND"

	.byte 150,194,0,9
	.asciz "ERROR_DS_NAME_ERROR_NOT_UNIQUE"

	.byte 151,194,0,9
	.asciz "ERROR_DS_NAME_ERROR_NO_MAPPING"

	.byte 152,194,0,9
	.asciz "ERROR_DS_NAME_ERROR_DOMAIN_ONLY"

	.byte 153,194,0,9
	.asciz "ERROR_DS_CONSTRUCTED_ATT_MOD"

	.byte 155,194,0,9
	.asciz "ERROR_DS_WRONG_OM_OBJ_CLASS"

	.byte 156,194,0,9
	.asciz "ERROR_DS_DRA_REPL_PENDING"

	.byte 157,194,0,9
	.asciz "ERROR_DS_DS_REQUIRED"

	.byte 158,194,0,9
	.asciz "ERROR_DS_NON_BASE_SEARCH"

	.byte 160,194,0,9
	.asciz "ERROR_DS_CANT_RETRIEVE_ATTS"

	.byte 161,194,0,9
	.asciz "ERROR_DS_BACKLINK_WITHOUT_LINK"

	.byte 162,194,0,9
	.asciz "ERROR_DS_EPOCH_MISMATCH"

	.byte 163,194,0,9
	.asciz "ERROR_DS_SRC_NAME_MISMATCH"

	.byte 164,194,0,9
	.asciz "ERROR_DS_DST_NC_MISMATCH"

	.byte 166,194,0,9
	.asciz "ERROR_DS_SRC_GUID_MISMATCH"

	.byte 168,194,0,9
	.asciz "ERROR_DS_NC_MUST_HAVE_NC_PARENT"

	.byte 174,194,0,9
	.asciz "ERROR_DS_DST_DOMAIN_NOT_NATIVE"

	.byte 176,194,0,9
	.asciz "ERROR_DS_INVALID_SEARCH_FLAG"

	.byte 180,194,0,9
	.asciz "ERROR_DS_SAM_INIT_FAILURE"

	.byte 184,194,0,9
	.asciz "ERROR_DS_NONSAFE_SCHEMA_CHANGE"

	.byte 188,194,0,9
	.asciz "ERROR_DS_INVALID_GROUP_TYPE"

	.byte 193,194,0,9
	.asciz "ERROR_DS_HAVE_PRIMARY_MEMBERS"

	.byte 201,194,0,9
	.asciz "ERROR_DS_NAMING_MASTER_GC"

	.byte 203,194,0,9
	.asciz "ERROR_DS_DNS_LOOKUP_FAILURE"

	.byte 204,194,0,9
	.asciz "ERROR_DS_COULDNT_UPDATE_SPNS"

	.byte 205,194,0,9
	.asciz "ERROR_DS_CANT_RETRIEVE_SD"

	.byte 206,194,0,9
	.asciz "ERROR_DS_KEY_NOT_UNIQUE"

	.byte 207,194,0,9
	.asciz "ERROR_DS_CANT_START"

	.byte 211,194,0,9
	.asciz "ERROR_DS_INIT_FAILURE"

	.byte 212,194,0,9
	.asciz "ERROR_SAM_INIT_FAILURE"

	.byte 221,194,0,9
	.asciz "ERROR_DS_DRA_SCHEMA_INFO_SHIP"

	.byte 222,194,0,9
	.asciz "ERROR_DS_DRA_SCHEMA_CONFLICT"

	.byte 223,194,0,9
	.asciz "ERROR_DS_DRA_OBJ_NC_MISMATCH"

	.byte 225,194,0,9
	.asciz "ERROR_DS_NC_STILL_HAS_DSAS"

	.byte 226,194,0,9
	.asciz "ERROR_DS_GC_REQUIRED"

	.byte 227,194,0,9
	.asciz "ERROR_DS_CANT_ADD_TO_GC"

	.byte 230,194,0,9
	.asciz "ERROR_DS_NO_CHECKPOINT_WITH_PDC"

	.byte 231,194,0,9
	.asciz "ERROR_DS_INVALID_NAME_FOR_SPN"

	.byte 234,194,0,9
	.asciz "ERROR_DS_MUST_BE_RUN_ON_DST_DC"

	.byte 238,194,0,9
	.asciz "ERROR_DS_INIT_FAILURE_CONSOLE"

	.byte 241,194,0,9
	.asciz "ERROR_DS_FOREST_VERSION_TOO_LOW"

	.byte 245,194,0,9
	.asciz "ERROR_DS_DOMAIN_VERSION_TOO_LOW"

	.byte 246,194,0,9
	.asciz "ERROR_DS_INCOMPATIBLE_VERSION"

	.byte 247,194,0,9
	.asciz "ERROR_DS_LOW_DSA_VERSION"

	.byte 248,194,0,9
	.asciz "ERROR_DS_NAME_NOT_UNIQUE"

	.byte 251,194,0,9
	.asciz "ERROR_DS_OUT_OF_VERSION_STORE"

	.byte 253,194,0,9
	.asciz "ERROR_DS_NO_REF_DOMAIN"

	.byte 255,194,0,9
	.asciz "ERROR_DS_RESERVED_LINK_ID"

	.byte 128,195,0,9
	.asciz "ERROR_DS_LINK_ID_NOT_AVAILABLE"

	.byte 129,195,0,9
	.asciz "ERROR_DS_THREAD_LIMIT_EXCEEDED"

	.byte 139,195,0,9
	.asciz "ERROR_DS_NOT_CLOSEST"

	.byte 140,195,0,9
	.asciz "ERROR_DS_NTDSCRIPT_SYNTAX_ERROR"

	.byte 143,195,0,9
	.asciz "ERROR_DS_DIFFERENT_REPL_EPOCHS"

	.byte 145,195,0,9
	.asciz "ERROR_DS_DRS_EXTENSIONS_CHANGED"

	.byte 146,195,0,9
	.asciz "ERROR_DS_NO_MSDS_INTID"

	.byte 148,195,0,9
	.asciz "ERROR_DS_DUP_MSDS_INTID"

	.byte 149,195,0,9
	.asciz "ERROR_DS_EXISTS_IN_RDNATTID"

	.byte 150,195,0,9
	.asciz "ERROR_DS_AUTHORIZATION_FAILED"

	.byte 151,195,0,9
	.asciz "ERROR_DS_INVALID_SCRIPT"

	.byte 152,195,0,9
	.asciz "ERROR_DS_CROSS_REF_BUSY"

	.byte 154,195,0,9
	.asciz "ERROR_DS_DUPLICATE_ID_FOUND"

	.byte 157,195,0,9
	.asciz "ERROR_DS_GROUP_CONVERSION_ERROR"

	.byte 159,195,0,9
	.asciz "ERROR_DS_ROLE_NOT_VERIFIED"

	.byte 162,195,0,9
	.asciz "ERROR_DS_EXISTING_AD_CHILD_NC"

	.byte 165,195,0,9
	.asciz "ERROR_DS_REPL_LIFETIME_EXCEEDED"

	.byte 166,195,0,9
	.asciz "ERROR_DS_LDAP_SEND_QUEUE_FULL"

	.byte 168,195,0,9
	.asciz "ERROR_DS_POLICY_NOT_KNOWN"

	.byte 170,195,0,9
	.asciz "ERROR_NO_SITE_SETTINGS_OBJECT"

	.byte 171,195,0,9
	.asciz "ERROR_NO_SECRETS"

	.byte 172,195,0,9
	.asciz "ERROR_NO_WRITABLE_DC_FOUND"

	.byte 173,195,0,9
	.asciz "ERROR_DS_NO_SERVER_OBJECT"

	.byte 174,195,0,9
	.asciz "ERROR_DS_NO_NTDSA_OBJECT"

	.byte 175,195,0,9
	.asciz "ERROR_DS_NON_ASQ_SEARCH"

	.byte 176,195,0,9
	.asciz "ERROR_DS_AUDIT_FAILURE"

	.byte 177,195,0,9
	.asciz "ERROR_DS_DRA_CORRUPT_UTD_VECTOR"

	.byte 181,195,0,9
	.asciz "ERROR_DS_DRA_SECRETS_DENIED"

	.byte 182,195,0,9
	.asciz "ERROR_DS_RESERVED_MAPI_ID"

	.byte 183,195,0,9
	.asciz "ERROR_DS_MAPI_ID_NOT_AVAILABLE"

	.byte 184,195,0,9
	.asciz "ERROR_DS_OID_NOT_FOUND"

	.byte 190,195,0,9
	.asciz "ERROR_DS_DRA_RECYCLED_TARGET"

	.byte 191,195,0,9
	.asciz "ERROR_DS_DISALLOWED_NC_REDIRECT"

	.byte 192,195,0,9
	.asciz "ERROR_DS_HIGH_ADLDS_FFL"

	.byte 193,195,0,9
	.asciz "ERROR_DS_HIGH_DSA_VERSION"

	.byte 194,195,0,9
	.asciz "ERROR_DS_LOW_ADLDS_FFL"

	.byte 195,195,0,9
	.asciz "ERROR_INCORRECT_ACCOUNT_TYPE"

	.byte 198,195,0,9
	.asciz "ERROR_DS_MISSING_FOREST_TRUST"

	.byte 201,195,0,9
	.asciz "ERROR_DS_VALUE_KEY_NOT_UNIQUE"

	.byte 202,195,0,9
	.asciz "DNS_ERROR_RCODE_FORMAT_ERROR"

	.byte 169,198,0,9
	.asciz "DNS_ERROR_RCODE_SERVER_FAILURE"

	.byte 170,198,0,9
	.asciz "DNS_ERROR_RCODE_NAME_ERROR"

	.byte 171,198,0,9
	.asciz "DNS_ERROR_RCODE_NOT_IMPLEMENTED"

	.byte 172,198,0,9
	.asciz "DNS_ERROR_RCODE_REFUSED"

	.byte 173,198,0,9
	.asciz "DNS_ERROR_RCODE_YXDOMAIN"

	.byte 174,198,0,9
	.asciz "DNS_ERROR_RCODE_YXRRSET"

	.byte 175,198,0,9
	.asciz "DNS_ERROR_RCODE_NXRRSET"

	.byte 176,198,0,9
	.asciz "DNS_ERROR_RCODE_NOTAUTH"

	.byte 177,198,0,9
	.asciz "DNS_ERROR_RCODE_NOTZONE"

	.byte 178,198,0,9
	.asciz "DNS_ERROR_RCODE_BADSIG"

	.byte 184,198,0,9
	.asciz "DNS_ERROR_RCODE_BADKEY"

	.byte 185,198,0,9
	.asciz "DNS_ERROR_RCODE_BADTIME"

	.byte 186,198,0,9
	.asciz "DNS_ERROR_KEYMASTER_REQUIRED"

	.byte 141,199,0,9
	.asciz "DNS_ERROR_UNSUPPORTED_ALGORITHM"

	.byte 145,199,0,9
	.asciz "DNS_ERROR_INVALID_KEY_SIZE"

	.byte 146,199,0,9
	.asciz "DNS_ERROR_UNEXPECTED_CNG_ERROR"

	.byte 150,199,0,9
	.asciz "DNS_ERROR_KSP_NOT_ACCESSIBLE"

	.byte 152,199,0,9
	.asciz "DNS_ERROR_TOO_MANY_SKDS"

	.byte 153,199,0,9
	.asciz "DNS_ERROR_ROLLOVER_IN_PROGRESS"

	.byte 156,199,0,9
	.asciz "DNS_ERROR_NOT_ALLOWED_ON_ZSK"

	.byte 158,199,0,9
	.asciz "DNS_ERROR_BAD_KEYMASTER"

	.byte 162,199,0,9
	.asciz "DNS_ERROR_DNSSEC_IS_DISABLED"

	.byte 165,199,0,9
	.asciz "DNS_ERROR_INVALID_XML"

	.byte 166,199,0,9
	.asciz "DNS_ERROR_ROLLOVER_NOT_POKEABLE"

	.byte 168,199,0,9
	.asciz "DNS_ERROR_NSEC3_NAME_COLLISION"

	.byte 169,199,0,9
	.asciz "DNS_INFO_NO_RECORDS"

	.byte 157,202,0,9
	.asciz "DNS_ERROR_BAD_PACKET"

	.byte 158,202,0,9
	.asciz "DNS_ERROR_NO_PACKET"

	.byte 159,202,0,9
	.asciz "DNS_ERROR_RCODE"

	.byte 160,202,0,9
	.asciz "DNS_ERROR_UNSECURE_PACKET"

	.byte 161,202,0,9
	.asciz "DNS_REQUEST_PENDING"

	.byte 162,202,0,9
	.asciz "DNS_ERROR_INVALID_TYPE"

	.byte 207,202,0,9
	.asciz "DNS_ERROR_INVALID_IP_ADDRESS"

	.byte 208,202,0,9
	.asciz "DNS_ERROR_INVALID_PROPERTY"

	.byte 209,202,0,9
	.asciz "DNS_ERROR_TRY_AGAIN_LATER"

	.byte 210,202,0,9
	.asciz "DNS_ERROR_NOT_UNIQUE"

	.byte 211,202,0,9
	.asciz "DNS_ERROR_NON_RFC_NAME"

	.byte 212,202,0,9
	.asciz "DNS_STATUS_FQDN"

	.byte 213,202,0,9
	.asciz "DNS_STATUS_DOTTED_NAME"

	.byte 214,202,0,9
	.asciz "DNS_STATUS_SINGLE_PART_NAME"

	.byte 215,202,0,9
	.asciz "DNS_ERROR_INVALID_NAME_CHAR"

	.byte 216,202,0,9
	.asciz "DNS_ERROR_NUMERIC_NAME"

	.byte 217,202,0,9
	.asciz "DNS_ERROR_DWORD_VALUE_TOO_SMALL"

	.byte 222,202,0,9
	.asciz "DNS_ERROR_DWORD_VALUE_TOO_LARGE"

	.byte 223,202,0,9
	.asciz "DNS_ERROR_BACKGROUND_LOADING"

	.byte 224,202,0,9
	.asciz "DNS_ERROR_NOT_ALLOWED_ON_RODC"

	.byte 225,202,0,9
	.asciz "DNS_ERROR_DELEGATION_REQUIRED"

	.byte 227,202,0,9
	.asciz "DNS_ERROR_INVALID_POLICY_TABLE"

	.byte 228,202,0,9
	.asciz "DNS_ERROR_ADDRESS_REQUIRED"

	.byte 229,202,0,9
	.asciz "DNS_ERROR_ZONE_DOES_NOT_EXIST"

	.byte 129,203,0,9
	.asciz "DNS_ERROR_NO_ZONE_INFO"

	.byte 130,203,0,9
	.asciz "DNS_ERROR_ZONE_LOCKED"

	.byte 135,203,0,9
	.asciz "DNS_ERROR_ZONE_CREATION_FAILED"

	.byte 136,203,0,9
	.asciz "DNS_ERROR_ZONE_ALREADY_EXISTS"

	.byte 137,203,0,9
	.asciz "DNS_ERROR_INVALID_ZONE_TYPE"

	.byte 139,203,0,9
	.asciz "DNS_ERROR_ZONE_NOT_SECONDARY"

	.byte 141,203,0,9
	.asciz "DNS_ERROR_WINS_INIT_FAILED"

	.byte 143,203,0,9
	.asciz "DNS_ERROR_NEED_WINS_SERVERS"

	.byte 144,203,0,9
	.asciz "DNS_ERROR_NBSTAT_INIT_FAILED"

	.byte 145,203,0,9
	.asciz "DNS_ERROR_SOA_DELETE_INVALID"

	.byte 146,203,0,9
	.asciz "DNS_ERROR_ZONE_IS_SHUTDOWN"

	.byte 149,203,0,9
	.asciz "DNS_ERROR_INVALID_DATAFILE_NAME"

	.byte 180,203,0,9
	.asciz "DNS_ERROR_DATAFILE_OPEN_FAILURE"

	.byte 181,203,0,9
	.asciz "DNS_ERROR_FILE_WRITEBACK_FAILED"

	.byte 182,203,0,9
	.asciz "DNS_ERROR_DATAFILE_PARSING"

	.byte 183,203,0,9
	.asciz "DNS_ERROR_RECORD_DOES_NOT_EXIST"

	.byte 229,203,0,9
	.asciz "DNS_ERROR_RECORD_FORMAT"

	.byte 230,203,0,9
	.asciz "DNS_ERROR_NODE_CREATION_FAILED"

	.byte 231,203,0,9
	.asciz "DNS_ERROR_UNKNOWN_RECORD_TYPE"

	.byte 232,203,0,9
	.asciz "DNS_ERROR_RECORD_TIMED_OUT"

	.byte 233,203,0,9
	.asciz "DNS_ERROR_NAME_NOT_IN_ZONE"

	.byte 234,203,0,9
	.asciz "DNS_ERROR_CNAME_LOOP"

	.byte 235,203,0,9
	.asciz "DNS_ERROR_NODE_IS_CNAME"

	.byte 236,203,0,9
	.asciz "DNS_ERROR_CNAME_COLLISION"

	.byte 237,203,0,9
	.asciz "DNS_ERROR_RECORD_ALREADY_EXISTS"

	.byte 239,203,0,9
	.asciz "DNS_ERROR_SECONDARY_DATA"

	.byte 240,203,0,9
	.asciz "DNS_ERROR_NO_CREATE_CACHE_DATA"

	.byte 241,203,0,9
	.asciz "DNS_ERROR_NAME_DOES_NOT_EXIST"

	.byte 242,203,0,9
	.asciz "DNS_WARNING_PTR_CREATE_FAILED"

	.byte 243,203,0,9
	.asciz "DNS_WARNING_DOMAIN_UNDELETED"

	.byte 244,203,0,9
	.asciz "DNS_ERROR_DS_UNAVAILABLE"

	.byte 245,203,0,9
	.asciz "DNS_ERROR_NODE_IS_DNAME"

	.byte 248,203,0,9
	.asciz "DNS_ERROR_DNAME_COLLISION"

	.byte 249,203,0,9
	.asciz "DNS_ERROR_ALIAS_LOOP"

	.byte 250,203,0,9
	.asciz "DNS_INFO_AXFR_COMPLETE"

	.byte 151,204,0,9
	.asciz "DNS_ERROR_AXFR"

	.byte 152,204,0,9
	.asciz "DNS_INFO_ADDED_LOCAL_WINS"

	.byte 153,204,0,9
	.asciz "DNS_STATUS_CONTINUE_NEEDED"

	.byte 201,204,0,9
	.asciz "DNS_ERROR_NO_TCPIP"

	.byte 251,204,0,9
	.asciz "DNS_ERROR_NO_DNS_SERVERS"

	.byte 252,204,0,9
	.asciz "DNS_ERROR_DP_DOES_NOT_EXIST"

	.byte 173,205,0,9
	.asciz "DNS_ERROR_DP_ALREADY_EXISTS"

	.byte 174,205,0,9
	.asciz "DNS_ERROR_DP_NOT_ENLISTED"

	.byte 175,205,0,9
	.asciz "DNS_ERROR_DP_ALREADY_ENLISTED"

	.byte 176,205,0,9
	.asciz "DNS_ERROR_DP_NOT_AVAILABLE"

	.byte 177,205,0,9
	.asciz "DNS_ERROR_DP_FSMO_ERROR"

	.byte 178,205,0,9
	.asciz "DNS_ERROR_DEFAULT_ZONESCOPE"

	.byte 225,205,0,9
	.asciz "DNS_ERROR_LOAD_ZONESCOPE_FAILED"

	.byte 228,205,0,9
	.asciz "DNS_ERROR_INVALID_SCOPE_NAME"

	.byte 230,205,0,9
	.asciz "DNS_ERROR_SCOPE_DOES_NOT_EXIST"

	.byte 231,205,0,9
	.asciz "DNS_ERROR_DEFAULT_SCOPE"

	.byte 232,205,0,9
	.asciz "DNS_ERROR_SCOPE_LOCKED"

	.byte 234,205,0,9
	.asciz "DNS_ERROR_SCOPE_ALREADY_EXISTS"

	.byte 235,205,0,9
	.asciz "DNS_ERROR_POLICY_ALREADY_EXISTS"

	.byte 243,205,0,9
	.asciz "DNS_ERROR_POLICY_DOES_NOT_EXIST"

	.byte 244,205,0,9
	.asciz "DNS_ERROR_SUBNET_DOES_NOT_EXIST"

	.byte 250,205,0,9
	.asciz "DNS_ERROR_SUBNET_ALREADY_EXISTS"

	.byte 251,205,0,9
	.asciz "DNS_ERROR_POLICY_LOCKED"

	.byte 252,205,0,9
	.asciz "DNS_ERROR_POLICY_INVALID_WEIGHT"

	.byte 253,205,0,9
	.asciz "DNS_ERROR_POLICY_INVALID_NAME"

	.byte 254,205,0,9
	.asciz "DNS_ERROR_POLICY_SCOPE_MISSING"

	.byte 130,206,0,9
	.asciz "WSAEINTR"

	.byte 148,206,0,9
	.asciz "WSAEBADF"

	.byte 153,206,0,9
	.asciz "WSAEACCES"

	.byte 157,206,0,9
	.asciz "WSAEFAULT"

	.byte 158,206,0,9
	.asciz "WSAEINVAL"

	.byte 166,206,0,9
	.asciz "WSAEMFILE"

	.byte 168,206,0,9
	.asciz "WSAEWOULDBLOCK"

	.byte 179,206,0,9
	.asciz "WSAEINPROGRESS"

	.byte 180,206,0,9
	.asciz "WSAEALREADY"

	.byte 181,206,0,9
	.asciz "WSAENOTSOCK"

	.byte 182,206,0,9
	.asciz "WSAEDESTADDRREQ"

	.byte 183,206,0,9
	.asciz "WSAEMSGSIZE"

	.byte 184,206,0,9
	.asciz "WSAEPROTOTYPE"

	.byte 185,206,0,9
	.asciz "WSAENOPROTOOPT"

	.byte 186,206,0,9
	.asciz "WSAEPROTONOSUPPORT"

	.byte 187,206,0,9
	.asciz "WSAESOCKTNOSUPPORT"

	.byte 188,206,0,9
	.asciz "WSAEOPNOTSUPP"

	.byte 189,206,0,9
	.asciz "WSAEPFNOSUPPORT"

	.byte 190,206,0,9
	.asciz "WSAEAFNOSUPPORT"

	.byte 191,206,0,9
	.asciz "WSAEADDRINUSE"

	.byte 192,206,0,9
	.asciz "WSAEADDRNOTAVAIL"

	.byte 193,206,0,9
	.asciz "WSAENETDOWN"

	.byte 194,206,0,9
	.asciz "WSAENETUNREACH"

	.byte 195,206,0,9
	.asciz "WSAENETRESET"

	.byte 196,206,0,9
	.asciz "WSAECONNABORTED"

	.byte 197,206,0,9
	.asciz "WSAECONNRESET"

	.byte 198,206,0,9
	.asciz "WSAENOBUFS"

	.byte 199,206,0,9
	.asciz "WSAEISCONN"

	.byte 200,206,0,9
	.asciz "WSAENOTCONN"

	.byte 201,206,0,9
	.asciz "WSAESHUTDOWN"

	.byte 202,206,0,9
	.asciz "WSAETOOMANYREFS"

	.byte 203,206,0,9
	.asciz "WSAETIMEDOUT"

	.byte 204,206,0,9
	.asciz "WSAECONNREFUSED"

	.byte 205,206,0,9
	.asciz "WSAELOOP"

	.byte 206,206,0,9
	.asciz "WSAENAMETOOLONG"

	.byte 207,206,0,9
	.asciz "WSAEHOSTDOWN"

	.byte 208,206,0,9
	.asciz "WSAEHOSTUNREACH"

	.byte 209,206,0,9
	.asciz "WSAENOTEMPTY"

	.byte 210,206,0,9
	.asciz "WSAEPROCLIM"

	.byte 211,206,0,9
	.asciz "WSAEUSERS"

	.byte 212,206,0,9
	.asciz "WSAEDQUOT"

	.byte 213,206,0,9
	.asciz "WSAESTALE"

	.byte 214,206,0,9
	.asciz "WSAEREMOTE"

	.byte 215,206,0,9
	.asciz "WSASYSNOTREADY"

	.byte 235,206,0,9
	.asciz "WSAVERNOTSUPPORTED"

	.byte 236,206,0,9
	.asciz "WSANOTINITIALISED"

	.byte 237,206,0,9
	.asciz "WSAEDISCON"

	.byte 245,206,0,9
	.asciz "WSAENOMORE"

	.byte 246,206,0,9
	.asciz "WSAECANCELLED"

	.byte 247,206,0,9
	.asciz "WSAEINVALIDPROCTABLE"

	.byte 248,206,0,9
	.asciz "WSAEINVALIDPROVIDER"

	.byte 249,206,0,9
	.asciz "WSAEPROVIDERFAILEDINIT"

	.byte 250,206,0,9
	.asciz "WSASYSCALLFAILURE"

	.byte 251,206,0,9
	.asciz "WSASERVICE_NOT_FOUND"

	.byte 252,206,0,9
	.asciz "WSATYPE_NOT_FOUND"

	.byte 253,206,0,9
	.asciz "WSA_E_NO_MORE"

	.byte 254,206,0,9
	.asciz "WSA_E_CANCELLED"

	.byte 255,206,0,9
	.asciz "WSAEREFUSED"

	.byte 128,207,0,9
	.asciz "WSAHOST_NOT_FOUND"

	.byte 249,213,0,9
	.asciz "WSATRY_AGAIN"

	.byte 250,213,0,9
	.asciz "WSANO_RECOVERY"

	.byte 251,213,0,9
	.asciz "WSANO_DATA"

	.byte 252,213,0,9
	.asciz "WSA_QOS_RECEIVERS"

	.byte 253,213,0,9
	.asciz "WSA_QOS_SENDERS"

	.byte 254,213,0,9
	.asciz "WSA_QOS_NO_SENDERS"

	.byte 255,213,0,9
	.asciz "WSA_QOS_NO_RECEIVERS"

	.byte 128,214,0,9
	.asciz "WSA_QOS_REQUEST_CONFIRMED"

	.byte 129,214,0,9
	.asciz "WSA_QOS_ADMISSION_FAILURE"

	.byte 130,214,0,9
	.asciz "WSA_QOS_POLICY_FAILURE"

	.byte 131,214,0,9
	.asciz "WSA_QOS_BAD_STYLE"

	.byte 132,214,0,9
	.asciz "WSA_QOS_BAD_OBJECT"

	.byte 133,214,0,9
	.asciz "WSA_QOS_TRAFFIC_CTRL_ERROR"

	.byte 134,214,0,9
	.asciz "WSA_QOS_GENERIC_ERROR"

	.byte 135,214,0,9
	.asciz "WSA_QOS_ESERVICETYPE"

	.byte 136,214,0,9
	.asciz "WSA_QOS_EFLOWSPEC"

	.byte 137,214,0,9
	.asciz "WSA_QOS_EPROVSPECBUF"

	.byte 138,214,0,9
	.asciz "WSA_QOS_EFILTERSTYLE"

	.byte 139,214,0,9
	.asciz "WSA_QOS_EFILTERTYPE"

	.byte 140,214,0,9
	.asciz "WSA_QOS_EFILTERCOUNT"

	.byte 141,214,0,9
	.asciz "WSA_QOS_EOBJLENGTH"

	.byte 142,214,0,9
	.asciz "WSA_QOS_EFLOWCOUNT"

	.byte 143,214,0,9
	.asciz "WSA_QOS_EUNKOWNPSOBJ"

	.byte 144,214,0,9
	.asciz "WSA_QOS_EPOLICYOBJ"

	.byte 145,214,0,9
	.asciz "WSA_QOS_EFLOWDESC"

	.byte 146,214,0,9
	.asciz "WSA_QOS_EPSFLOWSPEC"

	.byte 147,214,0,9
	.asciz "WSA_QOS_EPSFILTERSPEC"

	.byte 148,214,0,9
	.asciz "WSA_QOS_ESDMODEOBJ"

	.byte 149,214,0,9
	.asciz "WSA_QOS_ESHAPERATEOBJ"

	.byte 150,214,0,9
	.asciz "WSA_QOS_RESERVED_PETYPE"

	.byte 151,214,0,9
	.asciz "WSA_SECURE_HOST_NOT_FOUND"

	.byte 152,214,0,9
	.asciz "WSA_IPSEC_NAME_POLICY_ERROR"

	.byte 153,214,0,9
	.asciz "ERROR_IPSEC_QM_POLICY_EXISTS"

	.byte 200,229,0,9
	.asciz "ERROR_IPSEC_QM_POLICY_NOT_FOUND"

	.byte 201,229,0,9
	.asciz "ERROR_IPSEC_QM_POLICY_IN_USE"

	.byte 202,229,0,9
	.asciz "ERROR_IPSEC_MM_POLICY_EXISTS"

	.byte 203,229,0,9
	.asciz "ERROR_IPSEC_MM_POLICY_NOT_FOUND"

	.byte 204,229,0,9
	.asciz "ERROR_IPSEC_MM_POLICY_IN_USE"

	.byte 205,229,0,9
	.asciz "ERROR_IPSEC_MM_FILTER_EXISTS"

	.byte 206,229,0,9
	.asciz "ERROR_IPSEC_MM_FILTER_NOT_FOUND"

	.byte 207,229,0,9
	.asciz "ERROR_IPSEC_MM_AUTH_EXISTS"

	.byte 210,229,0,9
	.asciz "ERROR_IPSEC_MM_AUTH_NOT_FOUND"

	.byte 211,229,0,9
	.asciz "ERROR_IPSEC_MM_AUTH_IN_USE"

	.byte 212,229,0,9
	.asciz "WARNING_IPSEC_MM_POLICY_PRUNED"

	.byte 224,229,0,9
	.asciz "WARNING_IPSEC_QM_POLICY_PRUNED"

	.byte 225,229,0,9
	.asciz "ERROR_IPSEC_IKE_AUTH_FAIL"

	.byte 233,235,0,9
	.asciz "ERROR_IPSEC_IKE_ATTRIB_FAIL"

	.byte 234,235,0,9
	.asciz "ERROR_IPSEC_IKE_TIMED_OUT"

	.byte 237,235,0,9
	.asciz "ERROR_IPSEC_IKE_NO_CERT"

	.byte 238,235,0,9
	.asciz "ERROR_IPSEC_IKE_SA_DELETED"

	.byte 239,235,0,9
	.asciz "ERROR_IPSEC_IKE_SA_REAPED"

	.byte 240,235,0,9
	.asciz "ERROR_IPSEC_IKE_MM_ACQUIRE_DROP"

	.byte 241,235,0,9
	.asciz "ERROR_IPSEC_IKE_QM_ACQUIRE_DROP"

	.byte 242,235,0,9
	.asciz "ERROR_IPSEC_IKE_QUEUE_DROP_MM"

	.byte 243,235,0,9
	.asciz "ERROR_IPSEC_IKE_MM_DELAY_DROP"

	.byte 246,235,0,9
	.asciz "ERROR_IPSEC_IKE_QM_DELAY_DROP"

	.byte 247,235,0,9
	.asciz "ERROR_IPSEC_IKE_ERROR"

	.byte 248,235,0,9
	.asciz "ERROR_IPSEC_IKE_CRL_FAILED"

	.byte 249,235,0,9
	.asciz "ERROR_IPSEC_IKE_NO_PRIVATE_KEY"

	.byte 252,235,0,9
	.asciz "ERROR_IPSEC_IKE_DH_FAIL"

	.byte 254,235,0,9
	.asciz "ERROR_IPSEC_IKE_INVALID_HEADER"

	.byte 128,236,0,9
	.asciz "ERROR_IPSEC_IKE_NO_POLICY"

	.byte 129,236,0,9
	.asciz "ERROR_IPSEC_IKE_KERBEROS_ERROR"

	.byte 131,236,0,9
	.asciz "ERROR_IPSEC_IKE_NO_PUBLIC_KEY"

	.byte 132,236,0,9
	.asciz "ERROR_IPSEC_IKE_PROCESS_ERR"

	.byte 133,236,0,9
	.asciz "ERROR_IPSEC_IKE_PROCESS_ERR_SA"

	.byte 134,236,0,9
	.asciz "ERROR_IPSEC_IKE_PROCESS_ERR_KE"

	.byte 137,236,0,9
	.asciz "ERROR_IPSEC_IKE_PROCESS_ERR_ID"

	.byte 138,236,0,9
	.asciz "ERROR_IPSEC_IKE_PROCESS_ERR_SIG"

	.byte 142,236,0,9
	.asciz "ERROR_IPSEC_IKE_INVALID_PAYLOAD"

	.byte 147,236,0,9
	.asciz "ERROR_IPSEC_IKE_LOAD_SOFT_SA"

	.byte 148,236,0,9
	.asciz "ERROR_IPSEC_IKE_INVALID_COOKIE"

	.byte 150,236,0,9
	.asciz "ERROR_IPSEC_IKE_NO_PEER_CERT"

	.byte 151,236,0,9
	.asciz "ERROR_IPSEC_IKE_PEER_CRL_FAILED"

	.byte 152,236,0,9
	.asciz "ERROR_IPSEC_IKE_POLICY_CHANGE"

	.byte 153,236,0,9
	.asciz "ERROR_IPSEC_IKE_NO_MM_POLICY"

	.byte 154,236,0,9
	.asciz "ERROR_IPSEC_IKE_NOTCBPRIV"

	.byte 155,236,0,9
	.asciz "ERROR_IPSEC_IKE_SECLOADFAIL"

	.byte 156,236,0,9
	.asciz "ERROR_IPSEC_IKE_FAILSSPINIT"

	.byte 157,236,0,9
	.asciz "ERROR_IPSEC_IKE_FAILQUERYSSP"

	.byte 158,236,0,9
	.asciz "ERROR_IPSEC_IKE_SRVACQFAIL"

	.byte 159,236,0,9
	.asciz "ERROR_IPSEC_IKE_SRVQUERYCRED"

	.byte 160,236,0,9
	.asciz "ERROR_IPSEC_IKE_GETSPIFAIL"

	.byte 161,236,0,9
	.asciz "ERROR_IPSEC_IKE_INVALID_FILTER"

	.byte 162,236,0,9
	.asciz "ERROR_IPSEC_IKE_OUT_OF_MEMORY"

	.byte 163,236,0,9
	.asciz "ERROR_IPSEC_IKE_INVALID_POLICY"

	.byte 165,236,0,9
	.asciz "ERROR_IPSEC_IKE_UNKNOWN_DOI"

	.byte 166,236,0,9
	.asciz "ERROR_IPSEC_IKE_DH_FAILURE"

	.byte 168,236,0,9
	.asciz "ERROR_IPSEC_IKE_INVALID_GROUP"

	.byte 169,236,0,9
	.asciz "ERROR_IPSEC_IKE_ENCRYPT"

	.byte 170,236,0,9
	.asciz "ERROR_IPSEC_IKE_DECRYPT"

	.byte 171,236,0,9
	.asciz "ERROR_IPSEC_IKE_POLICY_MATCH"

	.byte 172,236,0,9
	.asciz "ERROR_IPSEC_IKE_UNSUPPORTED_ID"

	.byte 173,236,0,9
	.asciz "ERROR_IPSEC_IKE_INVALID_HASH"

	.byte 174,236,0,9
	.asciz "ERROR_IPSEC_IKE_INVALID_SIG"

	.byte 179,236,0,9
	.asciz "ERROR_IPSEC_IKE_LOAD_FAILED"

	.byte 180,236,0,9
	.asciz "ERROR_IPSEC_IKE_RPC_DELETE"

	.byte 181,236,0,9
	.asciz "ERROR_IPSEC_IKE_BENIGN_REINIT"

	.byte 182,236,0,9
	.asciz "ERROR_IPSEC_IKE_MM_LIMIT"

	.byte 186,236,0,9
	.asciz "ERROR_IPSEC_IKE_QM_LIMIT"

	.byte 188,236,0,9
	.asciz "ERROR_IPSEC_IKE_MM_EXPIRED"

	.byte 189,236,0,9
	.asciz "ERROR_IPSEC_IKE_DOS_COOKIE_SENT"

	.byte 194,236,0,9
	.asciz "ERROR_IPSEC_IKE_SHUTTING_DOWN"

	.byte 195,236,0,9
	.asciz "ERROR_IPSEC_IKE_CGA_AUTH_FAILED"

	.byte 196,236,0,9
	.asciz "ERROR_IPSEC_IKE_QM_EXPIRED"

	.byte 199,236,0,9
	.asciz "ERROR_IPSEC_IKE_NEG_STATUS_END"

	.byte 201,236,0,9
	.asciz "ERROR_IPSEC_IKE_RATELIMIT_DROP"

	.byte 207,236,0,9
	.asciz "ERROR_IPSEC_BAD_SPI"

	.byte 214,236,0,9
	.asciz "ERROR_IPSEC_SA_LIFETIME_EXPIRED"

	.byte 215,236,0,9
	.asciz "ERROR_IPSEC_WRONG_SA"

	.byte 216,236,0,9
	.asciz "ERROR_IPSEC_REPLAY_CHECK_FAILED"

	.byte 217,236,0,9
	.asciz "ERROR_IPSEC_INVALID_PACKET"

	.byte 218,236,0,9
	.asciz "ERROR_IPSEC_CLEAR_TEXT_DROP"

	.byte 220,236,0,9
	.asciz "ERROR_IPSEC_AUTH_FIREWALL_DROP"

	.byte 221,236,0,9
	.asciz "ERROR_IPSEC_THROTTLE_DROP"

	.byte 222,236,0,9
	.asciz "ERROR_IPSEC_DOSP_BLOCK"

	.byte 229,236,0,9
	.asciz "ERROR_IPSEC_DOSP_INVALID_PACKET"

	.byte 231,236,0,9
	.asciz "ERROR_IPSEC_DOSP_MAX_ENTRIES"

	.byte 233,236,0,9
	.asciz "ERROR_IPSEC_DOSP_NOT_INSTALLED"

	.byte 235,236,0,9
	.asciz "ERROR_SXS_SECTION_NOT_FOUND"

	.byte 176,237,0,9
	.asciz "ERROR_SXS_CANT_GEN_ACTCTX"

	.byte 177,237,0,9
	.asciz "ERROR_SXS_ASSEMBLY_NOT_FOUND"

	.byte 179,237,0,9
	.asciz "ERROR_SXS_MANIFEST_FORMAT_ERROR"

	.byte 180,237,0,9
	.asciz "ERROR_SXS_MANIFEST_PARSE_ERROR"

	.byte 181,237,0,9
	.asciz "ERROR_SXS_KEY_NOT_FOUND"

	.byte 183,237,0,9
	.asciz "ERROR_SXS_VERSION_CONFLICT"

	.byte 184,237,0,9
	.asciz "ERROR_SXS_WRONG_SECTION_TYPE"

	.byte 185,237,0,9
	.asciz "ERROR_SXS_UNKNOWN_ENCODING"

	.byte 189,237,0,9
	.asciz "ERROR_SXS_DUPLICATE_DLL_NAME"

	.byte 197,237,0,9
	.asciz "ERROR_SXS_DUPLICATE_CLSID"

	.byte 199,237,0,9
	.asciz "ERROR_SXS_DUPLICATE_IID"

	.byte 200,237,0,9
	.asciz "ERROR_SXS_DUPLICATE_TLBID"

	.byte 201,237,0,9
	.asciz "ERROR_SXS_DUPLICATE_PROGID"

	.byte 202,237,0,9
	.asciz "ERROR_SXS_FILE_HASH_MISMATCH"

	.byte 204,237,0,9
	.asciz "ERROR_SXS_POLICY_PARSE_ERROR"

	.byte 205,237,0,9
	.asciz "ERROR_SXS_XML_E_MISSINGQUOTE"

	.byte 206,237,0,9
	.asciz "ERROR_SXS_XML_E_COMMENTSYNTAX"

	.byte 207,237,0,9
	.asciz "ERROR_SXS_XML_E_BADNAMECHAR"

	.byte 209,237,0,9
	.asciz "ERROR_SXS_XML_E_BADCHARINSTRING"

	.byte 210,237,0,9
	.asciz "ERROR_SXS_XML_E_XMLDECLSYNTAX"

	.byte 211,237,0,9
	.asciz "ERROR_SXS_XML_E_BADCHARDATA"

	.byte 212,237,0,9
	.asciz "ERROR_SXS_XML_E_EXPECTINGTAGEND"

	.byte 214,237,0,9
	.asciz "ERROR_SXS_XML_E_UNBALANCEDPAREN"

	.byte 216,237,0,9
	.asciz "ERROR_SXS_XML_E_INTERNALERROR"

	.byte 217,237,0,9
	.asciz "ERROR_SXS_XML_E_MISSING_PAREN"

	.byte 220,237,0,9
	.asciz "ERROR_SXS_XML_E_MULTIPLE_COLONS"

	.byte 222,237,0,9
	.asciz "ERROR_SXS_XML_E_INVALID_DECIMAL"

	.byte 223,237,0,9
	.asciz "ERROR_SXS_XML_E_INVALID_UNICODE"

	.byte 225,237,0,9
	.asciz "ERROR_SXS_XML_E_UNCLOSEDTAG"

	.byte 228,237,0,9
	.asciz "ERROR_SXS_XML_E_MULTIPLEROOTS"

	.byte 230,237,0,9
	.asciz "ERROR_SXS_XML_E_BADXMLDECL"

	.byte 232,237,0,9
	.asciz "ERROR_SXS_XML_E_MISSINGROOT"

	.byte 233,237,0,9
	.asciz "ERROR_SXS_XML_E_UNEXPECTEDEOF"

	.byte 234,237,0,9
	.asciz "ERROR_SXS_XML_E_UNCLOSEDENDTAG"

	.byte 237,237,0,9
	.asciz "ERROR_SXS_XML_E_UNCLOSEDSTRING"

	.byte 238,237,0,9
	.asciz "ERROR_SXS_XML_E_UNCLOSEDCOMMENT"

	.byte 239,237,0,9
	.asciz "ERROR_SXS_XML_E_UNCLOSEDDECL"

	.byte 240,237,0,9
	.asciz "ERROR_SXS_XML_E_UNCLOSEDCDATA"

	.byte 241,237,0,9
	.asciz "ERROR_SXS_XML_E_INVALIDENCODING"

	.byte 243,237,0,9
	.asciz "ERROR_SXS_XML_E_INVALIDSWITCH"

	.byte 244,237,0,9
	.asciz "ERROR_SXS_XML_E_BADXMLCASE"

	.byte 245,237,0,9
	.asciz "ERROR_SXS_XML_E_INVALID_VERSION"

	.byte 248,237,0,9
	.asciz "ERROR_SXS_XML_E_MISSINGEQUALS"

	.byte 249,237,0,9
	.asciz "ERROR_SXS_ASSEMBLY_MISSING"

	.byte 129,238,0,9
	.asciz "ERROR_SXS_CORRUPTION"

	.byte 131,238,0,9
	.asciz "ERROR_SXS_EARLY_DEACTIVATION"

	.byte 132,238,0,9
	.asciz "ERROR_SXS_INVALID_DEACTIVATION"

	.byte 133,238,0,9
	.asciz "ERROR_SXS_MULTIPLE_DEACTIVATION"

	.byte 134,238,0,9
	.asciz "ERROR_SXS_IDENTITY_PARSE_ERROR"

	.byte 141,238,0,9
	.asciz "ERROR_SXS_ASSEMBLY_NOT_LOCKED"

	.byte 145,238,0,9
	.asciz "ERROR_ADVANCED_INSTALLER_FAILED"

	.byte 147,238,0,9
	.asciz "ERROR_XML_ENCODING_MISMATCH"

	.byte 148,238,0,9
	.asciz "ERROR_SXS_IDENTITIES_DIFFERENT"

	.byte 150,238,0,9
	.asciz "ERROR_SXS_MANIFEST_TOO_BIG"

	.byte 153,238,0,9
	.asciz "ERROR_GENERIC_COMMAND_FAILED"

	.byte 157,238,0,9
	.asciz "ERROR_SXS_FILE_HASH_MISSING"

	.byte 158,238,0,9
	.asciz "ERROR_EVT_INVALID_CHANNEL_PATH"

	.byte 152,245,0,9
	.asciz "ERROR_EVT_INVALID_QUERY"

	.byte 153,245,0,9
	.asciz "ERROR_EVT_INVALID_EVENT_DATA"

	.byte 157,245,0,9
	.asciz "ERROR_EVT_CHANNEL_NOT_FOUND"

	.byte 159,245,0,9
	.asciz "ERROR_EVT_MALFORMED_XML_TEXT"

	.byte 160,245,0,9
	.asciz "ERROR_EVT_CONFIGURATION_ERROR"

	.byte 162,245,0,9
	.asciz "ERROR_EVT_QUERY_RESULT_STALE"

	.byte 163,245,0,9
	.asciz "ERROR_EVT_NON_VALIDATING_MSXML"

	.byte 165,245,0,9
	.asciz "ERROR_EVT_FILTER_ALREADYSCOPED"

	.byte 166,245,0,9
	.asciz "ERROR_EVT_FILTER_NOTELTSET"

	.byte 167,245,0,9
	.asciz "ERROR_EVT_FILTER_INVARG"

	.byte 168,245,0,9
	.asciz "ERROR_EVT_FILTER_INVTEST"

	.byte 169,245,0,9
	.asciz "ERROR_EVT_FILTER_INVTYPE"

	.byte 170,245,0,9
	.asciz "ERROR_EVT_FILTER_PARSEERR"

	.byte 171,245,0,9
	.asciz "ERROR_EVT_FILTER_UNSUPPORTEDOP"

	.byte 172,245,0,9
	.asciz "ERROR_EVT_FILTER_TOO_COMPLEX"

	.byte 178,245,0,9
	.asciz "ERROR_EVT_MESSAGE_NOT_FOUND"

	.byte 179,245,0,9
	.asciz "ERROR_EVT_MESSAGE_ID_NOT_FOUND"

	.byte 180,245,0,9
	.asciz "ERROR_EVT_MAX_INSERTS_REACHED"

	.byte 183,245,0,9
	.asciz "ERROR_EVT_VERSION_TOO_OLD"

	.byte 186,245,0,9
	.asciz "ERROR_EVT_VERSION_TOO_NEW"

	.byte 187,245,0,9
	.asciz "ERROR_EVT_PUBLISHER_DISABLED"

	.byte 189,245,0,9
	.asciz "ERROR_EVT_FILTER_OUT_OF_RANGE"

	.byte 190,245,0,9
	.asciz "ERROR_EC_LOG_DISABLED"

	.byte 233,245,0,9
	.asciz "ERROR_EC_CIRCULAR_FORWARDING"

	.byte 234,245,0,9
	.asciz "ERROR_EC_CREDSTORE_FULL"

	.byte 235,245,0,9
	.asciz "ERROR_EC_CRED_NOT_FOUND"

	.byte 236,245,0,9
	.asciz "ERROR_EC_NO_ACTIVE_CHANNEL"

	.byte 237,245,0,9
	.asciz "ERROR_MUI_FILE_NOT_FOUND"

	.byte 252,245,0,9
	.asciz "ERROR_MUI_INVALID_FILE"

	.byte 253,245,0,9
	.asciz "ERROR_MUI_INVALID_RC_CONFIG"

	.byte 254,245,0,9
	.asciz "ERROR_MUI_INVALID_LOCALE_NAME"

	.byte 255,245,0,9
	.asciz "ERROR_MUI_FILE_NOT_LOADED"

	.byte 129,246,0,9
	.asciz "ERROR_RESOURCE_ENUM_USER_STOP"

	.byte 130,246,0,9
	.asciz "ERROR_MRM_INVALID_PRICONFIG"

	.byte 135,246,0,9
	.asciz "ERROR_MRM_INVALID_FILE_TYPE"

	.byte 136,246,0,9
	.asciz "ERROR_MRM_UNKNOWN_QUALIFIER"

	.byte 137,246,0,9
	.asciz "ERROR_MRM_NO_CANDIDATE"

	.byte 139,246,0,9
	.asciz "ERROR_MRM_DUPLICATE_MAP_NAME"

	.byte 142,246,0,9
	.asciz "ERROR_MRM_DUPLICATE_ENTRY"

	.byte 143,246,0,9
	.asciz "ERROR_MRM_FILEPATH_TOO_LONG"

	.byte 145,246,0,9
	.asciz "ERROR_MRM_INVALID_PRI_FILE"

	.byte 150,246,0,9
	.asciz "ERROR_MRM_MAP_NOT_FOUND"

	.byte 159,246,0,9
	.asciz "ERROR_MRM_AUTOMERGE_ENABLED"

	.byte 163,246,0,9
	.asciz "ERROR_MRM_TOO_MANY_RESOURCES"

	.byte 164,246,0,9
	.asciz "ERROR_MCA_INVALID_VCP_VERSION"

	.byte 225,246,0,9
	.asciz "ERROR_MCA_MCCS_VERSION_MISMATCH"

	.byte 227,246,0,9
	.asciz "ERROR_MCA_INTERNAL_ERROR"

	.byte 229,246,0,9
	.asciz "ERROR_AMBIGUOUS_SYSTEM_DEVICE"

	.byte 146,247,0,9
	.asciz "ERROR_SYSTEM_DEVICE_NOT_FOUND"

	.byte 195,247,0,9
	.asciz "ERROR_HASH_NOT_SUPPORTED"

	.byte 196,247,0,9
	.asciz "ERROR_HASH_NOT_PRESENT"

	.byte 197,247,0,9
	.asciz "ERROR_GPIO_OPERATION_DENIED"

	.byte 221,247,0,9
	.asciz "ERROR_CANNOT_SWITCH_RUNLEVEL"

	.byte 168,248,0,9
	.asciz "ERROR_INVALID_RUNLEVEL_SETTING"

	.byte 169,248,0,9
	.asciz "ERROR_RUNLEVEL_SWITCH_TIMEOUT"

	.byte 170,248,0,9
	.asciz "ERROR_SERVICES_FAILED_AUTOSTART"

	.byte 173,248,0,9
	.asciz "ERROR_COM_TASK_STOP_PENDING"

	.byte 141,249,0,9
	.asciz "ERROR_INSTALL_PACKAGE_NOT_FOUND"

	.byte 241,249,0,9
	.asciz "ERROR_INSTALL_INVALID_PACKAGE"

	.byte 242,249,0,9
	.asciz "ERROR_INSTALL_OUT_OF_DISK_SPACE"

	.byte 244,249,0,9
	.asciz "ERROR_INSTALL_NETWORK_FAILURE"

	.byte 245,249,0,9
	.asciz "ERROR_INSTALL_CANCEL"

	.byte 248,249,0,9
	.asciz "ERROR_INSTALL_FAILED"

	.byte 249,249,0,9
	.asciz "ERROR_REMOVE_FAILED"

	.byte 250,249,0,9
	.asciz "ERROR_PACKAGE_ALREADY_EXISTS"

	.byte 251,249,0,9
	.asciz "ERROR_NEEDS_REMEDIATION"

	.byte 252,249,0,9
	.asciz "ERROR_INSTALL_POLICY_FAILURE"

	.byte 255,249,0,9
	.asciz "ERROR_PACKAGE_UPDATING"

	.byte 128,250,0,9
	.asciz "ERROR_PACKAGES_IN_USE"

	.byte 130,250,0,9
	.asciz "ERROR_RECOVERY_FILE_CORRUPT"

	.byte 131,250,0,9
	.asciz "ERROR_INVALID_STAGED_SIGNATURE"

	.byte 132,250,0,9
	.asciz "ERROR_INSTALL_PACKAGE_DOWNGRADE"

	.byte 134,250,0,9
	.asciz "ERROR_SYSTEM_NEEDS_REMEDIATION"

	.byte 135,250,0,9
	.asciz "ERROR_RESILIENCY_FILE_CORRUPT"

	.byte 137,250,0,9
	.asciz "ERROR_PACKAGE_MOVE_FAILED"

	.byte 139,250,0,9
	.asciz "ERROR_INSTALL_VOLUME_NOT_EMPTY"

	.byte 140,250,0,9
	.asciz "ERROR_INSTALL_VOLUME_OFFLINE"

	.byte 141,250,0,9
	.asciz "ERROR_INSTALL_VOLUME_CORRUPT"

	.byte 142,250,0,9
	.asciz "ERROR_NEEDS_REGISTRATION"

	.byte 143,250,0,9
	.asciz "APPMODEL_ERROR_NO_PACKAGE"

	.byte 212,250,0,9
	.asciz "APPMODEL_ERROR_NO_APPLICATION"

	.byte 215,250,0,9
	.asciz "ERROR_STATE_LOAD_STORE_FAILED"

	.byte 184,251,0,9
	.asciz "ERROR_STATE_GET_VERSION_FAILED"

	.byte 185,251,0,9
	.asciz "ERROR_STATE_SET_VERSION_FAILED"

	.byte 186,251,0,9
	.asciz "ERROR_STATE_READ_SETTING_FAILED"

	.byte 191,251,0,9
	.asciz "ERROR_API_UNAVAILABLE"

	.byte 225,251,0,9
	.asciz "STORE_ERROR_UNLICENSED"

	.byte 245,251,0,9
	.asciz "STORE_ERROR_UNLICENSED_USER"

	.byte 246,251,0,9
	.asciz "STORE_ERROR_LICENSE_REVOKED"

	.byte 248,251,0,9
	.asciz "NERR_Success"

	.byte 0,9
	.asciz "NERR_NetNotStarted"

	.byte 182,16,9
	.asciz "NERR_UnknownServer"

	.byte 183,16,9
	.asciz "NERR_ShareMem"

	.byte 184,16,9
	.asciz "NERR_NoNetworkResource"

	.byte 185,16,9
	.asciz "NERR_RemoteOnly"

	.byte 186,16,9
	.asciz "NERR_DevNotRedirected"

	.byte 187,16,9
	.asciz "NERR_ServerNotStarted"

	.byte 194,16,9
	.asciz "NERR_ItemNotFound"

	.byte 195,16,9
	.asciz "NERR_UnknownDevDir"

	.byte 196,16,9
	.asciz "NERR_RedirectedPath"

	.byte 197,16,9
	.asciz "NERR_DuplicateShare"

	.byte 198,16,9
	.asciz "NERR_NoRoom"

	.byte 199,16,9
	.asciz "NERR_TooManyItems"

	.byte 201,16,9
	.asciz "NERR_InvalidMaxUsers"

	.byte 202,16,9
	.asciz "NERR_BufTooSmall"

	.byte 203,16,9
	.asciz "NERR_RemoteErr"

	.byte 207,16,9
	.asciz "NERR_LanmanIniError"

	.byte 211,16,9
	.asciz "NERR_NetworkError"

	.byte 216,16,9
	.asciz "NERR_WkstaInconsistentState"

	.byte 217,16,9
	.asciz "NERR_WkstaNotStarted"

	.byte 218,16,9
	.asciz "NERR_BrowserNotStarted"

	.byte 219,16,9
	.asciz "NERR_InternalError"

	.byte 220,16,9
	.asciz "NERR_BadTransactConfig"

	.byte 221,16,9
	.asciz "NERR_InvalidAPI"

	.byte 222,16,9
	.asciz "NERR_BadEventName"

	.byte 223,16,9
	.asciz "NERR_DupNameReboot"

	.byte 224,16,9
	.asciz "NERR_CfgCompNotFound"

	.byte 226,16,9
	.asciz "NERR_CfgParamNotFound"

	.byte 227,16,9
	.asciz "NERR_LineTooLong"

	.byte 229,16,9
	.asciz "NERR_QNotFound"

	.byte 230,16,9
	.asciz "NERR_JobNotFound"

	.byte 231,16,9
	.asciz "NERR_DestNotFound"

	.byte 232,16,9
	.asciz "NERR_DestExists"

	.byte 233,16,9
	.asciz "NERR_QExists"

	.byte 234,16,9
	.asciz "NERR_QNoRoom"

	.byte 235,16,9
	.asciz "NERR_JobNoRoom"

	.byte 236,16,9
	.asciz "NERR_DestNoRoom"

	.byte 237,16,9
	.asciz "NERR_DestIdle"

	.byte 238,16,9
	.asciz "NERR_DestInvalidOp"

	.byte 239,16,9
	.asciz "NERR_ProcNoRespond"

	.byte 240,16,9
	.asciz "NERR_SpoolerNotLoaded"

	.byte 241,16,9
	.asciz "NERR_DestInvalidState"

	.byte 242,16,9
	.asciz "NERR_QInvalidState"

	.byte 243,16,9
	.asciz "NERR_JobInvalidState"

	.byte 244,16,9
	.asciz "NERR_SpoolNoMemory"

	.byte 245,16,9
	.asciz "NERR_DriverNotFound"

	.byte 246,16,9
	.asciz "NERR_DataTypeInvalid"

	.byte 247,16,9
	.asciz "NERR_ProcNotFound"

	.byte 248,16,9
	.asciz "NERR_ServiceTableLocked"

	.byte 132,17,9
	.asciz "NERR_ServiceTableFull"

	.byte 133,17,9
	.asciz "NERR_ServiceInstalled"

	.byte 134,17,9
	.asciz "NERR_ServiceEntryLocked"

	.byte 135,17,9
	.asciz "NERR_ServiceNotInstalled"

	.byte 136,17,9
	.asciz "NERR_BadServiceName"

	.byte 137,17,9
	.asciz "NERR_ServiceCtlTimeout"

	.byte 138,17,9
	.asciz "NERR_ServiceCtlBusy"

	.byte 139,17,9
	.asciz "NERR_BadServiceProgName"

	.byte 140,17,9
	.asciz "NERR_ServiceNotCtrl"

	.byte 141,17,9
	.asciz "NERR_ServiceKillProc"

	.byte 142,17,9
	.asciz "NERR_ServiceCtlNotValid"

	.byte 143,17,9
	.asciz "NERR_NotInDispatchTbl"

	.byte 144,17,9
	.asciz "NERR_BadControlRecv"

	.byte 145,17,9
	.asciz "NERR_ServiceNotStarting"

	.byte 146,17,9
	.asciz "NERR_AlreadyLoggedOn"

	.byte 152,17,9
	.asciz "NERR_NotLoggedOn"

	.byte 153,17,9
	.asciz "NERR_BadUsername"

	.byte 154,17,9
	.asciz "NERR_BadPassword"

	.byte 155,17,9
	.asciz "NERR_UnableToAddName_W"

	.byte 156,17,9
	.asciz "NERR_UnableToAddName_F"

	.byte 157,17,9
	.asciz "NERR_UnableToDelName_W"

	.byte 158,17,9
	.asciz "NERR_UnableToDelName_F"

	.byte 159,17,9
	.asciz "NERR_LogonsPaused"

	.byte 161,17,9
	.asciz "NERR_LogonServerConflict"

	.byte 162,17,9
	.asciz "NERR_LogonNoUserPath"

	.byte 163,17,9
	.asciz "NERR_LogonScriptError"

	.byte 164,17,9
	.asciz "NERR_StandaloneLogon"

	.byte 166,17,9
	.asciz "NERR_LogonServerNotFound"

	.byte 167,17,9
	.asciz "NERR_LogonDomainExists"

	.byte 168,17,9
	.asciz "NERR_NonValidatedLogon"

	.byte 169,17,9
	.asciz "NERR_ACFNotFound"

	.byte 171,17,9
	.asciz "NERR_GroupNotFound"

	.byte 172,17,9
	.asciz "NERR_UserNotFound"

	.byte 173,17,9
	.asciz "NERR_ResourceNotFound"

	.byte 174,17,9
	.asciz "NERR_GroupExists"

	.byte 175,17,9
	.asciz "NERR_UserExists"

	.byte 176,17,9
	.asciz "NERR_ResourceExists"

	.byte 177,17,9
	.asciz "NERR_NotPrimary"

	.byte 178,17,9
	.asciz "NERR_ACFNotLoaded"

	.byte 179,17,9
	.asciz "NERR_ACFNoRoom"

	.byte 180,17,9
	.asciz "NERR_ACFFileIOFail"

	.byte 181,17,9
	.asciz "NERR_ACFTooManyLists"

	.byte 182,17,9
	.asciz "NERR_UserLogon"

	.byte 183,17,9
	.asciz "NERR_ACFNoParent"

	.byte 184,17,9
	.asciz "NERR_CanNotGrowSegment"

	.byte 185,17,9
	.asciz "NERR_SpeGroupOp"

	.byte 186,17,9
	.asciz "NERR_NotInCache"

	.byte 187,17,9
	.asciz "NERR_UserInGroup"

	.byte 188,17,9
	.asciz "NERR_UserNotInGroup"

	.byte 189,17,9
	.asciz "NERR_AccountUndefined"

	.byte 190,17,9
	.asciz "NERR_AccountExpired"

	.byte 191,17,9
	.asciz "NERR_InvalidWorkstation"

	.byte 192,17,9
	.asciz "NERR_InvalidLogonHours"

	.byte 193,17,9
	.asciz "NERR_PasswordExpired"

	.byte 194,17,9
	.asciz "NERR_PasswordCantChange"

	.byte 195,17,9
	.asciz "NERR_PasswordHistConflict"

	.byte 196,17,9
	.asciz "NERR_PasswordTooShort"

	.byte 197,17,9
	.asciz "NERR_PasswordTooRecent"

	.byte 198,17,9
	.asciz "NERR_InvalidDatabase"

	.byte 199,17,9
	.asciz "NERR_DatabaseUpToDate"

	.byte 200,17,9
	.asciz "NERR_SyncRequired"

	.byte 201,17,9
	.asciz "NERR_UseNotFound"

	.byte 202,17,9
	.asciz "NERR_BadAsgType"

	.byte 203,17,9
	.asciz "NERR_DeviceIsShared"

	.byte 204,17,9
	.asciz "NERR_SameAsComputerName"

	.byte 205,17,9
	.asciz "NERR_NoComputerName"

	.byte 222,17,9
	.asciz "NERR_MsgAlreadyStarted"

	.byte 223,17,9
	.asciz "NERR_MsgInitFailed"

	.byte 224,17,9
	.asciz "NERR_NameNotFound"

	.byte 225,17,9
	.asciz "NERR_AlreadyForwarded"

	.byte 226,17,9
	.asciz "NERR_AddForwarded"

	.byte 227,17,9
	.asciz "NERR_AlreadyExists"

	.byte 228,17,9
	.asciz "NERR_TooManyNames"

	.byte 229,17,9
	.asciz "NERR_DelComputerName"

	.byte 230,17,9
	.asciz "NERR_LocalForward"

	.byte 231,17,9
	.asciz "NERR_GrpMsgProcessor"

	.byte 232,17,9
	.asciz "NERR_PausedRemote"

	.byte 233,17,9
	.asciz "NERR_BadReceive"

	.byte 234,17,9
	.asciz "NERR_NameInUse"

	.byte 235,17,9
	.asciz "NERR_MsgNotStarted"

	.byte 236,17,9
	.asciz "NERR_NotLocalName"

	.byte 237,17,9
	.asciz "NERR_NoForwardName"

	.byte 238,17,9
	.asciz "NERR_RemoteFull"

	.byte 239,17,9
	.asciz "NERR_NameNotForwarded"

	.byte 240,17,9
	.asciz "NERR_TruncatedBroadcast"

	.byte 241,17,9
	.asciz "NERR_InvalidDevice"

	.byte 246,17,9
	.asciz "NERR_WriteFault"

	.byte 247,17,9
	.asciz "NERR_DuplicateName"

	.byte 249,17,9
	.asciz "NERR_DeleteLater"

	.byte 250,17,9
	.asciz "NERR_IncompleteDel"

	.byte 251,17,9
	.asciz "NERR_MultipleNets"

	.byte 252,17,9
	.asciz "NERR_NetNameNotFound"

	.byte 134,18,9
	.asciz "NERR_DeviceNotShared"

	.byte 135,18,9
	.asciz "NERR_ClientNameNotFound"

	.byte 136,18,9
	.asciz "NERR_FileIdNotFound"

	.byte 138,18,9
	.asciz "NERR_ExecFailure"

	.byte 139,18,9
	.asciz "NERR_TmpFile"

	.byte 140,18,9
	.asciz "NERR_TooMuchData"

	.byte 141,18,9
	.asciz "NERR_DeviceShareConflict"

	.byte 142,18,9
	.asciz "NERR_BrowserTableIncomplete"

	.byte 143,18,9
	.asciz "NERR_NotLocalDomain"

	.byte 144,18,9
	.asciz "NERR_IsDfsShare"

	.byte 145,18,9
	.asciz "NERR_DevInvalidOpCode"

	.byte 155,18,9
	.asciz "NERR_DevNotFound"

	.byte 156,18,9
	.asciz "NERR_DevNotOpen"

	.byte 157,18,9
	.asciz "NERR_BadQueueDevString"

	.byte 158,18,9
	.asciz "NERR_BadQueuePriority"

	.byte 159,18,9
	.asciz "NERR_NoCommDevs"

	.byte 161,18,9
	.asciz "NERR_QueueNotFound"

	.byte 162,18,9
	.asciz "NERR_BadDevString"

	.byte 164,18,9
	.asciz "NERR_BadDev"

	.byte 165,18,9
	.asciz "NERR_InUseBySpooler"

	.byte 166,18,9
	.asciz "NERR_CommDevInUse"

	.byte 167,18,9
	.asciz "NERR_InvalidComputer"

	.byte 175,18,9
	.asciz "NERR_MaxLenExceeded"

	.byte 178,18,9
	.asciz "NERR_BadComponent"

	.byte 180,18,9
	.asciz "NERR_CantType"

	.byte 181,18,9
	.asciz "NERR_TooManyEntries"

	.byte 186,18,9
	.asciz "NERR_ProfileFileTooBig"

	.byte 194,18,9
	.asciz "NERR_ProfileOffset"

	.byte 195,18,9
	.asciz "NERR_ProfileCleanup"

	.byte 196,18,9
	.asciz "NERR_ProfileUnknownCmd"

	.byte 197,18,9
	.asciz "NERR_ProfileLoadErr"

	.byte 198,18,9
	.asciz "NERR_ProfileSaveErr"

	.byte 199,18,9
	.asciz "NERR_LogOverflow"

	.byte 201,18,9
	.asciz "NERR_LogFileChanged"

	.byte 202,18,9
	.asciz "NERR_LogFileCorrupt"

	.byte 203,18,9
	.asciz "NERR_SourceIsDir"

	.byte 204,18,9
	.asciz "NERR_BadSource"

	.byte 205,18,9
	.asciz "NERR_BadDest"

	.byte 206,18,9
	.asciz "NERR_DifferentServers"

	.byte 207,18,9
	.asciz "NERR_RunSrvPaused"

	.byte 209,18,9
	.asciz "NERR_ErrCommRunSrv"

	.byte 213,18,9
	.asciz "NERR_ErrorExecingGhost"

	.byte 215,18,9
	.asciz "NERR_ShareNotFound"

	.byte 216,18,9
	.asciz "NERR_InvalidLana"

	.byte 224,18,9
	.asciz "NERR_OpenFiles"

	.byte 225,18,9
	.asciz "NERR_ActiveConns"

	.byte 226,18,9
	.asciz "NERR_BadPasswordCore"

	.byte 227,18,9
	.asciz "NERR_DevInUse"

	.byte 228,18,9
	.asciz "NERR_LocalDrive"

	.byte 229,18,9
	.asciz "NERR_AlertExists"

	.byte 254,18,9
	.asciz "NERR_TooManyAlerts"

	.byte 255,18,9
	.asciz "NERR_NoSuchAlert"

	.byte 128,19,9
	.asciz "NERR_BadRecipient"

	.byte 129,19,9
	.asciz "NERR_AcctLimitExceeded"

	.byte 130,19,9
	.asciz "NERR_InvalidLogSeek"

	.byte 136,19,9
	.asciz "NERR_BadUasConfig"

	.byte 146,19,9
	.asciz "NERR_InvalidUASOp"

	.byte 147,19,9
	.asciz "NERR_LastAdmin"

	.byte 148,19,9
	.asciz "NERR_DCNotFound"

	.byte 149,19,9
	.asciz "NERR_LogonTrackingError"

	.byte 150,19,9
	.asciz "NERR_NetlogonNotStarted"

	.byte 151,19,9
	.asciz "NERR_CanNotGrowUASFile"

	.byte 152,19,9
	.asciz "NERR_TimeDiffAtDC"

	.byte 153,19,9
	.asciz "NERR_PasswordMismatch"

	.byte 154,19,9
	.asciz "NERR_NoSuchServer"

	.byte 156,19,9
	.asciz "NERR_NoSuchSession"

	.byte 157,19,9
	.asciz "NERR_NoSuchConnection"

	.byte 158,19,9
	.asciz "NERR_TooManyServers"

	.byte 159,19,9
	.asciz "NERR_TooManySessions"

	.byte 160,19,9
	.asciz "NERR_TooManyConnections"

	.byte 161,19,9
	.asciz "NERR_TooManyFiles"

	.byte 162,19,9
	.asciz "NERR_NoAlternateServers"

	.byte 163,19,9
	.asciz "NERR_TryDownLevel"

	.byte 166,19,9
	.asciz "NERR_UPSDriverNotStarted"

	.byte 176,19,9
	.asciz "NERR_UPSInvalidConfig"

	.byte 177,19,9
	.asciz "NERR_UPSInvalidCommPort"

	.byte 178,19,9
	.asciz "NERR_UPSSignalAsserted"

	.byte 179,19,9
	.asciz "NERR_UPSShutdownFailed"

	.byte 180,19,9
	.asciz "NERR_BadDosRetCode"

	.byte 196,19,9
	.asciz "NERR_ProgNeedsExtraMem"

	.byte 197,19,9
	.asciz "NERR_BadDosFunction"

	.byte 198,19,9
	.asciz "NERR_RemoteBootFailed"

	.byte 199,19,9
	.asciz "NERR_BadFileCheckSum"

	.byte 200,19,9
	.asciz "NERR_NoRplBootSystem"

	.byte 201,19,9
	.asciz "NERR_RplLoadrNetBiosErr"

	.byte 202,19,9
	.asciz "NERR_RplLoadrDiskErr"

	.byte 203,19,9
	.asciz "NERR_ImageParamErr"

	.byte 204,19,9
	.asciz "NERR_TooManyImageParams"

	.byte 205,19,9
	.asciz "NERR_NonDosFloppyUsed"

	.byte 206,19,9
	.asciz "NERR_RplBootRestart"

	.byte 207,19,9
	.asciz "NERR_RplSrvrCallFailed"

	.byte 208,19,9
	.asciz "NERR_CantConnectRplSrvr"

	.byte 209,19,9
	.asciz "NERR_CantOpenImageFile"

	.byte 210,19,9
	.asciz "NERR_CallingRplSrvr"

	.byte 211,19,9
	.asciz "NERR_StartingRplBoot"

	.byte 212,19,9
	.asciz "NERR_RplBootServiceTerm"

	.byte 213,19,9
	.asciz "NERR_RplBootStartFailed"

	.byte 214,19,9
	.asciz "NERR_RPL_CONNECTED"

	.byte 215,19,9
	.asciz "NERR_BrowserConfiguredToNotRun"

	.byte 246,19,9
	.asciz "NERR_RplNoAdaptersStarted"

	.byte 178,20,9
	.asciz "NERR_RplBadRegistry"

	.byte 179,20,9
	.asciz "NERR_RplBadDatabase"

	.byte 180,20,9
	.asciz "NERR_RplRplfilesShare"

	.byte 181,20,9
	.asciz "NERR_RplNotRplServer"

	.byte 182,20,9
	.asciz "NERR_RplCannotEnum"

	.byte 183,20,9
	.asciz "NERR_RplWkstaInfoCorrupted"

	.byte 184,20,9
	.asciz "NERR_RplWkstaNotFound"

	.byte 185,20,9
	.asciz "NERR_RplWkstaNameUnavailable"

	.byte 186,20,9
	.asciz "NERR_RplProfileInfoCorrupted"

	.byte 187,20,9
	.asciz "NERR_RplProfileNotFound"

	.byte 188,20,9
	.asciz "NERR_RplProfileNameUnavailable"

	.byte 189,20,9
	.asciz "NERR_RplProfileNotEmpty"

	.byte 190,20,9
	.asciz "NERR_RplConfigInfoCorrupted"

	.byte 191,20,9
	.asciz "NERR_RplConfigNotFound"

	.byte 192,20,9
	.asciz "NERR_RplAdapterInfoCorrupted"

	.byte 193,20,9
	.asciz "NERR_RplInternal"

	.byte 194,20,9
	.asciz "NERR_RplVendorInfoCorrupted"

	.byte 195,20,9
	.asciz "NERR_RplBootInfoCorrupted"

	.byte 196,20,9
	.asciz "NERR_RplWkstaNeedsUserAcct"

	.byte 197,20,9
	.asciz "NERR_RplNeedsRPLUSERAcct"

	.byte 198,20,9
	.asciz "NERR_RplBootNotFound"

	.byte 199,20,9
	.asciz "NERR_RplIncompatibleProfile"

	.byte 200,20,9
	.asciz "NERR_RplAdapterNameUnavailable"

	.byte 201,20,9
	.asciz "NERR_RplConfigNotEmpty"

	.byte 202,20,9
	.asciz "NERR_RplBootInUse"

	.byte 203,20,9
	.asciz "NERR_RplBackupDatabase"

	.byte 204,20,9
	.asciz "NERR_RplAdapterNotFound"

	.byte 205,20,9
	.asciz "NERR_RplVendorNotFound"

	.byte 206,20,9
	.asciz "NERR_RplVendorNameUnavailable"

	.byte 207,20,9
	.asciz "NERR_RplBootNameUnavailable"

	.byte 208,20,9
	.asciz "NERR_RplConfigNameUnavailable"

	.byte 209,20,9
	.asciz "NERR_DfsInternalCorruption"

	.byte 228,20,9
	.asciz "NERR_DfsVolumeDataCorrupt"

	.byte 229,20,9
	.asciz "NERR_DfsNoSuchVolume"

	.byte 230,20,9
	.asciz "NERR_DfsVolumeAlreadyExists"

	.byte 231,20,9
	.asciz "NERR_DfsAlreadyShared"

	.byte 232,20,9
	.asciz "NERR_DfsNoSuchShare"

	.byte 233,20,9
	.asciz "NERR_DfsNotALeafVolume"

	.byte 234,20,9
	.asciz "NERR_DfsLeafVolume"

	.byte 235,20,9
	.asciz "NERR_DfsVolumeHasMultipleServers"

	.byte 236,20,9
	.asciz "NERR_DfsCantCreateJunctionPoint"

	.byte 237,20,9
	.asciz "NERR_DfsServerNotDfsAware"

	.byte 238,20,9
	.asciz "NERR_DfsBadRenamePath"

	.byte 239,20,9
	.asciz "NERR_DfsVolumeIsOffline"

	.byte 240,20,9
	.asciz "NERR_DfsNoSuchServer"

	.byte 241,20,9
	.asciz "NERR_DfsCyclicalName"

	.byte 242,20,9
	.asciz "NERR_DfsNotSupportedInServerDfs"

	.byte 243,20,9
	.asciz "NERR_DfsDuplicateService"

	.byte 244,20,9
	.asciz "NERR_DfsCantRemoveLastServerShare"

	.byte 245,20,9
	.asciz "NERR_DfsVolumeIsInterDfs"

	.byte 246,20,9
	.asciz "NERR_DfsInconsistent"

	.byte 247,20,9
	.asciz "NERR_DfsServerUpgraded"

	.byte 248,20,9
	.asciz "NERR_DfsDataIsIdentical"

	.byte 249,20,9
	.asciz "NERR_DfsCantRemoveDfsRoot"

	.byte 250,20,9
	.asciz "NERR_DfsChildOrParentInDfs"

	.byte 251,20,9
	.asciz "NERR_DfsInternalError"

	.byte 130,21,9
	.asciz "NERR_SetupAlreadyJoined"

	.byte 131,21,9
	.asciz "NERR_SetupNotJoined"

	.byte 132,21,9
	.asciz "NERR_SetupDomainController"

	.byte 133,21,9
	.asciz "NERR_DefaultJoinRequired"

	.byte 134,21,9
	.asciz "NERR_InvalidWorkgroupName"

	.byte 135,21,9
	.asciz "NERR_NameUsesIncompatibleCodePage"

	.byte 136,21,9
	.asciz "NERR_ComputerAccountNotFound"

	.byte 137,21,9
	.asciz "NERR_PersonalSku"

	.byte 138,21,9
	.asciz "NERR_SetupCheckDNSConfig"

	.byte 139,21,9
	.asciz "NERR_PasswordMustChange"

	.byte 141,21,9
	.asciz "NERR_AccountLockedOut"

	.byte 142,21,9
	.asciz "NERR_PasswordTooLong"

	.byte 143,21,9
	.asciz "NERR_PasswordNotComplexEnough"

	.byte 144,21,9
	.asciz "NERR_PasswordFilterError"

	.byte 145,21,9
	.asciz "NERR_NoOfflineJoinInfo"

	.byte 149,21,9
	.asciz "NERR_BadOfflineJoinInfo"

	.byte 150,21,9
	.asciz "NERR_CantCreateJoinInfo"

	.byte 151,21,9
	.asciz "NERR_BadDomainJoinInfo"

	.byte 152,21,9
	.asciz "NERR_JoinPerformedMustRestart"

	.byte 153,21,9
	.asciz "NERR_NoJoinPending"

	.byte 154,21,9
	.asciz "NERR_ValuesNotSet"

	.byte 155,21,9
	.asciz "NERR_CantVerifyHostname"

	.byte 156,21,9
	.asciz "NERR_CantLoadOfflineHive"

	.byte 157,21,9
	.asciz "NERR_ConnectionInsecure"

	.byte 158,21,9
	.asciz "NERR_ProvisioningBlobUnsupported"

	.byte 159,21,9
	.asciz "NERR_DS8DCRequired"

	.byte 160,21,9
	.asciz "NERR_LDAPCapableDCRequired"

	.byte 161,21,9
	.asciz "NERR_DS8DCNotFound"

	.byte 162,21,9
	.asciz "NERR_TargetVersionUnsupported"

	.byte 163,21,9
	.asciz "NERR_InvalidMachineNameForJoin"

	.byte 164,21,9
	.asciz "NERR_DS9DCNotFound"

	.byte 165,21,0,7
	.asciz "PInvoke_Win32ErrorCode"

LDIFF_SYM490=LTDIE_29 - Ldebug_info_start
	.long LDIFF_SYM490
LTDIE_29_POINTER:

	.byte 13
LDIFF_SYM491=LTDIE_29 - Ldebug_info_start
	.long LDIFF_SYM491
LTDIE_29_REFERENCE:

	.byte 14
LDIFF_SYM492=LTDIE_29 - Ldebug_info_start
	.long LDIFF_SYM492
	.byte 2
	.asciz "PInvoke.Kernel32Extensions:GetMessage"
	.asciz "PInvoke_Kernel32Extensions_GetMessage_PInvoke_Win32ErrorCode"

	.byte 0,0
	.long PInvoke_Kernel32Extensions_GetMessage_PInvoke_Win32ErrorCode
	.long Lme_5a

	.byte 2,118,16,3
	.asciz "error"

LDIFF_SYM493=LTDIE_29 - Ldebug_info_start
	.long LDIFF_SYM493
	.byte 2,123,8,11
	.asciz "V_0"

LDIFF_SYM494=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM494
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM495=Lfde69_end - Lfde69_start
	.long LDIFF_SYM495
Lfde69_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32Extensions_GetMessage_PInvoke_Win32ErrorCode

LDIFF_SYM496=Lme_5a - PInvoke_Kernel32Extensions_GetMessage_PInvoke_Win32ErrorCode
	.long LDIFF_SYM496
	.byte 68,14,8,135,2,72,14,16,136,4,139,3,142,1,68,14,32,68,13,11,2,40,10,68,13,13,14,16,68,8,8,8
	.byte 11,14,8,68,11
	.align 2
Lfde69_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32Extensions:ThrowOnError"
	.asciz "PInvoke_Kernel32Extensions_ThrowOnError_PInvoke_Win32ErrorCode"

	.byte 0,0
	.long PInvoke_Kernel32Extensions_ThrowOnError_PInvoke_Win32ErrorCode
	.long Lme_5b

	.byte 2,118,16,3
	.asciz "errorCode"

LDIFF_SYM497=LTDIE_29 - Ldebug_info_start
	.long LDIFF_SYM497
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM498=Lfde70_end - Lfde70_start
	.long LDIFF_SYM498
Lfde70_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32Extensions_ThrowOnError_PInvoke_Win32ErrorCode

LDIFF_SYM499=Lme_5b - PInvoke_Kernel32Extensions_ThrowOnError_PInvoke_Win32ErrorCode
	.long LDIFF_SYM499
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,32,80,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde70_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Kernel32Extensions:ThrowOnError"
	.asciz "PInvoke_Kernel32Extensions_ThrowOnError_PInvoke_NTSTATUS"

	.byte 0,0
	.long PInvoke_Kernel32Extensions_ThrowOnError_PInvoke_NTSTATUS
	.long Lme_5c

	.byte 2,118,16,3
	.asciz "status"

LDIFF_SYM500=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM500
	.byte 2,123,4,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM501=Lfde71_end - Lfde71_start
	.long LDIFF_SYM501
Lfde71_start:

	.long 0
	.align 2
	.long PInvoke_Kernel32Extensions_ThrowOnError_PInvoke_NTSTATUS

LDIFF_SYM502=Lme_5c - PInvoke_Kernel32Extensions_ThrowOnError_PInvoke_NTSTATUS
	.long LDIFF_SYM502
	.byte 68,14,8,135,2,72,14,16,136,4,139,3,142,1,68,14,32,68,13,11,84,10,68,13,13,14,16,68,8,8,8,11
	.byte 14,8,68,11
	.align 2
Lfde71_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_32:

	.byte 17
	.asciz "System_Collections_IDictionary"

	.byte 8,7
	.asciz "System_Collections_IDictionary"

LDIFF_SYM503=LTDIE_32 - Ldebug_info_start
	.long LDIFF_SYM503
LTDIE_32_POINTER:

	.byte 13
LDIFF_SYM504=LTDIE_32 - Ldebug_info_start
	.long LDIFF_SYM504
LTDIE_32_REFERENCE:

	.byte 14
LDIFF_SYM505=LTDIE_32 - Ldebug_info_start
	.long LDIFF_SYM505
LTDIE_34:

	.byte 17
	.asciz "System_Collections_Generic_IList`1"

	.byte 8,7
	.asciz "System_Collections_Generic_IList`1"

LDIFF_SYM506=LTDIE_34 - Ldebug_info_start
	.long LDIFF_SYM506
LTDIE_34_POINTER:

	.byte 13
LDIFF_SYM507=LTDIE_34 - Ldebug_info_start
	.long LDIFF_SYM507
LTDIE_34_REFERENCE:

	.byte 14
LDIFF_SYM508=LTDIE_34 - Ldebug_info_start
	.long LDIFF_SYM508
LTDIE_37:

	.byte 17
	.asciz "System_Collections_Generic_IEqualityComparer`1"

	.byte 8,7
	.asciz "System_Collections_Generic_IEqualityComparer`1"

LDIFF_SYM509=LTDIE_37 - Ldebug_info_start
	.long LDIFF_SYM509
LTDIE_37_POINTER:

	.byte 13
LDIFF_SYM510=LTDIE_37 - Ldebug_info_start
	.long LDIFF_SYM510
LTDIE_37_REFERENCE:

	.byte 14
LDIFF_SYM511=LTDIE_37 - Ldebug_info_start
	.long LDIFF_SYM511
LTDIE_38:

	.byte 5
	.asciz "_KeyCollection"

	.byte 12,16
LDIFF_SYM512=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM512
	.byte 2,35,0,6
	.asciz "dictionary"

LDIFF_SYM513=LTDIE_36_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM513
	.byte 2,35,8,0,7
	.asciz "_KeyCollection"

LDIFF_SYM514=LTDIE_38 - Ldebug_info_start
	.long LDIFF_SYM514
LTDIE_38_POINTER:

	.byte 13
LDIFF_SYM515=LTDIE_38 - Ldebug_info_start
	.long LDIFF_SYM515
LTDIE_38_REFERENCE:

	.byte 14
LDIFF_SYM516=LTDIE_38 - Ldebug_info_start
	.long LDIFF_SYM516
LTDIE_39:

	.byte 5
	.asciz "_ValueCollection"

	.byte 12,16
LDIFF_SYM517=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM517
	.byte 2,35,0,6
	.asciz "dictionary"

LDIFF_SYM518=LTDIE_36_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM518
	.byte 2,35,8,0,7
	.asciz "_ValueCollection"

LDIFF_SYM519=LTDIE_39 - Ldebug_info_start
	.long LDIFF_SYM519
LTDIE_39_POINTER:

	.byte 13
LDIFF_SYM520=LTDIE_39 - Ldebug_info_start
	.long LDIFF_SYM520
LTDIE_39_REFERENCE:

	.byte 14
LDIFF_SYM521=LTDIE_39 - Ldebug_info_start
	.long LDIFF_SYM521
LTDIE_36:

	.byte 5
	.asciz "System_Collections_Generic_Dictionary`2"

	.byte 48,16
LDIFF_SYM522=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM522
	.byte 2,35,0,6
	.asciz "buckets"

LDIFF_SYM523=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM523
	.byte 2,35,8,6
	.asciz "entries"

LDIFF_SYM524=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM524
	.byte 2,35,12,6
	.asciz "count"

LDIFF_SYM525=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM525
	.byte 2,35,32,6
	.asciz "version"

LDIFF_SYM526=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM526
	.byte 2,35,36,6
	.asciz "freeList"

LDIFF_SYM527=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM527
	.byte 2,35,40,6
	.asciz "freeCount"

LDIFF_SYM528=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM528
	.byte 2,35,44,6
	.asciz "comparer"

LDIFF_SYM529=LTDIE_37_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM529
	.byte 2,35,16,6
	.asciz "keys"

LDIFF_SYM530=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM530
	.byte 2,35,20,6
	.asciz "values"

LDIFF_SYM531=LTDIE_39_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM531
	.byte 2,35,24,6
	.asciz "_syncRoot"

LDIFF_SYM532=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM532
	.byte 2,35,28,0,7
	.asciz "System_Collections_Generic_Dictionary`2"

LDIFF_SYM533=LTDIE_36 - Ldebug_info_start
	.long LDIFF_SYM533
LTDIE_36_POINTER:

	.byte 13
LDIFF_SYM534=LTDIE_36 - Ldebug_info_start
	.long LDIFF_SYM534
LTDIE_36_REFERENCE:

	.byte 14
LDIFF_SYM535=LTDIE_36 - Ldebug_info_start
	.long LDIFF_SYM535
LTDIE_40:

	.byte 17
	.asciz "System_Runtime_Serialization_IFormatterConverter"

	.byte 8,7
	.asciz "System_Runtime_Serialization_IFormatterConverter"

LDIFF_SYM536=LTDIE_40 - Ldebug_info_start
	.long LDIFF_SYM536
LTDIE_40_POINTER:

	.byte 13
LDIFF_SYM537=LTDIE_40 - Ldebug_info_start
	.long LDIFF_SYM537
LTDIE_40_REFERENCE:

	.byte 14
LDIFF_SYM538=LTDIE_40 - Ldebug_info_start
	.long LDIFF_SYM538
LTDIE_42:

	.byte 5
	.asciz "System_Reflection_MemberInfo"

	.byte 8,16
LDIFF_SYM539=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM539
	.byte 2,35,0,0,7
	.asciz "System_Reflection_MemberInfo"

LDIFF_SYM540=LTDIE_42 - Ldebug_info_start
	.long LDIFF_SYM540
LTDIE_42_POINTER:

	.byte 13
LDIFF_SYM541=LTDIE_42 - Ldebug_info_start
	.long LDIFF_SYM541
LTDIE_42_REFERENCE:

	.byte 14
LDIFF_SYM542=LTDIE_42 - Ldebug_info_start
	.long LDIFF_SYM542
LTDIE_41:

	.byte 5
	.asciz "System_Type"

	.byte 12,16
LDIFF_SYM543=LTDIE_42 - Ldebug_info_start
	.long LDIFF_SYM543
	.byte 2,35,0,6
	.asciz "_impl"

LDIFF_SYM544=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM544
	.byte 2,35,8,0,7
	.asciz "System_Type"

LDIFF_SYM545=LTDIE_41 - Ldebug_info_start
	.long LDIFF_SYM545
LTDIE_41_POINTER:

	.byte 13
LDIFF_SYM546=LTDIE_41 - Ldebug_info_start
	.long LDIFF_SYM546
LTDIE_41_REFERENCE:

	.byte 14
LDIFF_SYM547=LTDIE_41 - Ldebug_info_start
	.long LDIFF_SYM547
LTDIE_35:

	.byte 5
	.asciz "System_Runtime_Serialization_SerializationInfo"

	.byte 48,16
LDIFF_SYM548=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM548
	.byte 2,35,0,6
	.asciz "m_members"

LDIFF_SYM549=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM549
	.byte 2,35,8,6
	.asciz "m_data"

LDIFF_SYM550=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM550
	.byte 2,35,12,6
	.asciz "m_types"

LDIFF_SYM551=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM551
	.byte 2,35,16,6
	.asciz "m_nameToIndex"

LDIFF_SYM552=LTDIE_36_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM552
	.byte 2,35,20,6
	.asciz "m_currMember"

LDIFF_SYM553=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM553
	.byte 2,35,40,6
	.asciz "m_converter"

LDIFF_SYM554=LTDIE_40_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM554
	.byte 2,35,24,6
	.asciz "m_fullTypeName"

LDIFF_SYM555=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM555
	.byte 2,35,28,6
	.asciz "m_assemName"

LDIFF_SYM556=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM556
	.byte 2,35,32,6
	.asciz "objectType"

LDIFF_SYM557=LTDIE_41_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM557
	.byte 2,35,36,6
	.asciz "isFullTypeNameSetExplicit"

LDIFF_SYM558=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM558
	.byte 2,35,44,6
	.asciz "isAssemblyNameSetExplicit"

LDIFF_SYM559=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM559
	.byte 2,35,45,6
	.asciz "requireSameTokenInPartialTrust"

LDIFF_SYM560=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM560
	.byte 2,35,46,0,7
	.asciz "System_Runtime_Serialization_SerializationInfo"

LDIFF_SYM561=LTDIE_35 - Ldebug_info_start
	.long LDIFF_SYM561
LTDIE_35_POINTER:

	.byte 13
LDIFF_SYM562=LTDIE_35 - Ldebug_info_start
	.long LDIFF_SYM562
LTDIE_35_REFERENCE:

	.byte 14
LDIFF_SYM563=LTDIE_35 - Ldebug_info_start
	.long LDIFF_SYM563
LTDIE_44:

	.byte 5
	.asciz "System_Reflection_TypeInfo"

	.byte 12,16
LDIFF_SYM564=LTDIE_41 - Ldebug_info_start
	.long LDIFF_SYM564
	.byte 2,35,0,0,7
	.asciz "System_Reflection_TypeInfo"

LDIFF_SYM565=LTDIE_44 - Ldebug_info_start
	.long LDIFF_SYM565
LTDIE_44_POINTER:

	.byte 13
LDIFF_SYM566=LTDIE_44 - Ldebug_info_start
	.long LDIFF_SYM566
LTDIE_44_REFERENCE:

	.byte 14
LDIFF_SYM567=LTDIE_44 - Ldebug_info_start
	.long LDIFF_SYM567
LTDIE_49:

	.byte 5
	.asciz "System_Reflection_MethodBase"

	.byte 8,16
LDIFF_SYM568=LTDIE_42 - Ldebug_info_start
	.long LDIFF_SYM568
	.byte 2,35,0,0,7
	.asciz "System_Reflection_MethodBase"

LDIFF_SYM569=LTDIE_49 - Ldebug_info_start
	.long LDIFF_SYM569
LTDIE_49_POINTER:

	.byte 13
LDIFF_SYM570=LTDIE_49 - Ldebug_info_start
	.long LDIFF_SYM570
LTDIE_49_REFERENCE:

	.byte 14
LDIFF_SYM571=LTDIE_49 - Ldebug_info_start
	.long LDIFF_SYM571
LTDIE_48:

	.byte 5
	.asciz "System_Reflection_ConstructorInfo"

	.byte 8,16
LDIFF_SYM572=LTDIE_49 - Ldebug_info_start
	.long LDIFF_SYM572
	.byte 2,35,0,0,7
	.asciz "System_Reflection_ConstructorInfo"

LDIFF_SYM573=LTDIE_48 - Ldebug_info_start
	.long LDIFF_SYM573
LTDIE_48_POINTER:

	.byte 13
LDIFF_SYM574=LTDIE_48 - Ldebug_info_start
	.long LDIFF_SYM574
LTDIE_48_REFERENCE:

	.byte 14
LDIFF_SYM575=LTDIE_48 - Ldebug_info_start
	.long LDIFF_SYM575
LTDIE_47:

	.byte 5
	.asciz "System_Reflection_RuntimeConstructorInfo"

	.byte 8,16
LDIFF_SYM576=LTDIE_48 - Ldebug_info_start
	.long LDIFF_SYM576
	.byte 2,35,0,0,7
	.asciz "System_Reflection_RuntimeConstructorInfo"

LDIFF_SYM577=LTDIE_47 - Ldebug_info_start
	.long LDIFF_SYM577
LTDIE_47_POINTER:

	.byte 13
LDIFF_SYM578=LTDIE_47 - Ldebug_info_start
	.long LDIFF_SYM578
LTDIE_47_REFERENCE:

	.byte 14
LDIFF_SYM579=LTDIE_47 - Ldebug_info_start
	.long LDIFF_SYM579
LTDIE_46:

	.byte 5
	.asciz "System_Reflection_MonoCMethod"

	.byte 20,16
LDIFF_SYM580=LTDIE_47 - Ldebug_info_start
	.long LDIFF_SYM580
	.byte 2,35,0,6
	.asciz "mhandle"

LDIFF_SYM581=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM581
	.byte 2,35,8,6
	.asciz "name"

LDIFF_SYM582=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM582
	.byte 2,35,12,6
	.asciz "reftype"

LDIFF_SYM583=LTDIE_41_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM583
	.byte 2,35,16,0,7
	.asciz "System_Reflection_MonoCMethod"

LDIFF_SYM584=LTDIE_46 - Ldebug_info_start
	.long LDIFF_SYM584
LTDIE_46_POINTER:

	.byte 13
LDIFF_SYM585=LTDIE_46 - Ldebug_info_start
	.long LDIFF_SYM585
LTDIE_46_REFERENCE:

	.byte 14
LDIFF_SYM586=LTDIE_46 - Ldebug_info_start
	.long LDIFF_SYM586
LTDIE_45:

	.byte 5
	.asciz "System_MonoTypeInfo"

	.byte 16,16
LDIFF_SYM587=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM587
	.byte 2,35,0,6
	.asciz "full_name"

LDIFF_SYM588=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM588
	.byte 2,35,8,6
	.asciz "default_ctor"

LDIFF_SYM589=LTDIE_46_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM589
	.byte 2,35,12,0,7
	.asciz "System_MonoTypeInfo"

LDIFF_SYM590=LTDIE_45 - Ldebug_info_start
	.long LDIFF_SYM590
LTDIE_45_POINTER:

	.byte 13
LDIFF_SYM591=LTDIE_45 - Ldebug_info_start
	.long LDIFF_SYM591
LTDIE_45_REFERENCE:

	.byte 14
LDIFF_SYM592=LTDIE_45 - Ldebug_info_start
	.long LDIFF_SYM592
LTDIE_43:

	.byte 5
	.asciz "System_RuntimeType"

	.byte 24,16
LDIFF_SYM593=LTDIE_44 - Ldebug_info_start
	.long LDIFF_SYM593
	.byte 2,35,0,6
	.asciz "type_info"

LDIFF_SYM594=LTDIE_45_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM594
	.byte 2,35,12,6
	.asciz "GenericCache"

LDIFF_SYM595=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM595
	.byte 2,35,16,6
	.asciz "m_serializationCtor"

LDIFF_SYM596=LTDIE_47_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM596
	.byte 2,35,20,0,7
	.asciz "System_RuntimeType"

LDIFF_SYM597=LTDIE_43 - Ldebug_info_start
	.long LDIFF_SYM597
LTDIE_43_POINTER:

	.byte 13
LDIFF_SYM598=LTDIE_43 - Ldebug_info_start
	.long LDIFF_SYM598
LTDIE_43_REFERENCE:

	.byte 14
LDIFF_SYM599=LTDIE_43 - Ldebug_info_start
	.long LDIFF_SYM599
LTDIE_53:

	.byte 5
	.asciz "System_Reflection_MethodInfo"

	.byte 8,16
LDIFF_SYM600=LTDIE_49 - Ldebug_info_start
	.long LDIFF_SYM600
	.byte 2,35,0,0,7
	.asciz "System_Reflection_MethodInfo"

LDIFF_SYM601=LTDIE_53 - Ldebug_info_start
	.long LDIFF_SYM601
LTDIE_53_POINTER:

	.byte 13
LDIFF_SYM602=LTDIE_53 - Ldebug_info_start
	.long LDIFF_SYM602
LTDIE_53_REFERENCE:

	.byte 14
LDIFF_SYM603=LTDIE_53 - Ldebug_info_start
	.long LDIFF_SYM603
LTDIE_54:

	.byte 5
	.asciz "System_DelegateData"

	.byte 20,16
LDIFF_SYM604=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM604
	.byte 2,35,0,6
	.asciz "target_type"

LDIFF_SYM605=LTDIE_41_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM605
	.byte 2,35,8,6
	.asciz "method_name"

LDIFF_SYM606=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM606
	.byte 2,35,12,6
	.asciz "curried_first_arg"

LDIFF_SYM607=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM607
	.byte 2,35,16,0,7
	.asciz "System_DelegateData"

LDIFF_SYM608=LTDIE_54 - Ldebug_info_start
	.long LDIFF_SYM608
LTDIE_54_POINTER:

	.byte 13
LDIFF_SYM609=LTDIE_54 - Ldebug_info_start
	.long LDIFF_SYM609
LTDIE_54_REFERENCE:

	.byte 14
LDIFF_SYM610=LTDIE_54 - Ldebug_info_start
	.long LDIFF_SYM610
LTDIE_52:

	.byte 5
	.asciz "System_Delegate"

	.byte 52,16
LDIFF_SYM611=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM611
	.byte 2,35,0,6
	.asciz "method_ptr"

LDIFF_SYM612=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM612
	.byte 2,35,8,6
	.asciz "invoke_impl"

LDIFF_SYM613=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM613
	.byte 2,35,12,6
	.asciz "m_target"

LDIFF_SYM614=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM614
	.byte 2,35,16,6
	.asciz "method"

LDIFF_SYM615=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM615
	.byte 2,35,20,6
	.asciz "delegate_trampoline"

LDIFF_SYM616=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM616
	.byte 2,35,24,6
	.asciz "extra_arg"

LDIFF_SYM617=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM617
	.byte 2,35,28,6
	.asciz "method_code"

LDIFF_SYM618=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM618
	.byte 2,35,32,6
	.asciz "method_info"

LDIFF_SYM619=LTDIE_53_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM619
	.byte 2,35,36,6
	.asciz "original_method_info"

LDIFF_SYM620=LTDIE_53_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM620
	.byte 2,35,40,6
	.asciz "data"

LDIFF_SYM621=LTDIE_54_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM621
	.byte 2,35,44,6
	.asciz "method_is_virtual"

LDIFF_SYM622=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM622
	.byte 2,35,48,0,7
	.asciz "System_Delegate"

LDIFF_SYM623=LTDIE_52 - Ldebug_info_start
	.long LDIFF_SYM623
LTDIE_52_POINTER:

	.byte 13
LDIFF_SYM624=LTDIE_52 - Ldebug_info_start
	.long LDIFF_SYM624
LTDIE_52_REFERENCE:

	.byte 14
LDIFF_SYM625=LTDIE_52 - Ldebug_info_start
	.long LDIFF_SYM625
LTDIE_51:

	.byte 5
	.asciz "System_MulticastDelegate"

	.byte 56,16
LDIFF_SYM626=LTDIE_52 - Ldebug_info_start
	.long LDIFF_SYM626
	.byte 2,35,0,6
	.asciz "delegates"

LDIFF_SYM627=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM627
	.byte 2,35,52,0,7
	.asciz "System_MulticastDelegate"

LDIFF_SYM628=LTDIE_51 - Ldebug_info_start
	.long LDIFF_SYM628
LTDIE_51_POINTER:

	.byte 13
LDIFF_SYM629=LTDIE_51 - Ldebug_info_start
	.long LDIFF_SYM629
LTDIE_51_REFERENCE:

	.byte 14
LDIFF_SYM630=LTDIE_51 - Ldebug_info_start
	.long LDIFF_SYM630
LTDIE_50:

	.byte 5
	.asciz "System_EventHandler`1"

	.byte 56,16
LDIFF_SYM631=LTDIE_51 - Ldebug_info_start
	.long LDIFF_SYM631
	.byte 2,35,0,0,7
	.asciz "System_EventHandler`1"

LDIFF_SYM632=LTDIE_50 - Ldebug_info_start
	.long LDIFF_SYM632
LTDIE_50_POINTER:

	.byte 13
LDIFF_SYM633=LTDIE_50 - Ldebug_info_start
	.long LDIFF_SYM633
LTDIE_50_REFERENCE:

	.byte 14
LDIFF_SYM634=LTDIE_50 - Ldebug_info_start
	.long LDIFF_SYM634
LTDIE_33:

	.byte 5
	.asciz "System_Runtime_Serialization_SafeSerializationManager"

	.byte 28,16
LDIFF_SYM635=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM635
	.byte 2,35,0,6
	.asciz "m_serializedStates"

LDIFF_SYM636=LTDIE_34_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM636
	.byte 2,35,8,6
	.asciz "m_savedSerializationInfo"

LDIFF_SYM637=LTDIE_35_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM637
	.byte 2,35,12,6
	.asciz "m_realObject"

LDIFF_SYM638=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM638
	.byte 2,35,16,6
	.asciz "m_realType"

LDIFF_SYM639=LTDIE_43_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM639
	.byte 2,35,20,6
	.asciz "SerializeObjectState"

LDIFF_SYM640=LTDIE_50_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM640
	.byte 2,35,24,0,7
	.asciz "System_Runtime_Serialization_SafeSerializationManager"

LDIFF_SYM641=LTDIE_33 - Ldebug_info_start
	.long LDIFF_SYM641
LTDIE_33_POINTER:

	.byte 13
LDIFF_SYM642=LTDIE_33 - Ldebug_info_start
	.long LDIFF_SYM642
LTDIE_33_REFERENCE:

	.byte 14
LDIFF_SYM643=LTDIE_33 - Ldebug_info_start
	.long LDIFF_SYM643
LTDIE_31:

	.byte 5
	.asciz "System_Exception"

	.byte 68,16
LDIFF_SYM644=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM644
	.byte 2,35,0,6
	.asciz "_className"

LDIFF_SYM645=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM645
	.byte 2,35,8,6
	.asciz "_message"

LDIFF_SYM646=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM646
	.byte 2,35,12,6
	.asciz "_data"

LDIFF_SYM647=LTDIE_32_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM647
	.byte 2,35,16,6
	.asciz "_innerException"

LDIFF_SYM648=LTDIE_31_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM648
	.byte 2,35,20,6
	.asciz "_helpURL"

LDIFF_SYM649=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM649
	.byte 2,35,24,6
	.asciz "_stackTrace"

LDIFF_SYM650=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM650
	.byte 2,35,28,6
	.asciz "_stackTraceString"

LDIFF_SYM651=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM651
	.byte 2,35,32,6
	.asciz "_remoteStackTraceString"

LDIFF_SYM652=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM652
	.byte 2,35,36,6
	.asciz "_remoteStackIndex"

LDIFF_SYM653=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM653
	.byte 2,35,40,6
	.asciz "_dynamicMethods"

LDIFF_SYM654=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM654
	.byte 2,35,44,6
	.asciz "_HResult"

LDIFF_SYM655=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM655
	.byte 2,35,48,6
	.asciz "_source"

LDIFF_SYM656=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM656
	.byte 2,35,52,6
	.asciz "_safeSerializationManager"

LDIFF_SYM657=LTDIE_33_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM657
	.byte 2,35,56,6
	.asciz "captured_traces"

LDIFF_SYM658=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM658
	.byte 2,35,60,6
	.asciz "native_trace_ips"

LDIFF_SYM659=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM659
	.byte 2,35,64,0,7
	.asciz "System_Exception"

LDIFF_SYM660=LTDIE_31 - Ldebug_info_start
	.long LDIFF_SYM660
LTDIE_31_POINTER:

	.byte 13
LDIFF_SYM661=LTDIE_31 - Ldebug_info_start
	.long LDIFF_SYM661
LTDIE_31_REFERENCE:

	.byte 14
LDIFF_SYM662=LTDIE_31 - Ldebug_info_start
	.long LDIFF_SYM662
LTDIE_30:

	.byte 5
	.asciz "PInvoke_NTStatusException"

	.byte 72,16
LDIFF_SYM663=LTDIE_31 - Ldebug_info_start
	.long LDIFF_SYM663
	.byte 2,35,0,6
	.asciz "<NativeErrorCode>k__BackingField"

LDIFF_SYM664=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM664
	.byte 2,35,68,0,7
	.asciz "PInvoke_NTStatusException"

LDIFF_SYM665=LTDIE_30 - Ldebug_info_start
	.long LDIFF_SYM665
LTDIE_30_POINTER:

	.byte 13
LDIFF_SYM666=LTDIE_30 - Ldebug_info_start
	.long LDIFF_SYM666
LTDIE_30_REFERENCE:

	.byte 14
LDIFF_SYM667=LTDIE_30 - Ldebug_info_start
	.long LDIFF_SYM667
	.byte 2
	.asciz "PInvoke.NTStatusException:.ctor"
	.asciz "PInvoke_NTStatusException__ctor_PInvoke_NTSTATUS"

	.byte 0,0
	.long PInvoke_NTStatusException__ctor_PInvoke_NTSTATUS
	.long Lme_5d

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM668=LTDIE_30_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM668
	.byte 2,123,0,3
	.asciz "statusCode"

LDIFF_SYM669=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM669
	.byte 2,123,4,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM670=Lfde72_end - Lfde72_start
	.long LDIFF_SYM670
Lfde72_start:

	.long 0
	.align 2
	.long PInvoke_NTStatusException__ctor_PInvoke_NTSTATUS

LDIFF_SYM671=Lme_5d - PInvoke_NTStatusException__ctor_PInvoke_NTSTATUS
	.long LDIFF_SYM671
	.byte 68,14,8,135,2,72,14,16,136,4,139,3,142,1,68,14,24,68,13,11,2,32,10,68,13,13,14,16,68,8,8,8
	.byte 11,14,8,68,11
	.align 2
Lfde72_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.NTStatusException:.ctor"
	.asciz "PInvoke_NTStatusException__ctor_PInvoke_NTSTATUS_string"

	.byte 0,0
	.long PInvoke_NTStatusException__ctor_PInvoke_NTSTATUS_string
	.long Lme_5e

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM672=LTDIE_30_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM672
	.byte 2,123,0,3
	.asciz "statusCode"

LDIFF_SYM673=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM673
	.byte 2,123,4,3
	.asciz "message"

LDIFF_SYM674=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM674
	.byte 2,123,8,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM675=Lfde73_end - Lfde73_start
	.long LDIFF_SYM675
Lfde73_start:

	.long 0
	.align 2
	.long PInvoke_NTStatusException__ctor_PInvoke_NTSTATUS_string

LDIFF_SYM676=Lme_5e - PInvoke_NTStatusException__ctor_PInvoke_NTSTATUS_string
	.long LDIFF_SYM676
	.byte 68,14,8,135,2,72,14,16,136,4,139,3,142,1,68,14,32,68,13,11,2,32,10,68,13,13,14,16,68,8,8,8
	.byte 11,14,8,68,11
	.align 2
Lfde73_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.NTStatusException:.ctor"
	.asciz "PInvoke_NTStatusException__ctor_PInvoke_NTSTATUS_string_System_Exception"

	.byte 0,0
	.long PInvoke_NTStatusException__ctor_PInvoke_NTSTATUS_string_System_Exception
	.long Lme_5f

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM677=LTDIE_30_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM677
	.byte 2,123,4,3
	.asciz "statusCode"

LDIFF_SYM678=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM678
	.byte 2,123,8,3
	.asciz "message"

LDIFF_SYM679=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM679
	.byte 2,123,12,3
	.asciz "inner"

LDIFF_SYM680=LTDIE_31_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM680
	.byte 2,123,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM681=Lfde74_end - Lfde74_start
	.long LDIFF_SYM681
Lfde74_start:

	.long 0
	.align 2
	.long PInvoke_NTStatusException__ctor_PInvoke_NTSTATUS_string_System_Exception

LDIFF_SYM682=Lme_5f - PInvoke_NTStatusException__ctor_PInvoke_NTSTATUS_string_System_Exception
	.long LDIFF_SYM682
	.byte 68,14,8,135,2,72,14,20,136,5,138,4,139,3,142,1,68,14,48,68,13,11,2,84,10,68,13,13,14,20,68,8
	.byte 8,8,10,8,11,14,8,68,11
	.align 2
Lfde74_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.NTStatusException:get_NativeErrorCode"
	.asciz "PInvoke_NTStatusException_get_NativeErrorCode"

	.byte 0,0
	.long PInvoke_NTStatusException_get_NativeErrorCode
	.long Lme_60

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM683=LTDIE_30_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM683
	.byte 2,125,8,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM684=Lfde75_end - Lfde75_start
	.long LDIFF_SYM684
Lfde75_start:

	.long 0
	.align 2
	.long PInvoke_NTStatusException_get_NativeErrorCode

LDIFF_SYM685=Lme_60 - PInvoke_NTStatusException_get_NativeErrorCode
	.long LDIFF_SYM685
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,32,2,36,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde75_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.NTStatusException:GetMessage"
	.asciz "PInvoke_NTStatusException_GetMessage_PInvoke_NTSTATUS"

	.byte 0,0
	.long PInvoke_NTStatusException_GetMessage_PInvoke_NTSTATUS
	.long Lme_61

	.byte 2,118,16,3
	.asciz "status"

LDIFF_SYM686=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM686
	.byte 2,123,28,11
	.asciz "V_0"

LDIFF_SYM687=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM687
	.byte 1,84,11
	.asciz "V_1"

LDIFF_SYM688=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM688
	.byte 2,123,0,11
	.asciz "V_2"

LDIFF_SYM689=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM689
	.byte 2,123,4,11
	.asciz "V_3"

LDIFF_SYM690=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM690
	.byte 2,123,8,11
	.asciz "V_4"

LDIFF_SYM691=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM691
	.byte 2,123,12,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM692=Lfde76_end - Lfde76_start
	.long LDIFF_SYM692
Lfde76_start:

	.long 0
	.align 2
	.long PInvoke_NTStatusException_GetMessage_PInvoke_NTSTATUS

LDIFF_SYM693=Lme_61 - PInvoke_NTStatusException_GetMessage_PInvoke_NTSTATUS
	.long LDIFF_SYM693
	.byte 68,14,8,135,2,72,14,20,132,5,136,4,139,3,142,1,68,14,80,68,13,11,3,44,2,10,68,13,13,14,20,68
	.byte 8,4,8,8,8,11,14,8,68,11
	.align 2
Lfde76_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_55:

	.byte 8
	.asciz "_SeverityCode"

	.byte 4
LDIFF_SYM694=LDIE_U4 - Ldebug_info_start
	.long LDIFF_SYM694
	.byte 9
	.asciz "STATUS_SEVERITY_SUCCESS"

	.byte 0,9
	.asciz "STATUS_SEVERITY_INFORMATIONAL"

	.byte 128,128,128,128,4,9
	.asciz "STATUS_SEVERITY_WARNING"

	.byte 128,128,128,128,8,9
	.asciz "STATUS_SEVERITY_ERROR"

	.byte 128,128,128,128,12,0,7
	.asciz "_SeverityCode"

LDIFF_SYM695=LTDIE_55 - Ldebug_info_start
	.long LDIFF_SYM695
LTDIE_55_POINTER:

	.byte 13
LDIFF_SYM696=LTDIE_55 - Ldebug_info_start
	.long LDIFF_SYM696
LTDIE_55_REFERENCE:

	.byte 14
LDIFF_SYM697=LTDIE_55 - Ldebug_info_start
	.long LDIFF_SYM697
	.byte 2
	.asciz "PInvoke.NTStatusException:GetSeverityString"
	.asciz "PInvoke_NTStatusException_GetSeverityString_PInvoke_NTSTATUS"

	.byte 0,0
	.long PInvoke_NTStatusException_GetSeverityString_PInvoke_NTSTATUS
	.long Lme_62

	.byte 2,118,16,3
	.asciz "status"

LDIFF_SYM698=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM698
	.byte 2,123,0,11
	.asciz "V_0"

LDIFF_SYM699=LTDIE_55 - Ldebug_info_start
	.long LDIFF_SYM699
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM700=Lfde77_end - Lfde77_start
	.long LDIFF_SYM700
Lfde77_start:

	.long 0
	.align 2
	.long PInvoke_NTStatusException_GetSeverityString_PInvoke_NTSTATUS

LDIFF_SYM701=Lme_62 - PInvoke_NTStatusException_GetSeverityString_PInvoke_NTSTATUS
	.long LDIFF_SYM701
	.byte 68,14,8,135,2,72,14,20,136,5,138,4,139,3,142,1,68,14,32,68,13,11,2,164,10,68,13,13,14,20,68,8
	.byte 8,8,10,8,11,14,8,68,11
	.align 2
Lfde77_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_56:

	.byte 5
	.asciz "PInvoke_Win32Exception"

	.byte 72,16
LDIFF_SYM702=LTDIE_31 - Ldebug_info_start
	.long LDIFF_SYM702
	.byte 2,35,0,6
	.asciz "nativeErrorCode"

LDIFF_SYM703=LTDIE_29 - Ldebug_info_start
	.long LDIFF_SYM703
	.byte 2,35,68,0,7
	.asciz "PInvoke_Win32Exception"

LDIFF_SYM704=LTDIE_56 - Ldebug_info_start
	.long LDIFF_SYM704
LTDIE_56_POINTER:

	.byte 13
LDIFF_SYM705=LTDIE_56 - Ldebug_info_start
	.long LDIFF_SYM705
LTDIE_56_REFERENCE:

	.byte 14
LDIFF_SYM706=LTDIE_56 - Ldebug_info_start
	.long LDIFF_SYM706
	.byte 2
	.asciz "PInvoke.Win32Exception:.ctor"
	.asciz "PInvoke_Win32Exception__ctor"

	.byte 0,0
	.long PInvoke_Win32Exception__ctor
	.long Lme_63

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM707=LTDIE_56_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM707
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM708=Lfde78_end - Lfde78_start
	.long LDIFF_SYM708
Lfde78_start:

	.long 0
	.align 2
	.long PInvoke_Win32Exception__ctor

LDIFF_SYM709=Lme_63 - PInvoke_Win32Exception__ctor
	.long LDIFF_SYM709
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,84,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde78_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Win32Exception:.ctor"
	.asciz "PInvoke_Win32Exception__ctor_PInvoke_Win32ErrorCode"

	.byte 0,0
	.long PInvoke_Win32Exception__ctor_PInvoke_Win32ErrorCode
	.long Lme_64

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM710=LTDIE_56_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM710
	.byte 1,86,3
	.asciz "error"

LDIFF_SYM711=LTDIE_29 - Ldebug_info_start
	.long LDIFF_SYM711
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM712=Lfde79_end - Lfde79_start
	.long LDIFF_SYM712
Lfde79_start:

	.long 0
	.align 2
	.long PInvoke_Win32Exception__ctor_PInvoke_Win32ErrorCode

LDIFF_SYM713=Lme_64 - PInvoke_Win32Exception__ctor_PInvoke_Win32ErrorCode
	.long LDIFF_SYM713
	.byte 68,14,8,135,2,72,14,24,132,6,134,5,136,4,138,3,142,1,68,14,48,2,176,10,68,14,24,68,8,4,8,6
	.byte 8,8,8,10,14,8,68,11
	.align 2
Lfde79_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Win32Exception:.ctor"
	.asciz "PInvoke_Win32Exception__ctor_int"

	.byte 0,0
	.long PInvoke_Win32Exception__ctor_int
	.long Lme_65

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM714=LTDIE_56_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM714
	.byte 2,125,0,3
	.asciz "error"

LDIFF_SYM715=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM715
	.byte 2,125,4,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM716=Lfde80_end - Lfde80_start
	.long LDIFF_SYM716
Lfde80_start:

	.long 0
	.align 2
	.long PInvoke_Win32Exception__ctor_int

LDIFF_SYM717=Lme_65 - PInvoke_Win32Exception__ctor_int
	.long LDIFF_SYM717
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,84,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde80_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Win32Exception:.ctor"
	.asciz "PInvoke_Win32Exception__ctor_PInvoke_Win32ErrorCode_string"

	.byte 0,0
	.long PInvoke_Win32Exception__ctor_PInvoke_Win32ErrorCode_string
	.long Lme_66

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM718=LTDIE_56_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM718
	.byte 2,125,0,3
	.asciz "error"

LDIFF_SYM719=LTDIE_29 - Ldebug_info_start
	.long LDIFF_SYM719
	.byte 2,125,4,3
	.asciz "message"

LDIFF_SYM720=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM720
	.byte 2,125,8,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM721=Lfde81_end - Lfde81_start
	.long LDIFF_SYM721
Lfde81_start:

	.long 0
	.align 2
	.long PInvoke_Win32Exception__ctor_PInvoke_Win32ErrorCode_string

LDIFF_SYM722=Lme_66 - PInvoke_Win32Exception__ctor_PInvoke_Win32ErrorCode_string
	.long LDIFF_SYM722
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,32,2,36,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde81_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "PInvoke.Win32Exception:get_NativeErrorCode"
	.asciz "PInvoke_Win32Exception_get_NativeErrorCode"

	.byte 0,0
	.long PInvoke_Win32Exception_get_NativeErrorCode
	.long Lme_67

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM723=LTDIE_56_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM723
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM724=Lfde82_end - Lfde82_start
	.long LDIFF_SYM724
Lfde82_start:

	.long 0
	.align 2
	.long PInvoke_Win32Exception_get_NativeErrorCode

LDIFF_SYM725=Lme_67 - PInvoke_Win32Exception_get_NativeErrorCode
	.long LDIFF_SYM725
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,76,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde82_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "System.Nullable`1<int>:.ctor"
	.asciz "System_Nullable_1_int__ctor_int"

	.byte 1,94
	.long System_Nullable_1_int__ctor_int
	.long Lme_69

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM726=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM726
	.byte 2,125,0,3
	.asciz "value"

LDIFF_SYM727=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM727
	.byte 2,125,4,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM728=Lfde83_end - Lfde83_start
	.long LDIFF_SYM728
Lfde83_start:

	.long 0
	.align 2
	.long System_Nullable_1_int__ctor_int

LDIFF_SYM729=Lme_69 - System_Nullable_1_int__ctor_int
	.long LDIFF_SYM729
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,92,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde83_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "System.Nullable`1<int>:get_HasValue"
	.asciz "System_Nullable_1_int_get_HasValue"

	.byte 1,99
	.long System_Nullable_1_int_get_HasValue
	.long Lme_6a

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM730=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM730
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM731=Lfde84_end - Lfde84_start
	.long LDIFF_SYM731
Lfde84_start:

	.long 0
	.align 2
	.long System_Nullable_1_int_get_HasValue

LDIFF_SYM732=Lme_6a - System_Nullable_1_int_get_HasValue
	.long LDIFF_SYM732
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,76,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde84_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "System.Nullable`1<int>:get_Value"
	.asciz "System_Nullable_1_int_get_Value"

	.byte 1,104
	.long System_Nullable_1_int_get_Value
	.long Lme_6b

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM733=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM733
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM734=Lfde85_end - Lfde85_start
	.long LDIFF_SYM734
Lfde85_start:

	.long 0
	.align 2
	.long System_Nullable_1_int_get_Value

LDIFF_SYM735=Lme_6b - System_Nullable_1_int_get_Value
	.long LDIFF_SYM735
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,92,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde85_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "System.Nullable`1<int>:Equals"
	.asciz "System_Nullable_1_int_Equals_object"

	.byte 1,113
	.long System_Nullable_1_int_Equals_object
	.long Lme_6c

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM736=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM736
	.byte 2,125,8,3
	.asciz "other"

LDIFF_SYM737=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM737
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM738=Lfde86_end - Lfde86_start
	.long LDIFF_SYM738
Lfde86_start:

	.long 0
	.align 2
	.long System_Nullable_1_int_Equals_object

LDIFF_SYM739=Lme_6c - System_Nullable_1_int_Equals_object
	.long LDIFF_SYM739
	.byte 68,14,8,135,2,72,14,20,133,5,136,4,138,3,142,1,68,14,40,2,176,10,68,14,20,68,8,5,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde86_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "System.Nullable`1<int>:Equals"
	.asciz "System_Nullable_1_int_Equals_System_Nullable_1_int"

	.byte 1,123
	.long System_Nullable_1_int_Equals_System_Nullable_1_int
	.long Lme_6d

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM740=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM740
	.byte 1,90,3
	.asciz "other"

LDIFF_SYM741=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM741
	.byte 2,123,8,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM742=Lfde87_end - Lfde87_start
	.long LDIFF_SYM742
Lfde87_start:

	.long 0
	.align 2
	.long System_Nullable_1_int_Equals_System_Nullable_1_int

LDIFF_SYM743=Lme_6d - System_Nullable_1_int_Equals_System_Nullable_1_int
	.long LDIFF_SYM743
	.byte 68,14,8,135,2,72,14,20,136,5,138,4,139,3,142,1,68,14,48,68,13,11,2,136,10,68,13,13,14,20,68,8
	.byte 8,8,10,8,11,14,8,68,11
	.align 2
Lfde87_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "System.Nullable`1<int>:GetHashCode"
	.asciz "System_Nullable_1_int_GetHashCode"

	.byte 1,134,1
	.long System_Nullable_1_int_GetHashCode
	.long Lme_6e

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM744=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM744
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM745=Lfde88_end - Lfde88_start
	.long LDIFF_SYM745
Lfde88_start:

	.long 0
	.align 2
	.long System_Nullable_1_int_GetHashCode

LDIFF_SYM746=Lme_6e - System_Nullable_1_int_GetHashCode
	.long LDIFF_SYM746
	.byte 68,14,8,135,2,72,14,16,136,4,138,3,142,1,2,32,10,68,14,16,68,8,8,8,10,14,8,68,11
	.align 2
Lfde88_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "System.Nullable`1<int>:GetValueOrDefault"
	.asciz "System_Nullable_1_int_GetValueOrDefault"

	.byte 1,142,1
	.long System_Nullable_1_int_GetValueOrDefault
	.long Lme_6f

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM747=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM747
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM748=Lfde89_end - Lfde89_start
	.long LDIFF_SYM748
Lfde89_start:

	.long 0
	.align 2
	.long System_Nullable_1_int_GetValueOrDefault

LDIFF_SYM749=Lme_6f - System_Nullable_1_int_GetValueOrDefault
	.long LDIFF_SYM749
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,76,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde89_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "System.Nullable`1<int>:GetValueOrDefault"
	.asciz "System_Nullable_1_int_GetValueOrDefault_int"

	.byte 1,147,1
	.long System_Nullable_1_int_GetValueOrDefault_int
	.long Lme_70

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM750=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM750
	.byte 2,125,0,3
	.asciz "defaultValue"

LDIFF_SYM751=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM751
	.byte 2,125,4,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM752=Lfde90_end - Lfde90_start
	.long LDIFF_SYM752
Lfde90_start:

	.long 0
	.align 2
	.long System_Nullable_1_int_GetValueOrDefault_int

LDIFF_SYM753=Lme_70 - System_Nullable_1_int_GetValueOrDefault_int
	.long LDIFF_SYM753
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,2,40,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde90_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "System.Nullable`1<int>:ToString"
	.asciz "System_Nullable_1_int_ToString"

	.byte 1,152,1
	.long System_Nullable_1_int_ToString
	.long Lme_71

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM754=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM754
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM755=Lfde91_end - Lfde91_start
	.long LDIFF_SYM755
Lfde91_start:

	.long 0
	.align 2
	.long System_Nullable_1_int_ToString

LDIFF_SYM756=Lme_71 - System_Nullable_1_int_ToString
	.long LDIFF_SYM756
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,2,52,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde91_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "System.Nullable`1<int>:Box"
	.asciz "System_Nullable_1_int_Box_System_Nullable_1_int"

	.byte 1,177,1
	.long System_Nullable_1_int_Box_System_Nullable_1_int
	.long Lme_72

	.byte 2,118,16,3
	.asciz "o"

LDIFF_SYM757=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM757
	.byte 2,123,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM758=Lfde92_end - Lfde92_start
	.long LDIFF_SYM758
Lfde92_start:

	.long 0
	.align 2
	.long System_Nullable_1_int_Box_System_Nullable_1_int

LDIFF_SYM759=Lme_72 - System_Nullable_1_int_Box_System_Nullable_1_int
	.long LDIFF_SYM759
	.byte 68,14,8,135,2,72,14,16,136,4,139,3,142,1,68,14,48,68,13,11,2,100,10,68,13,13,14,16,68,8,8,8
	.byte 11,14,8,68,11
	.align 2
Lfde92_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "System.Nullable`1<int>:Unbox"
	.asciz "System_Nullable_1_int_Unbox_object"

	.byte 1,185,1
	.long System_Nullable_1_int_Unbox_object
	.long Lme_73

	.byte 2,118,16,3
	.asciz "o"

LDIFF_SYM760=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM760
	.byte 1,86,11
	.asciz "V_0"

LDIFF_SYM761=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM761
	.byte 2,125,4,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM762=Lfde93_end - Lfde93_start
	.long LDIFF_SYM762
Lfde93_start:

	.long 0
	.align 2
	.long System_Nullable_1_int_Unbox_object

LDIFF_SYM763=Lme_73 - System_Nullable_1_int_Unbox_object
	.long LDIFF_SYM763
	.byte 68,14,8,135,2,72,14,16,134,4,136,3,142,1,68,14,56,2,216,10,68,14,16,68,8,6,8,8,14,8,68,11
	.align 2
Lfde93_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_57:

	.byte 5
	.asciz "System_ArraySegment`1"

	.byte 20,16
LDIFF_SYM764=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM764
	.byte 2,35,0,6
	.asciz "_array"

LDIFF_SYM765=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM765
	.byte 2,35,8,6
	.asciz "_offset"

LDIFF_SYM766=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM766
	.byte 2,35,12,6
	.asciz "_count"

LDIFF_SYM767=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM767
	.byte 2,35,16,0,7
	.asciz "System_ArraySegment`1"

LDIFF_SYM768=LTDIE_57 - Ldebug_info_start
	.long LDIFF_SYM768
LTDIE_57_POINTER:

	.byte 13
LDIFF_SYM769=LTDIE_57 - Ldebug_info_start
	.long LDIFF_SYM769
LTDIE_57_REFERENCE:

	.byte 14
LDIFF_SYM770=LTDIE_57 - Ldebug_info_start
	.long LDIFF_SYM770
	.byte 2
	.asciz "System.ArraySegment`1<T_BYTE>:.ctor"
	.asciz "System_ArraySegment_1_T_BYTE__ctor_T_BYTE__"

	.byte 2,39
	.long System_ArraySegment_1_T_BYTE__ctor_T_BYTE__
	.long Lme_74

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM771=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM771
	.byte 1,86,3
	.asciz "array"

LDIFF_SYM772=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM772
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM773=Lfde94_end - Lfde94_start
	.long LDIFF_SYM773
Lfde94_start:

	.long 0
	.align 2
	.long System_ArraySegment_1_T_BYTE__ctor_T_BYTE__

LDIFF_SYM774=Lme_74 - System_ArraySegment_1_T_BYTE__ctor_T_BYTE__
	.long LDIFF_SYM774
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,32,2,72,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde94_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "System.ArraySegment`1<T_BYTE>:.ctor"
	.asciz "System_ArraySegment_1_T_BYTE__ctor_T_BYTE___int_int"

	.byte 2,50
	.long System_ArraySegment_1_T_BYTE__ctor_T_BYTE___int_int
	.long Lme_75

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM775=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM775
	.byte 1,84,3
	.asciz "array"

LDIFF_SYM776=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM776
	.byte 1,85,3
	.asciz "offset"

LDIFF_SYM777=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM777
	.byte 1,86,3
	.asciz "count"

LDIFF_SYM778=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM778
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM779=Lfde95_end - Lfde95_start
	.long LDIFF_SYM779
Lfde95_start:

	.long 0
	.align 2
	.long System_ArraySegment_1_T_BYTE__ctor_T_BYTE___int_int

LDIFF_SYM780=Lme_75 - System_ArraySegment_1_T_BYTE__ctor_T_BYTE___int_int
	.long LDIFF_SYM780
	.byte 68,14,8,135,2,72,14,28,132,7,133,6,134,5,136,4,138,3,142,1,68,14,48,2,104,10,68,14,28,68,8,4
	.byte 8,5,8,6,8,8,8,10,14,8,68,11
	.align 2
Lfde95_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "System.ArraySegment`1<T_BYTE>:get_Array"
	.asciz "System_ArraySegment_1_T_BYTE_get_Array"

	.byte 2,73
	.long System_ArraySegment_1_T_BYTE_get_Array
	.long Lme_76

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM781=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM781
	.byte 2,125,4,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM782=Lfde96_end - Lfde96_start
	.long LDIFF_SYM782
Lfde96_start:

	.long 0
	.align 2
	.long System_ArraySegment_1_T_BYTE_get_Array

LDIFF_SYM783=Lme_76 - System_ArraySegment_1_T_BYTE_get_Array
	.long LDIFF_SYM783
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,80,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde96_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "System.ArraySegment`1<T_BYTE>:get_Offset"
	.asciz "System_ArraySegment_1_T_BYTE_get_Offset"

	.byte 2,92
	.long System_ArraySegment_1_T_BYTE_get_Offset
	.long Lme_77

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM784=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM784
	.byte 2,125,4,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM785=Lfde97_end - Lfde97_start
	.long LDIFF_SYM785
Lfde97_start:

	.long 0
	.align 2
	.long System_ArraySegment_1_T_BYTE_get_Offset

LDIFF_SYM786=Lme_77 - System_ArraySegment_1_T_BYTE_get_Offset
	.long LDIFF_SYM786
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,80,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde97_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "System.ArraySegment`1<T_BYTE>:get_Count"
	.asciz "System_ArraySegment_1_T_BYTE_get_Count"

	.byte 2,111
	.long System_ArraySegment_1_T_BYTE_get_Count
	.long Lme_78

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM787=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM787
	.byte 2,125,4,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM788=Lfde98_end - Lfde98_start
	.long LDIFF_SYM788
Lfde98_start:

	.long 0
	.align 2
	.long System_ArraySegment_1_T_BYTE_get_Count

LDIFF_SYM789=Lme_78 - System_ArraySegment_1_T_BYTE_get_Count
	.long LDIFF_SYM789
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,80,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde98_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "System.ArraySegment`1<T_BYTE>:GetHashCode"
	.asciz "System_ArraySegment_1_T_BYTE_GetHashCode"

	.byte 2,117
	.long System_ArraySegment_1_T_BYTE_GetHashCode
	.long Lme_79

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM790=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM790
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM791=Lfde99_end - Lfde99_start
	.long LDIFF_SYM791
Lfde99_start:

	.long 0
	.align 2
	.long System_ArraySegment_1_T_BYTE_GetHashCode

LDIFF_SYM792=Lme_79 - System_ArraySegment_1_T_BYTE_GetHashCode
	.long LDIFF_SYM792
	.byte 68,14,8,135,2,72,14,16,136,4,138,3,142,1,68,14,24,2,64,10,68,14,16,68,8,8,8,10,14,8,68,11
	.align 2
Lfde99_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "System.ArraySegment`1<T_BYTE>:Equals"
	.asciz "System_ArraySegment_1_T_BYTE_Equals_object"

	.byte 2,124
	.long System_ArraySegment_1_T_BYTE_Equals_object
	.long Lme_7a

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM793=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM793
	.byte 1,86,3
	.asciz "obj"

LDIFF_SYM794=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM794
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM795=Lfde100_end - Lfde100_start
	.long LDIFF_SYM795
Lfde100_start:

	.long 0
	.align 2
	.long System_ArraySegment_1_T_BYTE_Equals_object

LDIFF_SYM796=Lme_7a - System_ArraySegment_1_T_BYTE_Equals_object
	.long LDIFF_SYM796
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,48,2,192,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde100_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "System.ArraySegment`1<T_BYTE>:Equals"
	.asciz "System_ArraySegment_1_T_BYTE_Equals_System_ArraySegment_1_T_BYTE"

	.byte 2,132,1
	.long System_ArraySegment_1_T_BYTE_Equals_System_ArraySegment_1_T_BYTE
	.long Lme_7b

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM797=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM797
	.byte 1,90,3
	.asciz "obj"

LDIFF_SYM798=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM798
	.byte 2,123,40,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM799=Lfde101_end - Lfde101_start
	.long LDIFF_SYM799
Lfde101_start:

	.long 0
	.align 2
	.long System_ArraySegment_1_T_BYTE_Equals_System_ArraySegment_1_T_BYTE

LDIFF_SYM800=Lme_7b - System_ArraySegment_1_T_BYTE_Equals_System_ArraySegment_1_T_BYTE
	.long LDIFF_SYM800
	.byte 68,14,8,135,2,72,14,20,136,5,138,4,139,3,142,1,68,14,80,68,13,11,2,148,10,68,13,13,14,20,68,8
	.byte 8,8,10,8,11,14,8,68,11
	.align 2
Lfde101_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "System.ArraySegment`1<T_BYTE>:System.Collections.Generic.IList<T>.get_Item"
	.asciz "System_ArraySegment_1_T_BYTE_System_Collections_Generic_IList_T_get_Item_int"

	.byte 2,150,1
	.long System_ArraySegment_1_T_BYTE_System_Collections_Generic_IList_T_get_Item_int
	.long Lme_7c

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM801=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM801
	.byte 1,86,3
	.asciz "index"

LDIFF_SYM802=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM802
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM803=Lfde102_end - Lfde102_start
	.long LDIFF_SYM803
Lfde102_start:

	.long 0
	.align 2
	.long System_ArraySegment_1_T_BYTE_System_Collections_Generic_IList_T_get_Item_int

LDIFF_SYM804=Lme_7c - System_ArraySegment_1_T_BYTE_System_Collections_Generic_IList_T_get_Item_int
	.long LDIFF_SYM804
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,32,2,80,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde102_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "System.ArraySegment`1<T_BYTE>:System.Collections.Generic.IList<T>.set_Item"
	.asciz "System_ArraySegment_1_T_BYTE_System_Collections_Generic_IList_T_set_Item_int_T_BYTE"

	.byte 2,161,1
	.long System_ArraySegment_1_T_BYTE_System_Collections_Generic_IList_T_set_Item_int_T_BYTE
	.long Lme_7d

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM805=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM805
	.byte 1,86,3
	.asciz "index"

LDIFF_SYM806=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM806
	.byte 1,90,3
	.asciz "value"

LDIFF_SYM807=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM807
	.byte 2,125,4,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM808=Lfde103_end - Lfde103_start
	.long LDIFF_SYM808
Lfde103_start:

	.long 0
	.align 2
	.long System_ArraySegment_1_T_BYTE_System_Collections_Generic_IList_T_set_Item_int_T_BYTE

LDIFF_SYM809=Lme_7d - System_ArraySegment_1_T_BYTE_System_Collections_Generic_IList_T_set_Item_int_T_BYTE
	.long LDIFF_SYM809
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,32,2,88,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde103_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "System.ArraySegment`1<T_BYTE>:System.Collections.Generic.IList<T>.IndexOf"
	.asciz "System_ArraySegment_1_T_BYTE_System_Collections_Generic_IList_T_IndexOf_T_BYTE"

	.byte 2,173,1
	.long System_ArraySegment_1_T_BYTE_System_Collections_Generic_IList_T_IndexOf_T_BYTE
	.long Lme_7e

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM810=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM810
	.byte 1,90,3
	.asciz "item"

LDIFF_SYM811=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM811
	.byte 2,125,4,11
	.asciz "index"

LDIFF_SYM812=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM812
	.byte 1,86,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM813=Lfde104_end - Lfde104_start
	.long LDIFF_SYM813
Lfde104_start:

	.long 0
	.align 2
	.long System_ArraySegment_1_T_BYTE_System_Collections_Generic_IList_T_IndexOf_T_BYTE

LDIFF_SYM814=Lme_7e - System_ArraySegment_1_T_BYTE_System_Collections_Generic_IList_T_IndexOf_T_BYTE
	.long LDIFF_SYM814
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,48,2,128,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde104_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "System.ArraySegment`1<T_BYTE>:System.Collections.Generic.IList<T>.Insert"
	.asciz "System_ArraySegment_1_T_BYTE_System_Collections_Generic_IList_T_Insert_int_T_BYTE"

	.byte 2,187,1
	.long System_ArraySegment_1_T_BYTE_System_Collections_Generic_IList_T_Insert_int_T_BYTE
	.long Lme_7f

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM815=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM815
	.byte 2,125,4,3
	.asciz "index"

LDIFF_SYM816=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM816
	.byte 0,3
	.asciz "item"

LDIFF_SYM817=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM817
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM818=Lfde105_end - Lfde105_start
	.long LDIFF_SYM818
Lfde105_start:

	.long 0
	.align 2
	.long System_ArraySegment_1_T_BYTE_System_Collections_Generic_IList_T_Insert_int_T_BYTE

LDIFF_SYM819=Lme_7f - System_ArraySegment_1_T_BYTE_System_Collections_Generic_IList_T_Insert_int_T_BYTE
	.long LDIFF_SYM819
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,32,2,32,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde105_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "System.ArraySegment`1<T_BYTE>:System.Collections.Generic.IList<T>.RemoveAt"
	.asciz "System_ArraySegment_1_T_BYTE_System_Collections_Generic_IList_T_RemoveAt_int"

	.byte 2,192,1
	.long System_ArraySegment_1_T_BYTE_System_Collections_Generic_IList_T_RemoveAt_int
	.long Lme_80

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM820=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM820
	.byte 2,125,4,3
	.asciz "index"

LDIFF_SYM821=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM821
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM822=Lfde106_end - Lfde106_start
	.long LDIFF_SYM822
Lfde106_start:

	.long 0
	.align 2
	.long System_ArraySegment_1_T_BYTE_System_Collections_Generic_IList_T_RemoveAt_int

LDIFF_SYM823=Lme_80 - System_ArraySegment_1_T_BYTE_System_Collections_Generic_IList_T_RemoveAt_int
	.long LDIFF_SYM823
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,32,92,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde106_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "System.ArraySegment`1<T_BYTE>:System.Collections.Generic.IReadOnlyList<T>.get_Item"
	.asciz "System_ArraySegment_1_T_BYTE_System_Collections_Generic_IReadOnlyList_T_get_Item_int"

	.byte 2,201,1
	.long System_ArraySegment_1_T_BYTE_System_Collections_Generic_IReadOnlyList_T_get_Item_int
	.long Lme_81

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM824=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM824
	.byte 1,86,3
	.asciz "index"

LDIFF_SYM825=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM825
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM826=Lfde107_end - Lfde107_start
	.long LDIFF_SYM826
Lfde107_start:

	.long 0
	.align 2
	.long System_ArraySegment_1_T_BYTE_System_Collections_Generic_IReadOnlyList_T_get_Item_int

LDIFF_SYM827=Lme_81 - System_ArraySegment_1_T_BYTE_System_Collections_Generic_IReadOnlyList_T_get_Item_int
	.long LDIFF_SYM827
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,32,2,80,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde107_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "System.ArraySegment`1<T_BYTE>:System.Collections.Generic.ICollection<T>.get_IsReadOnly"
	.asciz "System_ArraySegment_1_T_BYTE_System_Collections_Generic_ICollection_T_get_IsReadOnly"

	.byte 2,219,1
	.long System_ArraySegment_1_T_BYTE_System_Collections_Generic_ICollection_T_get_IsReadOnly
	.long Lme_82

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM828=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM828
	.byte 2,125,4,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM829=Lfde108_end - Lfde108_start
	.long LDIFF_SYM829
Lfde108_start:

	.long 0
	.align 2
	.long System_ArraySegment_1_T_BYTE_System_Collections_Generic_ICollection_T_get_IsReadOnly

LDIFF_SYM830=Lme_82 - System_ArraySegment_1_T_BYTE_System_Collections_Generic_ICollection_T_get_IsReadOnly
	.long LDIFF_SYM830
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,76,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde108_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "System.ArraySegment`1<T_BYTE>:System.Collections.Generic.ICollection<T>.Add"
	.asciz "System_ArraySegment_1_T_BYTE_System_Collections_Generic_ICollection_T_Add_T_BYTE"

	.byte 2,225,1
	.long System_ArraySegment_1_T_BYTE_System_Collections_Generic_ICollection_T_Add_T_BYTE
	.long Lme_83

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM831=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM831
	.byte 2,125,4,3
	.asciz "item"

LDIFF_SYM832=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM832
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM833=Lfde109_end - Lfde109_start
	.long LDIFF_SYM833
Lfde109_start:

	.long 0
	.align 2
	.long System_ArraySegment_1_T_BYTE_System_Collections_Generic_ICollection_T_Add_T_BYTE

LDIFF_SYM834=Lme_83 - System_ArraySegment_1_T_BYTE_System_Collections_Generic_ICollection_T_Add_T_BYTE
	.long LDIFF_SYM834
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,32,92,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde109_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "System.ArraySegment`1<T_BYTE>:System.Collections.Generic.ICollection<T>.Clear"
	.asciz "System_ArraySegment_1_T_BYTE_System_Collections_Generic_ICollection_T_Clear"

	.byte 2,230,1
	.long System_ArraySegment_1_T_BYTE_System_Collections_Generic_ICollection_T_Clear
	.long Lme_84

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM835=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM835
	.byte 2,125,4,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM836=Lfde110_end - Lfde110_start
	.long LDIFF_SYM836
Lfde110_start:

	.long 0
	.align 2
	.long System_ArraySegment_1_T_BYTE_System_Collections_Generic_ICollection_T_Clear

LDIFF_SYM837=Lme_84 - System_ArraySegment_1_T_BYTE_System_Collections_Generic_ICollection_T_Clear
	.long LDIFF_SYM837
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,88,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde110_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "System.ArraySegment`1<T_BYTE>:System.Collections.Generic.ICollection<T>.Contains"
	.asciz "System_ArraySegment_1_T_BYTE_System_Collections_Generic_ICollection_T_Contains_T_BYTE"

	.byte 2,235,1
	.long System_ArraySegment_1_T_BYTE_System_Collections_Generic_ICollection_T_Contains_T_BYTE
	.long Lme_85

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM838=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM838
	.byte 1,90,3
	.asciz "item"

LDIFF_SYM839=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM839
	.byte 2,125,4,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM840=Lfde111_end - Lfde111_start
	.long LDIFF_SYM840
Lfde111_start:

	.long 0
	.align 2
	.long System_ArraySegment_1_T_BYTE_System_Collections_Generic_ICollection_T_Contains_T_BYTE

LDIFF_SYM841=Lme_85 - System_ArraySegment_1_T_BYTE_System_Collections_Generic_ICollection_T_Contains_T_BYTE
	.long LDIFF_SYM841
	.byte 68,14,8,135,2,72,14,16,136,4,138,3,142,1,68,14,40,2,124,10,68,14,16,68,8,8,8,10,14,8,68,11
	.align 2
Lfde111_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "System.ArraySegment`1<T_BYTE>:System.Collections.Generic.ICollection<T>.CopyTo"
	.asciz "System_ArraySegment_1_T_BYTE_System_Collections_Generic_ICollection_T_CopyTo_T_BYTE___int"

	.byte 2,249,1
	.long System_ArraySegment_1_T_BYTE_System_Collections_Generic_ICollection_T_CopyTo_T_BYTE___int
	.long Lme_86

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM842=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM842
	.byte 1,85,3
	.asciz "array"

LDIFF_SYM843=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM843
	.byte 2,123,12,3
	.asciz "arrayIndex"

LDIFF_SYM844=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM844
	.byte 2,123,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM845=Lfde112_end - Lfde112_start
	.long LDIFF_SYM845
Lfde112_start:

	.long 0
	.align 2
	.long System_ArraySegment_1_T_BYTE_System_Collections_Generic_ICollection_T_CopyTo_T_BYTE___int

LDIFF_SYM846=Lme_86 - System_ArraySegment_1_T_BYTE_System_Collections_Generic_ICollection_T_CopyTo_T_BYTE___int
	.long LDIFF_SYM846
	.byte 68,14,8,135,2,72,14,20,133,5,136,4,139,3,142,1,68,14,48,68,13,11,2,56,10,68,13,13,14,20,68,8
	.byte 5,8,8,8,11,14,8,68,11
	.align 2
Lfde112_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "System.ArraySegment`1<T_BYTE>:System.Collections.Generic.ICollection<T>.Remove"
	.asciz "System_ArraySegment_1_T_BYTE_System_Collections_Generic_ICollection_T_Remove_T_BYTE"

	.byte 2,130,2
	.long System_ArraySegment_1_T_BYTE_System_Collections_Generic_ICollection_T_Remove_T_BYTE
	.long Lme_87

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM847=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM847
	.byte 2,125,4,3
	.asciz "item"

LDIFF_SYM848=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM848
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM849=Lfde113_end - Lfde113_start
	.long LDIFF_SYM849
Lfde113_start:

	.long 0
	.align 2
	.long System_ArraySegment_1_T_BYTE_System_Collections_Generic_ICollection_T_Remove_T_BYTE

LDIFF_SYM850=Lme_87 - System_ArraySegment_1_T_BYTE_System_Collections_Generic_ICollection_T_Remove_T_BYTE
	.long LDIFF_SYM850
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,32,92,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde113_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "System.ArraySegment`1<T_BYTE>:System.Collections.Generic.IEnumerable<T>.GetEnumerator"
	.asciz "System_ArraySegment_1_T_BYTE_System_Collections_Generic_IEnumerable_T_GetEnumerator"

	.byte 2,137,2
	.long System_ArraySegment_1_T_BYTE_System_Collections_Generic_IEnumerable_T_GetEnumerator
	.long Lme_88

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM851=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM851
	.byte 2,125,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM852=Lfde114_end - Lfde114_start
	.long LDIFF_SYM852
Lfde114_start:

	.long 0
	.align 2
	.long System_ArraySegment_1_T_BYTE_System_Collections_Generic_IEnumerable_T_GetEnumerator

LDIFF_SYM853=Lme_88 - System_ArraySegment_1_T_BYTE_System_Collections_Generic_IEnumerable_T_GetEnumerator
	.long LDIFF_SYM853
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,48,2,112,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde114_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "System.ArraySegment`1<T_BYTE>:System.Collections.IEnumerable.GetEnumerator"
	.asciz "System_ArraySegment_1_T_BYTE_System_Collections_IEnumerable_GetEnumerator"

	.byte 2,148,2
	.long System_ArraySegment_1_T_BYTE_System_Collections_IEnumerable_GetEnumerator
	.long Lme_89

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM854=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM854
	.byte 2,125,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM855=Lfde115_end - Lfde115_start
	.long LDIFF_SYM855
Lfde115_start:

	.long 0
	.align 2
	.long System_ArraySegment_1_T_BYTE_System_Collections_IEnumerable_GetEnumerator

LDIFF_SYM856=Lme_89 - System_ArraySegment_1_T_BYTE_System_Collections_IEnumerable_GetEnumerator
	.long LDIFF_SYM856
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,48,2,112,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde115_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_58:

	.byte 5
	.asciz "System_Nullable`1"

	.byte 24,16
LDIFF_SYM857=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM857
	.byte 2,35,0,6
	.asciz "value"

LDIFF_SYM858=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM858
	.byte 2,35,8,6
	.asciz "has_value"

LDIFF_SYM859=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM859
	.byte 2,35,20,0,7
	.asciz "System_Nullable`1"

LDIFF_SYM860=LTDIE_58 - Ldebug_info_start
	.long LDIFF_SYM860
LTDIE_58_POINTER:

	.byte 13
LDIFF_SYM861=LTDIE_58 - Ldebug_info_start
	.long LDIFF_SYM861
LTDIE_58_REFERENCE:

	.byte 14
LDIFF_SYM862=LTDIE_58 - Ldebug_info_start
	.long LDIFF_SYM862
	.byte 2
	.asciz "System.Nullable`1<PInvoke.Kernel32/SECURITY_ATTRIBUTES>:.ctor"
	.asciz "System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES__ctor_PInvoke_Kernel32_SECURITY_ATTRIBUTES"

	.byte 1,94
	.long System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES__ctor_PInvoke_Kernel32_SECURITY_ATTRIBUTES
	.long Lme_8a

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM863=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM863
	.byte 2,123,0,3
	.asciz "value"

LDIFF_SYM864=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM864
	.byte 2,123,4,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM865=Lfde116_end - Lfde116_start
	.long LDIFF_SYM865
Lfde116_start:

	.long 0
	.align 2
	.long System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES__ctor_PInvoke_Kernel32_SECURITY_ATTRIBUTES

LDIFF_SYM866=Lme_8a - System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES__ctor_PInvoke_Kernel32_SECURITY_ATTRIBUTES
	.long LDIFF_SYM866
	.byte 68,14,8,135,2,72,14,16,136,4,139,3,142,1,68,14,32,68,13,11,2,52,10,68,13,13,14,16,68,8,8,8
	.byte 11,14,8,68,11
	.align 2
Lfde116_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "System.Nullable`1<PInvoke.Kernel32/SECURITY_ATTRIBUTES>:get_HasValue"
	.asciz "System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_get_HasValue"

	.byte 1,99
	.long System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_get_HasValue
	.long Lme_8b

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM867=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM867
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM868=Lfde117_end - Lfde117_start
	.long LDIFF_SYM868
Lfde117_start:

	.long 0
	.align 2
	.long System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_get_HasValue

LDIFF_SYM869=Lme_8b - System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_get_HasValue
	.long LDIFF_SYM869
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,76,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde117_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "System.Nullable`1<PInvoke.Kernel32/SECURITY_ATTRIBUTES>:get_Value"
	.asciz "System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_get_Value"

	.byte 1,104
	.long System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_get_Value
	.long Lme_8c

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM870=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM870
	.byte 2,125,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM871=Lfde118_end - Lfde118_start
	.long LDIFF_SYM871
Lfde118_start:

	.long 0
	.align 2
	.long System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_get_Value

LDIFF_SYM872=Lme_8c - System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_get_Value
	.long LDIFF_SYM872
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,40,2,80,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde118_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "System.Nullable`1<PInvoke.Kernel32/SECURITY_ATTRIBUTES>:Equals"
	.asciz "System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_Equals_object"

	.byte 1,113
	.long System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_Equals_object
	.long Lme_8d

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM873=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM873
	.byte 2,123,24,3
	.asciz "other"

LDIFF_SYM874=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM874
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM875=Lfde119_end - Lfde119_start
	.long LDIFF_SYM875
Lfde119_start:

	.long 0
	.align 2
	.long System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_Equals_object

LDIFF_SYM876=Lme_8d - System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_Equals_object
	.long LDIFF_SYM876
	.byte 68,14,8,135,2,72,14,24,133,6,136,5,138,4,139,3,142,1,68,14,56,68,13,11,2,188,10,68,13,13,14,24
	.byte 68,8,5,8,8,8,10,8,11,14,8,68,11
	.align 2
Lfde119_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "System.Nullable`1<PInvoke.Kernel32/SECURITY_ATTRIBUTES>:Equals"
	.asciz "System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_Equals_System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES"

	.byte 1,123
	.long System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_Equals_System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES
	.long Lme_8e

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM877=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM877
	.byte 1,90,3
	.asciz "other"

LDIFF_SYM878=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM878
	.byte 2,123,40,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM879=Lfde120_end - Lfde120_start
	.long LDIFF_SYM879
Lfde120_start:

	.long 0
	.align 2
	.long System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_Equals_System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES

LDIFF_SYM880=Lme_8e - System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_Equals_System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES
	.long LDIFF_SYM880
	.byte 68,14,8,135,2,72,14,20,136,5,138,4,139,3,142,1,68,14,88,68,13,11,3,44,1,10,68,13,13,14,20,68
	.byte 8,8,8,10,8,11,14,8,68,11
	.align 2
Lfde120_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "System.Nullable`1<PInvoke.Kernel32/SECURITY_ATTRIBUTES>:GetHashCode"
	.asciz "System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_GetHashCode"

	.byte 1,134,1
	.long System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_GetHashCode
	.long Lme_8f

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM881=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM881
	.byte 2,125,12,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM882=Lfde121_end - Lfde121_start
	.long LDIFF_SYM882
Lfde121_start:

	.long 0
	.align 2
	.long System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_GetHashCode

LDIFF_SYM883=Lme_8f - System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_GetHashCode
	.long LDIFF_SYM883
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,32,2,128,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde121_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "System.Nullable`1<PInvoke.Kernel32/SECURITY_ATTRIBUTES>:GetValueOrDefault"
	.asciz "System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_GetValueOrDefault"

	.byte 1,142,1
	.long System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_GetValueOrDefault
	.long Lme_90

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM884=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM884
	.byte 2,125,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM885=Lfde122_end - Lfde122_start
	.long LDIFF_SYM885
Lfde122_start:

	.long 0
	.align 2
	.long System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_GetValueOrDefault

LDIFF_SYM886=Lme_90 - System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_GetValueOrDefault
	.long LDIFF_SYM886
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,40,2,64,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde122_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "System.Nullable`1<PInvoke.Kernel32/SECURITY_ATTRIBUTES>:GetValueOrDefault"
	.asciz "System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_GetValueOrDefault_PInvoke_Kernel32_SECURITY_ATTRIBUTES"

	.byte 1,147,1
	.long System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_GetValueOrDefault_PInvoke_Kernel32_SECURITY_ATTRIBUTES
	.long Lme_91

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM887=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM887
	.byte 2,123,16,3
	.asciz "defaultValue"

LDIFF_SYM888=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM888
	.byte 2,123,20,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM889=Lfde123_end - Lfde123_start
	.long LDIFF_SYM889
Lfde123_start:

	.long 0
	.align 2
	.long System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_GetValueOrDefault_PInvoke_Kernel32_SECURITY_ATTRIBUTES

LDIFF_SYM890=Lme_91 - System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_GetValueOrDefault_PInvoke_Kernel32_SECURITY_ATTRIBUTES
	.long LDIFF_SYM890
	.byte 68,14,8,135,2,72,14,16,136,4,139,3,142,1,68,14,48,68,13,11,2,128,10,68,13,13,14,16,68,8,8,8
	.byte 11,14,8,68,11
	.align 2
Lfde123_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "System.Nullable`1<PInvoke.Kernel32/SECURITY_ATTRIBUTES>:ToString"
	.asciz "System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_ToString"

	.byte 1,152,1
	.long System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_ToString
	.long Lme_92

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM891=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM891
	.byte 2,125,12,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM892=Lfde124_end - Lfde124_start
	.long LDIFF_SYM892
Lfde124_start:

	.long 0
	.align 2
	.long System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_ToString

LDIFF_SYM893=Lme_92 - System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_ToString
	.long LDIFF_SYM893
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,32,2,144,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde124_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "System.Nullable`1<PInvoke.Kernel32/SECURITY_ATTRIBUTES>:Box"
	.asciz "System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_Box_System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES"

	.byte 1,177,1
	.long System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_Box_System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES
	.long Lme_93

	.byte 2,118,16,3
	.asciz "o"

LDIFF_SYM894=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM894
	.byte 2,123,44,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM895=Lfde125_end - Lfde125_start
	.long LDIFF_SYM895
Lfde125_start:

	.long 0
	.align 2
	.long System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_Box_System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES

LDIFF_SYM896=Lme_93 - System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_Box_System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES
	.long LDIFF_SYM896
	.byte 68,14,8,135,2,72,14,16,136,4,139,3,142,1,68,14,80,68,13,11,2,180,10,68,13,13,14,16,68,8,8,8
	.byte 11,14,8,68,11
	.align 2
Lfde125_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "System.Nullable`1<PInvoke.Kernel32/SECURITY_ATTRIBUTES>:Unbox"
	.asciz "System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_Unbox_object"

	.byte 1,185,1
	.long System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_Unbox_object
	.long Lme_94

	.byte 2,118,16,3
	.asciz "o"

LDIFF_SYM897=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM897
	.byte 1,86,11
	.asciz "V_0"

LDIFF_SYM898=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM898
	.byte 2,125,4,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM899=Lfde126_end - Lfde126_start
	.long LDIFF_SYM899
Lfde126_start:

	.long 0
	.align 2
	.long System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_Unbox_object

LDIFF_SYM900=Lme_94 - System_Nullable_1_PInvoke_Kernel32_SECURITY_ATTRIBUTES_Unbox_object
	.long LDIFF_SYM900
	.byte 68,14,8,135,2,72,14,16,134,4,136,3,142,1,68,14,96,3,108,1,10,68,14,16,68,8,6,8,8,14,8,68
	.byte 11
	.align 2
Lfde126_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_runtime-invoke)_<Module>:runtime_invoke_bool_object_intptr_int_Nullable`1<int>__intptr"
	.asciz "wrapper_runtime_invoke__Module_runtime_invoke_bool_object_intptr_int_Nullable_1_int__intptr_object_intptr_intptr_intptr"

	.byte 0,0
	.long wrapper_runtime_invoke__Module_runtime_invoke_bool_object_intptr_int_Nullable_1_int__intptr_object_intptr_intptr_intptr
	.long Lme_97

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM901=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM901
	.byte 0,3
	.asciz "params"

LDIFF_SYM902=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM902
	.byte 1,86,3
	.asciz "exc"

LDIFF_SYM903=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM903
	.byte 3,123,196,0,3
	.asciz "method"

LDIFF_SYM904=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM904
	.byte 3,123,200,0,11
	.asciz "V_0"

LDIFF_SYM905=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM905
	.byte 2,123,8,11
	.asciz "V_1"

LDIFF_SYM906=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM906
	.byte 2,123,12,11
	.asciz "V_2"

LDIFF_SYM907=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM907
	.byte 2,123,16,11
	.asciz "V_3"

LDIFF_SYM908=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM908
	.byte 2,123,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM909=Lfde127_end - Lfde127_start
	.long LDIFF_SYM909
Lfde127_start:

	.long 0
	.align 2
	.long wrapper_runtime_invoke__Module_runtime_invoke_bool_object_intptr_int_Nullable_1_int__intptr_object_intptr_intptr_intptr

LDIFF_SYM910=Lme_97 - wrapper_runtime_invoke__Module_runtime_invoke_bool_object_intptr_int_Nullable_1_int__intptr_object_intptr_intptr_intptr
	.long LDIFF_SYM910
	.byte 68,14,8,135,2,72,14,24,133,6,134,5,136,4,139,3,142,1,68,14,128,1,68,13,11,3,208,2,10,68,13,13
	.byte 14,24,68,8,5,8,6,8,8,8,11,14,8,68,11
	.align 2
Lfde127_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_runtime-invoke)_<Module>:runtime_invoke_bool_object_void__int_Nullable`1<int>__Kernel32/OVERLAPPED_"
	.asciz "wrapper_runtime_invoke__Module_runtime_invoke_bool_object_void__int_Nullable_1_int__Kernel32_OVERLAPPED__object_intptr_intptr_intptr"

	.byte 0,0
	.long wrapper_runtime_invoke__Module_runtime_invoke_bool_object_void__int_Nullable_1_int__Kernel32_OVERLAPPED__object_intptr_intptr_intptr
	.long Lme_98

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM911=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM911
	.byte 0,3
	.asciz "params"

LDIFF_SYM912=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM912
	.byte 1,86,3
	.asciz "exc"

LDIFF_SYM913=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM913
	.byte 3,123,196,0,3
	.asciz "method"

LDIFF_SYM914=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM914
	.byte 3,123,200,0,11
	.asciz "V_0"

LDIFF_SYM915=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM915
	.byte 2,123,8,11
	.asciz "V_1"

LDIFF_SYM916=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM916
	.byte 2,123,12,11
	.asciz "V_2"

LDIFF_SYM917=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM917
	.byte 2,123,16,11
	.asciz "V_3"

LDIFF_SYM918=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM918
	.byte 2,123,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM919=Lfde128_end - Lfde128_start
	.long LDIFF_SYM919
Lfde128_start:

	.long 0
	.align 2
	.long wrapper_runtime_invoke__Module_runtime_invoke_bool_object_void__int_Nullable_1_int__Kernel32_OVERLAPPED__object_intptr_intptr_intptr

LDIFF_SYM920=Lme_98 - wrapper_runtime_invoke__Module_runtime_invoke_bool_object_void__int_Nullable_1_int__Kernel32_OVERLAPPED__object_intptr_intptr_intptr
	.long LDIFF_SYM920
	.byte 68,14,8,135,2,72,14,24,133,6,134,5,136,4,139,3,142,1,68,14,128,1,68,13,11,3,192,2,10,68,13,13
	.byte 14,24,68,8,5,8,6,8,8,8,11,14,8,68,11
	.align 2
Lfde128_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_runtime-invoke)_<Module>:runtime_invoke_object_Nullable`1<Kernel32/SECURITY_ATTRIBUTES>_byte_object"
	.asciz "wrapper_runtime_invoke__Module_runtime_invoke_object_Nullable_1_Kernel32_SECURITY_ATTRIBUTES_byte_object_object_intptr_intptr_intptr"

	.byte 0,0
	.long wrapper_runtime_invoke__Module_runtime_invoke_object_Nullable_1_Kernel32_SECURITY_ATTRIBUTES_byte_object_object_intptr_intptr_intptr
	.long Lme_99

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM921=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM921
	.byte 0,3
	.asciz "params"

LDIFF_SYM922=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM922
	.byte 1,86,3
	.asciz "exc"

LDIFF_SYM923=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM923
	.byte 3,123,196,0,3
	.asciz "method"

LDIFF_SYM924=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM924
	.byte 3,123,200,0,11
	.asciz "V_0"

LDIFF_SYM925=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM925
	.byte 2,123,8,11
	.asciz "V_1"

LDIFF_SYM926=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM926
	.byte 2,123,12,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM927=Lfde129_end - Lfde129_start
	.long LDIFF_SYM927
Lfde129_start:

	.long 0
	.align 2
	.long wrapper_runtime_invoke__Module_runtime_invoke_object_Nullable_1_Kernel32_SECURITY_ATTRIBUTES_byte_object_object_intptr_intptr_intptr

LDIFF_SYM928=Lme_99 - wrapper_runtime_invoke__Module_runtime_invoke_object_Nullable_1_Kernel32_SECURITY_ATTRIBUTES_byte_object_object_intptr_intptr_intptr
	.long LDIFF_SYM928
	.byte 68,14,8,135,2,72,14,24,133,6,134,5,136,4,139,3,142,1,68,14,112,68,13,11,3,124,1,10,68,13,13,14
	.byte 24,68,8,5,8,6,8,8,8,11,14,8,68,11
	.align 2
Lfde129_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_PInvoke.Kernel32:FindFirstFileEx"
	.asciz "wrapper_managed_to_native_PInvoke_Kernel32_FindFirstFileEx_string_PInvoke_Kernel32_FINDEX_INFO_LEVELS_PInvoke_Kernel32_WIN32_FIND_DATA__PInvoke_Kernel32_FINDEX_SEARCH_OPS_void__PInvoke_Kernel32_FindFirstFileExFlags"

	.byte 0,0
	.long wrapper_managed_to_native_PInvoke_Kernel32_FindFirstFileEx_string_PInvoke_Kernel32_FINDEX_INFO_LEVELS_PInvoke_Kernel32_WIN32_FIND_DATA__PInvoke_Kernel32_FINDEX_SEARCH_OPS_void__PInvoke_Kernel32_FindFirstFileExFlags
	.long Lme_9a

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM929=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM929
	.byte 2,123,48,3
	.asciz "param1"

LDIFF_SYM930=LTDIE_12 - Ldebug_info_start
	.long LDIFF_SYM930
	.byte 2,123,52,3
	.asciz "param2"

LDIFF_SYM931=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM931
	.byte 2,123,56,3
	.asciz "param3"

LDIFF_SYM932=LTDIE_16 - Ldebug_info_start
	.long LDIFF_SYM932
	.byte 2,123,60,3
	.asciz "param4"

LDIFF_SYM933=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM933
	.byte 3,123,192,0,3
	.asciz "param5"

LDIFF_SYM934=LTDIE_17 - Ldebug_info_start
	.long LDIFF_SYM934
	.byte 3,123,196,0,11
	.asciz "V_0"

LDIFF_SYM935=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM935
	.byte 1,90,11
	.asciz "V_1"

LDIFF_SYM936=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM936
	.byte 1,84,11
	.asciz "V_2"

LDIFF_SYM937=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM937
	.byte 0,11
	.asciz "V_3"

LDIFF_SYM938=LTDIE_26_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM938
	.byte 1,85,11
	.asciz "V_4"

LDIFF_SYM939=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM939
	.byte 0,11
	.asciz "V_5"

LDIFF_SYM940=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM940
	.byte 1,86,11
	.asciz "V_6"

LDIFF_SYM941=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM941
	.byte 0,11
	.asciz "V_7"

LDIFF_SYM942=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM942
	.byte 2,123,8,11
	.asciz "V_8"

LDIFF_SYM943=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM943
	.byte 2,123,12,11
	.asciz "V_9"

LDIFF_SYM944=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM944
	.byte 2,123,16,11
	.asciz "V_10"

LDIFF_SYM945=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM945
	.byte 2,123,20,11
	.asciz "V_11"

LDIFF_SYM946=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM946
	.byte 2,123,24,11
	.asciz "V_12"

LDIFF_SYM947=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM947
	.byte 2,123,28,11
	.asciz "V_13"

LDIFF_SYM948=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM948
	.byte 2,123,32,11
	.asciz "V_14"

LDIFF_SYM949=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM949
	.byte 2,123,36,11
	.asciz "V_15"

LDIFF_SYM950=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM950
	.byte 2,123,40,11
	.asciz "V_16"

LDIFF_SYM951=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM951
	.byte 2,123,44,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM952=Lfde130_end - Lfde130_start
	.long LDIFF_SYM952
Lfde130_start:

	.long 0
	.align 2
	.long wrapper_managed_to_native_PInvoke_Kernel32_FindFirstFileEx_string_PInvoke_Kernel32_FINDEX_INFO_LEVELS_PInvoke_Kernel32_WIN32_FIND_DATA__PInvoke_Kernel32_FINDEX_SEARCH_OPS_void__PInvoke_Kernel32_FindFirstFileExFlags

LDIFF_SYM953=Lme_9a - wrapper_managed_to_native_PInvoke_Kernel32_FindFirstFileEx_string_PInvoke_Kernel32_FINDEX_INFO_LEVELS_PInvoke_Kernel32_WIN32_FIND_DATA__PInvoke_Kernel32_FINDEX_SEARCH_OPS_void__PInvoke_Kernel32_FindFirstFileExFlags
	.long LDIFF_SYM953
	.byte 68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,168,2,68,13
	.byte 11,3,100,2,10,84,12,13,48,68,8,4,8,5,8,6,8,7,8,8,8,9,8,10,8,11,8,12,14,12,68,14
	.byte 8,68,11
	.align 2
Lfde130_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_PInvoke.Kernel32:FormatMessage"
	.asciz "wrapper_managed_to_native_PInvoke_Kernel32_FormatMessage_PInvoke_Kernel32_FormatMessageFlags_void__int_int_System_Text_StringBuilder_int_intptr__"

	.byte 0,0
	.long wrapper_managed_to_native_PInvoke_Kernel32_FormatMessage_PInvoke_Kernel32_FormatMessageFlags_void__int_int_System_Text_StringBuilder_int_intptr__
	.long Lme_9b

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM954=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM954
	.byte 2,123,24,3
	.asciz "param1"

LDIFF_SYM955=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM955
	.byte 2,123,28,3
	.asciz "param2"

LDIFF_SYM956=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM956
	.byte 2,123,32,3
	.asciz "param3"

LDIFF_SYM957=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM957
	.byte 2,123,36,3
	.asciz "param4"

LDIFF_SYM958=LTDIE_5_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM958
	.byte 2,123,40,3
	.asciz "param5"

LDIFF_SYM959=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM959
	.byte 2,123,44,3
	.asciz "param6"

LDIFF_SYM960=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM960
	.byte 2,123,48,11
	.asciz "V_0"

LDIFF_SYM961=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM961
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM962=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM962
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM963=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM963
	.byte 0,11
	.asciz "V_3"

LDIFF_SYM964=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM964
	.byte 2,123,16,11
	.asciz "V_4"

LDIFF_SYM965=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM965
	.byte 1,90,11
	.asciz "V_5"

LDIFF_SYM966=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM966
	.byte 1,85,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM967=Lfde131_end - Lfde131_start
	.long LDIFF_SYM967
Lfde131_start:

	.long 0
	.align 2
	.long wrapper_managed_to_native_PInvoke_Kernel32_FormatMessage_PInvoke_Kernel32_FormatMessageFlags_void__int_int_System_Text_StringBuilder_int_intptr__

LDIFF_SYM968=Lme_9b - wrapper_managed_to_native_PInvoke_Kernel32_FormatMessage_PInvoke_Kernel32_FormatMessageFlags_void__int_int_System_Text_StringBuilder_int_intptr__
	.long LDIFF_SYM968
	.byte 68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,152,2,68,13
	.byte 11,2,216,10,84,12,13,44,68,8,5,8,6,8,7,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11
	.align 2
Lfde131_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_PInvoke.Kernel32:GetCurrentThreadId"
	.asciz "wrapper_managed_to_native_PInvoke_Kernel32_GetCurrentThreadId"

	.byte 0,0
	.long wrapper_managed_to_native_PInvoke_Kernel32_GetCurrentThreadId
	.long Lme_9c

	.byte 2,118,16,11
	.asciz "V_0"

LDIFF_SYM969=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM969
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM970=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM970
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM971=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM971
	.byte 0,11
	.asciz "V_3"

LDIFF_SYM972=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM972
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM973=Lfde132_end - Lfde132_start
	.long LDIFF_SYM973
Lfde132_start:

	.long 0
	.align 2
	.long wrapper_managed_to_native_PInvoke_Kernel32_GetCurrentThreadId

LDIFF_SYM974=Lme_9c - wrapper_managed_to_native_PInvoke_Kernel32_GetCurrentThreadId
	.long LDIFF_SYM974
	.byte 68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,224,1,2,84
	.byte 10,80,12,13,32,68,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11
	.align 2
Lfde132_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_PInvoke.Kernel32:GetCurrentProcessId"
	.asciz "wrapper_managed_to_native_PInvoke_Kernel32_GetCurrentProcessId"

	.byte 0,0
	.long wrapper_managed_to_native_PInvoke_Kernel32_GetCurrentProcessId
	.long Lme_9d

	.byte 2,118,16,11
	.asciz "V_0"

LDIFF_SYM975=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM975
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM976=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM976
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM977=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM977
	.byte 0,11
	.asciz "V_3"

LDIFF_SYM978=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM978
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM979=Lfde133_end - Lfde133_start
	.long LDIFF_SYM979
Lfde133_start:

	.long 0
	.align 2
	.long wrapper_managed_to_native_PInvoke_Kernel32_GetCurrentProcessId

LDIFF_SYM980=Lme_9d - wrapper_managed_to_native_PInvoke_Kernel32_GetCurrentProcessId
	.long LDIFF_SYM980
	.byte 68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,224,1,2,84
	.byte 10,80,12,13,32,68,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11
	.align 2
Lfde133_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_PInvoke.Kernel32:GetCurrentProcess"
	.asciz "wrapper_managed_to_native_PInvoke_Kernel32_GetCurrentProcess"

	.byte 0,0
	.long wrapper_managed_to_native_PInvoke_Kernel32_GetCurrentProcess
	.long Lme_9e

	.byte 2,118,16,11
	.asciz "V_0"

LDIFF_SYM981=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM981
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM982=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM982
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM983=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM983
	.byte 0,11
	.asciz "V_3"

LDIFF_SYM984=LTDIE_6_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM984
	.byte 1,90,11
	.asciz "V_4"

LDIFF_SYM985=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM985
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM986=Lfde134_end - Lfde134_start
	.long LDIFF_SYM986
Lfde134_start:

	.long 0
	.align 2
	.long wrapper_managed_to_native_PInvoke_Kernel32_GetCurrentProcess

LDIFF_SYM987=Lme_9e - wrapper_managed_to_native_PInvoke_Kernel32_GetCurrentProcess
	.long LDIFF_SYM987
	.byte 68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,232,1,2,132
	.byte 10,80,12,13,32,68,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11
	.align 2
Lfde134_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_PInvoke.Kernel32:CancelIoEx"
	.asciz "wrapper_managed_to_native_PInvoke_Kernel32_CancelIoEx_PInvoke_Kernel32_SafeObjectHandle_PInvoke_Kernel32_OVERLAPPED_"

	.byte 0,0
	.long wrapper_managed_to_native_PInvoke_Kernel32_CancelIoEx_PInvoke_Kernel32_SafeObjectHandle_PInvoke_Kernel32_OVERLAPPED_
	.long Lme_9f

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM988=LTDIE_6_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM988
	.byte 1,86,3
	.asciz "param1"

LDIFF_SYM989=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM989
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM990=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM990
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM991=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM991
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM992=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM992
	.byte 0,11
	.asciz "V_3"

LDIFF_SYM993=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM993
	.byte 2,125,0,11
	.asciz "V_4"

LDIFF_SYM994=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM994
	.byte 2,125,4,11
	.asciz "V_5"

LDIFF_SYM995=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM995
	.byte 2,125,8,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM996=Lfde135_end - Lfde135_start
	.long LDIFF_SYM996
Lfde135_start:

	.long 0
	.align 2
	.long wrapper_managed_to_native_PInvoke_Kernel32_CancelIoEx_PInvoke_Kernel32_SafeObjectHandle_PInvoke_Kernel32_OVERLAPPED_

LDIFF_SYM997=Lme_9f - wrapper_managed_to_native_PInvoke_Kernel32_CancelIoEx_PInvoke_Kernel32_SafeObjectHandle_PInvoke_Kernel32_OVERLAPPED_
	.long LDIFF_SYM997
	.byte 68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,240,1,2,176
	.byte 10,80,12,13,40,68,8,6,8,7,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11
	.align 2
Lfde135_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_PInvoke.Kernel32:ReadFile"
	.asciz "wrapper_managed_to_native_PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_void__int_int__PInvoke_Kernel32_OVERLAPPED_"

	.byte 0,0
	.long wrapper_managed_to_native_PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_void__int_int__PInvoke_Kernel32_OVERLAPPED_
	.long Lme_a0

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM998=LTDIE_6_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM998
	.byte 1,90,3
	.asciz "param1"

LDIFF_SYM999=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM999
	.byte 2,123,24,3
	.asciz "param2"

LDIFF_SYM1000=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1000
	.byte 2,123,28,3
	.asciz "param3"

LDIFF_SYM1001=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1001
	.byte 2,123,32,3
	.asciz "param4"

LDIFF_SYM1002=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1002
	.byte 2,123,36,11
	.asciz "V_0"

LDIFF_SYM1003=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1003
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM1004=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1004
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM1005=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1005
	.byte 0,11
	.asciz "V_3"

LDIFF_SYM1006=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM1006
	.byte 2,123,8,11
	.asciz "V_4"

LDIFF_SYM1007=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1007
	.byte 2,123,12,11
	.asciz "V_5"

LDIFF_SYM1008=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM1008
	.byte 2,123,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1009=Lfde136_end - Lfde136_start
	.long LDIFF_SYM1009
Lfde136_start:

	.long 0
	.align 2
	.long wrapper_managed_to_native_PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_void__int_int__PInvoke_Kernel32_OVERLAPPED_

LDIFF_SYM1010=Lme_a0 - wrapper_managed_to_native_PInvoke_Kernel32_ReadFile_PInvoke_Kernel32_SafeObjectHandle_void__int_int__PInvoke_Kernel32_OVERLAPPED_
	.long LDIFF_SYM1010
	.byte 68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,136,2,68,13
	.byte 11,2,208,10,84,12,13,32,68,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11
	.align 2
Lfde136_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_PInvoke.Kernel32:WriteFile"
	.asciz "wrapper_managed_to_native_PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_void__int_int__PInvoke_Kernel32_OVERLAPPED_"

	.byte 0,0
	.long wrapper_managed_to_native_PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_void__int_int__PInvoke_Kernel32_OVERLAPPED_
	.long Lme_a1

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1011=LTDIE_6_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1011
	.byte 1,90,3
	.asciz "param1"

LDIFF_SYM1012=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1012
	.byte 2,123,24,3
	.asciz "param2"

LDIFF_SYM1013=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1013
	.byte 2,123,28,3
	.asciz "param3"

LDIFF_SYM1014=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1014
	.byte 2,123,32,3
	.asciz "param4"

LDIFF_SYM1015=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1015
	.byte 2,123,36,11
	.asciz "V_0"

LDIFF_SYM1016=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1016
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM1017=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1017
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM1018=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1018
	.byte 0,11
	.asciz "V_3"

LDIFF_SYM1019=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM1019
	.byte 2,123,8,11
	.asciz "V_4"

LDIFF_SYM1020=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1020
	.byte 2,123,12,11
	.asciz "V_5"

LDIFF_SYM1021=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM1021
	.byte 2,123,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1022=Lfde137_end - Lfde137_start
	.long LDIFF_SYM1022
Lfde137_start:

	.long 0
	.align 2
	.long wrapper_managed_to_native_PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_void__int_int__PInvoke_Kernel32_OVERLAPPED_

LDIFF_SYM1023=Lme_a1 - wrapper_managed_to_native_PInvoke_Kernel32_WriteFile_PInvoke_Kernel32_SafeObjectHandle_void__int_int__PInvoke_Kernel32_OVERLAPPED_
	.long LDIFF_SYM1023
	.byte 68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,136,2,68,13
	.byte 11,2,208,10,84,12,13,32,68,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11
	.align 2
Lfde137_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_PInvoke.Kernel32:SuspendThread"
	.asciz "wrapper_managed_to_native_PInvoke_Kernel32_SuspendThread_PInvoke_Kernel32_SafeObjectHandle"

	.byte 0,0
	.long wrapper_managed_to_native_PInvoke_Kernel32_SuspendThread_PInvoke_Kernel32_SafeObjectHandle
	.long Lme_a2

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1024=LTDIE_6_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1024
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM1025=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1025
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM1026=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1026
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM1027=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1027
	.byte 0,11
	.asciz "V_3"

LDIFF_SYM1028=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1028
	.byte 2,125,0,11
	.asciz "V_4"

LDIFF_SYM1029=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1029
	.byte 1,85,11
	.asciz "V_5"

LDIFF_SYM1030=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM1030
	.byte 2,125,4,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1031=Lfde138_end - Lfde138_start
	.long LDIFF_SYM1031
Lfde138_start:

	.long 0
	.align 2
	.long wrapper_managed_to_native_PInvoke_Kernel32_SuspendThread_PInvoke_Kernel32_SafeObjectHandle

LDIFF_SYM1032=Lme_a2 - wrapper_managed_to_native_PInvoke_Kernel32_SuspendThread_PInvoke_Kernel32_SafeObjectHandle
	.long LDIFF_SYM1032
	.byte 68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,232,1,2,168
	.byte 10,80,12,13,44,68,8,5,8,6,8,7,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11
	.align 2
Lfde138_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_PInvoke.Kernel32:ResumeThread"
	.asciz "wrapper_managed_to_native_PInvoke_Kernel32_ResumeThread_PInvoke_Kernel32_SafeObjectHandle"

	.byte 0,0
	.long wrapper_managed_to_native_PInvoke_Kernel32_ResumeThread_PInvoke_Kernel32_SafeObjectHandle
	.long Lme_a3

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1033=LTDIE_6_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1033
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM1034=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1034
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM1035=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1035
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM1036=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1036
	.byte 0,11
	.asciz "V_3"

LDIFF_SYM1037=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1037
	.byte 2,125,0,11
	.asciz "V_4"

LDIFF_SYM1038=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1038
	.byte 1,85,11
	.asciz "V_5"

LDIFF_SYM1039=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM1039
	.byte 2,125,4,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1040=Lfde139_end - Lfde139_start
	.long LDIFF_SYM1040
Lfde139_start:

	.long 0
	.align 2
	.long wrapper_managed_to_native_PInvoke_Kernel32_ResumeThread_PInvoke_Kernel32_SafeObjectHandle

LDIFF_SYM1041=Lme_a3 - wrapper_managed_to_native_PInvoke_Kernel32_ResumeThread_PInvoke_Kernel32_SafeObjectHandle
	.long LDIFF_SYM1041
	.byte 68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,232,1,2,168
	.byte 10,80,12,13,44,68,8,5,8,6,8,7,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11
	.align 2
Lfde139_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_59:

	.byte 8
	.asciz "_WaitForSingleObjectResult"

	.byte 4
LDIFF_SYM1042=LDIE_U4 - Ldebug_info_start
	.long LDIFF_SYM1042
	.byte 9
	.asciz "WAIT_ABANDONED"

	.byte 128,1,9
	.asciz "WAIT_OBJECT_0"

	.byte 0,9
	.asciz "WAIT_TIMEOUT"

	.byte 130,2,9
	.asciz "WAIT_FAILED"

	.byte 255,255,255,255,15,0,7
	.asciz "_WaitForSingleObjectResult"

LDIFF_SYM1043=LTDIE_59 - Ldebug_info_start
	.long LDIFF_SYM1043
LTDIE_59_POINTER:

	.byte 13
LDIFF_SYM1044=LTDIE_59 - Ldebug_info_start
	.long LDIFF_SYM1044
LTDIE_59_REFERENCE:

	.byte 14
LDIFF_SYM1045=LTDIE_59 - Ldebug_info_start
	.long LDIFF_SYM1045
	.byte 2
	.asciz "(wrapper_managed-to-native)_PInvoke.Kernel32:WaitForSingleObject"
	.asciz "wrapper_managed_to_native_PInvoke_Kernel32_WaitForSingleObject_System_Runtime_InteropServices_SafeHandle_int"

	.byte 0,0
	.long wrapper_managed_to_native_PInvoke_Kernel32_WaitForSingleObject_System_Runtime_InteropServices_SafeHandle_int
	.long Lme_a4

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1046=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1046
	.byte 1,86,3
	.asciz "param1"

LDIFF_SYM1047=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1047
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM1048=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1048
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM1049=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1049
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM1050=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1050
	.byte 0,11
	.asciz "V_3"

LDIFF_SYM1051=LTDIE_59 - Ldebug_info_start
	.long LDIFF_SYM1051
	.byte 2,125,0,11
	.asciz "V_4"

LDIFF_SYM1052=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1052
	.byte 2,125,4,11
	.asciz "V_5"

LDIFF_SYM1053=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM1053
	.byte 2,125,8,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1054=Lfde140_end - Lfde140_start
	.long LDIFF_SYM1054
Lfde140_start:

	.long 0
	.align 2
	.long wrapper_managed_to_native_PInvoke_Kernel32_WaitForSingleObject_System_Runtime_InteropServices_SafeHandle_int

LDIFF_SYM1055=Lme_a4 - wrapper_managed_to_native_PInvoke_Kernel32_WaitForSingleObject_System_Runtime_InteropServices_SafeHandle_int
	.long LDIFF_SYM1055
	.byte 68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,240,1,2,176
	.byte 10,80,12,13,40,68,8,6,8,7,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11
	.align 2
Lfde140_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_PInvoke.Kernel32:CloseHandle"
	.asciz "wrapper_managed_to_native_PInvoke_Kernel32_CloseHandle_intptr"

	.byte 0,0
	.long wrapper_managed_to_native_PInvoke_Kernel32_CloseHandle_intptr
	.long Lme_a5

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1056=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1056
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM1057=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1057
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM1058=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1058
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM1059=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1059
	.byte 0,11
	.asciz "V_3"

LDIFF_SYM1060=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM1060
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1061=Lfde141_end - Lfde141_start
	.long LDIFF_SYM1061
Lfde141_start:

	.long 0
	.align 2
	.long wrapper_managed_to_native_PInvoke_Kernel32_CloseHandle_intptr

LDIFF_SYM1062=Lme_a5 - wrapper_managed_to_native_PInvoke_Kernel32_CloseHandle_intptr
	.long LDIFF_SYM1062
	.byte 68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,232,1,2,104
	.byte 10,80,12,13,32,68,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11
	.align 2
Lfde141_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_PInvoke.Kernel32:FlushFileBuffers"
	.asciz "wrapper_managed_to_native_PInvoke_Kernel32_FlushFileBuffers_PInvoke_Kernel32_SafeObjectHandle"

	.byte 0,0
	.long wrapper_managed_to_native_PInvoke_Kernel32_FlushFileBuffers_PInvoke_Kernel32_SafeObjectHandle
	.long Lme_a6

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1063=LTDIE_6_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1063
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM1064=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1064
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM1065=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1065
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM1066=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1066
	.byte 0,11
	.asciz "V_3"

LDIFF_SYM1067=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM1067
	.byte 2,125,0,11
	.asciz "V_4"

LDIFF_SYM1068=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1068
	.byte 1,86,11
	.asciz "V_5"

LDIFF_SYM1069=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM1069
	.byte 2,125,1,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1070=Lfde142_end - Lfde142_start
	.long LDIFF_SYM1070
Lfde142_start:

	.long 0
	.align 2
	.long wrapper_managed_to_native_PInvoke_Kernel32_FlushFileBuffers_PInvoke_Kernel32_SafeObjectHandle

LDIFF_SYM1071=Lme_a6 - wrapper_managed_to_native_PInvoke_Kernel32_FlushFileBuffers_PInvoke_Kernel32_SafeObjectHandle
	.long LDIFF_SYM1071
	.byte 68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,232,1,2,168
	.byte 10,80,12,13,40,68,8,6,8,7,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11
	.align 2
Lfde142_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_PInvoke.Kernel32:CreateMutex"
	.asciz "wrapper_managed_to_native_PInvoke_Kernel32_CreateMutex_PInvoke_Kernel32_SECURITY_ATTRIBUTES__bool_string"

	.byte 0,0
	.long wrapper_managed_to_native_PInvoke_Kernel32_CreateMutex_PInvoke_Kernel32_SECURITY_ATTRIBUTES__bool_string
	.long Lme_a7

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1072=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1072
	.byte 2,125,4,3
	.asciz "param1"

LDIFF_SYM1073=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM1073
	.byte 2,125,8,3
	.asciz "param2"

LDIFF_SYM1074=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM1074
	.byte 2,125,12,11
	.asciz "V_0"

LDIFF_SYM1075=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1075
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM1076=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1076
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM1077=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1077
	.byte 0,11
	.asciz "V_3"

LDIFF_SYM1078=LTDIE_6_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1078
	.byte 1,85,11
	.asciz "V_4"

LDIFF_SYM1079=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1079
	.byte 1,84,11
	.asciz "V_5"

LDIFF_SYM1080=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1080
	.byte 1,91,11
	.asciz "V_6"

LDIFF_SYM1081=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1081
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1082=Lfde143_end - Lfde143_start
	.long LDIFF_SYM1082
Lfde143_start:

	.long 0
	.align 2
	.long wrapper_managed_to_native_PInvoke_Kernel32_CreateMutex_PInvoke_Kernel32_SECURITY_ATTRIBUTES__bool_string

LDIFF_SYM1083=Lme_a7 - wrapper_managed_to_native_PInvoke_Kernel32_CreateMutex_PInvoke_Kernel32_SECURITY_ATTRIBUTES__bool_string
	.long LDIFF_SYM1083
	.byte 68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,240,1,2,200
	.byte 10,80,12,13,48,68,8,4,8,5,8,6,8,7,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11
	.align 2
Lfde143_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_PInvoke.Kernel32:GetProcAddress"
	.asciz "wrapper_managed_to_native_PInvoke_Kernel32_GetProcAddress_PInvoke_Kernel32_SafeLibraryHandle_string"

	.byte 0,0
	.long wrapper_managed_to_native_PInvoke_Kernel32_GetProcAddress_PInvoke_Kernel32_SafeLibraryHandle_string
	.long Lme_a8

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1084=LTDIE_27_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1084
	.byte 1,86,3
	.asciz "param1"

LDIFF_SYM1085=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM1085
	.byte 2,125,8,11
	.asciz "V_0"

LDIFF_SYM1086=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1086
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM1087=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1087
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM1088=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1088
	.byte 0,11
	.asciz "V_3"

LDIFF_SYM1089=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1089
	.byte 2,125,0,11
	.asciz "V_4"

LDIFF_SYM1090=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1090
	.byte 1,84,11
	.asciz "V_5"

LDIFF_SYM1091=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM1091
	.byte 2,125,4,11
	.asciz "V_6"

LDIFF_SYM1092=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1092
	.byte 1,91,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1093=Lfde144_end - Lfde144_start
	.long LDIFF_SYM1093
Lfde144_start:

	.long 0
	.align 2
	.long wrapper_managed_to_native_PInvoke_Kernel32_GetProcAddress_PInvoke_Kernel32_SafeLibraryHandle_string

LDIFF_SYM1094=Lme_a8 - wrapper_managed_to_native_PInvoke_Kernel32_GetProcAddress_PInvoke_Kernel32_SafeLibraryHandle_string
	.long LDIFF_SYM1094
	.byte 68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,240,1,2,196
	.byte 10,80,12,13,48,68,8,4,8,5,8,6,8,7,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11
	.align 2
Lfde144_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_PInvoke.Kernel32:GetTickCount"
	.asciz "wrapper_managed_to_native_PInvoke_Kernel32_GetTickCount"

	.byte 0,0
	.long wrapper_managed_to_native_PInvoke_Kernel32_GetTickCount
	.long Lme_a9

	.byte 2,118,16,11
	.asciz "V_0"

LDIFF_SYM1095=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1095
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM1096=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1096
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM1097=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1097
	.byte 0,11
	.asciz "V_3"

LDIFF_SYM1098=LDIE_U4 - Ldebug_info_start
	.long LDIFF_SYM1098
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1099=Lfde145_end - Lfde145_start
	.long LDIFF_SYM1099
Lfde145_start:

	.long 0
	.align 2
	.long wrapper_managed_to_native_PInvoke_Kernel32_GetTickCount

LDIFF_SYM1100=Lme_a9 - wrapper_managed_to_native_PInvoke_Kernel32_GetTickCount
	.long LDIFF_SYM1100
	.byte 68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,224,1,2,84
	.byte 10,80,12,13,32,68,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11
	.align 2
Lfde145_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_60:

	.byte 5
	.asciz "System_UInt64"

	.byte 16,16
LDIFF_SYM1101=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM1101
	.byte 2,35,0,6
	.asciz "m_value"

LDIFF_SYM1102=LDIE_U8 - Ldebug_info_start
	.long LDIFF_SYM1102
	.byte 2,35,8,0,7
	.asciz "System_UInt64"

LDIFF_SYM1103=LTDIE_60 - Ldebug_info_start
	.long LDIFF_SYM1103
LTDIE_60_POINTER:

	.byte 13
LDIFF_SYM1104=LTDIE_60 - Ldebug_info_start
	.long LDIFF_SYM1104
LTDIE_60_REFERENCE:

	.byte 14
LDIFF_SYM1105=LTDIE_60 - Ldebug_info_start
	.long LDIFF_SYM1105
	.byte 2
	.asciz "(wrapper_managed-to-native)_PInvoke.Kernel32:GetTickCount64"
	.asciz "wrapper_managed_to_native_PInvoke_Kernel32_GetTickCount64"

	.byte 0,0
	.long wrapper_managed_to_native_PInvoke_Kernel32_GetTickCount64
	.long Lme_aa

	.byte 2,118,16,11
	.asciz "V_0"

LDIFF_SYM1106=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1106
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM1107=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1107
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM1108=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1108
	.byte 0,11
	.asciz "V_3"

LDIFF_SYM1109=LDIE_U8 - Ldebug_info_start
	.long LDIFF_SYM1109
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1110=Lfde146_end - Lfde146_start
	.long LDIFF_SYM1110
Lfde146_start:

	.long 0
	.align 2
	.long wrapper_managed_to_native_PInvoke_Kernel32_GetTickCount64

LDIFF_SYM1111=Lme_aa - wrapper_managed_to_native_PInvoke_Kernel32_GetTickCount64
	.long LDIFF_SYM1111
	.byte 68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,240,1,2,104
	.byte 10,80,12,13,32,68,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11
	.align 2
Lfde146_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_PInvoke.Kernel32:GetSystemTime"
	.asciz "wrapper_managed_to_native_PInvoke_Kernel32_GetSystemTime_PInvoke_Kernel32_SYSTEMTIME_"

	.byte 0,0
	.long wrapper_managed_to_native_PInvoke_Kernel32_GetSystemTime_PInvoke_Kernel32_SYSTEMTIME_
	.long Lme_ab

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1112=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1112
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM1113=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1113
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM1114=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1114
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM1115=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1115
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1116=Lfde147_end - Lfde147_start
	.long LDIFF_SYM1116
Lfde147_start:

	.long 0
	.align 2
	.long wrapper_managed_to_native_PInvoke_Kernel32_GetSystemTime_PInvoke_Kernel32_SYSTEMTIME_

LDIFF_SYM1117=Lme_ab - wrapper_managed_to_native_PInvoke_Kernel32_GetSystemTime_PInvoke_Kernel32_SYSTEMTIME_
	.long LDIFF_SYM1117
	.byte 68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,216,1,2,84
	.byte 10,80,12,13,32,68,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11
	.align 2
Lfde147_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_PInvoke.Kernel32:SetLastError"
	.asciz "wrapper_managed_to_native_PInvoke_Kernel32_SetLastError_uint"

	.byte 0,0
	.long wrapper_managed_to_native_PInvoke_Kernel32_SetLastError_uint
	.long Lme_ac

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1118=LDIE_U4 - Ldebug_info_start
	.long LDIFF_SYM1118
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM1119=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1119
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM1120=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1120
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM1121=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1121
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1122=Lfde148_end - Lfde148_start
	.long LDIFF_SYM1122
Lfde148_start:

	.long 0
	.align 2
	.long wrapper_managed_to_native_PInvoke_Kernel32_SetLastError_uint

LDIFF_SYM1123=Lme_ac - wrapper_managed_to_native_PInvoke_Kernel32_SetLastError_uint
	.long LDIFF_SYM1123
	.byte 68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,216,1,2,88
	.byte 10,80,12,13,32,68,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11
	.align 2
Lfde148_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_PInvoke.Kernel32:FindClose"
	.asciz "wrapper_managed_to_native_PInvoke_Kernel32_FindClose_intptr"

	.byte 0,0
	.long wrapper_managed_to_native_PInvoke_Kernel32_FindClose_intptr
	.long Lme_ad

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1124=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1124
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM1125=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1125
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM1126=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1126
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM1127=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1127
	.byte 0,11
	.asciz "V_3"

LDIFF_SYM1128=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM1128
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1129=Lfde149_end - Lfde149_start
	.long LDIFF_SYM1129
Lfde149_start:

	.long 0
	.align 2
	.long wrapper_managed_to_native_PInvoke_Kernel32_FindClose_intptr

LDIFF_SYM1130=Lme_ad - wrapper_managed_to_native_PInvoke_Kernel32_FindClose_intptr
	.long LDIFF_SYM1130
	.byte 68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,232,1,2,104
	.byte 10,80,12,13,32,68,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11
	.align 2
Lfde149_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_PInvoke.Kernel32:FreeLibrary"
	.asciz "wrapper_managed_to_native_PInvoke_Kernel32_FreeLibrary_intptr"

	.byte 0,0
	.long wrapper_managed_to_native_PInvoke_Kernel32_FreeLibrary_intptr
	.long Lme_ae

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1131=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1131
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM1132=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1132
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM1133=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1133
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM1134=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1134
	.byte 0,11
	.asciz "V_3"

LDIFF_SYM1135=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM1135
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1136=Lfde150_end - Lfde150_start
	.long LDIFF_SYM1136
Lfde150_start:

	.long 0
	.align 2
	.long wrapper_managed_to_native_PInvoke_Kernel32_FreeLibrary_intptr

LDIFF_SYM1137=Lme_ae - wrapper_managed_to_native_PInvoke_Kernel32_FreeLibrary_intptr
	.long LDIFF_SYM1137
	.byte 68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,232,1,2,104
	.byte 10,80,12,13,32,68,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11
	.align 2
Lfde150_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_unknown)_PInvoke.Kernel32/ACCESS_MASK:StructureToPtr"
	.asciz "wrapper_unknown_PInvoke_Kernel32_ACCESS_MASK_StructureToPtr_object_intptr_bool"

	.byte 0,0
	.long wrapper_unknown_PInvoke_Kernel32_ACCESS_MASK_StructureToPtr_object_intptr_bool
	.long Lme_af

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1138=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM1138
	.byte 2,125,0,3
	.asciz "param1"

LDIFF_SYM1139=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1139
	.byte 2,125,4,3
	.asciz "param2"

LDIFF_SYM1140=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1140
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1141=Lfde151_end - Lfde151_start
	.long LDIFF_SYM1141
Lfde151_start:

	.long 0
	.align 2
	.long wrapper_unknown_PInvoke_Kernel32_ACCESS_MASK_StructureToPtr_object_intptr_bool

LDIFF_SYM1142=Lme_af - wrapper_unknown_PInvoke_Kernel32_ACCESS_MASK_StructureToPtr_object_intptr_bool
	.long LDIFF_SYM1142
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,32,2,32,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde151_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_unknown)_PInvoke.Kernel32/ACCESS_MASK:PtrToStructure"
	.asciz "wrapper_unknown_PInvoke_Kernel32_ACCESS_MASK_PtrToStructure_intptr_object"

	.byte 0,0
	.long wrapper_unknown_PInvoke_Kernel32_ACCESS_MASK_PtrToStructure_intptr_object
	.long Lme_b0

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1143=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1143
	.byte 2,125,0,3
	.asciz "param1"

LDIFF_SYM1144=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM1144
	.byte 2,125,4,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1145=Lfde152_end - Lfde152_start
	.long LDIFF_SYM1145
Lfde152_start:

	.long 0
	.align 2
	.long wrapper_unknown_PInvoke_Kernel32_ACCESS_MASK_PtrToStructure_intptr_object

LDIFF_SYM1146=Lme_b0 - wrapper_unknown_PInvoke_Kernel32_ACCESS_MASK_PtrToStructure_intptr_object
	.long LDIFF_SYM1146
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,92,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde152_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_unknown)_PInvoke.Kernel32/FILETIME:StructureToPtr"
	.asciz "wrapper_unknown_PInvoke_Kernel32_FILETIME_StructureToPtr_object_intptr_bool"

	.byte 0,0
	.long wrapper_unknown_PInvoke_Kernel32_FILETIME_StructureToPtr_object_intptr_bool
	.long Lme_b1

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1147=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM1147
	.byte 2,125,0,3
	.asciz "param1"

LDIFF_SYM1148=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1148
	.byte 2,125,4,3
	.asciz "param2"

LDIFF_SYM1149=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1149
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1150=Lfde153_end - Lfde153_start
	.long LDIFF_SYM1150
Lfde153_start:

	.long 0
	.align 2
	.long wrapper_unknown_PInvoke_Kernel32_FILETIME_StructureToPtr_object_intptr_bool

LDIFF_SYM1151=Lme_b1 - wrapper_unknown_PInvoke_Kernel32_FILETIME_StructureToPtr_object_intptr_bool
	.long LDIFF_SYM1151
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,32,2,40,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde153_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_unknown)_PInvoke.Kernel32/FILETIME:PtrToStructure"
	.asciz "wrapper_unknown_PInvoke_Kernel32_FILETIME_PtrToStructure_intptr_object"

	.byte 0,0
	.long wrapper_unknown_PInvoke_Kernel32_FILETIME_PtrToStructure_intptr_object
	.long Lme_b2

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1152=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1152
	.byte 2,125,0,3
	.asciz "param1"

LDIFF_SYM1153=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM1153
	.byte 2,125,4,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1154=Lfde154_end - Lfde154_start
	.long LDIFF_SYM1154
Lfde154_start:

	.long 0
	.align 2
	.long wrapper_unknown_PInvoke_Kernel32_FILETIME_PtrToStructure_intptr_object

LDIFF_SYM1155=Lme_b2 - wrapper_unknown_PInvoke_Kernel32_FILETIME_PtrToStructure_intptr_object
	.long LDIFF_SYM1155
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,2,36,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde154_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_unknown)_PInvoke.Kernel32/OVERLAPPED:StructureToPtr"
	.asciz "wrapper_unknown_PInvoke_Kernel32_OVERLAPPED_StructureToPtr_object_intptr_bool"

	.byte 0,0
	.long wrapper_unknown_PInvoke_Kernel32_OVERLAPPED_StructureToPtr_object_intptr_bool
	.long Lme_b3

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1156=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM1156
	.byte 2,125,0,3
	.asciz "param1"

LDIFF_SYM1157=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1157
	.byte 1,90,3
	.asciz "param2"

LDIFF_SYM1158=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1158
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1159=Lfde155_end - Lfde155_start
	.long LDIFF_SYM1159
Lfde155_start:

	.long 0
	.align 2
	.long wrapper_unknown_PInvoke_Kernel32_OVERLAPPED_StructureToPtr_object_intptr_bool

LDIFF_SYM1160=Lme_b3 - wrapper_unknown_PInvoke_Kernel32_OVERLAPPED_StructureToPtr_object_intptr_bool
	.long LDIFF_SYM1160
	.byte 68,14,8,135,2,72,14,16,136,4,138,3,142,1,68,14,24,2,60,10,68,14,16,68,8,8,8,10,14,8,68,11
	.align 2
Lfde155_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_unknown)_PInvoke.Kernel32/OVERLAPPED:PtrToStructure"
	.asciz "wrapper_unknown_PInvoke_Kernel32_OVERLAPPED_PtrToStructure_intptr_object"

	.byte 0,0
	.long wrapper_unknown_PInvoke_Kernel32_OVERLAPPED_PtrToStructure_intptr_object
	.long Lme_b4

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1161=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1161
	.byte 1,86,3
	.asciz "param1"

LDIFF_SYM1162=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM1162
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1163=Lfde156_end - Lfde156_start
	.long LDIFF_SYM1163
Lfde156_start:

	.long 0
	.align 2
	.long wrapper_unknown_PInvoke_Kernel32_OVERLAPPED_PtrToStructure_intptr_object

LDIFF_SYM1164=Lme_b4 - wrapper_unknown_PInvoke_Kernel32_OVERLAPPED_PtrToStructure_intptr_object
	.long LDIFF_SYM1164
	.byte 68,14,8,135,2,72,14,16,134,4,136,3,142,1,68,14,24,2,56,10,68,14,16,68,8,6,8,8,14,8,68,11
	.align 2
Lfde156_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_unknown)_PInvoke.Kernel32/SECURITY_ATTRIBUTES:StructureToPtr"
	.asciz "wrapper_unknown_PInvoke_Kernel32_SECURITY_ATTRIBUTES_StructureToPtr_object_intptr_bool"

	.byte 0,0
	.long wrapper_unknown_PInvoke_Kernel32_SECURITY_ATTRIBUTES_StructureToPtr_object_intptr_bool
	.long Lme_b5

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1165=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM1165
	.byte 2,125,0,3
	.asciz "param1"

LDIFF_SYM1166=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1166
	.byte 1,90,3
	.asciz "param2"

LDIFF_SYM1167=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1167
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1168=Lfde157_end - Lfde157_start
	.long LDIFF_SYM1168
Lfde157_start:

	.long 0
	.align 2
	.long wrapper_unknown_PInvoke_Kernel32_SECURITY_ATTRIBUTES_StructureToPtr_object_intptr_bool

LDIFF_SYM1169=Lme_b5 - wrapper_unknown_PInvoke_Kernel32_SECURITY_ATTRIBUTES_StructureToPtr_object_intptr_bool
	.long LDIFF_SYM1169
	.byte 68,14,8,135,2,72,14,16,136,4,138,3,142,1,68,14,24,2,44,10,68,14,16,68,8,8,8,10,14,8,68,11
	.align 2
Lfde157_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_unknown)_PInvoke.Kernel32/SECURITY_ATTRIBUTES:PtrToStructure"
	.asciz "wrapper_unknown_PInvoke_Kernel32_SECURITY_ATTRIBUTES_PtrToStructure_intptr_object"

	.byte 0,0
	.long wrapper_unknown_PInvoke_Kernel32_SECURITY_ATTRIBUTES_PtrToStructure_intptr_object
	.long Lme_b6

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1170=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1170
	.byte 1,86,3
	.asciz "param1"

LDIFF_SYM1171=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM1171
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1172=Lfde158_end - Lfde158_start
	.long LDIFF_SYM1172
Lfde158_start:

	.long 0
	.align 2
	.long wrapper_unknown_PInvoke_Kernel32_SECURITY_ATTRIBUTES_PtrToStructure_intptr_object

LDIFF_SYM1173=Lme_b6 - wrapper_unknown_PInvoke_Kernel32_SECURITY_ATTRIBUTES_PtrToStructure_intptr_object
	.long LDIFF_SYM1173
	.byte 68,14,8,135,2,72,14,16,134,4,136,3,142,1,68,14,24,2,40,10,68,14,16,68,8,6,8,8,14,8,68,11
	.align 2
Lfde158_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_unknown)_PInvoke.Kernel32/SECURITY_DESCRIPTOR:StructureToPtr"
	.asciz "wrapper_unknown_PInvoke_Kernel32_SECURITY_DESCRIPTOR_StructureToPtr_object_intptr_bool"

	.byte 0,0
	.long wrapper_unknown_PInvoke_Kernel32_SECURITY_DESCRIPTOR_StructureToPtr_object_intptr_bool
	.long Lme_b7

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1174=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM1174
	.byte 2,125,0,3
	.asciz "param1"

LDIFF_SYM1175=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1175
	.byte 1,90,3
	.asciz "param2"

LDIFF_SYM1176=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1176
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1177=Lfde159_end - Lfde159_start
	.long LDIFF_SYM1177
Lfde159_start:

	.long 0
	.align 2
	.long wrapper_unknown_PInvoke_Kernel32_SECURITY_DESCRIPTOR_StructureToPtr_object_intptr_bool

LDIFF_SYM1178=Lme_b7 - wrapper_unknown_PInvoke_Kernel32_SECURITY_DESCRIPTOR_StructureToPtr_object_intptr_bool
	.long LDIFF_SYM1178
	.byte 68,14,8,135,2,72,14,16,136,4,138,3,142,1,68,14,24,2,60,10,68,14,16,68,8,8,8,10,14,8,68,11
	.align 2
Lfde159_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_unknown)_PInvoke.Kernel32/SECURITY_DESCRIPTOR:PtrToStructure"
	.asciz "wrapper_unknown_PInvoke_Kernel32_SECURITY_DESCRIPTOR_PtrToStructure_intptr_object"

	.byte 0,0
	.long wrapper_unknown_PInvoke_Kernel32_SECURITY_DESCRIPTOR_PtrToStructure_intptr_object
	.long Lme_b8

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1179=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1179
	.byte 1,86,3
	.asciz "param1"

LDIFF_SYM1180=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM1180
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1181=Lfde160_end - Lfde160_start
	.long LDIFF_SYM1181
Lfde160_start:

	.long 0
	.align 2
	.long wrapper_unknown_PInvoke_Kernel32_SECURITY_DESCRIPTOR_PtrToStructure_intptr_object

LDIFF_SYM1182=Lme_b8 - wrapper_unknown_PInvoke_Kernel32_SECURITY_DESCRIPTOR_PtrToStructure_intptr_object
	.long LDIFF_SYM1182
	.byte 68,14,8,135,2,72,14,16,134,4,136,3,142,1,68,14,24,2,56,10,68,14,16,68,8,6,8,8,14,8,68,11
	.align 2
Lfde160_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_unknown)_PInvoke.Kernel32/SYSTEMTIME:StructureToPtr"
	.asciz "wrapper_unknown_PInvoke_Kernel32_SYSTEMTIME_StructureToPtr_object_intptr_bool"

	.byte 0,0
	.long wrapper_unknown_PInvoke_Kernel32_SYSTEMTIME_StructureToPtr_object_intptr_bool
	.long Lme_b9

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1183=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM1183
	.byte 2,125,0,3
	.asciz "param1"

LDIFF_SYM1184=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1184
	.byte 1,90,3
	.asciz "param2"

LDIFF_SYM1185=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1185
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1186=Lfde161_end - Lfde161_start
	.long LDIFF_SYM1186
Lfde161_start:

	.long 0
	.align 2
	.long wrapper_unknown_PInvoke_Kernel32_SYSTEMTIME_StructureToPtr_object_intptr_bool

LDIFF_SYM1187=Lme_b9 - wrapper_unknown_PInvoke_Kernel32_SYSTEMTIME_StructureToPtr_object_intptr_bool
	.long LDIFF_SYM1187
	.byte 68,14,8,135,2,72,14,16,136,4,138,3,142,1,68,14,24,2,52,10,68,14,16,68,8,8,8,10,14,8,68,11
	.align 2
Lfde161_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_unknown)_PInvoke.Kernel32/SYSTEMTIME:PtrToStructure"
	.asciz "wrapper_unknown_PInvoke_Kernel32_SYSTEMTIME_PtrToStructure_intptr_object"

	.byte 0,0
	.long wrapper_unknown_PInvoke_Kernel32_SYSTEMTIME_PtrToStructure_intptr_object
	.long Lme_ba

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1188=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1188
	.byte 1,86,3
	.asciz "param1"

LDIFF_SYM1189=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM1189
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1190=Lfde162_end - Lfde162_start
	.long LDIFF_SYM1190
Lfde162_start:

	.long 0
	.align 2
	.long wrapper_unknown_PInvoke_Kernel32_SYSTEMTIME_PtrToStructure_intptr_object

LDIFF_SYM1191=Lme_ba - wrapper_unknown_PInvoke_Kernel32_SYSTEMTIME_PtrToStructure_intptr_object
	.long LDIFF_SYM1191
	.byte 68,14,8,135,2,72,14,16,134,4,136,3,142,1,68,14,24,2,48,10,68,14,16,68,8,6,8,8,14,8,68,11
	.align 2
Lfde162_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_unknown)_PInvoke.Kernel32/WIN32_FIND_DATA:StructureToPtr"
	.asciz "wrapper_unknown_PInvoke_Kernel32_WIN32_FIND_DATA_StructureToPtr_object_intptr_bool"

	.byte 0,0
	.long wrapper_unknown_PInvoke_Kernel32_WIN32_FIND_DATA_StructureToPtr_object_intptr_bool
	.long Lme_bb

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1192=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM1192
	.byte 2,125,0,3
	.asciz "param1"

LDIFF_SYM1193=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1193
	.byte 2,125,4,3
	.asciz "param2"

LDIFF_SYM1194=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1194
	.byte 0,11
	.asciz "V_0"

LDIFF_SYM1195=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1195
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM1196=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1196
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM1197=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1197
	.byte 0,11
	.asciz "V_3"

LDIFF_SYM1198=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1198
	.byte 0,11
	.asciz "V_4"

LDIFF_SYM1199=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1199
	.byte 0,11
	.asciz "V_5"

LDIFF_SYM1200=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1200
	.byte 0,11
	.asciz "V_6"

LDIFF_SYM1201=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1201
	.byte 0,11
	.asciz "V_7"

LDIFF_SYM1202=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1202
	.byte 0,11
	.asciz "V_8"

LDIFF_SYM1203=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1203
	.byte 0,11
	.asciz "V_9"

LDIFF_SYM1204=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1204
	.byte 0,11
	.asciz "V_10"

LDIFF_SYM1205=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1205
	.byte 0,11
	.asciz "V_11"

LDIFF_SYM1206=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1206
	.byte 0,11
	.asciz "V_12"

LDIFF_SYM1207=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1207
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1208=Lfde163_end - Lfde163_start
	.long LDIFF_SYM1208
Lfde163_start:

	.long 0
	.align 2
	.long wrapper_unknown_PInvoke_Kernel32_WIN32_FIND_DATA_StructureToPtr_object_intptr_bool

LDIFF_SYM1209=Lme_bb - wrapper_unknown_PInvoke_Kernel32_WIN32_FIND_DATA_StructureToPtr_object_intptr_bool
	.long LDIFF_SYM1209
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,40,2,236,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde163_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_unknown)_PInvoke.Kernel32/WIN32_FIND_DATA:PtrToStructure"
	.asciz "wrapper_unknown_PInvoke_Kernel32_WIN32_FIND_DATA_PtrToStructure_intptr_object"

	.byte 0,0
	.long wrapper_unknown_PInvoke_Kernel32_WIN32_FIND_DATA_PtrToStructure_intptr_object
	.long Lme_bc

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1210=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1210
	.byte 2,125,0,3
	.asciz "param1"

LDIFF_SYM1211=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM1211
	.byte 2,125,4,11
	.asciz "V_0"

LDIFF_SYM1212=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1212
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM1213=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1213
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM1214=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1214
	.byte 0,11
	.asciz "V_3"

LDIFF_SYM1215=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1215
	.byte 0,11
	.asciz "V_4"

LDIFF_SYM1216=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1216
	.byte 0,11
	.asciz "V_5"

LDIFF_SYM1217=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1217
	.byte 0,11
	.asciz "V_6"

LDIFF_SYM1218=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1218
	.byte 0,11
	.asciz "V_7"

LDIFF_SYM1219=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1219
	.byte 0,11
	.asciz "V_8"

LDIFF_SYM1220=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1220
	.byte 0,11
	.asciz "V_9"

LDIFF_SYM1221=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1221
	.byte 0,11
	.asciz "V_10"

LDIFF_SYM1222=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1222
	.byte 0,11
	.asciz "V_11"

LDIFF_SYM1223=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1223
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1224=Lfde164_end - Lfde164_start
	.long LDIFF_SYM1224
Lfde164_start:

	.long 0
	.align 2
	.long wrapper_unknown_PInvoke_Kernel32_WIN32_FIND_DATA_PtrToStructure_intptr_object

LDIFF_SYM1225=Lme_bc - wrapper_unknown_PInvoke_Kernel32_WIN32_FIND_DATA_PtrToStructure_intptr_object
	.long LDIFF_SYM1225
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,40,3,88,1,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde164_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "System.Array:IndexOf<T_BYTE>"
	.asciz "System_Array_IndexOf_T_BYTE_T_BYTE___T_BYTE_int_int"

	.byte 3,175,5
	.long System_Array_IndexOf_T_BYTE_T_BYTE___T_BYTE_int_int
	.long Lme_bd

	.byte 2,118,16,3
	.asciz "array"

LDIFF_SYM1226=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM1226
	.byte 1,85,3
	.asciz "value"

LDIFF_SYM1227=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1227
	.byte 2,125,4,3
	.asciz "startIndex"

LDIFF_SYM1228=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1228
	.byte 1,86,3
	.asciz "count"

LDIFF_SYM1229=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1229
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1230=Lfde165_end - Lfde165_start
	.long LDIFF_SYM1230
Lfde165_start:

	.long 0
	.align 2
	.long System_Array_IndexOf_T_BYTE_T_BYTE___T_BYTE_int_int

LDIFF_SYM1231=Lme_bd - System_Array_IndexOf_T_BYTE_T_BYTE___T_BYTE_int_int
	.long LDIFF_SYM1231
	.byte 68,14,8,135,2,72,14,24,133,6,134,5,136,4,138,3,142,1,68,14,40,2,124,10,68,14,24,68,8,5,8,6
	.byte 8,8,8,10,14,8,68,11
	.align 2
Lfde165_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_61:

	.byte 5
	.asciz "_ArraySegmentEnumerator"

	.byte 24,16
LDIFF_SYM1232=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM1232
	.byte 2,35,0,6
	.asciz "_array"

LDIFF_SYM1233=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM1233
	.byte 2,35,8,6
	.asciz "_start"

LDIFF_SYM1234=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1234
	.byte 2,35,12,6
	.asciz "_end"

LDIFF_SYM1235=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1235
	.byte 2,35,16,6
	.asciz "_current"

LDIFF_SYM1236=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1236
	.byte 2,35,20,0,7
	.asciz "_ArraySegmentEnumerator"

LDIFF_SYM1237=LTDIE_61 - Ldebug_info_start
	.long LDIFF_SYM1237
LTDIE_61_POINTER:

	.byte 13
LDIFF_SYM1238=LTDIE_61 - Ldebug_info_start
	.long LDIFF_SYM1238
LTDIE_61_REFERENCE:

	.byte 14
LDIFF_SYM1239=LTDIE_61 - Ldebug_info_start
	.long LDIFF_SYM1239
	.byte 2
	.asciz "System.ArraySegment`1/ArraySegmentEnumerator<T_BYTE>:.ctor"
	.asciz "System_ArraySegment_1_ArraySegmentEnumerator_T_BYTE__ctor_System_ArraySegment_1_T_BYTE"

	.byte 2,164,2
	.long System_ArraySegment_1_ArraySegmentEnumerator_T_BYTE__ctor_System_ArraySegment_1_T_BYTE
	.long Lme_be

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM1240=LTDIE_61_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1240
	.byte 2,123,36,3
	.asciz "arraySegment"

LDIFF_SYM1241=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1241
	.byte 2,123,40,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1242=Lfde166_end - Lfde166_start
	.long LDIFF_SYM1242
Lfde166_start:

	.long 0
	.align 2
	.long System_ArraySegment_1_ArraySegmentEnumerator_T_BYTE__ctor_System_ArraySegment_1_T_BYTE

LDIFF_SYM1243=Lme_be - System_ArraySegment_1_ArraySegmentEnumerator_T_BYTE__ctor_System_ArraySegment_1_T_BYTE
	.long LDIFF_SYM1243
	.byte 68,14,8,135,2,72,14,16,136,4,139,3,142,1,68,14,72,68,13,11,2,188,10,68,13,13,14,16,68,8,8,8
	.byte 11,14,8,68,11
	.align 2
Lfde166_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "System.Array:IndexOfImpl<T_BYTE>"
	.asciz "System_Array_IndexOfImpl_T_BYTE_T_BYTE___T_BYTE_int_int"

	.byte 4,240,4
	.long System_Array_IndexOfImpl_T_BYTE_T_BYTE___T_BYTE_int_int
	.long Lme_bf

	.byte 2,118,16,3
	.asciz "array"

LDIFF_SYM1244=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM1244
	.byte 2,123,12,3
	.asciz "value"

LDIFF_SYM1245=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1245
	.byte 2,123,16,3
	.asciz "startIndex"

LDIFF_SYM1246=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1246
	.byte 2,123,20,3
	.asciz "count"

LDIFF_SYM1247=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1247
	.byte 2,123,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1248=Lfde167_end - Lfde167_start
	.long LDIFF_SYM1248
Lfde167_start:

	.long 0
	.align 2
	.long System_Array_IndexOfImpl_T_BYTE_T_BYTE___T_BYTE_int_int

LDIFF_SYM1249=Lme_bf - System_Array_IndexOfImpl_T_BYTE_T_BYTE___T_BYTE_int_int
	.long LDIFF_SYM1249
	.byte 68,14,8,135,2,72,14,16,136,4,139,3,142,1,68,14,56,68,13,11,2,96,10,68,13,13,14,16,68,8,8,8
	.byte 11,14,8,68,11
	.align 2
Lfde167_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_62:

	.byte 5
	.asciz "System_Collections_Generic_EqualityComparer`1"

	.byte 8,16
LDIFF_SYM1250=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM1250
	.byte 2,35,0,0,7
	.asciz "System_Collections_Generic_EqualityComparer`1"

LDIFF_SYM1251=LTDIE_62 - Ldebug_info_start
	.long LDIFF_SYM1251
LTDIE_62_POINTER:

	.byte 13
LDIFF_SYM1252=LTDIE_62 - Ldebug_info_start
	.long LDIFF_SYM1252
LTDIE_62_REFERENCE:

	.byte 14
LDIFF_SYM1253=LTDIE_62 - Ldebug_info_start
	.long LDIFF_SYM1253
	.byte 2
	.asciz "System.Collections.Generic.EqualityComparer`1<T_BYTE>:get_Default"
	.asciz "System_Collections_Generic_EqualityComparer_1_T_BYTE_get_Default"

	.byte 5,32
	.long System_Collections_Generic_EqualityComparer_1_T_BYTE_get_Default
	.long Lme_c0

	.byte 2,118,16,11
	.asciz "comparer"

LDIFF_SYM1254=LTDIE_62_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1254
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1255=Lfde168_end - Lfde168_start
	.long LDIFF_SYM1255
Lfde168_start:

	.long 0
	.align 2
	.long System_Collections_Generic_EqualityComparer_1_T_BYTE_get_Default

LDIFF_SYM1256=Lme_c0 - System_Collections_Generic_EqualityComparer_1_T_BYTE_get_Default
	.long LDIFF_SYM1256
	.byte 68,14,8,135,2,72,14,16,136,4,138,3,142,1,68,14,40,2,104,10,68,14,16,68,8,8,8,10,14,8,68,11
	.align 2
Lfde168_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_63:

	.byte 8
	.asciz "System_TypeCode"

	.byte 4
LDIFF_SYM1257=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1257
	.byte 9
	.asciz "Empty"

	.byte 0,9
	.asciz "Object"

	.byte 1,9
	.asciz "DBNull"

	.byte 2,9
	.asciz "Boolean"

	.byte 3,9
	.asciz "Char"

	.byte 4,9
	.asciz "SByte"

	.byte 5,9
	.asciz "Byte"

	.byte 6,9
	.asciz "Int16"

	.byte 7,9
	.asciz "UInt16"

	.byte 8,9
	.asciz "Int32"

	.byte 9,9
	.asciz "UInt32"

	.byte 10,9
	.asciz "Int64"

	.byte 11,9
	.asciz "UInt64"

	.byte 12,9
	.asciz "Single"

	.byte 13,9
	.asciz "Double"

	.byte 14,9
	.asciz "Decimal"

	.byte 15,9
	.asciz "DateTime"

	.byte 16,9
	.asciz "String"

	.byte 18,0,7
	.asciz "System_TypeCode"

LDIFF_SYM1258=LTDIE_63 - Ldebug_info_start
	.long LDIFF_SYM1258
LTDIE_63_POINTER:

	.byte 13
LDIFF_SYM1259=LTDIE_63 - Ldebug_info_start
	.long LDIFF_SYM1259
LTDIE_63_REFERENCE:

	.byte 14
LDIFF_SYM1260=LTDIE_63 - Ldebug_info_start
	.long LDIFF_SYM1260
	.byte 2
	.asciz "System.Collections.Generic.EqualityComparer`1<T_BYTE>:CreateComparer"
	.asciz "System_Collections_Generic_EqualityComparer_1_T_BYTE_CreateComparer"

	.byte 5,49
	.long System_Collections_Generic_EqualityComparer_1_T_BYTE_CreateComparer
	.long Lme_c1

	.byte 2,118,16,11
	.asciz "t"

LDIFF_SYM1261=LTDIE_43_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1261
	.byte 1,90,11
	.asciz "u"

LDIFF_SYM1262=LTDIE_43_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1262
	.byte 1,86,11
	.asciz "underlyingTypeCode"

LDIFF_SYM1263=LTDIE_63 - Ldebug_info_start
	.long LDIFF_SYM1263
	.byte 1,85,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1264=Lfde169_end - Lfde169_start
	.long LDIFF_SYM1264
Lfde169_start:

	.long 0
	.align 2
	.long System_Collections_Generic_EqualityComparer_1_T_BYTE_CreateComparer

LDIFF_SYM1265=Lme_c1 - System_Collections_Generic_EqualityComparer_1_T_BYTE_CreateComparer
	.long LDIFF_SYM1265
	.byte 68,14,8,135,2,72,14,32,132,8,133,7,134,6,136,5,138,4,139,3,142,1,68,14,48,3,228,4,10,68,14,32
	.byte 68,8,4,8,5,8,6,8,8,8,10,8,11,14,8,68,11
	.align 2
Lfde169_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_65:

	.byte 5
	.asciz "System_Collections_Generic_EqualityComparer`1"

	.byte 8,16
LDIFF_SYM1266=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM1266
	.byte 2,35,0,0,7
	.asciz "System_Collections_Generic_EqualityComparer`1"

LDIFF_SYM1267=LTDIE_65 - Ldebug_info_start
	.long LDIFF_SYM1267
LTDIE_65_POINTER:

	.byte 13
LDIFF_SYM1268=LTDIE_65 - Ldebug_info_start
	.long LDIFF_SYM1268
LTDIE_65_REFERENCE:

	.byte 14
LDIFF_SYM1269=LTDIE_65 - Ldebug_info_start
	.long LDIFF_SYM1269
LTDIE_64:

	.byte 5
	.asciz "System_Collections_Generic_ObjectEqualityComparer`1"

	.byte 8,16
LDIFF_SYM1270=LTDIE_65 - Ldebug_info_start
	.long LDIFF_SYM1270
	.byte 2,35,0,0,7
	.asciz "System_Collections_Generic_ObjectEqualityComparer`1"

LDIFF_SYM1271=LTDIE_64 - Ldebug_info_start
	.long LDIFF_SYM1271
LTDIE_64_POINTER:

	.byte 13
LDIFF_SYM1272=LTDIE_64 - Ldebug_info_start
	.long LDIFF_SYM1272
LTDIE_64_REFERENCE:

	.byte 14
LDIFF_SYM1273=LTDIE_64 - Ldebug_info_start
	.long LDIFF_SYM1273
	.byte 2
	.asciz "System.Collections.Generic.ObjectEqualityComparer`1<T_BYTE>:.ctor"
	.asciz "System_Collections_Generic_ObjectEqualityComparer_1_T_BYTE__ctor"

	.byte 0,0
	.long System_Collections_Generic_ObjectEqualityComparer_1_T_BYTE__ctor
	.long Lme_c2

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM1274=LTDIE_64_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1274
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1275=Lfde170_end - Lfde170_start
	.long LDIFF_SYM1275
Lfde170_start:

	.long 0
	.align 2
	.long System_Collections_Generic_ObjectEqualityComparer_1_T_BYTE__ctor

LDIFF_SYM1276=Lme_c2 - System_Collections_Generic_ObjectEqualityComparer_1_T_BYTE__ctor
	.long LDIFF_SYM1276
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,68,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde170_end:

.section __DWARF, __debug_info,regular,debug

	.byte 0
Ldebug_info_end:
.text
	.align 3
mem_end:
