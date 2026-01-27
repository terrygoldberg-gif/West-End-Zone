using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;

namespace UserModule_CONTEMPORARY_RESEARCH_232_ATSC_1_IP_FEEDBACK_PROCESSOR_V1_2
{
    public class UserModuleClass_CONTEMPORARY_RESEARCH_232_ATSC_1_IP_FEEDBACK_PROCESSOR_V1_2 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.BufferInput FROM_DEVICE;
        Crestron.Logos.SplusObjects.AnalogInput PARAMETERIZED_UNIT_ID;
        Crestron.Logos.SplusObjects.AnalogOutput POWER_STATUS_ANALOG;
        Crestron.Logos.SplusObjects.AnalogOutput AUDIO_STATUS_POWER_ANALOG;
        Crestron.Logos.SplusObjects.StringOutput CHANNEL_TEXT;
        Crestron.Logos.SplusObjects.StringOutput CHANNEL_NAME;
        Crestron.Logos.SplusObjects.StringOutput PROGRAM_NAME;
        Crestron.Logos.SplusObjects.StringOutput MODEL_VERSION;
        Crestron.Logos.SplusObjects.AnalogOutput VOLUME_ACTUAL_ANALOG;
        Crestron.Logos.SplusObjects.AnalogOutput VOLUME_MUTE_STATUS_ANALOG;
        Crestron.Logos.SplusObjects.AnalogOutput CC_STATUS_ANALOG;
        Crestron.Logos.SplusObjects.AnalogOutput CC_TYPE_ANALOG;
        Crestron.Logos.SplusObjects.AnalogOutput VIDEO_DETECT_ANALOG;
        Crestron.Logos.SplusObjects.AnalogOutput AV_DETECT_ANALOG;
        Crestron.Logos.SplusObjects.AnalogOutput LABEL_ANALOG;
        Crestron.Logos.SplusObjects.AnalogOutput IR_STATUS_ANALOG;
        Crestron.Logos.SplusObjects.AnalogOutput DIGITAL_CC_ANALOG;
        Crestron.Logos.SplusObjects.AnalogOutput VIDEO_MUTE_STATUS_ANALOG;
        Crestron.Logos.SplusObjects.AnalogOutput INPUT_RF_ANALOG;
        Crestron.Logos.SplusObjects.AnalogOutput RF_STATUS_ANALOG;
        Crestron.Logos.SplusObjects.AnalogOutput RECEIVED_RESOLUTION_ANALOG;
        Crestron.Logos.SplusObjects.AnalogOutput OUTPUT_ANALOG;
        Crestron.Logos.SplusObjects.AnalogOutput OUTPUT_RESOLUTION_ANALOG;
        Crestron.Logos.SplusObjects.AnalogOutput OUTPUT_SETTING_ANALOG;
        Crestron.Logos.SplusObjects.AnalogOutput F_PANEL_LOCK_ANALOG;
        ushort ITEMP = 0;
        ushort IFLAG1 = 0;
        ushort CH_SRC_MAJ_CH_ANALOG = 0;
        ushort CH_SRC_MIN_CH_ANALOG = 0;
        CrestronString STEMP;
        CrestronString STEMP1;
        CrestronString SUNIT_RESPONSE_T;
        CrestronString SUNIT_RESPONSE_V;
        CrestronString SUNIT_RESPONSE_S;
        CrestronString SUNIT_RESPONSE_Q;
        CrestronString SUNIT_RESPONSE_NC;
        CrestronString SUNIT_RESPONSE_NP;
        CrestronString SUNIT_RESPONSE_ID;
        object FROM_DEVICE_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 85;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IFLAG1 == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 87;
                    IFLAG1 = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 88;
                    while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "<" , FROM_DEVICE ) > 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 90;
                        STEMP  .UpdateValue ( Functions.Gather ( "\u000A" , FROM_DEVICE )  ) ; 
                        __context__.SourceCodeLine = 91;
                        SUNIT_RESPONSE_T  .UpdateValue ( Functions.ItoA (  (int) ( PARAMETERIZED_UNIT_ID  .UshortValue ) ) + "T"  ) ; 
                        __context__.SourceCodeLine = 92;
                        SUNIT_RESPONSE_V  .UpdateValue ( Functions.ItoA (  (int) ( PARAMETERIZED_UNIT_ID  .UshortValue ) ) + "V"  ) ; 
                        __context__.SourceCodeLine = 93;
                        SUNIT_RESPONSE_S  .UpdateValue ( Functions.ItoA (  (int) ( PARAMETERIZED_UNIT_ID  .UshortValue ) ) + "S"  ) ; 
                        __context__.SourceCodeLine = 94;
                        SUNIT_RESPONSE_Q  .UpdateValue ( Functions.ItoA (  (int) ( PARAMETERIZED_UNIT_ID  .UshortValue ) ) + "Q"  ) ; 
                        __context__.SourceCodeLine = 95;
                        SUNIT_RESPONSE_NC  .UpdateValue ( Functions.ItoA (  (int) ( PARAMETERIZED_UNIT_ID  .UshortValue ) ) + "NC"  ) ; 
                        __context__.SourceCodeLine = 96;
                        SUNIT_RESPONSE_NP  .UpdateValue ( Functions.ItoA (  (int) ( PARAMETERIZED_UNIT_ID  .UshortValue ) ) + "NP"  ) ; 
                        __context__.SourceCodeLine = 97;
                        SUNIT_RESPONSE_ID  .UpdateValue ( Functions.ItoA (  (int) ( PARAMETERIZED_UNIT_ID  .UshortValue ) ) + "ID"  ) ; 
                        __context__.SourceCodeLine = 99;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( SUNIT_RESPONSE_T , STEMP ) > 0 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 101;
                            STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( 4 ) ,  (int) ( 1 ) )  ) ; 
                            __context__.SourceCodeLine = 102;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "U" , STEMP1 ) > 0 ))  ) ) 
                                {
                                __context__.SourceCodeLine = 103;
                                POWER_STATUS_ANALOG  .Value = (ushort) ( 1 ) ; 
                                }
                            
                            __context__.SourceCodeLine = 104;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "M" , STEMP1 ) > 0 ))  ) ) 
                                {
                                __context__.SourceCodeLine = 105;
                                POWER_STATUS_ANALOG  .Value = (ushort) ( 0 ) ; 
                                }
                            
                            __context__.SourceCodeLine = 107;
                            STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( 5 ) ,  (int) ( 3 ) )  ) ; 
                            __context__.SourceCodeLine = 108;
                            CH_SRC_MAJ_CH_ANALOG = (ushort) ( Functions.Atoi( STEMP1 ) ) ; 
                            __context__.SourceCodeLine = 110;
                            STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( 8 ) ,  (int) ( 1 ) )  ) ; 
                            __context__.SourceCodeLine = 111;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "U" , STEMP1 ) > 0 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 113;
                                VIDEO_MUTE_STATUS_ANALOG  .Value = (ushort) ( 0 ) ; 
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 117;
                                VIDEO_MUTE_STATUS_ANALOG  .Value = (ushort) ( 1 ) ; 
                                } 
                            
                            __context__.SourceCodeLine = 120;
                            STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( 9 ) ,  (int) ( 1 ) )  ) ; 
                            __context__.SourceCodeLine = 121;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "U" , STEMP1 ) > 0 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 123;
                                INPUT_RF_ANALOG  .Value = (ushort) ( 0 ) ; 
                                } 
                            
                            __context__.SourceCodeLine = 127;
                            STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( 10 ) ,  (int) ( 1 ) )  ) ; 
                            __context__.SourceCodeLine = 128;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "A" , STEMP1 ) > 0 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 130;
                                RF_STATUS_ANALOG  .Value = (ushort) ( 1 ) ; 
                                } 
                            
                            __context__.SourceCodeLine = 132;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "C" , STEMP1 ) > 0 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 134;
                                RF_STATUS_ANALOG  .Value = (ushort) ( 2 ) ; 
                                } 
                            
                            __context__.SourceCodeLine = 138;
                            STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( 11 ) ,  (int) ( 1 ) )  ) ; 
                            __context__.SourceCodeLine = 139;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "0" , STEMP1 ) > 0 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 141;
                                RECEIVED_RESOLUTION_ANALOG  .Value = (ushort) ( 0 ) ; 
                                } 
                            
                            __context__.SourceCodeLine = 143;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "1" , STEMP1 ) > 0 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 145;
                                RECEIVED_RESOLUTION_ANALOG  .Value = (ushort) ( 1 ) ; 
                                } 
                            
                            __context__.SourceCodeLine = 147;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "2" , STEMP1 ) > 0 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 149;
                                RECEIVED_RESOLUTION_ANALOG  .Value = (ushort) ( 2 ) ; 
                                } 
                            
                            __context__.SourceCodeLine = 151;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "3" , STEMP1 ) > 0 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 153;
                                RECEIVED_RESOLUTION_ANALOG  .Value = (ushort) ( 3 ) ; 
                                } 
                            
                            __context__.SourceCodeLine = 155;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "N" , STEMP1 ) > 0 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 157;
                                RECEIVED_RESOLUTION_ANALOG  .Value = (ushort) ( 4 ) ; 
                                } 
                            
                            __context__.SourceCodeLine = 161;
                            STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( 12 ) ,  (int) ( 3 ) )  ) ; 
                            __context__.SourceCodeLine = 162;
                            CH_SRC_MIN_CH_ANALOG = (ushort) ( Functions.Atoi( STEMP1 ) ) ; 
                            __context__.SourceCodeLine = 163;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( CH_SRC_MIN_CH_ANALOG > 0 ))  ) ) 
                                {
                                __context__.SourceCodeLine = 164;
                                CHANNEL_TEXT  .UpdateValue ( Functions.ItoA (  (int) ( CH_SRC_MAJ_CH_ANALOG ) ) + "-" + Functions.ItoA (  (int) ( CH_SRC_MIN_CH_ANALOG ) )  ) ; 
                                }
                            
                            else 
                                {
                                __context__.SourceCodeLine = 166;
                                CHANNEL_TEXT  .UpdateValue ( Functions.ItoA (  (int) ( CH_SRC_MAJ_CH_ANALOG ) )  ) ; 
                                }
                            
                            __context__.SourceCodeLine = 169;
                            STEMP1  .UpdateValue ( ""  ) ; 
                            __context__.SourceCodeLine = 170;
                            STEMP  .UpdateValue ( ""  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 174;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( SUNIT_RESPONSE_V , STEMP ) > 0 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 176;
                                STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( 4 ) ,  (int) ( 1 ) )  ) ; 
                                __context__.SourceCodeLine = 178;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "U" , STEMP1 ) > 0 ))  ) ) 
                                    {
                                    __context__.SourceCodeLine = 179;
                                    AUDIO_STATUS_POWER_ANALOG  .Value = (ushort) ( 1 ) ; 
                                    }
                                
                                __context__.SourceCodeLine = 180;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "M" , STEMP1 ) > 0 ))  ) ) 
                                    {
                                    __context__.SourceCodeLine = 181;
                                    AUDIO_STATUS_POWER_ANALOG  .Value = (ushort) ( 0 ) ; 
                                    }
                                
                                __context__.SourceCodeLine = 183;
                                STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( 7 ) ,  (int) ( 1 ) )  ) ; 
                                __context__.SourceCodeLine = 184;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "M" , STEMP1 ) > 0 ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 186;
                                    VOLUME_MUTE_STATUS_ANALOG  .Value = (ushort) ( 1 ) ; 
                                    } 
                                
                                __context__.SourceCodeLine = 188;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "U" , STEMP1 ) > 0 ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 190;
                                    VOLUME_MUTE_STATUS_ANALOG  .Value = (ushort) ( 0 ) ; 
                                    } 
                                
                                __context__.SourceCodeLine = 196;
                                STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( 9 ) ,  (int) ( 3 ) )  ) ; 
                                __context__.SourceCodeLine = 197;
                                VOLUME_ACTUAL_ANALOG  .Value = (ushort) ( Functions.Atoi( STEMP1 ) ) ; 
                                __context__.SourceCodeLine = 199;
                                STEMP1  .UpdateValue ( ""  ) ; 
                                __context__.SourceCodeLine = 200;
                                STEMP  .UpdateValue ( ""  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 202;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( SUNIT_RESPONSE_S , STEMP ) > 0 ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 205;
                                    F_PANEL_LOCK_ANALOG  .Value = (ushort) ( Functions.Atoi( Functions.Mid( STEMP , (int)( 6 ) , (int)( 1 ) ) ) ) ; 
                                    __context__.SourceCodeLine = 207;
                                    STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( 10 ) ,  (int) ( 1 ) )  ) ; 
                                    __context__.SourceCodeLine = 208;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "0" , STEMP1 ) > 0 ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 210;
                                        OUTPUT_ANALOG  .Value = (ushort) ( 0 ) ; 
                                        } 
                                    
                                    __context__.SourceCodeLine = 213;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "2" , STEMP1 ) > 0 ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 215;
                                        OUTPUT_ANALOG  .Value = (ushort) ( 2 ) ; 
                                        } 
                                    
                                    __context__.SourceCodeLine = 218;
                                    STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( 11 ) ,  (int) ( 1 ) )  ) ; 
                                    __context__.SourceCodeLine = 219;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "0" , STEMP1 ) > 0 ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 221;
                                        OUTPUT_RESOLUTION_ANALOG  .Value = (ushort) ( 0 ) ; 
                                        } 
                                    
                                    __context__.SourceCodeLine = 223;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "1" , STEMP1 ) > 0 ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 225;
                                        OUTPUT_RESOLUTION_ANALOG  .Value = (ushort) ( 1 ) ; 
                                        } 
                                    
                                    __context__.SourceCodeLine = 227;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "2" , STEMP1 ) > 0 ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 229;
                                        OUTPUT_RESOLUTION_ANALOG  .Value = (ushort) ( 2 ) ; 
                                        } 
                                    
                                    __context__.SourceCodeLine = 231;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "3" , STEMP1 ) > 0 ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 233;
                                        OUTPUT_RESOLUTION_ANALOG  .Value = (ushort) ( 3 ) ; 
                                        } 
                                    
                                    __context__.SourceCodeLine = 235;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "4" , STEMP1 ) > 0 ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 237;
                                        OUTPUT_RESOLUTION_ANALOG  .Value = (ushort) ( 4 ) ; 
                                        } 
                                    
                                    __context__.SourceCodeLine = 240;
                                    STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( 12 ) ,  (int) ( 1 ) )  ) ; 
                                    __context__.SourceCodeLine = 241;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "0" , STEMP1 ) > 0 ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 243;
                                        OUTPUT_SETTING_ANALOG  .Value = (ushort) ( 0 ) ; 
                                        } 
                                    
                                    __context__.SourceCodeLine = 245;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "1" , STEMP1 ) > 0 ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 247;
                                        OUTPUT_SETTING_ANALOG  .Value = (ushort) ( 1 ) ; 
                                        } 
                                    
                                    __context__.SourceCodeLine = 249;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "2" , STEMP1 ) > 0 ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 251;
                                        OUTPUT_SETTING_ANALOG  .Value = (ushort) ( 2 ) ; 
                                        } 
                                    
                                    __context__.SourceCodeLine = 253;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "3" , STEMP1 ) > 0 ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 255;
                                        OUTPUT_SETTING_ANALOG  .Value = (ushort) ( 3 ) ; 
                                        } 
                                    
                                    __context__.SourceCodeLine = 258;
                                    STEMP1  .UpdateValue ( ""  ) ; 
                                    __context__.SourceCodeLine = 259;
                                    STEMP  .UpdateValue ( ""  ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 261;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( SUNIT_RESPONSE_Q , STEMP ) > 0 ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 264;
                                        CC_STATUS_ANALOG  .Value = (ushort) ( Functions.Atoi( Functions.Mid( STEMP , (int)( 4 ) , (int)( 1 ) ) ) ) ; 
                                        __context__.SourceCodeLine = 266;
                                        CC_TYPE_ANALOG  .Value = (ushort) ( Functions.Atoi( Functions.Mid( STEMP , (int)( 5 ) , (int)( 1 ) ) ) ) ; 
                                        __context__.SourceCodeLine = 268;
                                        STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( 6 ) ,  (int) ( 1 ) )  ) ; 
                                        __context__.SourceCodeLine = 269;
                                        VIDEO_DETECT_ANALOG  .Value = (ushort) ( Functions.Atoi( Functions.Mid( STEMP , (int)( 6 ) , (int)( 1 ) ) ) ) ; 
                                        __context__.SourceCodeLine = 271;
                                        AV_DETECT_ANALOG  .Value = (ushort) ( Functions.Atoi( Functions.Mid( STEMP , (int)( 7 ) , (int)( 1 ) ) ) ) ; 
                                        __context__.SourceCodeLine = 273;
                                        LABEL_ANALOG  .Value = (ushort) ( Functions.Atoi( Functions.Mid( STEMP , (int)( 8 ) , (int)( 1 ) ) ) ) ; 
                                        __context__.SourceCodeLine = 275;
                                        IR_STATUS_ANALOG  .Value = (ushort) ( Functions.Atoi( Functions.Mid( STEMP , (int)( 9 ) , (int)( 1 ) ) ) ) ; 
                                        __context__.SourceCodeLine = 277;
                                        DIGITAL_CC_ANALOG  .Value = (ushort) ( Functions.Atoi( Functions.Mid( STEMP , (int)( 11 ) , (int)( 1 ) ) ) ) ; 
                                        __context__.SourceCodeLine = 278;
                                        STEMP1  .UpdateValue ( ""  ) ; 
                                        __context__.SourceCodeLine = 279;
                                        STEMP  .UpdateValue ( ""  ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 281;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( SUNIT_RESPONSE_NC , STEMP ) > 0 ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 283;
                                            CHANNEL_NAME  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( 5 ) ,  (int) ( 3 ) )  ) ; 
                                            __context__.SourceCodeLine = 284;
                                            STEMP1  .UpdateValue ( ""  ) ; 
                                            __context__.SourceCodeLine = 285;
                                            STEMP  .UpdateValue ( ""  ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 287;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( SUNIT_RESPONSE_NP , STEMP ) > 0 ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 289;
                                                PROGRAM_NAME  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( 5 ) ,  (int) ( 12 ) )  ) ; 
                                                __context__.SourceCodeLine = 290;
                                                STEMP1  .UpdateValue ( ""  ) ; 
                                                __context__.SourceCodeLine = 291;
                                                STEMP  .UpdateValue ( ""  ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 293;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( SUNIT_RESPONSE_ID , STEMP ) > 0 ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 295;
                                                    MODEL_VERSION  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( 5 ) ,  (int) ( 12 ) )  ) ; 
                                                    __context__.SourceCodeLine = 296;
                                                    STEMP1  .UpdateValue ( ""  ) ; 
                                                    __context__.SourceCodeLine = 297;
                                                    STEMP  .UpdateValue ( ""  ) ; 
                                                    } 
                                                
                                                }
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            }
                        
                        __context__.SourceCodeLine = 88;
                        } 
                    
                    __context__.SourceCodeLine = 301;
                    IFLAG1 = (ushort) ( 0 ) ; 
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    public override object FunctionMain (  object __obj__ ) 
        { 
        try
        {
            SplusExecutionContext __context__ = SplusFunctionMainStartCode();
            
            __context__.SourceCodeLine = 311;
            IFLAG1 = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 312;
            STEMP  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 313;
            STEMP1  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 314;
            ITEMP = (ushort) ( 100 ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler(); }
        return __obj__;
        }
        
    
    public override void LogosSplusInitialize()
    {
        _SplusNVRAM = new SplusNVRAM( this );
        STEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
        STEMP1  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
        SUNIT_RESPONSE_T  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4, this );
        SUNIT_RESPONSE_V  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4, this );
        SUNIT_RESPONSE_S  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4, this );
        SUNIT_RESPONSE_Q  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4, this );
        SUNIT_RESPONSE_NC  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4, this );
        SUNIT_RESPONSE_NP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 15, this );
        SUNIT_RESPONSE_ID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 15, this );
        
        PARAMETERIZED_UNIT_ID = new Crestron.Logos.SplusObjects.AnalogInput( PARAMETERIZED_UNIT_ID__AnalogSerialInput__, this );
        m_AnalogInputList.Add( PARAMETERIZED_UNIT_ID__AnalogSerialInput__, PARAMETERIZED_UNIT_ID );
        
        POWER_STATUS_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( POWER_STATUS_ANALOG__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( POWER_STATUS_ANALOG__AnalogSerialOutput__, POWER_STATUS_ANALOG );
        
        AUDIO_STATUS_POWER_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( AUDIO_STATUS_POWER_ANALOG__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( AUDIO_STATUS_POWER_ANALOG__AnalogSerialOutput__, AUDIO_STATUS_POWER_ANALOG );
        
        VOLUME_ACTUAL_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( VOLUME_ACTUAL_ANALOG__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( VOLUME_ACTUAL_ANALOG__AnalogSerialOutput__, VOLUME_ACTUAL_ANALOG );
        
        VOLUME_MUTE_STATUS_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( VOLUME_MUTE_STATUS_ANALOG__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( VOLUME_MUTE_STATUS_ANALOG__AnalogSerialOutput__, VOLUME_MUTE_STATUS_ANALOG );
        
        CC_STATUS_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( CC_STATUS_ANALOG__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( CC_STATUS_ANALOG__AnalogSerialOutput__, CC_STATUS_ANALOG );
        
        CC_TYPE_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( CC_TYPE_ANALOG__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( CC_TYPE_ANALOG__AnalogSerialOutput__, CC_TYPE_ANALOG );
        
        VIDEO_DETECT_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( VIDEO_DETECT_ANALOG__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( VIDEO_DETECT_ANALOG__AnalogSerialOutput__, VIDEO_DETECT_ANALOG );
        
        AV_DETECT_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( AV_DETECT_ANALOG__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( AV_DETECT_ANALOG__AnalogSerialOutput__, AV_DETECT_ANALOG );
        
        LABEL_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( LABEL_ANALOG__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( LABEL_ANALOG__AnalogSerialOutput__, LABEL_ANALOG );
        
        IR_STATUS_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( IR_STATUS_ANALOG__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( IR_STATUS_ANALOG__AnalogSerialOutput__, IR_STATUS_ANALOG );
        
        DIGITAL_CC_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( DIGITAL_CC_ANALOG__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( DIGITAL_CC_ANALOG__AnalogSerialOutput__, DIGITAL_CC_ANALOG );
        
        VIDEO_MUTE_STATUS_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( VIDEO_MUTE_STATUS_ANALOG__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( VIDEO_MUTE_STATUS_ANALOG__AnalogSerialOutput__, VIDEO_MUTE_STATUS_ANALOG );
        
        INPUT_RF_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( INPUT_RF_ANALOG__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( INPUT_RF_ANALOG__AnalogSerialOutput__, INPUT_RF_ANALOG );
        
        RF_STATUS_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( RF_STATUS_ANALOG__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( RF_STATUS_ANALOG__AnalogSerialOutput__, RF_STATUS_ANALOG );
        
        RECEIVED_RESOLUTION_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( RECEIVED_RESOLUTION_ANALOG__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( RECEIVED_RESOLUTION_ANALOG__AnalogSerialOutput__, RECEIVED_RESOLUTION_ANALOG );
        
        OUTPUT_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( OUTPUT_ANALOG__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( OUTPUT_ANALOG__AnalogSerialOutput__, OUTPUT_ANALOG );
        
        OUTPUT_RESOLUTION_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( OUTPUT_RESOLUTION_ANALOG__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( OUTPUT_RESOLUTION_ANALOG__AnalogSerialOutput__, OUTPUT_RESOLUTION_ANALOG );
        
        OUTPUT_SETTING_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( OUTPUT_SETTING_ANALOG__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( OUTPUT_SETTING_ANALOG__AnalogSerialOutput__, OUTPUT_SETTING_ANALOG );
        
        F_PANEL_LOCK_ANALOG = new Crestron.Logos.SplusObjects.AnalogOutput( F_PANEL_LOCK_ANALOG__AnalogSerialOutput__, this );
        m_AnalogOutputList.Add( F_PANEL_LOCK_ANALOG__AnalogSerialOutput__, F_PANEL_LOCK_ANALOG );
        
        CHANNEL_TEXT = new Crestron.Logos.SplusObjects.StringOutput( CHANNEL_TEXT__AnalogSerialOutput__, this );
        m_StringOutputList.Add( CHANNEL_TEXT__AnalogSerialOutput__, CHANNEL_TEXT );
        
        CHANNEL_NAME = new Crestron.Logos.SplusObjects.StringOutput( CHANNEL_NAME__AnalogSerialOutput__, this );
        m_StringOutputList.Add( CHANNEL_NAME__AnalogSerialOutput__, CHANNEL_NAME );
        
        PROGRAM_NAME = new Crestron.Logos.SplusObjects.StringOutput( PROGRAM_NAME__AnalogSerialOutput__, this );
        m_StringOutputList.Add( PROGRAM_NAME__AnalogSerialOutput__, PROGRAM_NAME );
        
        MODEL_VERSION = new Crestron.Logos.SplusObjects.StringOutput( MODEL_VERSION__AnalogSerialOutput__, this );
        m_StringOutputList.Add( MODEL_VERSION__AnalogSerialOutput__, MODEL_VERSION );
        
        FROM_DEVICE = new Crestron.Logos.SplusObjects.BufferInput( FROM_DEVICE__AnalogSerialInput__, 200, this );
        m_StringInputList.Add( FROM_DEVICE__AnalogSerialInput__, FROM_DEVICE );
        
        
        FROM_DEVICE.OnSerialChange.Add( new InputChangeHandlerWrapper( FROM_DEVICE_OnChange_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_CONTEMPORARY_RESEARCH_232_ATSC_1_IP_FEEDBACK_PROCESSOR_V1_2 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint FROM_DEVICE__AnalogSerialInput__ = 0;
    const uint PARAMETERIZED_UNIT_ID__AnalogSerialInput__ = 1;
    const uint POWER_STATUS_ANALOG__AnalogSerialOutput__ = 0;
    const uint AUDIO_STATUS_POWER_ANALOG__AnalogSerialOutput__ = 1;
    const uint CHANNEL_TEXT__AnalogSerialOutput__ = 2;
    const uint CHANNEL_NAME__AnalogSerialOutput__ = 3;
    const uint PROGRAM_NAME__AnalogSerialOutput__ = 4;
    const uint MODEL_VERSION__AnalogSerialOutput__ = 5;
    const uint VOLUME_ACTUAL_ANALOG__AnalogSerialOutput__ = 6;
    const uint VOLUME_MUTE_STATUS_ANALOG__AnalogSerialOutput__ = 7;
    const uint CC_STATUS_ANALOG__AnalogSerialOutput__ = 8;
    const uint CC_TYPE_ANALOG__AnalogSerialOutput__ = 9;
    const uint VIDEO_DETECT_ANALOG__AnalogSerialOutput__ = 10;
    const uint AV_DETECT_ANALOG__AnalogSerialOutput__ = 11;
    const uint LABEL_ANALOG__AnalogSerialOutput__ = 12;
    const uint IR_STATUS_ANALOG__AnalogSerialOutput__ = 13;
    const uint DIGITAL_CC_ANALOG__AnalogSerialOutput__ = 14;
    const uint VIDEO_MUTE_STATUS_ANALOG__AnalogSerialOutput__ = 15;
    const uint INPUT_RF_ANALOG__AnalogSerialOutput__ = 16;
    const uint RF_STATUS_ANALOG__AnalogSerialOutput__ = 17;
    const uint RECEIVED_RESOLUTION_ANALOG__AnalogSerialOutput__ = 18;
    const uint OUTPUT_ANALOG__AnalogSerialOutput__ = 19;
    const uint OUTPUT_RESOLUTION_ANALOG__AnalogSerialOutput__ = 20;
    const uint OUTPUT_SETTING_ANALOG__AnalogSerialOutput__ = 21;
    const uint F_PANEL_LOCK_ANALOG__AnalogSerialOutput__ = 22;
    
    [SplusStructAttribute(-1, true, false)]
    public class SplusNVRAM : SplusStructureBase
    {
    
        public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
        
        
    }
    
    SplusNVRAM _SplusNVRAM = null;
    
    public class __CEvent__ : CEvent
    {
        public __CEvent__() {}
        public void Close() { base.Close(); }
        public int Reset() { return base.Reset() ? 1 : 0; }
        public int Set() { return base.Set() ? 1 : 0; }
        public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
    }
    public class __CMutex__ : CMutex
    {
        public __CMutex__() {}
        public void Close() { base.Close(); }
        public void ReleaseMutex() { base.ReleaseMutex(); }
        public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
    }
     public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
}


}
