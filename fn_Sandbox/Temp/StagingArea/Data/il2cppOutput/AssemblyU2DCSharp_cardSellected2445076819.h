#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.GameObject
struct GameObject_t1756533147;
// System.String
struct String_t;
// GameContrller
struct GameContrller_t2992541687;

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// cardSellected
struct  cardSellected_t2445076819  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.GameObject cardSellected::g
	GameObject_t1756533147 * ___g_2;
	// System.String cardSellected::cardSelected
	String_t* ___cardSelected_3;
	// GameContrller cardSellected::gameController
	GameContrller_t2992541687 * ___gameController_4;

public:
	inline static int32_t get_offset_of_g_2() { return static_cast<int32_t>(offsetof(cardSellected_t2445076819, ___g_2)); }
	inline GameObject_t1756533147 * get_g_2() const { return ___g_2; }
	inline GameObject_t1756533147 ** get_address_of_g_2() { return &___g_2; }
	inline void set_g_2(GameObject_t1756533147 * value)
	{
		___g_2 = value;
		Il2CppCodeGenWriteBarrier(&___g_2, value);
	}

	inline static int32_t get_offset_of_cardSelected_3() { return static_cast<int32_t>(offsetof(cardSellected_t2445076819, ___cardSelected_3)); }
	inline String_t* get_cardSelected_3() const { return ___cardSelected_3; }
	inline String_t** get_address_of_cardSelected_3() { return &___cardSelected_3; }
	inline void set_cardSelected_3(String_t* value)
	{
		___cardSelected_3 = value;
		Il2CppCodeGenWriteBarrier(&___cardSelected_3, value);
	}

	inline static int32_t get_offset_of_gameController_4() { return static_cast<int32_t>(offsetof(cardSellected_t2445076819, ___gameController_4)); }
	inline GameContrller_t2992541687 * get_gameController_4() const { return ___gameController_4; }
	inline GameContrller_t2992541687 ** get_address_of_gameController_4() { return &___gameController_4; }
	inline void set_gameController_4(GameContrller_t2992541687 * value)
	{
		___gameController_4 = value;
		Il2CppCodeGenWriteBarrier(&___gameController_4, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
