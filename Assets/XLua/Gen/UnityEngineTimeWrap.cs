﻿#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace CSObjectWrap
{
    using Utils = XLua.Utils;
    public class UnityEngineTimeWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.Time), L, translator, 0, 0, 0, 0);
			
			
			
			
			
			Utils.EndObjectRegister(typeof(UnityEngine.Time), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.Time), L, __CreateInstance, 1, 15, 5);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.Time));
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "time", _g_get_time);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "timeSinceLevelLoad", _g_get_timeSinceLevelLoad);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "deltaTime", _g_get_deltaTime);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "fixedTime", _g_get_fixedTime);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "unscaledTime", _g_get_unscaledTime);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "unscaledDeltaTime", _g_get_unscaledDeltaTime);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "fixedDeltaTime", _g_get_fixedDeltaTime);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "maximumDeltaTime", _g_get_maximumDeltaTime);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "smoothDeltaTime", _g_get_smoothDeltaTime);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "maximumParticleDeltaTime", _g_get_maximumParticleDeltaTime);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "timeScale", _g_get_timeScale);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "frameCount", _g_get_frameCount);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "renderedFrameCount", _g_get_renderedFrameCount);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "realtimeSinceStartup", _g_get_realtimeSinceStartup);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "captureFramerate", _g_get_captureFramerate);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "fixedDeltaTime", _s_set_fixedDeltaTime);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "maximumDeltaTime", _s_set_maximumDeltaTime);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "maximumParticleDeltaTime", _s_set_maximumParticleDeltaTime);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "timeScale", _s_set_timeScale);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "captureFramerate", _s_set_captureFramerate);
            
			Utils.EndClassRegister(typeof(UnityEngine.Time), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.Time __cl_gen_ret = new UnityEngine.Time();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Time constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_time(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushnumber(L, UnityEngine.Time.time);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_timeSinceLevelLoad(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushnumber(L, UnityEngine.Time.timeSinceLevelLoad);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_deltaTime(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushnumber(L, UnityEngine.Time.deltaTime);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_fixedTime(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushnumber(L, UnityEngine.Time.fixedTime);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_unscaledTime(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushnumber(L, UnityEngine.Time.unscaledTime);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_unscaledDeltaTime(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushnumber(L, UnityEngine.Time.unscaledDeltaTime);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_fixedDeltaTime(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushnumber(L, UnityEngine.Time.fixedDeltaTime);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maximumDeltaTime(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushnumber(L, UnityEngine.Time.maximumDeltaTime);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_smoothDeltaTime(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushnumber(L, UnityEngine.Time.smoothDeltaTime);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maximumParticleDeltaTime(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushnumber(L, UnityEngine.Time.maximumParticleDeltaTime);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_timeScale(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushnumber(L, UnityEngine.Time.timeScale);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_frameCount(RealStatePtr L)
        {
            
            try {
			    LuaAPI.xlua_pushinteger(L, UnityEngine.Time.frameCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_renderedFrameCount(RealStatePtr L)
        {
            
            try {
			    LuaAPI.xlua_pushinteger(L, UnityEngine.Time.renderedFrameCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_realtimeSinceStartup(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushnumber(L, UnityEngine.Time.realtimeSinceStartup);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_captureFramerate(RealStatePtr L)
        {
            
            try {
			    LuaAPI.xlua_pushinteger(L, UnityEngine.Time.captureFramerate);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_fixedDeltaTime(RealStatePtr L)
        {
            
            try {
			    UnityEngine.Time.fixedDeltaTime = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_maximumDeltaTime(RealStatePtr L)
        {
            
            try {
			    UnityEngine.Time.maximumDeltaTime = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_maximumParticleDeltaTime(RealStatePtr L)
        {
            
            try {
			    UnityEngine.Time.maximumParticleDeltaTime = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_timeScale(RealStatePtr L)
        {
            
            try {
			    UnityEngine.Time.timeScale = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_captureFramerate(RealStatePtr L)
        {
            
            try {
			    UnityEngine.Time.captureFramerate = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}