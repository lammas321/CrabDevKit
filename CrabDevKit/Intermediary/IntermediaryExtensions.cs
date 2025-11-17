using CodeStage.AntiCheat.ObscuredTypes;
using CrabDevKit.Utilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using Il2CppSystem.IO;
using Il2CppSystem.Text;
using Il2CppSystem.Text.RegularExpressions;
using MilkShake;
using SteamworksNative;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;

/* ============================ Intermediary Extension Mappings v1 - Crab Game v1.362 ============================ //
 * A *near* complete set of intermediary mapping names, using the names originally written by Dani where viable.
 * Most, if not all of these names were found by inspecting the old versions of Crab Game, which weren't obfuscated,
 * and then comparing their definitions and functionality with the latest version (v1.362), which is obfuscated.
 * 
 * Matching fields and properties was all manual, while methods were mostly manual, but a script helped with matching
 * a lot of the methods, and even correcting some incorrectly matched methods. I can guarantee *most* of the methods
 * you will use here are correct, but if you find any incorrectly matched method, let me know so they may be corrected!
 * 
 * Extensions beginning with 'Deobf_' are names I came up with myself, as these fields, methods, etc were added later, 
 * when Dani began obfuscating the game. This was the first version to be obfuscated, albeit lightly with A-P names:
 * - https://steamdb.info/depot/1782211/history/?changeid=M:8222576179761599905
 * Every version after this is more heavily obfuscated, and uses obscure unicode characters. The latest version
 * for MacOS uses the unicode characters \u1099-\u10A8, and every obfuscated name is 11 characters long:
 * - https://steamdb.info/depot/1782212/history/?changeid=M:4682332062135883449
// =============================================================================================================== */

namespace CrabDevKit.Intermediary
{
    public static class AssignSharedObjectIDExtensions
    {
        public static List<SharedObject> get_sharedObjects()
            => AssignSharedObjectID.field_Private_Static_List_1_MonoBehaviourPublicInidBoskUnique_0;

        public static void set_sharedObjects(List<SharedObject> sharedObjects)
            => AssignSharedObjectID.field_Private_Static_List_1_MonoBehaviourPublicInidBoskUnique_0 = sharedObjects;
    }

    public static class BlockManagerExtensions
    {
        public static Il2CppSystem.Random get_random(this BlockManager self)
            => self.field_Private_Random_0;

        public static void set_random(this BlockManager self, Il2CppSystem.Random random)
            => self.field_Private_Random_0 = random;
    }
    
    public static class BoulderControllerExtensions
    {
        public static float get_spawnRate(this BoulderController self)
            => self.field_Private_Single_0;

        public static void set_spawnRate(this BoulderController self, float spawnRate)
            => self.field_Private_Single_0 = spawnRate;


        public static void SendBoulder(this BoulderController self)
            => self.Method_Private_Void_PDM_39();
    }

    public static class BouncePlayerExtensions
    {
        public static bool get_ready(this BouncePlayer self)
            => self.field_Private_Boolean_0;

        public static void set_ready(this BouncePlayer self, bool ready)
            => self.field_Private_Boolean_0 = ready;
    }

    public static class BulletPrefabExtensions
    {
        public static void StopBullet(this BulletPrefab self)
            => self.Method_Private_Void_PDM_9();
    }

    public static class BustlingButtonInteractExtensions
    {
        public static Vector3 get_activePosition(this BustlingButtonInteract self)
            => self.field_Private_Vector3_0;

        public static void set_activePosition(this BustlingButtonInteract self, Vector3 activePosition)
            => self.field_Private_Vector3_0 = activePosition;


        public static Vector3 get_inactivePosition(this BustlingButtonInteract self)
            => self.field_Private_Vector3_1;

        public static void set_inactivePosition(this BustlingButtonInteract self, Vector3 inactivePosition)
            => self.field_Private_Vector3_1 = inactivePosition;


        public static Vector3 get_desiredPosition(this BustlingButtonInteract self)
            => self.field_Private_Vector3_2;

        public static void set_desiredPosition(this BustlingButtonInteract self, Vector3 desiredPosition)
            => self.field_Private_Vector3_2 = desiredPosition;


        public static Vector3 get_startPosition(this BustlingButtonInteract self)
            => self.field_Private_Vector3_3;

        public static void set_startPosition(this BustlingButtonInteract self, Vector3 startPosition)
            => self.field_Private_Vector3_3 = startPosition;


        public static float get_moveTime(this BustlingButtonInteract self)
            => self.field_Private_Single_0;

        public static void set_moveTime(this BustlingButtonInteract self, float moveTime)
            => self.field_Private_Single_0 = moveTime;


        public static float get_currentTime(this BustlingButtonInteract self)
            => self.field_Private_Single_1;

        public static void set_currentTime(this BustlingButtonInteract self, float currentTime)
            => self.field_Private_Single_1 = currentTime;
    }

    public static class ButtonTimerExtensions
    {
        public static GameModeButtons get_gameMode(this ButtonTimer self)
            => self.field_Private_GameModePublicInSiUISiIncuneSiUIBoUnique_0;

        public static void set_gameMode(this ButtonTimer self, GameModeButtons gameMode)
            => self.field_Private_GameModePublicInSiUISiIncuneSiUIBoUnique_0 = gameMode;
    }

    public static class CameraControllerExtensions
    {
        public static int get_currentCamera(this CameraController self)
            => self.field_Private_Int32_0;

        public static void set_currentCamera(this CameraController self, int currentCamera)
            => self.field_Private_Int32_0 = currentCamera;


        public static void NextCamera(this CameraController self)
            => self.Method_Private_Void_PDM_37();
    }

    public static class CameraRecoilExtensions
    {
        public static Vector3 get_currentRotation(this CameraRecoil self)
            => self.field_Private_Vector3_0;

        public static void set_currentRotation(this CameraRecoil self, Vector3 currentRotation)
            => self.field_Private_Vector3_0 = currentRotation;
    }

    public static class CameraShakerExtensions
    {
        public static Shaker get_shaker(this CameraShaker self)
            => self.field_Private_Shaker_0;

        public static void set_shaker(this CameraShaker self, Shaker shaker)
            => self.field_Private_Shaker_0 = shaker;
    }

    public static class ChatboxExtensions
    {
        public static Color get_console(this Chatbox self)
            => self.field_Private_Color_0;

        public static void set_console(this Chatbox self, Color console)
            => self.field_Private_Color_0 = console;


        public static int get_maxMsgLength(this Chatbox self)
            => self.field_Private_Int32_0;

        public static void set_maxMsgLength(this Chatbox self, int maxMsgLength)
            => self.field_Private_Int32_0 = maxMsgLength;


        public static int get_maxChars(this Chatbox self)
            => self.field_Private_Int32_1;

        public static void set_maxChars(this Chatbox self, int maxChars)
            => self.field_Private_Int32_1 = maxChars;


        public static int get_purgeAmount(this Chatbox self)
            => self.field_Private_Int32_2;

        public static void set_purgeAmount(this Chatbox self, int purgeAmount)
            => self.field_Private_Int32_2 = purgeAmount;


        public static int get_deobf_maxConsecutiveChars(this Chatbox self)
            => self.field_Private_Int32_3;

        public static void set_deobf_maxConsecutiveChars(this Chatbox self, int deobf_maxConsecutiveChars)
            => self.field_Private_Int32_3 = deobf_maxConsecutiveChars;


        public static List<string> get_profanity(this Chatbox self)
            => self.field_Private_List_1_String_0;

        public static void set_profanity(this Chatbox self, List<string> profanity)
            => self.field_Private_List_1_String_0 = profanity;


        public static string get_deobf_messageContents(this Chatbox self)
            => self.field_Private_String_0;

        public static void set_deobf_messageContents(this Chatbox self, string deobf_messageContents)
            => self.field_Private_String_0 = deobf_messageContents;


        public static string get_deobf_message(this Chatbox self)
            => self.field_Private_String_1;

        public static void set_deobf_message(this Chatbox self, string deobf_message)
            => self.field_Private_String_1 = deobf_message;


        public static string get_deobf_newLine(this Chatbox self)
            => self.field_Private_String_2;

        public static void set_deobf_newLine(this Chatbox self, string deobf_newLine)
            => self.field_Private_String_2 = deobf_newLine;


        public static bool get_backing_typing(this Chatbox self)
            => self.field_Private_Boolean_0;

        public static void set_backing_typing(this Chatbox self, bool backing_typing)
            => self.field_Private_Boolean_0 = backing_typing;


        public static bool get_deobf_ready(this Chatbox self)
            => self.field_Private_Boolean_0;

        public static void set_deobf_ready(this Chatbox self, bool deobf_ready)
            => self.field_Private_Boolean_1 = deobf_ready;


        public static Regex get_deobf_removeMultipleSpaces()
            => Chatbox.field_Private_Static_Regex_0;

        public static void set_deobf_removeMultipleSpaces(Regex deobf_removeMultipleSpaces)
            => Chatbox.field_Private_Static_Regex_0 = deobf_removeMultipleSpaces;
        

        public static bool get_typing(this Chatbox self)
            => self.prop_Boolean_0;

        public static void set_typing(this Chatbox self, bool typing)
            => self.prop_Boolean_0 = typing;


        public static void UserInput(this Chatbox self)
            => self.Method_Private_Void_0();


        public static void ShowChat(this Chatbox self)
            => self.Method_Private_Void_1();


        public static void Deobf_Cooldown(this Chatbox self)
            => self.Method_Private_Void_PDM_38();


        public static void HideChat(this Chatbox self)
            => self.Method_Private_Void_PDM_40();


        public static string TrimMessage(this Chatbox self, string message)
            => self.Method_Private_String_String_0(message);


        public static void ClearMessage(this Chatbox self)
            => self.Method_Private_Void_2();
    }

    public static class CinameticCameraExtensions
    {
        public static Vector3 get_desiredPosition(this CinematicCamera self)
            => self.field_Private_Vector3_0;

        public static void set_desiredPosition(this CinematicCamera self, Vector3 desiredPosition)
            => self.field_Private_Vector3_0 = desiredPosition;


        public static void NewShake(this CinematicCamera self)
            => self.Method_Private_Void_PDM_49();
    }

    public static class CircleRatioUIExtensions
    {
        public static float get_currentValue(this CircleRatioUI self)
            => self.field_Private_Single_0;

        public static void set_currentValue(this CircleRatioUI self, float currentValue)
            => self.field_Private_Single_0 = currentValue;


        public static float get_desiredValue(this CircleRatioUI self)
            => self.field_Private_Single_1;

        public static void set_desiredValue(this CircleRatioUI self, float desiredValue)
            => self.field_Private_Single_1 = desiredValue;


        public static float get_currentValueMax(this CircleRatioUI self)
            => self.field_Private_Single_2;

        public static void set_currentValueMax(this CircleRatioUI self, float currentValueMax)
            => self.field_Private_Single_2 = currentValueMax;


        public static float get_desiredValueMax(this CircleRatioUI self)
            => self.field_Private_Single_3;

        public static void set_desiredValueMax(this CircleRatioUI self, float desiredValueMax)
            => self.field_Private_Single_3 = desiredValueMax;


        public static int get_maxValue(this CircleRatioUI self)
            => self.field_Private_Int32_0;

        public static void set_maxValue(this CircleRatioUI self, int maxValue)
            => self.field_Private_Int32_0 = maxValue;
    }

    public static class ClientExtensions
    {
        public static bool get_activePlayer(this Client self)
            => self.field_Public_Boolean_0;

        public static void set_activePlayer(this Client self, bool activePlayer)
            => self.field_Public_Boolean_0 = activePlayer;


        public static bool get_readyToLoad(this Client self)
            => self.field_Public_Boolean_1;

        public static void set_readyToLoad(this Client self, bool readyToLoad)
            => self.field_Public_Boolean_1 = readyToLoad;


        public static bool get_isLoading(this Client self)
            => self.field_Public_Boolean_2;

        public static void set_isLoading(this Client self, bool isLoading)
            => self.field_Public_Boolean_2 = isLoading;


        public static bool get_vcEnabled(this Client self)
            => self.field_Public_Boolean_3;

        public static void set_vcEnabled(this Client self, bool vcEnabled)
            => self.field_Public_Boolean_3 = vcEnabled;


        public static bool get_kicked(this Client self)
            => self.field_Public_Boolean_4;

        public static void set_kicked(this Client self, bool kicked)
            => self.field_Public_Boolean_4 = kicked;


        public static bool get_punchCooldown(this Client self)
            => self.field_Public_Boolean_5;

        public static void set_punchCooldown(this Client self, bool punchCooldown)
            => self.field_Public_Boolean_5 = punchCooldown;


        public static bool get_deobf_chatCooldown(this Client self)
            => self.field_Public_Boolean_6;

        public static void set_deobf_chatCooldown(this Client self, bool deobf_chatCooldown)
            => self.field_Public_Boolean_6 = deobf_chatCooldown;


        public static bool get_deobf_hasDrip(this Client self)
            => self.field_Public_Boolean_7;

        public static void set_deobf_hasDrip(this Client self, bool deobf_hasDrip)
            => self.field_Public_Boolean_7 = deobf_hasDrip;


        public static int get_ping(this Client self)
            => self.field_Public_Int32_0;

        public static void set_ping(this Client self, int ping)
            => self.field_Public_Int32_0 = ping;


        public static int get_colorId(this Client self)
            => self.field_Public_Int32_1;

        public static void set_colorId(this Client self, int colorId)
            => self.field_Public_Int32_1 = colorId;


        public static int get_money(this Client self)
            => self.field_Public_Int32_2;

        public static void set_money(this Client self, int money)
            => self.field_Public_Int32_2 = money;


        public static int get_deobf_dripLength(this Client self)
            => self.field_Public_Int32_3;

        public static void set_deobf_dripLength(this Client self, int deobf_dripLength)
            => self.field_Public_Int32_3 = deobf_dripLength;


        public static CSteamID get_steamId(this Client self)
            => self.field_Public_CSteamID_0;

        public static void set_steamId(this Client self, CSteamID steamId)
            => self.field_Public_CSteamID_0 = steamId;


        public static ItemData[] get_inventory(this Client self)
            => self.field_Public_ArrayOf_ItemData_0;

        public static void set_inventory(this Client self, ItemData[] inventory)
            => self.field_Public_ArrayOf_ItemData_0 = inventory;


        public static float get_punchCooldownTime(this Client self)
            => self.field_Private_Single_0;

        public static void set_punchCooldownTime(this Client self, float punchCooldownTime)
            => self.field_Private_Single_0 = punchCooldownTime;


        public static float get_deobf_chatCooldownTime(this Client self)
            => self.field_Public_Single_0;

        public static void set_deobf_chatCooldownTime(this Client self, float deobf_chatCooldownTime)
            => self.field_Public_Single_0 = deobf_chatCooldownTime;


        public static byte[] get_deobf_drip(this Client self)
            => self.field_Public_ArrayOf_Byte_0;

        public static void set_deobf_drip(this Client self, byte[] deobf_drip)
            => self.field_Public_ArrayOf_Byte_0 = deobf_drip;


        public static bool Deobf_HasItemById(this Client self, int itemId)
            => self.Method_Public_Boolean_Int32_0(itemId);


        public static void HandleItem(this Client self, ItemPrefab item)
            => self.Method_Public_Void_MonoBehaviour1PublicAbstractItitBoGapiTrrileTrObUnique_1(item);


        public static void Deobf_SetDrip(this Client self, byte[] deobf_drip, int deobf_dripLength)
            => self.Method_Public_Void_ArrayOf_Byte_Int32_0(deobf_drip, deobf_dripLength);


        public static void ResetClient(this Client self)
            => self.Method_Private_Void_PDM_0();


        public static void StartPunchCooldown(this Client self)
            => self.Method_Public_Void_1();


        public static void RemoveItem(this Client self, int objectId)
            => self.Method_Public_Void_Int32_0(objectId);


        public static void AddItem(this Client self, ItemPrefab item)
            => self.Method_Public_Void_MonoBehaviour1PublicAbstractItitBoGapiTrrileTrObUnique_5(item);


        public static void AddAmmo(this Client self, ItemPrefab item)
            => self.Method_Public_Void_MonoBehaviour1PublicAbstractItitBoGapiTrrileTrObUnique_6(item);


        public static bool HasItem(this Client self, int itemId, int objectId)
            => self.Method_Public_Boolean_Int32_Int32_0(itemId, objectId);


        public static void DropInventory(this Client self)
            => self.Method_Public_Void_3();


        public static void Deobf_RemoveItemById(this Client self, int itemId)
            => self.Method_Public_Void_Int32_1(itemId);


        public static void AddItem(this Client self, ItemData item)
            => self.Method_Public_Void_ItemData_2(item);
    }

    public static class ClientHandleExtensions
    {
        public static ulong get_deobf_spectatorId()
            => ClientHandle.field_Private_Static_UInt64_0;

        public static void set_deobf_spectatorId(ulong deobf_spectatorId)
            => ClientHandle.field_Private_Static_UInt64_0 = deobf_spectatorId;


        public static ulong get_deobf_spectatingId()
            => ClientHandle.field_Private_Static_UInt64_1;

        public static void set_deobf_spectatingId(ulong deobf_spectatingId)
            => ClientHandle.field_Private_Static_UInt64_1 = deobf_spectatingId;


        public static ulong get_deobf_clientId()
            => ClientHandle.field_Private_Static_UInt64_2;

        public static void set_deobf_clientId(ulong deobf_clientId)
            => ClientHandle.field_Private_Static_UInt64_2 = deobf_clientId;


        public static int get_deobf_dripLength()
            => ClientHandle.field_Private_Static_Int32_0;

        public static void set_deobf_dripLength(int deobf_dripLength)
            => ClientHandle.field_Private_Static_Int32_0 = deobf_dripLength;


        public static byte[] get_deobf_drip()
            => ClientHandle.field_Private_Static_ArrayOf_Byte_0;

        public static void set_deobf_drip(byte[] deobf_drip)
            => ClientHandle.field_Private_Static_ArrayOf_Byte_0 = deobf_drip;


        public static void ActuallyLoad()
            => ClientHandle.Method_Private_Static_Void_PDM_0();


        public static void LoadWinnerScene()
            => ClientHandle.Method_Private_Static_Void_PDM_2();
    }

    public static class ClientSendExtensions
    {
        public static int get_deobf_reliable()
            => ClientSend.field_Private_Static_Int32_0;

        public static void set_deobf_reliable(int deobf_reliable)
            => ClientSend.field_Private_Static_Int32_0 = deobf_reliable;


        public static int get_deobf_unreliable()
            => ClientSend.field_Private_Static_Int32_1;

        public static void set_deobf_unreliable(int deobf_unreliable)
            => ClientSend.field_Private_Static_Int32_1 = deobf_unreliable;


        public static void SendTCPData(Packet packet)
            => ClientSend.Method_Private_Static_Void_ObjectPublicIDisposableLi1ByInByBoUnique_2(packet);


        public static void SendTCPData(Packet packet, ulong clientId)
            => ClientSend.Method_Private_Static_Void_ObjectPublicIDisposableLi1ByInByBoUnique_UInt64_0(packet, clientId);


        public static void SendUDPData(Packet packet)
            => ClientSend.Method_Private_Static_Void_ObjectPublicIDisposableLi1ByInByBoUnique_1(packet);


        public static void SendUDPData(Packet packet, ulong clientId)
            => ClientSend.Method_Private_Static_Void_ObjectPublicIDisposableLi1ByInByBoUnique_UInt64_1(packet, clientId);
    }

    public static class ControlSettingExtensions
    {
        public static string get_actionName(this ControlSetting self)
            => self.field_Private_String_0;

        public static void set_actionName(this ControlSetting self, string actionName)
            => self.field_Private_String_0 = actionName;


        public static void UpdateSetting(this ControlSetting self)
            => self.Method_Private_Void_0();


        public static string intToKeyCode(this ControlSetting self, int keyCode)
            => self.Method_Private_String_Int32_0(keyCode);
    }

    public static class DamageNumbersExtensions
    {
        public static Vector3 get_desiredPos(this DamageNumbers self)
            => self.field_Private_Vector3_0;

        public static void set_desiredPos(this DamageNumbers self, Vector3 desiredPos)
            => self.field_Private_Vector3_0 = desiredPos;


        public static Vector3 get_shooterPos(this DamageNumbers self)
            => self.field_Private_Vector3_1;

        public static void set_shooterPos(this DamageNumbers self, Vector3 shooterPos)
            => self.field_Private_Vector3_1 = shooterPos;


        public static void StartFade(this DamageNumbers self)
            => self.Method_Private_Void_PDM_13();
    }

    public static class DebugNetExtensions
    {
        public static bool get_fpsOn(this DebugNet self)
            => self.field_Private_Boolean_0;

        public static void set_fpsOn(this DebugNet self, bool fpsOn)
            => self.field_Private_Boolean_0 = fpsOn;


        public static bool get_speedOn(this DebugNet self)
            => self.field_Private_Boolean_1;

        public static void set_speedOn(this DebugNet self, bool speedOn)
            => self.field_Private_Boolean_1 = speedOn;


        public static bool get_pingOn(this DebugNet self)
            => self.field_Private_Boolean_2;

        public static void set_pingOn(this DebugNet self, bool pingOn)
            => self.field_Private_Boolean_2 = pingOn;


        public static bool get_bandwidthOn(this DebugNet self)
            => self.field_Private_Boolean_3;

        public static void set_bandwidthOn(this DebugNet self, bool bandwidthOn)
            => self.field_Private_Boolean_3 = bandwidthOn;


        public static float get_deltaTime(this DebugNet self)
            => self.field_Private_Single_0;

        public static void set_deltaTime(this DebugNet self, float deltaTime)
            => self.field_Private_Single_0 = deltaTime;


        public static float get_byteUp(this DebugNet self)
            => self.field_Private_Single_1;

        public static void set_byteUp(this DebugNet self, float byteUp)
            => self.field_Private_Single_1 = byteUp;


        public static float get_byteDown(this DebugNet self)
            => self.field_Private_Single_2;

        public static void set_byteDown(this DebugNet self, float byteDown)
            => self.field_Private_Single_2 = byteDown;


        public static float get_pSent(this DebugNet self)
            => self.field_Private_Single_3;

        public static void set_pSent(this DebugNet self, float pSent)
            => self.field_Private_Single_3 = pSent;


        public static float get_pReceived(this DebugNet self)
            => self.field_Private_Single_4;

        public static void set_pReceived(this DebugNet self, float pReceived)
            => self.field_Private_Single_4 = pReceived;


        public static void Fps(this DebugNet self)
            => self.Method_Private_Void_0();


        public static void Bandwidth(this DebugNet self)
            => self.Method_Private_Void_PDM_45();
    }

    public static class DecalsExtensions
    {
        public static List<MeshRenderer> get_decalPool(this Decals self)
            => self.field_Private_List_1_MeshRenderer_0;

        public static void set_decalPool(this Decals self, List<MeshRenderer> decalPool)
            => self.field_Private_List_1_MeshRenderer_0 = decalPool;


        public static int get_index(this Decals self)
            => self.field_Private_Int32_0;

        public static void set_index(this Decals self, int index)
            => self.field_Private_Int32_0 = index;


        public static int get_maxSize(this Decals self)
            => self.field_Private_Int32_1;

        public static void set_maxSize(this Decals self, int maxSize)
            => self.field_Private_Int32_1 = maxSize;
    }

    public static class DestroyObjectExtensions
    {
        public static void DestroySelf(this DestroyObject self)
            => self.Method_Private_Void_PDM_3();
    }

    public static class DetectItemsExtensions
    {
        public static void RemoveHighlight(this DetectItems self)
            => self.Method_Private_Void_PDM_3();


        public static void AddHighlight(this DetectItems self, GameObject gameObject)
            => self.Method_Private_Void_GameObject_PDM_11(gameObject);


        public static void CheckHighlight(this DetectItems self, GameObject gameObject)
            => self.Method_Private_Void_GameObject_PDM_20(gameObject);


        public static void CheckForItems(this DetectItems self)
            => self.Method_Private_Void_PDM_85();
    }

    public static class DiffuseAudioExtensions
    {
        public static float get_backing_defaultVolume(this DiffuseAudio self)
            => self.field_Private_Single_0;

        public static void set_backing_defaultVolume(this DiffuseAudio self, float backing_defaultVolume)
            => self.field_Private_Single_0 = backing_defaultVolume;


        public static float get_multiplier(this DiffuseAudio self)
            => self.field_Private_Single_1;

        public static void set_multiplier(this DiffuseAudio self, float multiplier)
            => self.field_Private_Single_1 = multiplier;


        public static float get_defaultHz(this DiffuseAudio self)
            => self.field_Private_Single_2;

        public static void set_defaultHz(this DiffuseAudio self, float defaultHz)
            => self.field_Private_Single_2 = defaultHz;


        public static float get_volumeMultiplier(this DiffuseAudio self)
            => self.field_Private_Single_3;

        public static void set_volumeMultiplier(this DiffuseAudio self, float volumeMultiplier)
            => self.field_Private_Single_3 = volumeMultiplier;


        public static float get_filterMultiplier(this DiffuseAudio self)
            => self.field_Private_Single_4;

        public static void set_filterMultiplier(this DiffuseAudio self, float filterMultiplier)
            => self.field_Private_Single_4 = filterMultiplier;


        public static float get_defaultVolume(this DiffuseAudio self)
            => self.prop_Single_0;

        public static void set_defaultVolume(this DiffuseAudio self, float defaultVolume)
            => self.prop_Single_0 = defaultVolume;
    }

    public static class DisplayNameUIExtensions
    {
        public static bool get_hidden(this DisplayNameUI self)
            => self.field_Private_Boolean_0;

        public static void set_hidden(this DisplayNameUI self, bool hidden)
            => self.field_Private_Boolean_0 = hidden;
    }

    public static class DissonanceManagerExtensions
    {
        public static void OnPlayerJoined(this DissonanceManager self, ObjectPublicAbstractObStAc12ObAc1BoStUnique player)
            => self.Method_Private_Void_ObjectPublicAbstractObStAc12ObAc1BoStUnique_4(player);
    }
    
    public static class DissonancePlayerExtensions
    {
        public static bool get_isTracking(this DissonancePlayer self)
            => self.field_Private_Boolean_0;

        public static void set_isTracking(this DissonancePlayer self, bool isTracking)
            => self.field_Private_Boolean_0 = isTracking;


        public static bool get_isLocal(this DissonancePlayer self)
            => self.field_Private_Boolean_1;

        public static void set_isLocal(this DissonancePlayer self, bool isLocal)
            => self.field_Private_Boolean_1 = isLocal;


        public static string get_playerId(this DissonancePlayer self)
            => self.field_Private_String_0;

        public static void set_playerId(this DissonancePlayer self, string playerId)
            => self.field_Private_String_0 = playerId;


        public static MonoBehaviourPublicSealedObSt_lBo_iObStBoSi_iUnique get_comms(this DissonancePlayer self)
            => self.field_Private_MonoBehaviourPublicSealedObSt_lBo_iObStBoSi_iUnique_0;

        public static void set_comms(this DissonancePlayer self, MonoBehaviourPublicSealedObSt_lBo_iObStBoSi_iUnique comms)
            => self.field_Private_MonoBehaviourPublicSealedObSt_lBo_iObStBoSi_iUnique_0 = comms;


        public static float get_maxRadius(this DissonancePlayer self)
            => self.field_Private_Single_0;

        public static void set_maxRadius(this DissonancePlayer self, float maxRadius)
            => self.field_Private_Single_0 = maxRadius;


        public static float get_minRadius(this DissonancePlayer self)
            => self.field_Private_Single_1;

        public static void set_minRadius(this DissonancePlayer self, float minRadius)
            => self.field_Private_Single_1 = minRadius;


        public static int get_maxPlayers(this DissonancePlayer self)
            => self.field_Private_Int32_0;

        public static void set_maxPlayers(this DissonancePlayer self, int maxPlayers)
            => self.field_Private_Int32_0 = maxPlayers;


        public static int get_minPlayers(this DissonancePlayer self)
            => self.field_Private_Int32_1;

        public static void set_minPlayers(this DissonancePlayer self, int minPlayers)
            => self.field_Private_Int32_1 = minPlayers;


        public static int get_currentPlayers(this DissonancePlayer self)
            => self.field_Private_Int32_2;

        public static void set_currentPlayers(this DissonancePlayer self, int currentPlayers)
            => self.field_Private_Int32_2 = currentPlayers;


        public static bool get_IsTracking(this DissonancePlayer self)
            => self.prop_Boolean_0;


        public static string get_PlayerId(this DissonancePlayer self)
            => self.prop_String_0;


        public static Vector3 get_Position(this DissonancePlayer self)
            => self.prop_Vector3_0;


        public static Quaternion get_Rotation(this DissonancePlayer self)
            => self.prop_Quaternion_0;


        public static EnumPublicSealedvaUnLoRe4vUnique get_Type(this DissonancePlayer self)
            => self.prop_EnumPublicSealedvaUnLoRe4vUnique_0;


        public static void SetSphereRadius(this DissonancePlayer self)
            => self.Method_Private_Void_PDM_9();
    }

    public static class DropdownSettingExtensions
    {
        public static Resolution[] get_resolutions(this DropdownSetting self)
            => self.field_Private_ArrayOf_Resolution_0;

        public static void set_resolutions(this DropdownSetting self, Resolution[] resolutions)
            => self.field_Private_ArrayOf_Resolution_0 = resolutions;


        public static void UpdateSetting(this DropdownSetting self)
            => self.Method_Private_Void_6();
    }

    public static class EffectManagerExtensions
    {
        public static void Deobf_DetectModding(this EffectManager self, GameObject gameObject, bool unusedBool, Vector3 unusedVector3, Quaternion unusedQuaternion)
            => self.Method_Private_Void_GameObject_Boolean_Vector3_Quaternion_0(gameObject, unusedBool, unusedVector3, unusedQuaternion);
    }

    public static class EnableAudioExtensions
    {
        public static void Activate(this EnableAudio self)
            => self.Method_Private_Void_PDM_38();
    }

    public static class EnableDepthBufferExtensions
    {
        public static Camera get_m_camera(this EnableDepthBuffer self)
            => self.field_Private_Camera_0;

        public static void set_m_camera(this EnableDepthBuffer self, Camera m_camera)
            => self.field_Private_Camera_0 = m_camera;
    }

    public static class ExplodePlayerExtensions
    {
        public static float get_force(this ExplodePlayer self)
            => self.field_Private_Single_0;

        public static void set_force(this ExplodePlayer self, float force)
            => self.field_Private_Single_0 = force;
    }

    public static class FollowTargetExtensions
    {
        public static Vector3 get_offset(this FollowTarget self)
            => self.field_Private_Vector3_0;

        public static void set_offset(this FollowTarget self, Vector3 offset)
            => self.field_Private_Vector3_0 = offset;
    }

    public static class FootStepExtensions
    {
        public static void FindGroundType(this FootStep self)
            => self.Method_Private_Void_0();
    }

    public static class FootstepOnTouchExtensions
    {
        public static bool get_ready(this FootstepOnTouch self)
            => self.field_Private_Boolean_0;

        public static void set_ready(this FootstepOnTouch self, bool ready)
            => self.field_Private_Boolean_0 = ready;


        public static float get_cooldown(this FootstepOnTouch self)
            => self.field_Private_Single_0;

        public static void set_cooldown(this FootstepOnTouch self, float cooldown)
            => self.field_Private_Single_0 = cooldown;
    }

    public static class GameAudioExtensions
    {
        public static bool get_firstTick(this GameAudio self)
            => self.field_Private_Boolean_0;

        public static void set_firstTick(this GameAudio self, bool firstTick)
            => self.field_Private_Boolean_0 = firstTick;
    }

    public static class GameLoopExtensions
    {
        public static Il2CppSystem.Random get_random(this GameLoop self)
            => self.field_Private_Random_0;

        public static void set_random(this GameLoop self, Il2CppSystem.Random random)
            => self.field_Private_Random_0 = random;


        public static int get_backing_currentMapIndex(this GameLoop self)
            => self.field_Private_Int32_0;

        public static void set_backing_currentMapIndex(this GameLoop self, int backing_currentMapIndex)
            => self.field_Private_Int32_0 = backing_currentMapIndex;


        public static int get_backing_currentModeIndex(this GameLoop self)
            => self.field_Private_Int32_1;

        public static void set_backing_currentModeIndex(this GameLoop self, int backing_currentModeIndex)
            => self.field_Private_Int32_1 = backing_currentModeIndex;


        public static int get_currentMapIndex(this GameLoop self)
            => self.prop_Int32_0;

        public static void set_currentMapIndex(this GameLoop self, int currentMapIndex)
            => self.prop_Int32_0 = currentMapIndex;


        public static int get_currentModeIndex(this GameLoop self)
            => self.prop_Int32_1;

        public static void set_currentModeIndex(this GameLoop self, int currentModeIndex)
            => self.prop_Int32_1 = currentModeIndex;


        public static void CheckDeadPlayers(this GameLoop self)
            => self.Method_Private_Void_0();


        public static void ResetGameModesList(this GameLoop self)
            => self.Method_Private_Void_1();


        public static void ResetReadyToJoin(this GameLoop self)
            => self.Method_Private_Void_2();


        public static ulong FindWinnerId(this GameLoop self)
            => self.Method_Private_UInt64_0();
    }

    public static class GameManagerExtensions
    {
        public static GameObject get_spectatorObject(this GameManager self)
            => self.field_Private_GameObject_0;

        public static void set_spectatorObject(this GameManager self, GameObject spectatorObject)
            => self.field_Private_GameObject_0 = spectatorObject;


        public static ulong get_deobf_clientId(this GameManager self)
            => self.field_Private_UInt64_0;

        public static void set_deobf_clientId(this GameManager self, ulong deobf_clientId)
            => self.field_Private_UInt64_0 = deobf_clientId;


        public static Vector3 get_deobf_position(this GameManager self)
            => self.field_Private_Vector3_0;

        public static void set_deobf_position(this GameManager self, Vector3 deobf_position)
            => self.field_Private_Vector3_0 = deobf_position;


        public static float get_deobf_rotationX(this GameManager self)
            => self.field_Private_Single_0;

        public static void set_deobf_rotationX(this GameManager self, float deobf_rotationX)
            => self.field_Private_Single_0 = deobf_rotationX;


        public static float get_deobf_rotationY(this GameManager self)
            => self.field_Private_Single_1;

        public static void set_deobf_rotationY(this GameManager self, float deobf_rotationY)
            => self.field_Private_Single_1 = deobf_rotationY;


        public static OnlinePlayerMovement_PlayerAnimation get_deobf_playerAnimation(this GameManager self)
            => self.field_Private_EnumNPublicSealedvaCrMe3vUnique_0;

        public static void set_deobf_playerAnimation(this GameManager self, OnlinePlayerMovement_PlayerAnimation deobf_playerAnimation)
            => self.field_Private_EnumNPublicSealedvaCrMe3vUnique_0 = deobf_playerAnimation;


        public static bool get_deobf_crouchState(this GameManager self)
            => self.field_Private_Boolean_0;

        public static void set_deobf_crouchState(this GameManager self, bool deobf_crouchState)
            => self.field_Private_Boolean_0 = deobf_crouchState;


        public static int get_deobf_playersAlive(this GameManager self)
            => self.field_Private_Int32_0;

        public static void set_deobf_playersAlive(this GameManager self, int deobf_playersAlive)
            => self.field_Private_Int32_0 = deobf_playersAlive;


        public static void RequestSpawn(this GameManager self)
            => self.Method_Private_Void_0();


        public static void OnPlayerSpawnOrDespawn(this GameManager self, ulong clientId)
            => self.Method_Private_Void_UInt64_PDM_1(clientId);


        /**
         * <summary>This is a Coroutine: <see cref="GameManager.ObjectNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpmObSistObObUnique"/></summary>
         */
        public static IEnumerator StopPlayerVoip(this GameManager self, PlayerManager playerManager, float speakAfterDeathTime)
            => self.Method_Private_IEnumerator_MonoBehaviourPublicCSstReshTrheObplBojuUnique_Single_0(playerManager, speakAfterDeathTime);
    }

    public static class GameModeExtensions
    {
        public static void UpdateTimer(this GameMode self)
            => self.Method_Private_Void_PDM_0();


        public static void StartRound(this GameMode self)
            => self.Method_Private_Void_0();


        public static void StartMusic(this GameMode self)
            => self.Method_Private_Void_PDM_1();


        public static void UpdateMusic(this GameMode self)
            => self.Method_Private_Void_PDM_2();


        public static void EndMusic(this GameMode self)
            => self.Method_Protected_Void_0();
    }

    public static class GameModeBombTagExtensions
    {
        public static int get_bombsLeft(this GameModeBombTag self)
            => self.field_Private_Int32_0;

        public static void set_bombsLeft(this GameModeBombTag self, int bombsLeft)
            => self.field_Private_Int32_0 = bombsLeft;


        public static float get_intervalTime(this GameModeBombTag self)
            => self.field_Private_Single_0;

        public static void set_intervalTime(this GameModeBombTag self, float intervalTime)
            => self.field_Private_Single_0 = intervalTime;


        public static float get_fuseTime(this GameModeBombTag self)
            => self.field_Private_Single_1;

        public static void set_fuseTime(this GameModeBombTag self, float fuseTime)
            => self.field_Private_Single_1 = fuseTime;


        public static int get_maxBombs(this GameModeBombTag self)
            => self.field_Private_Int32_1;

        public static void set_maxBombs(this GameModeBombTag self, int maxBombs)
            => self.field_Private_Int32_1 = maxBombs;


        public static List<ulong> get_taggedPlayers(this GameModeBombTag self)
            => self.field_Private_List_1_UInt64_0;

        public static void set_taggedPlayers(this GameModeBombTag self, List<ulong> taggedPlayers)
            => self.field_Private_List_1_UInt64_0 = taggedPlayers;


        public static MyTimer get_bombTimer(this GameModeBombTag self)
            => self.field_Private_ObjectPublicSiBoSiSiSiUnique_0;

        public static void set_bombTimer(this GameModeBombTag self, MyTimer bombTimer)
            => self.field_Private_ObjectPublicSiBoSiSiSiUnique_0 = bombTimer;


        public static bool get_showedAlert(this GameModeBombTag self)
            => self.field_Private_Boolean_0;

        public static void set_showedAlert(this GameModeBombTag self, bool showedAlert)
            => self.field_Private_Boolean_0 = showedAlert;


        public static List<ulong> GetAllAlivePlayers(this GameModeBombTag self)
            => self.Method_Private_List_1_UInt64_2();


        public static void ExplodeBomb(this GameModeBombTag self)
            => self.Method_Private_Void_4();


        public static void SendTagPlayer(this GameModeBombTag self, ulong bomberClientId, ulong taggedClientId)
            => self.Method_Private_Void_UInt64_UInt64_4(bomberClientId, taggedClientId);


        public static void SelectBomber(this GameModeBombTag self)
            => self.Method_Private_Void_5();
    }

    public static class GameModeButtonsExtensions
    {
        public static int get_dangerousButton(this GameModeButtons self)
            => self.field_Private_Int32_0;

        public static void set_dangerousButton(this GameModeButtons self, int dangerousButton)
            => self.field_Private_Int32_0 = dangerousButton;


        public static float get_maxModeTime(this GameModeButtons self)
            => self.field_Private_Single_0;

        public static void set_maxModeTime(this GameModeButtons self, float maxModeTime)
            => self.field_Private_Single_0 = maxModeTime;


        public static float get_timeToPressButton(this GameModeButtons self)
            => self.field_Private_Single_1;

        public static void set_timeToPressButton(this GameModeButtons self, float timeToPressButton)
            => self.field_Private_Single_1 = timeToPressButton;


        public static float get_timeToGetOffStage(this GameModeButtons self)
            => self.field_Private_Single_2;

        public static void set_timeToGetOffStage(this GameModeButtons self, float timeToGetOffStage)
            => self.field_Private_Single_2 = timeToGetOffStage;


        public static float get_timeToRevealExplosion(this GameModeButtons self)
            => self.field_Private_Single_3;

        public static void set_timeToRevealExplosion(this GameModeButtons self, float timeToRevealExplosion)
            => self.field_Private_Single_3 = timeToRevealExplosion;


        public static int get_desiredPlayersLeft(this GameModeButtons self)
            => self.field_Private_Int32_1;

        public static void set_desiredPlayersLeft(this GameModeButtons self, int desiredPlayersLeft)
            => self.field_Private_Int32_1 = desiredPlayersLeft;


        public static bool get_canPressButton(this GameModeButtons self)
            => self.field_Private_Boolean_0;

        public static void set_currentButtonPresser(this GameModeButtons self, bool canPressButton)
            => self.field_Private_Boolean_0 = canPressButton;


        public static int get_lastTick(this GameModeButtons self)
            => self.field_Private_Int32_2;

        public static void set_lastTick(this GameModeButtons self, int lastTick)
            => self.field_Private_Int32_2 = lastTick;


        public static Il2CppSystem.Random get_random(this GameModeButtons self)
            => self.field_Private_Random_0;

        public static void set_random(this GameModeButtons self, Il2CppSystem.Random random)
            => self.field_Private_Random_0 = random;


        public static float get_killRatio(this GameModeButtons self)
            => self.field_Private_Single_4;

        public static void set_killRatio(this GameModeButtons self, float killRatio)
            => self.field_Private_Single_4 = killRatio;


        public static void IncrementPlayerIndex(this GameModeButtons self)
            => self.Method_Private_Void_PDM_1();


        public static void UpdatePlayerOrder(this GameModeButtons self)
            => self.Method_Private_Void_PDM_5();


        public static void Unfreeze(this GameModeButtons self)
            => self.Method_Private_Void_PDM_11();


        public static void FindNextPlayer(this GameModeButtons self)
            => self.Method_Private_Void_PDM_12();


        /**
         * <summary>This is a Coroutine: <see cref="GameModeButtons.ObjectNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObbuObInUIplObObUnique"/></summary>
         */
        public static IEnumerator RevealButton(this GameModeButtons self, ulong clientId, int buttonId)
            => self.Method_Private_IEnumerator_UInt64_Int32_PDM_3(clientId, buttonId);


        public static void FindPlayersToKill(this GameModeButtons self)
            => self.Method_Private_Void_1();


        public static void InvokeFindNextPlayer(this GameModeButtons self, bool increment)
            => self.Method_Private_Void_Boolean_PDM_2(increment);


        public static List<ulong> GetAllAlivePlayers(this GameModeButtons self)
            => self.Method_Private_List_1_UInt64_1();
    }

    public static class GameModeDataExtensions
    {
        public static int GetModeTime(this GameModeData self, int players)
            => self.Method_Public_Int32_Int32_PDM_1(players);


        public static Map GetMap(this GameModeData self, int players)
            => self.Method_Public_Map_Int32_0(players);


        public static bool CanPlay(this GameModeData self, int players)
            => self.Method_Public_Boolean_Int32_1(players);


        public static Type GameModeScript(this GameModeData self)
            => self.Method_Public_Type_0();


        public static List<Map> GetCompatibleMaps(this GameModeData self, List<Map_MapSize> mapSizes)
            => self.Method_Private_List_1_Map_List_1_EnumNPublicSealedvasmmelaan5vUnique_0(mapSizes);
    }

    public static class GameModeFallingPlatformsExtensions
    {
        public static int get_totalPieces(this GameModeFallingPlatforms self)
            => self.field_Private_Int32_0;

        public static void set_totalPieces(this GameModeFallingPlatforms self, int totalPieces)
            => self.field_Private_Int32_0 = totalPieces;


        public static int get_endPieces(this GameModeFallingPlatforms self)
            => self.field_Private_Int32_1;

        public static void set_endPieces(this GameModeFallingPlatforms self, int endPieces)
            => self.field_Private_Int32_1 = endPieces;


        public static int get_currentlyFallen(this GameModeFallingPlatforms self)
            => self.field_Private_Int32_2;

        public static void set_currentlyFallen(this GameModeFallingPlatforms self, int currentlyFallen)
            => self.field_Private_Int32_2 = currentlyFallen;


        public static int get_fallPieces(this GameModeFallingPlatforms self)
            => self.field_Private_Int32_3;

        public static void set_fallPieces(this GameModeFallingPlatforms self, int fallPieces)
            => self.field_Private_Int32_3 = fallPieces;


        public static float get_fallInterval(this GameModeFallingPlatforms self)
            => self.field_Private_Single_0;

        public static void set_fallInterval(this GameModeFallingPlatforms self, float fallInterval)
            => self.field_Private_Single_0 = fallInterval;


        public static float get_piecesRatio(this GameModeFallingPlatforms self)
            => self.field_Private_Single_1;

        public static void set_piecesRatio(this GameModeFallingPlatforms self, float piecesRatio)
            => self.field_Private_Single_1 = piecesRatio;


        public static void SendFallPiece(this GameModeFallingPlatforms self)
            => self.Method_Private_Void_PDM_11();
    }

    public static class GameModeGlassExtensions
    {
        public static List<int> get_deobf_realPieces(this GameModeGlass self)
            => self.field_Private_List_1_Int32_0;

        public static void set_deobf_realPieces(this GameModeGlass self, List<int> deobf_realPieces)
            => self.field_Private_List_1_Int32_0 = deobf_realPieces;


        public static List<int> get_deobf_realPiecesList(this GameModeGlass self)
            => self.field_Private_List_1_Int32_1;

        public static void set_deobf_realPiecesList(this GameModeGlass self, List<int> deobf_realPiecesList)
            => self.field_Private_List_1_Int32_1 = deobf_realPiecesList;


        public static List<int> GetRealPieces(this GameModeGlass self)
            => self.Method_Private_List_1_Int32_3();
    }

    public static class GameModeHatExtensions
    {
        public static float get_scoreUpdateRate(this GameModeHat self)
            => self.field_Private_Single_0;

        public static void set_scoreUpdateRate(this GameModeHat self, float scoreUpdateRate)
            => self.field_Private_Single_0 = scoreUpdateRate;


        public static float get_sendScoreUpdateRate(this GameModeHat self)
            => self.field_Private_Single_1;

        public static void set_sendScoreUpdateRate(this GameModeHat self, float sendScoreUpdateRate)
            => self.field_Private_Single_1 = sendScoreUpdateRate;


        public static List<ulong> get_deobf_playersToEliminate(this GameModeHat self)
            => self.field_Private_List_1_UInt64_0;

        public static void set_deobf_playersToEliminate(this GameModeHat self, List<ulong> deobf_playersToEliminate)
            => self.field_Private_List_1_UInt64_0 = deobf_playersToEliminate;


        public static void SendTagPlayer(this GameModeHat self, ulong giveClientId, ulong takeClientId)
            => self.Method_Private_Void_UInt64_UInt64_PDM_1(giveClientId, takeClientId);


        public static void ScoreUpdate(this GameModeHat self)
            => self.Method_Private_Void_PDM_6();


        public static void UpdateHat(this GameModeHat self, bool hasHat)
            => self.Method_Private_Void_Boolean_PDM_2(hasHat);


        public static void SendScoreUpdate(this GameModeHat self)
            => self.Method_Private_Void_PDM_15();


        public static List<ulong> GetAllAlivePlayers(this GameModeHat self)
            => self.Method_Private_List_1_UInt64_1();
    }
    
    public static class GameModeHnSExtensions
    {
        public static List<ulong> GetAllAlivePlayers(this GameModeHnS self)
            => self.Method_Private_List_1_UInt64_0();


        public static void SendSeekerPlayer(this GameModeHnS self, ulong clientId, bool seeker)
            => self.Method_Private_Void_UInt64_Boolean_0(clientId, seeker);


        public static void Deobf_Unfreeze(this GameModeHnS self)
            => self.Method_Private_Void_PDM_3();
    }

    public static class GameModeKingExtensions
    {
        public static float get_scoreUpdateRate(this GameModeKing self)
            => self.field_Private_Single_0;

        public static void set_scoreUpdateRate(this GameModeKing self, float scoreUpdateRate)
            => self.field_Private_Single_0 = scoreUpdateRate;


        public static float get_sendScoreUpdateRate(this GameModeKing self)
            => self.field_Private_Single_1;

        public static void set_sendScoreUpdateRate(this GameModeKing self, float sendScoreUpdateRate)
            => self.field_Private_Single_1 = sendScoreUpdateRate;


        public static List<ulong> get_deobf_playersToEliminate(this GameModeKing self)
            => self.field_Private_List_1_UInt64_0;

        public static void set_deobf_playersToEliminate(this GameModeKing self, List<ulong> deobf_playersToEliminate)
            => self.field_Private_List_1_UInt64_0 = deobf_playersToEliminate;


        public static void SendScoreUpdate(this GameModeKing self)
            => self.Method_Private_Void_1();


        public static void ScoreUpdate(this GameModeKing self)
            => self.Method_Private_Void_PDM_7();
    }

    public static class GameModeLightsExtensions
    {
        public static bool get_lightsOut(this GameModeLights self)
            => self.field_Private_Boolean_0;

        public static void set_lightsOut(this GameModeLights self, bool lightsOut)
            => self.field_Private_Boolean_0 = lightsOut;


        public static string[] get_weapons(this GameModeLights self)
            => self.field_Private_ArrayOf_0;

        public static void set_weapons(this GameModeLights self, string[] weapons)
            => self.field_Private_ArrayOf_0 = weapons;


        public static bool get_firstToggle(this GameModeLights self)
            => self.field_Private_Boolean_1;

        public static void set_firstToggle(this GameModeLights self, bool firstToggle)
            => self.field_Private_Boolean_1 = firstToggle;


        public static void StrobeOff(this GameModeLights self)
            => self.Method_Private_Void_PDM_1();


        public static void SendLightsOut(this GameModeLights self)
            => self.Method_Private_Void_PDM_41();
    }
    
    public static class GameModeRaceExtensions
    {
        public static void FindQualifiers(this GameModeRace self, int players)
            => self.Method_Private_Void_Int32_0(players);
    }

    public static class GameModeRedLightExtensions
    {
        public static float get_serverReactionTime(this GameModeRedLight self)
            => self.field_Private_Single_0;

        public static void set_serverReactionTime(this GameModeRedLight self, float serverReactionTime)
            => self.field_Private_Single_0 = serverReactionTime;


        public static bool get_redLightActive(this GameModeRedLight self)
            => self.field_Private_Boolean_0;

        public static void set_redLightActive(this GameModeRedLight self, bool redLightActive)
            => self.field_Private_Boolean_0 = redLightActive;


        public static Dictionary<ulong, GameModeRedLight_SnapShot> get_freezePositions(this GameModeRedLight self)
            => self.field_Private_Dictionary_2_UInt64_ObjectNPrivateVeQuUnique_0;

        public static void set_freezePositions(this GameModeRedLight self, Dictionary<ulong, GameModeRedLight_SnapShot> freezePositions)
            => self.field_Private_Dictionary_2_UInt64_ObjectNPrivateVeQuUnique_0 = freezePositions;


        public static float get_minReactionTime(this GameModeRedLight self)
            => self.field_Private_Single_1;

        public static void set_minReactionTime(this GameModeRedLight self, float minReactionTime)
            => self.field_Private_Single_1 = minReactionTime;


        public static float get_maxReactionTime(this GameModeRedLight self)
            => self.field_Private_Single_2;

        public static void set_maxReactionTime(this GameModeRedLight self, float maxReactionTime)
            => self.field_Private_Single_2 = maxReactionTime;


        public static float get_reductionTime(this GameModeRedLight self)
            => self.field_Private_Single_3;

        public static void set_reductionTime(this GameModeRedLight self, float reductionTime)
            => self.field_Private_Single_3 = reductionTime;


        public static void ActivateRedLight(this GameModeRedLight self)
            => self.Method_Private_Void_PDM_2();


        /**
         * <summary>This is a Coroutine: <see cref="GameModeRedLight.ObjectNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiUIpIObObObUnique"/></summary>
         */
        public static IEnumerator SendRedLight(this GameModeRedLight self, float delay, ulong clientId)
            => self.Method_Private_IEnumerator_Single_UInt64_1(delay, clientId);



        public static float FindNextTime(this GameModeRedLight self)
            => self.Method_Private_Single_PDM_1();


        public static void InvokeStopRedLight(this GameModeRedLight self)
            => self.Method_Private_Void_1();


        public static void InvokeRedLight(this GameModeRedLight self)
            => self.Method_Private_Void_3();


        public static void SendGreenLight(this GameModeRedLight self)
            => self.Method_Private_Void_5();


        public static bool CanSeePlayer(this GameModeRedLight self, ulong clientId)
            => self.Method_Private_Boolean_UInt64_0(clientId);


        public static void ExplodePlayer(this GameModeRedLight self, PlayerManager playerManager)
            => self.Method_Private_Void_MonoBehaviourPublicCSstReshTrheObplBojuUnique_0(playerManager);
    }

    public static class GameModeRedLight_SnapShotExtensions
    {
        public static Vector3 get_position(this GameModeRedLight_SnapShot self)
            => self.field_Public_Vector3_0;

        public static void set_position(this GameModeRedLight_SnapShot self, Vector3 position)
            => self.field_Public_Vector3_0 = position;


        public static Quaternion get_rotation(this GameModeRedLight_SnapShot self)
            => self.field_Public_Quaternion_0;

        public static void set_rotation(this GameModeRedLight_SnapShot self, Quaternion rotation)
            => self.field_Public_Quaternion_0 = rotation;
    }

    public static class GameModeTagExtensions
    {
        public static List<ulong> get_taggedPlayers(this GameModeTag self)
            => self.field_Private_List_1_UInt64_0;

        public static void set_taggedPlayers(this GameModeTag self, List<ulong> taggedPlayers)
            => self.field_Private_List_1_UInt64_0 = taggedPlayers;


        public static List<ulong> GetAllAlivePlayers(this GameModeTag self)
            => self.Method_Private_List_1_UInt64_0();


        public static void SendTagPlayer(this GameModeTag self, ulong taggerId, ulong taggedId)
            => self.Method_Private_Void_UInt64_UInt64_0(taggerId, taggedId);
    }

    public static class GameModeTileDriveExtensions
    {
        public static List<ulong> GetAllAlivePlayers(this GameModeTileDrive self)
            => self.Method_Private_List_1_UInt64_0();
    }

    public static class GameModeTimerExtensions
    {
        public static string get_emptyCountdown(this GameModeTimer self)
            => self.field_Private_String_0;

        public static void set_emptyCountdown(this GameModeTimer self, string emptyCountdown)
            => self.field_Private_String_0 = emptyCountdown;


        public static string get_fullCountdown(this GameModeTimer self)
            => self.field_Private_String_1;

        public static void set_fullCountdown(this GameModeTimer self, string fullCountdown)
            => self.field_Private_String_1 = fullCountdown;


        public static float get_deobf_freezeTime(this GameModeTimer self)
            => self.field_Private_Single_0;

        public static void set_deobf_freezeTime(this GameModeTimer self, float deobf_freezeTime)
            => self.field_Private_Single_0 = deobf_freezeTime;


        public static TimeSpan get_deobf_timeSpan(this GameModeTimer self)
            => self.field_Private_TimeSpan_0;

        public static void set_deobf_timeSpan(this GameModeTimer self, TimeSpan deobf_timeSpan)
            => self.field_Private_TimeSpan_0 = deobf_timeSpan;
    }

    public static class GameModeWaitingExtensions
    {
        public static int FindReadyPlayers(this GameModeWaiting self)
            => self.Method_Private_Int32_0();

        public static void TimerDone(this GameModeWaiting self)
            => self.Method_Private_Void_0();
    }

    public static class GameServerExtensions
    {
        /**
         * <summary>This is a Coroutine: <see cref="GameServer.ObjectNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSireUIplObObUnique"/></summary>
         */
        public static IEnumerator RespawnPlayer(this GameServer self, ulong clientId, float time)
            => self.Method_Private_IEnumerator_UInt64_Single_PDM_0(clientId, time);
    }

    public static class GameSettingsExtensions
    {
        public static GameSettings_LobbyType get_lobbyType(this GameSettings self)
            => self.field_Public_EnumNPublicSealedvaLoFrPu4vUnique_0;

        public static void set_lobbyType(this GameSettings self, GameSettings_LobbyType lobbyType)
            => self.field_Public_EnumNPublicSealedvaLoFrPu4vUnique_0 = lobbyType;


        public static int get_nRounds(this GameSettings self)
            => self.field_Public_Int32_0;

        public static void set_nRounds(this GameSettings self, int nRounds)
            => self.field_Public_Int32_0 = nRounds;


        public static int get_joinableInGame(this GameSettings self)
            => self.field_Public_Int32_1;

        public static void set_joinableInGame(this GameSettings self, int joinableInGame)
            => self.field_Public_Int32_1 = joinableInGame;


        public static int get_mapIndex(this GameSettings self)
            => self.field_Public_Int32_2;

        public static void set_mapIndex(this GameSettings self, int mapIndex)
            => self.field_Public_Int32_2 = mapIndex;


        public static int get_proximityChat(this GameSettings self)
            => self.field_Public_Int32_3;

        public static void set_proximityChat(this GameSettings self, int proximityChat)
            => self.field_Public_Int32_3 = proximityChat;


        public static int get_maxPlayers(this GameSettings self)
            => self.field_Public_Int32_4;

        public static void set_maxPlayers(this GameSettings self, int maxPlayers)
            => self.field_Public_Int32_4 = maxPlayers;


        public static ulong get_mapId(this GameSettings self)
            => self.field_Public_UInt64_0;

        public static void set_mapId(this GameSettings self, ulong mapId)
            => self.field_Public_UInt64_0 = mapId;


        public static ulong[] get_assets(this GameSettings self)
            => self.field_Public_ArrayOf_UInt64_0;

        public static void set_assets(this GameSettings self, ulong[] assets)
            => self.field_Public_ArrayOf_UInt64_0 = assets;


        public static void WriteSettings(this GameSettings self, Packet packet)
            => self.Method_Public_Void_ObjectPublicIDisposableLi1ByInByBoUnique_32(packet);


        public static void ReadSettings(this GameSettings self, Packet packet)
            => self.Method_Public_Void_ObjectPublicIDisposableLi1ByInByBoUnique_39(packet);
    }

    public static class GameStateExtensions
    {
        public static int get_currentRound(this GameState self)
            => self.field_Public_Int32_0;

        public static void set_currentRound(this GameState self, int currentRound)
            => self.field_Public_Int32_0 = currentRound;


        public static bool get_started(this GameState self)
            => self.field_Public_Boolean_0;

        public static void set_started(this GameState self, bool started)
            => self.field_Public_Boolean_0 = started;
    }

    public static class GameUIExtensions
    {
        public static void FixUI(this GameUI self)
            => self.Method_Private_Void_1();
    }

    public static class GeometryGrassPainterExtensions
    {
        public static Mesh get_mesh(this GeometryGrassPainter self)
            => self.field_Private_Mesh_0;

        public static void set_mesh(this GeometryGrassPainter self, Mesh mesh)
            => self.field_Private_Mesh_0 = mesh;


        public static MeshFilter get_filter(this GeometryGrassPainter self)
            => self.field_Private_MeshFilter_0;
        
        public static void set_filter(this GeometryGrassPainter self, MeshFilter filter)
            => self.field_Private_MeshFilter_0 = filter;


        public static Vector3 get_lastPosition(this GeometryGrassPainter self)
            => self.field_Private_Vector3_0;

        public static void set_lastPosition(this GeometryGrassPainter self, Vector3 lastPosition)
            => self.field_Private_Vector3_0 = lastPosition;


        public static Vector3 get_mousePos(this GeometryGrassPainter self)
            => self.field_Private_Vector3_1;

        public static void set_mousePos(this GeometryGrassPainter self, Vector3 mousePos)
            => self.field_Private_Vector3_1 = mousePos;


        public static Vector3 get_hitPos(this GeometryGrassPainter self)
            => self.field_Private_Vector3_2;

        public static void set_hitPos(this GeometryGrassPainter self, Vector3 hitPos)
            => self.field_Private_Vector3_2 = hitPos;


        public static int[] get_indi(this GeometryGrassPainter self)
            => self.field_Private_ArrayOf_Int32_0;
        
        public static void set_indi(this GeometryGrassPainter self, int[] indi)
            => self.field_Private_ArrayOf_Int32_0 = indi;
    }

    public static class GlassBreakExtensions
    {
        public static void BreakGlass(this GlassBreak self)
            => self.Method_Private_Void_4();
    }

    public static class GunExtensions
    {
        public static Rigidbody get_rb(this Gun self)
            => self.field_Private_Rigidbody_0;

        public static void set_rb(this Gun self, Rigidbody rb)
            => self.field_Private_Rigidbody_0 = rb;


        public static Transform get_playerCam(this Gun self)
            => self.field_Private_Transform_0;

        public static void set_playerCam(this Gun self, Transform playerCam)
            => self.field_Private_Transform_0 = playerCam;


        public static Vector3 get_startPos(this Gun self)
            => self.field_Private_Vector3_0;

        public static void set_startPos(this Gun self, Vector3 startPos)
            => self.field_Private_Vector3_0 = startPos;


        public static List<Vector3> get_velHistory(this Gun self)
            => self.field_Private_List_1_Vector3_0;

        public static void set_velHistory(this Gun self, List<Vector3> velHistory)
            => self.field_Private_List_1_Vector3_0 = velHistory;


        public static Vector3 get_desiredBob(this Gun self)
            => self.field_Private_Vector3_1;

        public static void set_desiredBob(this Gun self, Vector3 desiredBob)
            => self.field_Private_Vector3_1 = desiredBob;


        public static float get_xBob(this Gun self)
            => self.field_Private_Single_0;

        public static void set_xBob(this Gun self, float xBob)
            => self.field_Private_Single_0 = xBob;


        public static float get_yBob(this Gun self)
            => self.field_Private_Single_1;

        public static void set_yBob(this Gun self, float yBob)
            => self.field_Private_Single_1 = yBob;


        public static float get_zBob(this Gun self)
            => self.field_Private_Single_2;

        public static void set_zBob(this Gun self, float zBob)
            => self.field_Private_Single_2 = zBob;


        public static float get_bobSpeed(this Gun self)
            => self.field_Private_Single_3;

        public static void set_bobSpeed(this Gun self, float bobSpeed)
            => self.field_Private_Single_3 = bobSpeed;


        public static Vector3 get_recoilOffset(this Gun self)
            => self.field_Private_Vector3_2;

        public static void set_recoilOffset(this Gun self, Vector3 recoilOffset)
            => self.field_Private_Vector3_2 = recoilOffset;


        public static Vector3 get_recoilRotation(this Gun self)
            => self.field_Private_Vector3_3;

        public static void set_recoilRotation(this Gun self, Vector3 recoilRotation)
            => self.field_Private_Vector3_3 = recoilRotation;


        public static Vector3 get_recoilOffsetVel(this Gun self)
            => self.field_Private_Vector3_4;

        public static void set_recoilOffsetVel(this Gun self, Vector3 recoilOffsetVel)
            => self.field_Private_Vector3_4 = recoilOffsetVel;


        public static Vector3 get_recoilRotVel(this Gun self)
            => self.field_Private_Vector3_5;

        public static void set_recoilRotVel(this Gun self, Vector3 recoilRotVel)
            => self.field_Private_Vector3_5 = recoilRotVel;


        public static float get_reloadRotation(this Gun self)
            => self.field_Private_Single_4;

        public static void set_reloadRotation(this Gun self, float reloadRotation)
            => self.field_Private_Single_4 = reloadRotation;


        public static float get_desiredReloadRotation(this Gun self)
            => self.field_Private_Single_5;

        public static void set_desiredReloadRotation(this Gun self, float desiredReloadRotation)
            => self.field_Private_Single_5 = desiredReloadRotation;


        public static float get_reloadTime(this Gun self)
            => self.field_Private_Single_6;

        public static void set_reloadTime(this Gun self, float reloadTime)
            => self.field_Private_Single_6 = reloadTime;


        public static float get_rVel(this Gun self)
            => self.field_Private_Single_7;

        public static void set_rVel(this Gun self, float rVel)
            => self.field_Private_Single_7 = rVel;


        public static float get_reloadPosOffset(this Gun self)
            => self.field_Private_Single_8;

        public static void set_reloadPosOffset(this Gun self, float reloadPosOffset)
            => self.field_Private_Single_8 = reloadPosOffset;


        public static float get_rPVel(this Gun self)
            => self.field_Private_Single_9;
        
        public static void set_rPVel(this Gun self, float rPVel)
            => self.field_Private_Single_9 = rPVel;


        public static float get_gunDrag(this Gun self)
            => self.field_Private_Single_10;

        public static void set_gunDrag(this Gun self, float gunDrag)
            => self.field_Private_Single_10 = gunDrag;


        public static float get_desX(this Gun self)
            => self.field_Private_Single_11;

        public static void set_desX(this Gun self, float desX)
            => self.field_Private_Single_11 = desX;


        public static float get_desY(this Gun self)
            => self.field_Private_Single_12;

        public static void set_desY(this Gun self, float desY)
            => self.field_Private_Single_12 = desY;


        public static Vector3 get_speedBob(this Gun self)
            => self.field_Private_Vector3_6;

        public static void set_speedBob(this Gun self, Vector3 speedBob)
            => self.field_Private_Vector3_6 = speedBob;


        public static float get_currentReloadTime(this Gun self)
            => self.field_Private_Single_13;

        public static void set_currentReloadTime(this Gun self, float currentReloadTime)
            => self.field_Private_Single_13 = currentReloadTime;

        
        public static float get_totalReloadTime(this Gun self)
            => self.field_Private_Single_14;

        public static void set_totalReloadTime(this Gun self, float totalReloadTime)
            => self.field_Private_Single_14 = totalReloadTime;


        public static void MovementBob(this Gun self)
            => self.Method_Private_Void_0();


        public static void SpeedBob(this Gun self)
            => self.Method_Private_Void_1();


        public static float EaseInOutBack(this Gun self, float val)
            => self.Method_Private_Single_Single_PDM_2(val);


        public static void Rotation(this Gun self, Vector2 desired)
            => self.Method_Private_Void_Vector2_0(desired);


        public static void ReloadGun(this Gun self)
            => self.Method_Private_Void_PDM_17();


        public static void RecoilGun(this Gun self)
            => self.Method_Private_Void_PDM_19();
    }

    public static class GunComponentExtensions
    {
        public static int GetMaxBulletDistance(this GunComponent self)
            => self.Method_Public_Int32_0();


        public static int GetDamage(this GunComponent self, float distance)
            => self.Method_Public_Int32_Single_5(distance);


        public static Vector3 GetRecoil(this GunComponent self, float recoilProgress)
            => self.Method_Public_Vector2_Single_16(recoilProgress);
    }

    public static class HatScoreboardExtensions
    {
        public static List<HatScoreboard_PlayerScore> get_idsSorted(this HatScoreboard self)
            => self.field_Private_List_1_ObjectNPublicIComparable1ObfUIStInUnique_0;

        public static void set_idsSorted(this HatScoreboard self, List<HatScoreboard_PlayerScore> idsSorted)
            => self.field_Private_List_1_ObjectNPublicIComparable1ObfUIStInUnique_0 = idsSorted;


        public static GameModeHat get_gameMode(this HatScoreboard self)
            => self.field_Private_GameModePublicLi1UItaDi2InUIplSiUnique_0;

        public static void set_gameMode(this HatScoreboard self, GameModeHat gameMode)
            => self.field_Private_GameModePublicLi1UItaDi2InUIplSiUnique_0 = gameMode;


        public static string get_selfColor(this HatScoreboard self)
            => self.field_Private_String_0;

        public static void set_selfColor(this HatScoreboard self, string selfColor)
            => self.field_Private_String_0 = selfColor;


        public static string get_dangerColor(this HatScoreboard self)
            => self.field_Private_String_1;

        public static void set_dangerColor(this HatScoreboard self, string dangerColor)
            => self.field_Private_String_1 = dangerColor;


        public static List<ulong> get_deobf_playersToEliminate(this HatScoreboard self)
            => self.field_Private_List_1_UInt64_0;

        public static void set_deobf_playersToEliminate(this HatScoreboard self, List<ulong> deobf_playersToEliminate)
            => self.field_Private_List_1_UInt64_0 = deobf_playersToEliminate;


        public static void SortList(this HatScoreboard self)
            => self.Method_Private_Void_PDM_18();
    }

    public static class HatScoreboard_PlayerScoreExtensions
    {
        public static ulong get_pid(this HatScoreboard_PlayerScore self)
            => self.field_Public_UInt64_0;

        public static void set_pid(this HatScoreboard_PlayerScore self, ulong pid)
            => self.field_Public_UInt64_0 = pid;


        public static string get_username(this HatScoreboard_PlayerScore self)
            => self.field_Public_String_0;

        public static void set_username(this HatScoreboard_PlayerScore self, string username)
            => self.field_Public_String_0 = username;


        public static int get_score(this HatScoreboard_PlayerScore self)
            => self.field_Public_Int32_0;

        public static void set_score(this HatScoreboard_PlayerScore self, int score)
            => self.field_Public_Int32_0 = score;
    }

    public static class HatUIExtensions
    {
        public static GameModeHat get_gameMode(this HatUI self)
            => self.field_Private_GameModePublicLi1UItaDi2InUIplSiUnique_0;

        public static void set_gameMode(this HatUI self, GameModeHat gameMode)
            => self.field_Private_GameModePublicLi1UItaDi2InUIplSiUnique_0 = gameMode;


        public static PlayerManager get_pm(this HatUI self)
            => self.field_Private_MonoBehaviourPublicCSstReshTrheObplBojuUnique_0;

        public static void set_pm(this HatUI self, PlayerManager pm)
            => self.field_Private_MonoBehaviourPublicCSstReshTrheObplBojuUnique_0 = pm;


        public static int get_lastRecordedScore(this HatUI self)
            => self.field_Private_Int32_0;

        public static void set_lastRecordedScore(this HatUI self, int lastRecordedScore)
            => self.field_Private_Int32_0 = lastRecordedScore;


        public static List<ulong> get_deobf_playersToEliminate(this HatUI self)
            => self.field_Private_List_1_UInt64_0;

        public static void set_deobf_playersToEliminate(this HatUI self, List<ulong> deobf_playersToEliminate)
            => self.field_Private_List_1_UInt64_0 = deobf_playersToEliminate;


        public static void AmBeingEliminated(this HatUI self)
            => self.Method_Private_Void_PDM_38();


        public static void UpdateScore(this HatUI self, int newScore)
            => self.Method_Private_Void_Int32_0(newScore);
    }

    public static class InputManagerExtensions
    {
        public static void Init(this InputManager self)
            => self.Method_Private_Void_2();
    }

    public static class InventoryUIExtensions
    {
        public static ItemSlotUI[] get_itemSlots(this InventoryUI self)
            => self.field_Private_ArrayOf_MonoBehaviourPublicCacaTeslnaTeRaimseRaUnique_0;

        public static void set_itemSlots(this InventoryUI self, ItemSlotUI[] itemSlots)
            => self.field_Private_ArrayOf_MonoBehaviourPublicCacaTeslnaTeRaimseRaUnique_0 = itemSlots;


        public static float get_fadeTime(this InventoryUI self)
            => self.field_Private_Single_0;

        public static void set_fadeTime(this InventoryUI self, float fadeTime)
            => self.field_Private_Single_0 = fadeTime;


        public static float get_currentFadeTime(this InventoryUI self)
            => self.field_Private_Single_1;

        public static void set_currentFadeTime(this InventoryUI self, float currentFadeTime)
            => self.field_Private_Single_1 = currentFadeTime;


        public static float get_startAlpha(this InventoryUI self)
            => self.field_Private_Single_2;

        public static void set_startAlpha(this InventoryUI self, float startAlpha)
            => self.field_Private_Single_2 = startAlpha;


        public static float get_desiredAlpha(this InventoryUI self)
            => self.field_Private_Single_3;

        public static void set_desiredAlpha(this InventoryUI self, float desiredAlpha)
            => self.field_Private_Single_3 = desiredAlpha;
    }

    public static class ItemAnimationsExtensions
    {
        public static Animator get_animator(this ItemAnimations self)
            => self.field_Private_Animator_0;

        public static void set_animator(this ItemAnimations self, Animator animator)
            => self.field_Private_Animator_0 = animator;


        public static RandomSfx get_sfx(this ItemAnimations self)
            => self.field_Private_MonoBehaviourPublicAusoSimamiSiBoAuplSiUnique_0;

        public static void set_sfx(this ItemAnimations self, RandomSfx sfx)
            => self.field_Private_MonoBehaviourPublicAusoSimamiSiBoAuplSiUnique_0 = sfx;
    }

    public static class ItemGunExtensions
    {
        public static float get_maxShootDistance(this ItemGun self)
            => self.field_Private_Single_0;

        public static void set_maxShootDistance(this ItemGun self, float maxShootDistance)
            => self.field_Private_Single_0 = maxShootDistance;


        public static bool get_shooting(this ItemGun self)
            => self.field_Private_Boolean_0;

        public static void set_shooting(this ItemGun self, bool shooting)
            => self.field_Private_Boolean_0 = shooting;


        public static float get_recoilProgress(this ItemGun self)
            => self.field_Private_Single_1;

        public static void set_recoilProgress(this ItemGun self, float recoilProgress)
            => self.field_Private_Single_1 = recoilProgress;


        public static Vector2 GetAccuracyOffset(this ItemGun self)
            => self.Method_Private_Vector2_0();


        public static void AddRecoilOffset(this ItemGun self)
            => self.Method_Private_Void_PDM_4();


        public static void StopReload(this ItemGun self)
            => self.Method_Private_Void_PDM_5();


        public static void StartReload(this ItemGun self)
            => self.Method_Private_Void_PDM_9();


        public static void HitPlayer(this ItemGun self, RaycastHit hit)
            => self.Method_Private_Void_RaycastHit_Single_1(hit);


        public static void ResetRecoil(this ItemGun self)
            => self.Method_Private_Void_3();


        public static void FinishReload(this ItemGun self)
            => self.Method_Private_Void_PDM_13();
    }

    public static class ItemHandleExtensions
    {
        public static ItemPrefab get_currentItem(this ItemHandle self)
            => self.field_Private_MonoBehaviour1PublicAbstractItitBoGapiTrrileTrObUnique_0;

        public static void set_currentItem(this ItemHandle self, ItemPrefab currentItem)
            => self.field_Private_MonoBehaviour1PublicAbstractItitBoGapiTrrileTrObUnique_0 = currentItem;


        public static Vector3 get_restingPosition(this ItemHandle self)
            => self.field_Private_Vector3_0;

        public static void set_restingPosition(this ItemHandle self, Vector3 restingPosition)
            => self.field_Private_Vector3_0 = restingPosition;


        public static Vector3 get_desiredPosition(this ItemHandle self)
            => self.field_Private_Vector3_1;

        public static void set_desiredPosition(this ItemHandle self, Vector3 desiredPosition)
            => self.field_Private_Vector3_1 = desiredPosition;


        public static Vector3 get_reloadPosition(this ItemHandle self)
            => self.field_Private_Vector3_2;

        public static void set_reloadPosition(this ItemHandle self, Vector3 reloadPosition)
            => self.field_Private_Vector3_2 = reloadPosition;


        public static Quaternion get_restingRotation(this ItemHandle self)
            => self.field_Private_Quaternion_0;

        public static void set_restingRotation(this ItemHandle self, Quaternion restingRotation)
            => self.field_Private_Quaternion_0 = restingRotation;


        public static void FinishReload(this ItemGun self)
            => self.Method_Private_Void_PDM_8();
    }

    public static class ItemManagerExtensions
    {
        public static void PopulateItemList(this ItemManager self)
            => self.Method_Private_Void_PDM_49();
    }

    public static class ItemMeleeExtensions
    {
        public static Transform get_currentCamForward(this ItemMelee self)
            => self.field_Private_Transform_0;

        public static void set_currentCamForward(this ItemMelee self, Transform currentCamForward)
            => self.field_Private_Transform_0 = currentCamForward;


        public static float get_deobf_delayedAttackTime(this ItemMelee self)
            => self.field_Private_Single_0;

        public static void set_deobf_delayedAttackTime(this ItemMelee self, float deobf_delayedAttackTime)
            => self.field_Private_Single_0 = deobf_delayedAttackTime;


        public static float get_deobf_endFalloffDistance(this ItemMelee self)
            => self.field_Private_Single_1;

        public static void set_deobf_endFalloffDistance(this ItemMelee self, float deobf_endFalloffDistance)
            => self.field_Private_Single_1 = deobf_endFalloffDistance;


        public static Vector3 get_attackDir(this ItemMelee self)
            => self.field_Private_Vector3_0;

        public static void set_attackDir(this ItemMelee self, Vector3 attackDir)
            => self.field_Private_Vector3_0 = attackDir;


        public static void HitPlayer(this ItemMelee self, RaycastHit hit, float damageMult)
            => self.Method_Private_Void_RaycastHit_Single_PDM_0(hit, damageMult);


        public static void SpawnParticles(this ItemMelee self)
            => self.Method_Private_Void_PDM_4();


        public static void LocalRaycast(this ItemMelee self)
            => self.Method_Private_Void_PDM_6();
    }

    public static class ItemPrefabExtensions
    {
        public static bool get_ready(this ItemPrefab self)
            => self.field_Protected_Boolean_0;

        public static void set_ready(this ItemPrefab self, bool ready)
            => self.field_Protected_Boolean_0 = ready;


        public static PlayerManager get_owner(this ItemPrefab self)
            => self.field_Protected_MonoBehaviourPublicCSstReshTrheObplBojuUnique_0;

        public static void set_owner(this ItemPrefab self, PlayerManager owner)
            => self.field_Protected_MonoBehaviourPublicCSstReshTrheObplBojuUnique_0 = owner;


        public static bool get_backing_isPickedUp(this ItemPrefab self)
            => self.field_Private_Boolean_0;

        public static void set_backing_isPickedUp(this ItemPrefab self, bool backing_isPickedUp)
            => self.field_Private_Boolean_0 = backing_isPickedUp;


        public static bool get_isPickedUp(this ItemPrefab self)
            => self.prop_Boolean_0;

        public static void set_isPickedUp(this ItemPrefab self, bool isPickedUp)
            => self.prop_Boolean_0 = isPickedUp;


        public static void OtherStart(this ItemPrefab self)
            => self.Method_Protected_Virtual_New_Void_0();


        public static void FinishEquip(this ItemPrefab self)
            => self.Method_Private_Void_0();


        public static void CheckComponents(this ItemPrefab self)
            => self.Method_Private_Void_1();
    }

    public static class ItemSlotUIExtensions
    {
        public static Vector3 get_defaultSelectionPosition(this ItemSlotUI self)
            => self.field_Private_Vector3_0;

        public static void set_defaultSelectionPosition(this ItemSlotUI self, Vector3 defaultSelectionPosition)
            => self.field_Private_Vector3_0 = defaultSelectionPosition;
    }

    public static class ItemThrowableExtensions
    {
        public static float get_deobf_raycastDistance(this ItemThrowable self)
            => self.field_Private_Single_0;

        public static void set_deobf_raycastDistance(this ItemThrowable self, float deobf_raycastDistance)
            => self.field_Private_Single_0 = deobf_raycastDistance;


        public static bool get_deobf_unusedBool(this ItemThrowable self)
            => self.field_Private_Boolean_0;
        
        public static void set_deobf_unusedBool(this ItemThrowable self, bool deobf_unusedBool)
            => self.field_Private_Boolean_0 = deobf_unusedBool;
    }

    public static class JumpPadExtensions
    {
        public static float get_cooldown(this JumpPad self)
            => self.field_Private_Single_0;

        public static void set_cooldown(this JumpPad self, float cooldown)
            => self.field_Private_Single_0 = cooldown;


        public static bool get_ready(this JumpPad self)
            => self.field_Private_Boolean_0;

        public static void set_ready(this JumpPad self, bool ready)
            => self.field_Private_Boolean_0 = ready;


        public static void Cooldown(this JumpPad self)
            => self.Method_Private_Void_2();
    }

    public static class KeyListenerExtensions
    {
        public static bool get_backing_justClosed(this KeyListener self)
            => self.field_Private_Boolean_0;

        public static void set_backing_justClosed(this KeyListener self, bool backing_justClosed)
            => self.field_Private_Boolean_0 = backing_justClosed;


        public static bool get_justClosed(this KeyListener self)
            => self.prop_Boolean_0;

        public static void set_justClosed(this KeyListener self, bool justClosed)
            => self.prop_Boolean_0 = justClosed;


        public static void CloseListener(this KeyListener self)
            => self.Method_Private_Void_7();


        public static void Cooldown(this KeyListener self)
            => self.Method_Private_Void_10();
    }

    public static class KingOfTheHillUIExtensions
    {
        public static GameModeKing get_gameMode(this KingOfTheHillUI self)
            => self.field_Private_GameModePublicDi2UIInplSielSiLiInUnique_0;

        public static void set_gameMode(this KingOfTheHillUI self, GameModeKing gameMode)
            => self.field_Private_GameModePublicDi2UIInplSielSiLiInUnique_0 = gameMode;


        public static PlayerManager get_pm(this KingOfTheHillUI self)
            => self.field_Private_MonoBehaviourPublicCSstReshTrheObplBojuUnique_0;

        public static void set_pm(this KingOfTheHillUI self, PlayerManager pm)
            => self.field_Private_MonoBehaviourPublicCSstReshTrheObplBojuUnique_0 = pm;


        public static int get_lastRecordedScore(this KingOfTheHillUI self)
            => self.field_Private_Int32_0;

        public static void set_lastRecordedScore(this KingOfTheHillUI self, int lastRecordedScore)
            => self.field_Private_Int32_0 = lastRecordedScore;


        public static List<ulong> get_deobf_playersToEliminate(this KingOfTheHillUI self)
            => self.field_Private_List_1_UInt64_0;

        public static void set_deobf_playersToEliminate(this KingOfTheHillUI self, List<ulong> deobf_playersToEliminate)
            => self.field_Private_List_1_UInt64_0 = deobf_playersToEliminate;


        public static void UpdateScore(this KingOfTheHillUI self, int newScore)
            => self.Method_Private_Void_Int32_0(newScore);


        public static void AmBeingEliminated(this KingOfTheHillUI self)
            => self.Method_Private_Void_PDM_8();
    }

    public static class KingScoreboardExtensions
    {
        public static List<KingScoreboard_PlayerScore> get_idsSorted(this KingScoreboard self)
            => self.field_Private_List_1_ObjectNPublicIComparable1ObfUIStInUnique_0;

        public static void set_idsSorted(this KingScoreboard self, List<KingScoreboard_PlayerScore> idsSorted)
            => self.field_Private_List_1_ObjectNPublicIComparable1ObfUIStInUnique_0 = idsSorted;


        public static GameModeKing get_gameMode(this KingScoreboard self)
            => self.field_Private_GameModePublicDi2UIInplSielSiLiInUnique_0;

        public static void set_gameMode(this KingScoreboard self, GameModeKing gameMode)
            => self.field_Private_GameModePublicDi2UIInplSielSiLiInUnique_0 = gameMode;


        public static string get_selfColor(this KingScoreboard self)
            => self.field_Private_String_0;

        public static void set_selfColor(this KingScoreboard self, string selfColor)
            => self.field_Private_String_0 = selfColor;


        public static string get_dangerColor(this KingScoreboard self)
            => self.field_Private_String_1;

        public static void set_dangerColor(this KingScoreboard self, string dangerColor)
            => self.field_Private_String_1 = dangerColor;


        public static List<ulong> get_deobf_playersToEliminate(this KingScoreboard self)
            => self.field_Private_List_1_UInt64_0;

        public static void set_deobf_playersToEliminate(this KingScoreboard self, List<ulong> deobf_playersToEliminate)
            => self.field_Private_List_1_UInt64_0 = deobf_playersToEliminate;


        public static void SortList(this KingScoreboard self)
            => self.Method_Private_Void_PDM_16();
    }

    public static class KingScoreboard_PlayerScoreExtensions
    {
        public static ulong get_pid(this KingScoreboard_PlayerScore self)
            => self.field_Public_UInt64_0;

        public static void set_pid(this KingScoreboard_PlayerScore self, ulong pid)
            => self.field_Public_UInt64_0 = pid;


        public static string get_username(this KingScoreboard_PlayerScore self)
            => self.field_Public_String_0;

        public static void set_username(this KingScoreboard_PlayerScore self, string username)
            => self.field_Public_String_0 = username;


        public static int get_score(this KingScoreboard_PlayerScore self)
            => self.field_Public_Int32_0;

        public static void set_score(this KingScoreboard_PlayerScore self, int score)
            => self.field_Public_Int32_0 = score;
    }

    public static class LavaDamageExtensions
    {
        public static void YouWhat(this LavaDamage self)
            => self.Method_Private_Void_PDM_7();
    }

    public static class LavaPieceExtensions
    {
        public static bool get_breaking(this LavaPiece self)
            => self.field_Private_Boolean_0;

        public static void set_breaking(this LavaPiece self, bool breaking)
            => self.field_Private_Boolean_0 = breaking;


        public static float get_currentTime(this LavaPiece self)
            => self.field_Private_Single_0;

        public static void set_currentTime(this LavaPiece self, float currentTime)
            => self.field_Private_Single_0 = currentTime;


        public static float get_breakTime(this LavaPiece self)
            => self.field_Private_Single_1;

        public static void set_breakTime(this LavaPiece self, float breakTime)
            => self.field_Private_Single_1 = breakTime;


        public static float get_fallSpeed(this LavaPiece self)
            => self.field_Private_Single_2;

        public static void set_fallSpeed(this LavaPiece self, float fallSpeed)
            => self.field_Private_Single_2 = fallSpeed;


        public static void FinalBreak(this LavaPiece self)
            => self.Method_Private_Void_PDM_32();
    }

    public static class LinkOpenerExtensions
    {
        public static string get_CCId(this LinkOpener self)
            => self.field_Private_String_0;

        public static void set_CCId(this LinkOpener self, string CCId)
            => self.field_Private_String_0 = CCId;


        public static string get_CC0(this LinkOpener self)
            => self.field_Private_String_1;

        public static void set_CC0(this LinkOpener self, string CC0)
            => self.field_Private_String_1 = CC0;
    }

    public static class ListExtensionsExtensions // lmao
    {
        public static List<T> Shuffle<T>(List<T> list, Il2CppSystem.Random random)
            => ListExtensions.Method_Public_Static_List_1_T_List_1_T_Random_PDM_0(list, random);

        public static void Swap<T>(List<T> list, int index1, int index2)
            => ListExtensions.Method_Private_Static_Void_List_1_T_Int32_Int32_PDM_0(list, index1, index2);
    }

    public static class LoadingScreenExtensions
    {
        public static ulong[] get_assets(this LoadingScreen self)
            => self.field_Private_ArrayOf_UInt64_0;

        public static void set_assets(this LoadingScreen self, ulong[] assets)
            => self.field_Private_ArrayOf_UInt64_0 = assets;


        public static ulong get_mapId(this LoadingScreen self)
            => self.field_Private_UInt64_0;

        public static void set_mapId(this LoadingScreen self, ulong mapId)
            => self.field_Private_UInt64_0 = mapId;


        public static MyTimer get_timer(this LoadingScreen self)
            => self.field_Private_ObjectPublicSiBoSiSiSiUnique_0;

        public static void set_timer(this LoadingScreen self, MyTimer timer)
            => self.field_Private_ObjectPublicSiBoSiSiSiUnique_0 = timer;


        public static AsyncOperation get_AO(this LoadingScreen self)
            => self.field_Private_AsyncOperation_0;

        public static void set_AO(this LoadingScreen self, AsyncOperation AO)
            => self.field_Private_AsyncOperation_0 = AO;


        public static int get_joinAttempts(this LoadingScreen self)
            => self.field_Private_Int32_0;

        public static void set_joinAttempts(this LoadingScreen self, int joinAttempts)
            => self.field_Private_Int32_0 = joinAttempts;


        public static void UpdateProgressText(this LoadingScreen self, AsyncOperation asyncOperation)
            => self.Method_Private_Void_AsyncOperation_0(asyncOperation);


        public static void RequestEnterGame(this LoadingScreen self)
            => self.Method_Private_Void_PDM_22();


        /**
         * <summary>This is a Coroutine: <see cref="LoadingScreen.ObjectNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStObscObObUnique"/></summary>
         */
        public static IEnumerator LoadSceneAsync(this LoadingScreen self, string sceneName)
            => self.Method_Private_IEnumerator_String_0(sceneName);


        public static void AllowSceneActivation(this LoadingScreen self)
            => self.Method_Private_Void_PDM_24();
    }

    public static class LobbyCameraExtensions
    {
        public static ShakeInstance get_deobf_shakerInstance(this LobbyCamera self)
            => self.field_Private_ShakeInstance_0;

        public static void set_deobf_shakerInstance(this LobbyCamera self, ShakeInstance deobf_shakerInstance)
            => self.field_Private_ShakeInstance_0 = deobf_shakerInstance;
    }

    public static class LobbyManagerExtensions
    {
        public static CSteamID get_backing_currentLobby(this LobbyManager self)
            => self.field_Private_CSteamID_0;

        public static void set_backing_currentLobby(this LobbyManager self, CSteamID backing_currentLobby)
            => self.field_Private_CSteamID_0 = backing_currentLobby;


        public static ulong[] get_UIDToSteamId(this LobbyManager self)
            => self.field_Private_ArrayOf_UInt64_0;

        public static void set_UIDToSteamId(this LobbyManager self, ulong[] UIDToSteamId)
            => self.field_Private_ArrayOf_UInt64_0 = UIDToSteamId;


        public static Client[] get_clients(this LobbyManager self)
            => self.field_Private_ArrayOf_ObjectPublicBoInBoCSItBoInSiBySiUnique_0;

        public static void set_clients(this LobbyManager self, Client[] clients)
            => self.field_Private_ArrayOf_ObjectPublicBoInBoCSItBoInSiBySiUnique_0 = clients;


        public static bool[] get_backing_colorsTaken(this LobbyManager self)
            => self.field_Private_ArrayOf_Boolean_0;

        public static void set_backing_colorsTaken(this LobbyManager self, bool[] backing_colorsTaken)
            => self.field_Private_ArrayOf_Boolean_0 = backing_colorsTaken;


        public static bool get_backing_practiceMode(this LobbyManager self)
            => self.field_Private_Boolean_0;

        public static void set_backing_practiceMode(this LobbyManager self, bool backing_practiceMode)
            => self.field_Private_Boolean_0 = backing_practiceMode;


        public static Deobf_ProfanityDetector get_deobf_profanityDetector(this LobbyManager self)
            => self.field_Private_Object1PublicObObUnique_0;

        public static void set_deobf_profanityDetector(this LobbyManager self, Deobf_ProfanityDetector deobf_profanityDetector)
            => self.field_Private_Object1PublicObObUnique_0 = deobf_profanityDetector;


        public static string get_backing_serverName(this LobbyManager self)
            => self.field_Private_String_0;

        public static void set_backing_serverName(this LobbyManager self, string backing_serverName)
            => self.field_Private_String_0 = backing_serverName;


        public static bool get_practiceMode(this LobbyManager self)
            => self.prop_Boolean_0;

        public static void set_practiceMode(this LobbyManager self, bool practiceMode)
            => self.prop_Boolean_0 = practiceMode;


        public static string get_serverName(this LobbyManager self)
            => self.prop_String_0;

        public static void set_serverName(this LobbyManager self, string serverName)
            => self.prop_String_0 = serverName;


        public static bool[] get_colorsTaken(this LobbyManager self)
            => self.prop_ArrayOf_Boolean_0;

        public static void set_colorsTaken(this LobbyManager self, bool[] colorsTaken)
            => self.prop_ArrayOf_Boolean_0 = colorsTaken;


        public static CSteamID get_currentLobby(this LobbyManager self)
            => self.prop_CSteamID_0;

        public static void set_currentLobby(this LobbyManager self, CSteamID currentLobby)
            => self.prop_CSteamID_0 = currentLobby;


        public static void InitLobby(this LobbyManager self, CSteamID currentLobby, bool practiceMode)
            => self.Method_Private_Void_CSteamID_Boolean_0(currentLobby, practiceMode);


        public static void Deobf_DetectModding(this LobbyManager self)
            => self.Method_Private_Void_0();


        public static string Deobf_ReturnTest(this LobbyManager self, string unused)
            => self.Method_Private_String_String_PDM_2(unused);


        public static int FindAvailableLobbyId(this LobbyManager self)
            => self.Method_Private_Int32_PDM_1();


        public static void SetLobbyType(this LobbyManager self)
            => self.Method_Private_Void_1();


        public static void UpdateColor(this LobbyManager self, int color, bool inUse)
            => self.Method_Private_Void_Int32_Boolean_PDM_0(color, inUse);


        public static string Deobf_NameKey(this LobbyManager self)
            => self.Method_Private_String_PDM_12();


        public static void Deobf_SetLobbyModded(this LobbyManager self)
            => self.Method_Private_Void_2();


        public static void SetLobbyMetaData(this LobbyManager self)
            => self.Method_Private_Void_3();


        public static void SetLobbySize(this LobbyManager self)
            => self.Method_Private_Void_PDM_7();


        public static void Deobf_ReturnTest2(this LobbyManager self, string unused)
            => self.Method_Private_String_String_PDM_5(unused);
    }

    public static class LobbyReadyInteractExtensions
    {
        public static bool get_ready(this LobbyReadyInteract self)
            => self.field_Private_Boolean_0;

        public static void set_ready(this LobbyReadyInteract self, bool ready)
            => self.field_Private_Boolean_0 = ready;


        public static Vector3 get_defaultScale(this LobbyReadyInteract self)
            => self.field_Private_Vector3_0;

        public static void set_defaultScale(this LobbyReadyInteract self, Vector3 defaultScale)
            => self.field_Private_Vector3_0 = defaultScale;


        public static Vector3 get_desiredScale(this LobbyReadyInteract self)
            => self.field_Private_Vector3_1;

        public static void set_desiredScale(this LobbyReadyInteract self, Vector3 desiredScale)
            => self.field_Private_Vector3_1 = desiredScale;


        public static Vector3 get_currentScale(this LobbyReadyInteract self)
            => self.field_Private_Vector3_2;

        public static void set_currentScale(this LobbyReadyInteract self, Vector3 currentScale)
            => self.field_Private_Vector3_2 = currentScale;


        public static void ResetReady(this LobbyReadyInteract self)
            => self.Method_Private_Void_3();


        public static void PressButton(this LobbyReadyInteract self, ulong clientId)
            => self.Method_Private_Void_UInt64_2(clientId);
    }

    public static class LobbySettingsExtensions
    {
        public static GameSettings_LobbyType get_storedLobbyType(this LobbySettings self)
            => self.field_Private_EnumNPublicSealedvaLoFrPu4vUnique_0;

        public static void set_storedLobbyType(this LobbySettings self, GameSettings_LobbyType storedLobbyType)
            => self.field_Private_EnumNPublicSealedvaLoFrPu4vUnique_0 = storedLobbyType;


        public static void UpdateLobbyType(this LobbySettings self)
            => self.Method_Private_Void_PDM_5();


        public static void UpdateMaxPlayers(this LobbySettings self)
            => self.Method_Private_Void_PDM_17();


        public static void UpdateProximityChat(this LobbySettings self)
            => self.Method_Private_Void_PDM_41();


        public static void UpdateSettings(this LobbySettings self)
            => self.Method_Private_Void_13();
    }

    public static class LobbyUtilityExtensions
    {
        public static List<string> get_profanity(this LobbyUtility self)
            => self.field_Private_List_1_String_0;

        public static void set_profanity(this LobbyUtility self, List<string> profanity)
            => self.field_Private_List_1_String_0 = profanity;
    }

    public static class MakeRagdollExtensions
    {
        public static void Ragdoll(this MakeRagdoll self, Transform transform, Vector3 impactNormal)
            => self.Method_Private_Void_Transform_Vector3_0(transform, impactNormal);


        public static void AddComponents(this MakeRagdoll self, Transform transform, Rigidbody rigidbody, Vector3 impactNormal)
            => self.Method_Private_Void_Transform_Rigidbody_Vector3_0(transform, rigidbody, impactNormal);
    }

    public static class ManagePlayerListingExtensions
    {
        public static RectTransform get_windowRect(this ManagePlayerListing self)
            => self.field_Private_RectTransform_0;

        public static void set_windowRect(this ManagePlayerListing self, RectTransform windowRect)
            => self.field_Private_RectTransform_0 = windowRect;


        public static ulong get_deobf_clientId(this ManagePlayerListing self)
            => self.field_Private_UInt64_0;

        public static void set_deobf_clientId(this ManagePlayerListing self, ulong deobf_clientId)
            => self.field_Private_UInt64_0 = deobf_clientId;


        public static void UpdateMuted(this ManagePlayerListing self, ulong clientId)
            => self.Method_Private_Void_UInt64_0(clientId);
    }

    public static class MapCameraExtensions
    {
        public static bool get_stopped(this MapCamera self)
            => self.field_Private_Boolean_0;

        public static void set_stopped(this MapCamera self, bool stopped)
            => self.field_Private_Boolean_0 = stopped;


        public static void StopCinematicCamera(this MapCamera self)
            => self.Method_Private_Void_0();
    }

    public static class MapSelectionExtensions
    {
        public static int get_backing_selectedMap(this MapSelection self)
            => self.field_Private_Int32_0;

        public static void set_backing_selectedMap(this MapSelection self, int backing_selectedMap)
            => self.field_Private_Int32_0 = backing_selectedMap;


        public static string get_workshopPath(this MapSelection self)
            => self.field_Private_String_0;

        public static void set_workshopPath(this MapSelection self, string workshopPath)
            => self.field_Private_String_0 = workshopPath;


        public static int get_selectedMap(this MapSelection self)
            => self.prop_Int32_0;

        public static void set_selectedMap(this MapSelection self, int selectedMap)
            => self.prop_Int32_0 = selectedMap;
    }

    public static class MicDropDownExtensions
    {
        public static List<string> get_devices(this MicDropDown self)
            => self.field_Private_List_1_String_0;

        public static void set_devices(this MicDropDown self, List<string> devices)
            => self.field_Private_List_1_String_0 = devices;


        public static void UpdateSetting(this MicDropDown self)
            => self.Method_Private_Void_5();
    }

    public static class MicIconExtensions
    {
        public static InterfacePublicAbstractStVeQuObBogeStgeVeQuUnique get_player(this MicIcon self)
            => self.field_Private_InterfacePublicAbstractStVeQuObBogeStgeVeQuUnique_0;

        public static void set_player(this MicIcon self, InterfacePublicAbstractStVeQuObBogeStgeVeQuUnique player)
            => self.field_Private_InterfacePublicAbstractStVeQuObBogeStgeVeQuUnique_0 = player;


        public static ObjectPublicAbstractObStAc12ObAc1BoStUnique get_state(this MicIcon self)
            => self.field_Private_ObjectPublicAbstractObStAc12ObAc1BoStUnique_0;

        public static void set_state(this MicIcon self, ObjectPublicAbstractObStAc12ObAc1BoStUnique state)
            => self.field_Private_ObjectPublicAbstractObStAc12ObAc1BoStUnique_0 = state;


        public static void SetIcon(this MicIcon self, bool active)
            => self.Method_Private_Void_Boolean_12(active);
    }

    public static class MicSettingExtensions
    {
        public static void UpdateMicSetting(this MicSetting self)
            => self.Method_Private_Void_PDM_20();
    }

    public static class MoveAlertExtensions
    {
        public static Vector3 get_defaultPos(this MoveAlert self)
            => self.field_Private_Vector3_0;

        public static void set_defaultPos(this MoveAlert self, Vector3 defaultPos)
            => self.field_Private_Vector3_0 = defaultPos;


        public static float get_offset(this MoveAlert self)
            => self.field_Private_Single_0;

        public static void set_offset(this MoveAlert self, float offset)
            => self.field_Private_Single_0 = offset;


        public static float get_startFadeAt(this MoveAlert self)
            => self.field_Private_Single_1;

        public static void set_startFadeAt(this MoveAlert self, float startFadeAt)
            => self.field_Private_Single_1 = startFadeAt;


        public static void Remove(this MoveAlert self)
            => self.Method_Private_Void_PDM_24();


        public static void StartFade(this MoveAlert self)
            => self.Method_Private_Void_PDM_26();
    }

    public static class MoveCameraExtensions
    {
        public static Camera get_cam(this MoveCamera self)
            => self.field_Private_Camera_0;

        public static void set_cam(this MoveCamera self, Camera cam)
            => self.field_Private_Camera_0 = cam;


        public static Rigidbody get_rb(this MoveCamera self)
            => self.field_Private_Rigidbody_0;

        public static void set_rb(this MoveCamera self, Rigidbody rb)
            => self.field_Private_Rigidbody_0 = rb;


        public static MoveCamera get_backing_Instance()
            => MoveCamera.field_Private_Static_MonoBehaviourPublicTrplVeofdeVevaCaRiVeUnique_0;

        public static void set_backing_Instance(MoveCamera backing_Instance)
            => MoveCamera.field_Private_Static_MonoBehaviourPublicTrplVeofdeVevaCaRiVeUnique_0 = backing_Instance;


        public static float get_desiredTilt(this MoveCamera self)
            => self.field_Private_Single_0;

        public static void set_desiredTilt(this MoveCamera self, float desiredTilt)
            => self.field_Private_Single_0 = desiredTilt;


        public static float get_tilt(this MoveCamera self)
            => self.field_Private_Single_1;

        public static void set_tilt(this MoveCamera self, float tilt)
            => self.field_Private_Single_1 = tilt;


        public static MoveCamera_CameraState get_backing_state(this MoveCamera self)
            => self.field_Private_EnumNPublicSealedvaPlSpPlFr5vUnique_0;

        public static void set_backing_state(this MoveCamera self, MoveCamera_CameraState backing_state)
            => self.field_Private_EnumNPublicSealedvaPlSpPlFr5vUnique_0 = backing_state;


        public static Vector3 get_desiredDeathPos(this MoveCamera self)
            => self.field_Private_Vector3_0;

        public static void set_desiredDeathPos(this MoveCamera self, Vector3 desiredDeathPos)
            => self.field_Private_Vector3_0 = desiredDeathPos;


        public static Transform get_target(this MoveCamera self)
            => self.field_Private_Transform_0;

        public static void set_target(this MoveCamera self, Transform target)
            => self.field_Private_Transform_0 = target;


        public static Vector3 get_desiredSpectateRotation(this MoveCamera self)
            => self.field_Private_Vector3_1;

        public static void set_desiredSpectateRotation(this MoveCamera self, Vector3 desiredSpectateRotation)
            => self.field_Private_Vector3_1 = desiredSpectateRotation;


        public static Transform get_playerTarget(this MoveCamera self)
            => self.field_Private_Transform_1;

        public static void set_playerTarget(this MoveCamera self, Transform playerTarget)
            => self.field_Private_Transform_1 = playerTarget;


        public static int get_spectatingId(this MoveCamera self)
            => self.field_Private_Int32_0;

        public static void set_spectatingId(this MoveCamera self, int spectatingId)
            => self.field_Private_Int32_0 = spectatingId;


        public static float get_yRotation(this MoveCamera self)
            => self.field_Private_Single_2;

        public static void set_yRotation(this MoveCamera self, float yRotation)
            => self.field_Private_Single_2 = yRotation;


        public static float get_desiredX(this MoveCamera self)
            => self.field_Private_Single_3;

        public static void set_desiredX(this MoveCamera self, float desiredX)
            => self.field_Private_Single_3 = desiredX;


        public static ulong get_lastSentSpectatingId(this MoveCamera self)
            => self.field_Private_UInt64_0;

        public static void set_lastSentSpectatingId(this MoveCamera self, ulong lastSentSpectatingId)
            => self.field_Private_UInt64_0 = lastSentSpectatingId;


        public static Vector3 get_desiredBob(this MoveCamera self)
            => self.field_Private_Vector3_2;

        public static void set_desiredBob(this MoveCamera self, Vector3 desiredBob)
            => self.field_Private_Vector3_2 = desiredBob;


        public static Vector3 get_bobOffset(this MoveCamera self)
            => self.field_Private_Vector3_3;

        public static void set_bobOffset(this MoveCamera self, Vector3 bobOffset)
            => self.field_Private_Vector3_3 = bobOffset;


        public static float get_bobSpeed(this MoveCamera self)
            => self.field_Private_Single_4;

        public static void set_bobSpeed(this MoveCamera self, float bobSpeed)
            => self.field_Private_Single_4 = bobSpeed;


        public static float get_bobMultiplier(this MoveCamera self)
            => self.field_Private_Single_5;

        public static void set_bobMultiplier(this MoveCamera self, float bobMultiplier)
            => self.field_Private_Single_5 = bobMultiplier;


        public static MoveCamera get_Instance()
            => MoveCamera.prop_MonoBehaviourPublicTrplVeofdeVevaCaRiVeUnique_0;

        public static void set_Instance(MoveCamera Instance)
            => MoveCamera.prop_MonoBehaviourPublicTrplVeofdeVevaCaRiVeUnique_0 = Instance;


        public static MoveCamera_CameraState get_state(this MoveCamera self)
            => self.prop_EnumNPublicSealedvaPlSpPlFr5vUnique_0;

        public static void set_state(this MoveCamera self, MoveCamera_CameraState state)
            => self.prop_EnumNPublicSealedvaPlSpPlFr5vUnique_0 = state;


        public static void PlayerDeathCamera(this MoveCamera self)
            => self.Method_Private_Void_0();


        public static void SpectateToggle(this MoveCamera self, int dir)
            => self.Method_Private_Void_Int32_0(dir);


        public static Vector3 ClampVector(this MoveCamera self, Vector3 vec, float min, float max)
            => self.Method_Private_Vector3_Vector3_Single_Single_PDM_0(vec, min, max);


        public static void FreeCam(this MoveCamera self)
            => self.Method_Private_Void_1();


        public static void SpectateCamera(this MoveCamera self)
            => self.Method_Private_Void_2();


        public static void PlayerCamera(this MoveCamera self)
            => self.Method_Private_Void_3();


        public static void FreeCamRotation(this MoveCamera self)
            => self.Method_Private_Void_4();


        public static void UpdateBob(this MoveCamera self)
            => self.Method_Private_Void_5();


        public static void MoveGun(this MoveCamera self)
            => self.Method_Private_Void_PDM_11();


        public static bool Deobf_FreeCamToggleSpectate(this MoveCamera self)
            => self.Method_Private_Boolean_1();


        public static bool Deobf_SpectateToggleFreeCam(this MoveCamera self)
            => self.Method_Private_Boolean_0();
    }

    public static class MoveInteractExtensions
    {
        public static Vector3 get_defaultPosition(this MoveInteract self)
            => self.field_Private_Vector3_0;

        public static void set_defaultPosition(this MoveInteract self, Vector3 defaultPosition)
            => self.field_Private_Vector3_0 = defaultPosition;
    }

    public static class MoveLavaExtensions
    {
        public static Vector3 get_startPosition(this MoveLava self)
            => self.field_Private_Vector3_0;

        public static void set_startPosition(this MoveLava self, Vector3 startPosition)
            => self.field_Private_Vector3_0 = startPosition;


        public static float get_lavaPeakStart(this MoveLava self)
            => self.field_Private_Single_0;

        public static void set_lavaPeakStart(this MoveLava self, float lavaPeakStart)
            => self.field_Private_Single_0 = lavaPeakStart;


        public static float get_lavaPeakEnd(this MoveLava self)
            => self.field_Private_Single_1;

        public static void set_lavaPeakEnd(this MoveLava self, float lavaPeakEnd)
            => self.field_Private_Single_1 = lavaPeakEnd;


        public static bool get_started(this MoveLava self)
            => self.field_Private_Boolean_0;

        public static void set_started(this MoveLava self, bool started)
            => self.field_Private_Boolean_0 = started;


        public static float get_sirenOffset(this MoveLava self)
            => self.field_Private_Single_2;

        public static void set_sirenOffset(this MoveLava self, float sirenOffset)
            => self.field_Private_Single_2 = sirenOffset;


        public static void StartLava(this MoveLava self)
            => self.Method_Private_Void_PDM_0();


        public static float FindHeightOffset(this MoveLava self)
            => self.Method_Private_Single_PDM_17();
    }

    public static class MovingObjectExtensions
    {
        public static Vector3 get_startPosition(this MovingObject self)
            => self.field_Private_Vector3_0;

        public static void set_startPosition(this MovingObject self, Vector3 startPosition)
            => self.field_Private_Vector3_0 = startPosition;


        public static Rigidbody get_rb(this MovingObject self)
            => self.field_Private_Rigidbody_0;

        public static void set_rb(this MovingObject self, Rigidbody rb)
            => self.field_Private_Rigidbody_0 = rb;
    }

    public static class MusicControllerExtensions
    {
        public static AudioSource get_audio(this MusicController self)
            => self.field_Private_AudioSource_0;

        public static void set_audio(this MusicController self, AudioSource audio)
            => self.field_Private_AudioSource_0 = audio;


        public static AudioClip get_queuedSong(this MusicController self)
            => self.field_Private_AudioClip_0;

        public static void set_queuedSong(this MusicController self, AudioClip queuedSong)
            => self.field_Private_AudioClip_0 = queuedSong;


        public static float get_fadeTime(this MusicController self)
            => self.field_Private_Single_0;

        public static void set_fadeTime(this MusicController self, float fadeTime)
            => self.field_Private_Single_0 = fadeTime;


        public static float get_defaultFadeTime(this MusicController self)
            => self.field_Private_Single_1;

        public static void set_defaultFadeTime(this MusicController self, float defaultFadeTime)
            => self.field_Private_Single_1 = defaultFadeTime;


        public static float get_targetVolume(this MusicController self)
            => self.field_Private_Single_2;

        public static void set_targetVolume(this MusicController self, float targetVolume)
            => self.field_Private_Single_2 = targetVolume;


        public static MusicController_SongType get_currentSong(this MusicController self)
            => self.field_Private_EnumNPublicSealedvaNoInMeFuScWi7vUnique_0;

        public static void set_currentSong(this MusicController self, MusicController_SongType currentSong)
            => self.field_Private_EnumNPublicSealedvaNoInMeFuScWi7vUnique_0 = currentSong;


        public static float get_currentTime(this MusicController self)
            => self.field_Private_Single_3;

        public static void set_currentTime(this MusicController self, float currentTime)
            => self.field_Private_Single_3 = currentTime;


        public static float get_newFadeTime(this MusicController self)
            => self.field_Private_Single_4;

        public static void set_newFadeTime(this MusicController self, float newFadeTime)
            => self.field_Private_Single_4 = newFadeTime;


        public static float get_desiredVolume(this MusicController self)
            => self.field_Private_Single_5;

        public static void set_desiredVolume(this MusicController self, float desiredVolume)
            => self.field_Private_Single_5 = desiredVolume;


        public static float get_startVolume(this MusicController self)
            => self.field_Private_Single_6;

        public static void set_startVolume(this MusicController self, float startVolume)
            => self.field_Private_Single_6 = startVolume;


        public static void NextSong(this MusicController self, AudioClip clip)
            => self.Method_Private_Void_AudioClip_PDM_1(clip);


        public static void NextSong(this MusicController self)
            => self.Method_Private_Void_PDM_26();


        public static void StartFade(this MusicController self, AudioSource source, float newFadeTime, float desiredVolume)
            => self.Method_Private_Void_AudioSource_Single_Single_PDM_7(source, newFadeTime, desiredVolume);
    }

    public static class MyBoolSettingExtensions
    {
        public static void UpdateSetting(this MyBoolSetting self)
            => self.Method_Private_Void_PDM_0();
    }

    public static class MyTimerExtensions
    {
        public static float get_backing_currentTime(this MyTimer self)
            => self.field_Private_Single_0;

        public static void set_backing_currentTime(this MyTimer self, float backing_currentTime)
            => self.field_Private_Single_0 = backing_currentTime;


        public static float get_backing_totalTime(this MyTimer self)
            => self.field_Private_Single_1;

        public static void set_backing_totalTime(this MyTimer self, float backing_totalTime)
            => self.field_Private_Single_1 = backing_totalTime;


        public static bool get_running(this MyTimer self)
            => self.field_Private_Boolean_0;

        public static void set_running(this MyTimer self, bool running)
            => self.field_Private_Boolean_0 = running;


        public static float get_currentTime(this MyTimer self)
            => self.prop_Single_0;

        public static void set_currentTime(this MyTimer self, float currentTime)
            => self.prop_Single_0 = currentTime;


        public static float get_totalTime(this MyTimer self)
            => self.prop_Single_1;

        public static void set_totalTime(this MyTimer self, float totalTime)
            => self.prop_Single_1 = totalTime;


        public static bool UpdateTimer(this MyTimer self)
            => self.Method_Public_Boolean_3();


        public static bool IsRunning(this MyTimer self)
            => self.Method_Public_Boolean_4();


        public static void SetTimer(this MyTimer self, float time)
            => self.Method_Public_Void_Single_18(time);


        public static int GetSeconds(this MyTimer self)
            => self.Method_Public_Int32_4();


        public static void StopTimer(this MyTimer self)
            => self.Method_Public_Void_PDM_6();
    }

    public static class NetStatusExtensions
    {
        public static string get_dateFormat(this NetStatus self)
            => self.field_Private_String_0;

        public static void set_dateFormat(this NetStatus self, string dateFormat)
            => self.field_Private_String_0 = dateFormat;


        public static LinkedList<int> get_pings()
            => NetStatus.field_Private_Static_LinkedList_1_Int32_0;

        public static void set_pings(LinkedList<int> pings)
            => NetStatus.field_Private_Static_LinkedList_1_Int32_0 = pings;


        public static int get_pingBuffer()
            => NetStatus.field_Private_Static_Int32_0;

        public static void set_pingBuffer(int pingBuffer)
            => NetStatus.field_Private_Static_Int32_0 = pingBuffer;


        public static void SlowerUpdate(this NetStatus self)
            => self.Method_Private_Void_PDM_33();


        public static void SendPings(this NetStatus self)
            => self.Method_Private_Void_PDM_41();
    }

    public static class OnlinePlayerMovementExtensions
    {
        public static PlayerManager get_backing_playerManager(this OnlinePlayerMovement self)
            => self.field_Private_MonoBehaviourPublicCSstReshTrheObplBojuUnique_0;

        public static void set_backing_playerManager(this OnlinePlayerMovement self, PlayerManager backing_playerManager)
            => self.field_Private_MonoBehaviourPublicCSstReshTrheObplBojuUnique_0 = backing_playerManager;


        public static Vector3 get_desiredPosition(this OnlinePlayerMovement self)
            => self.field_Private_Vector3_0;

        public static void set_desiredPosition(this OnlinePlayerMovement self, Vector3 desiredPosition)
            => self.field_Private_Vector3_0 = desiredPosition;


        public static Vector3 get_velocity(this OnlinePlayerMovement self)
            => self.field_Private_Vector3_1;

        public static void set_velocity(this OnlinePlayerMovement self, Vector3 velocity)
            => self.field_Private_Vector3_1 = velocity;


        public static Vector3 get_lastPosition(this OnlinePlayerMovement self)
            => self.field_Private_Vector3_2;

        public static void set_lastPosition(this OnlinePlayerMovement self, Vector3 lastPosition)
            => self.field_Private_Vector3_2 = lastPosition;


        public static float get_fallSpeed(this OnlinePlayerMovement self)
            => self.field_Private_Single_0;

        public static void set_fallSpeed(this OnlinePlayerMovement self, float fallSpeed)
            => self.field_Private_Single_0 = fallSpeed;


        public static float get_playerSpeed(this OnlinePlayerMovement self)
            => self.field_Private_Single_1;

        public static void set_playerSpeed(this OnlinePlayerMovement self, float playerSpeed)
            => self.field_Private_Single_1 = playerSpeed;


        public static Rigidbody get_rb(this OnlinePlayerMovement self)
            => self.field_Private_Rigidbody_0;

        public static void set_rb(this OnlinePlayerMovement self, Rigidbody rb)
            => self.field_Private_Rigidbody_0 = rb;


        public static float get_moveSpeed(this OnlinePlayerMovement self)
            => self.field_Private_Single_2;

        public static void set_moveSpeed(this OnlinePlayerMovement self, float moveSpeed)
            => self.field_Private_Single_2 = moveSpeed;


        public static float get_rotationSpeed(this OnlinePlayerMovement self)
            => self.field_Private_Single_3;

        public static void set_rotationSpeed(this OnlinePlayerMovement self, float rotationSpeed)
            => self.field_Private_Single_3 = rotationSpeed;


        public static float get_deobf_unusedFloatEight(this OnlinePlayerMovement self)
            => self.field_Private_Single_4;

        public static void set_deobf_unusedFloatEight(this OnlinePlayerMovement self, float deobf_unusedFloatEight)
            => self.field_Private_Single_4 = deobf_unusedFloatEight;


        public static Vector3 get_crouchScale(this OnlinePlayerMovement self)
            => self.field_Private_Vector3_3;

        public static void set_crouchScale(this OnlinePlayerMovement self, Vector3 crouchScale)
            => self.field_Private_Vector3_3 = crouchScale;


        public static Vector3 get_deobf_unusedSpawnPos(this OnlinePlayerMovement self)
            => self.field_Private_Vector3_4;

        public static void set_deobf_unusedSpawnPos(this OnlinePlayerMovement self, Vector3 deobf_unusedSpawnPos)
            => self.field_Private_Vector3_4 = deobf_unusedSpawnPos;


        public static Vector3 get_deobf_unusedSpawnPosUsed(this OnlinePlayerMovement self)
            => self.field_Private_Vector3_5;

        public static void set_deobf_unusedSpawnPosUsed(this OnlinePlayerMovement self, Vector3 deobf_unusedSpawnPosUsed)
            => self.field_Private_Vector3_5 = deobf_unusedSpawnPosUsed;


        public static Vector3 get_deobf_unusedVector3(this OnlinePlayerMovement self)
            => self.field_Private_Vector3_6;

        public static void set_deobf_unusedVector3(this OnlinePlayerMovement self, Vector3 deobf_unusedVector3)
            => self.field_Private_Vector3_6 = deobf_unusedVector3;


        public static Vector3 get_deobf_unusedTranslationFromSpawnPos(this OnlinePlayerMovement self)
            => self.field_Private_Vector3_7;

        public static void set_deobf_unusedTranslationFromSpawnPos(this OnlinePlayerMovement self, Vector3 deobf_unusedTranslationFromSpawnPos)
            => self.field_Private_Vector3_7 = deobf_unusedTranslationFromSpawnPos;


        public static float get_deobf_unusedFloatOne(this OnlinePlayerMovement self)
            => self.field_Private_Single_5;

        public static void set_deobf_unusedFloatOne(this OnlinePlayerMovement self, float deobf_unusedFloatOne)
            => self.field_Private_Single_5 = deobf_unusedFloatOne;


        public static float get_deobf_unusedDistanceFromSpawnPos(this OnlinePlayerMovement self)
            => self.field_Private_Single_6;

        public static void set_deobf_unusedDistanceFromSpawnPos(this OnlinePlayerMovement self, float deobf_unusedDistanceFromSpawnPos)
            => self.field_Private_Single_6 = deobf_unusedDistanceFromSpawnPos;


        public static Vector3 get_playerScale(this OnlinePlayerMovement self)
            => self.field_Private_Vector3_8;

        public static void set_playerScale(this OnlinePlayerMovement self, Vector3 playerScale)
            => self.field_Private_Vector3_8 = playerScale;


        public static bool get_crouching(this OnlinePlayerMovement self)
            => self.field_Private_Boolean_0;

        public static void set_crouching(this OnlinePlayerMovement self, bool crouching)
            => self.field_Private_Boolean_0 = crouching;


        public static float get_deobf_sqrSpeed(this OnlinePlayerMovement self)
            => self.field_Private_Single_7;

        public static void set_deobf_sqrSpeed(this OnlinePlayerMovement self, float deobf_sqrSpeed)
            => self.field_Private_Single_7 = deobf_sqrSpeed;


        public static float get_deobf_maxSqrColliderSpeed(this OnlinePlayerMovement self)
            => self.field_Private_Single_8;

        public static void set_deobf_maxSqrColliderSpeed(this OnlinePlayerMovement self, float deobf_maxSqrColliderSpeed)
            => self.field_Private_Single_8 = deobf_maxSqrColliderSpeed;


        public static bool get_grounded(this OnlinePlayerMovement self)
            => self.field_Private_Boolean_1;

        public static void set_grounded(this OnlinePlayerMovement self, bool grounded)
            => self.field_Private_Boolean_1 = grounded;


        public static bool get_jumping(this OnlinePlayerMovement self)
            => self.field_Private_Boolean_2;

        public static void set_jumping(this OnlinePlayerMovement self, bool jumping)
            => self.field_Private_Boolean_2 = jumping;


        public static Collider[] get_deobf_groundCheck(this OnlinePlayerMovement self)
            => self.field_Private_ArrayOf_Collider_0;

        public static void set_deobf_groundCheck(this OnlinePlayerMovement self, Collider[] deobf_groundCheck)
            => self.field_Private_ArrayOf_Collider_0 = deobf_groundCheck;


        public static float get_currentUpperBodyRotation(this OnlinePlayerMovement self)
            => self.field_Private_Single_9;

        public static void set_currentUpperBodyRotation(this OnlinePlayerMovement self, float currentUpperBodyRotation)
            => self.field_Private_Single_9 = currentUpperBodyRotation;


        public static float get_xDir(this OnlinePlayerMovement self)
            => self.field_Private_Single_10;

        public static void set_xDir(this OnlinePlayerMovement self, float xDir)
            => self.field_Private_Single_10 = xDir;


        public static float get_yDir(this OnlinePlayerMovement self)
            => self.field_Private_Single_11;

        public static void set_yDir(this OnlinePlayerMovement self, float yDir)
            => self.field_Private_Single_11 = yDir;


        public static Vector3 get_deobf_inverseVelocity(this OnlinePlayerMovement self)
            => self.field_Private_Vector3_9;

        public static void set_deobf_inverseVelocity(this OnlinePlayerMovement self, Vector3 deobf_inverseVelocity)
            => self.field_Private_Vector3_9 = deobf_inverseVelocity;


        public static void Animate(this OnlinePlayerMovement self)
            => self.Method_Private_Void_0();


        public static void AnimationStateChecks(this OnlinePlayerMovement self)
            => self.Method_Private_Void_1();
    }

    public static class OutlineExtensions
    {
        public static HashSet<Mesh> get_registeredMeshes()
            => Outline.field_Private_Static_HashSet_1_Mesh_0;

        public static void set_registeredMeshes(HashSet<Mesh> registeredMeshes)
            => Outline.field_Private_Static_HashSet_1_Mesh_0 = registeredMeshes;


        public static Renderer[] get_renderers(this Outline self)
            => self.field_Private_ArrayOf_Renderer_0;

        public static void set_renderers(this Outline self, Renderer[] renderers)
            => self.field_Private_ArrayOf_Renderer_0 = renderers;


        public static Material get_outlineMaskMaterial(this Outline self)
            => self.field_Private_Material_0;

        public static void set_outlineMaskMaterial(this Outline self, Material outlineMaskMaterial)
            => self.field_Private_Material_0 = outlineMaskMaterial;


        public static Material get_outlineFillMaterial(this Outline self)
            => self.field_Private_Material_1;

        public static void set_outlineFillMaterial(this Outline self, Material outlineFillMaterial)
            => self.field_Private_Material_1 = outlineFillMaterial;


        public static bool get_needsUpdate(this Outline self)
            => self.field_Private_Boolean_0;

        public static void set_needsUpdate(this Outline self, bool needsUpdate)
            => self.field_Private_Boolean_0 = needsUpdate;


        public static Outline_Mode get_OutlineMode(this Outline self)
            => self.prop_EnumNPublicSealedvaOuSiOu6vOuOuUnique_0;

        public static void set_OutlineMode(this Outline self, Outline_Mode OutlineMode)
            => self.prop_EnumNPublicSealedvaOuSiOu6vOuOuUnique_0 = OutlineMode;


        public static Color get_OutlineColor(this Outline self)
            => self.prop_Color_0;

        public static void set_OutlineColor(this Outline self, Color OutlineColor)
            => self.prop_Color_0 = OutlineColor;


        public static float get_OutlineWidth(this Outline self)
            => self.prop_Single_0;

        public static void set_OutlineWidth(this Outline self, float OutlineWidth)
            => self.prop_Single_0 = OutlineWidth;


        public static List<Vector3> SmoothNormals(this Outline self, Mesh mesh)
            => self.Method_Private_List_1_Vector3_Mesh_0(mesh);


        public static void LoadSmoothNormals(this Outline self)
            => self.Method_Private_Void_0();


        public static void Bake(this Outline self)
            => self.Method_Private_Void_1();


        public static void UpdateMaterialProperties(this Outline self)
            => self.Method_Private_Void_2();
    }

    public static class PacketExtensions
    {
        public static List<byte> get_buffer(this Packet self)
            => self.field_Private_List_1_Byte_0;
        
        public static void set_buffer(this Packet self, List<byte> buffer)
            => self.field_Private_List_1_Byte_0 = buffer;


        public static bool get_disposed(this Packet self)
            => self.field_Private_Boolean_0;

        public static void set_disposed(this Packet self, bool disposed)
            => self.field_Private_Boolean_0 = disposed;


        public static byte[] get_readableBuffer(this Packet self)
            => self.field_Private_ArrayOf_Byte_0;

        public static void set_buffer(this Packet self, byte[] readableBuffer)
            => self.field_Private_ArrayOf_Byte_0 = readableBuffer;


        public static int get_readPos(this Packet self)
            => self.field_Private_Int32_0;

        public static void set_readPos(this Packet self, int readPos)
            => self.field_Private_Int32_0 = readPos;


        public static byte[] CloneBytes(this Packet self)
            => self.Method_Public_ArrayOf_Byte_1();


        public static void SetBytes(this Packet self, byte[] data)
            => self.Method_Public_Void_ArrayOf_Byte_1(data);


        public static void Reset(this Packet self, bool reset)
            => self.Method_Public_Void_Boolean_PDM_1(reset);


        public static byte[] ToArray(this Packet self)
            => self.Method_Public_ArrayOf_Byte_PDM_0();


        public static int Length(this Packet self)
            => self.Method_Public_Int32_2();


        public static int UnreadLength(this Packet self)
            => self.Method_Public_Int32_3();


        public static bool ReadBool(this Packet self, bool moveReadPos = true)
            => self.Method_Public_Boolean_Boolean_0(moveReadPos);


        public static byte ReadByte(this Packet self, bool moveReadPos = true)
            => self.Method_Public_Byte_Boolean_PDM_0(moveReadPos);


        public static byte[] ReadBytes(this Packet self, int length, bool moveReadPos = true)
            => self.Method_Public_ArrayOf_Byte_Int32_Boolean_0(length, moveReadPos);


        public static float ReadFloat(this Packet self, bool moveReadPos = true)
            => self.Method_Public_Single_Boolean_0(moveReadPos);


        public static int ReadInt(this Packet self, bool moveReadPos = true)
            => self.Method_Public_Int32_Boolean_1(moveReadPos);


        public static uint Deobf_ReadUint(this Packet self, bool moveReadPos = true)
            => self.Method_Public_UInt32_Boolean_PDM_2(moveReadPos);


        public static string ReadString(this Packet self, bool moveReadPos = true)
            => self.Method_Public_String_Boolean_0(moveReadPos);


        public static short ReadShort(this Packet self, bool moveReadPos = true)
            => self.Method_Public_Int16_Boolean_PDM_1(moveReadPos);


        public static long ReadLong(this Packet self, bool moveReadPos = true)
            => self.Method_Public_Int64_Boolean_PDM_0(moveReadPos);


        public static ulong ReadUlong(this Packet self, bool moveReadPos = true)
            => self.Method_Public_UInt64_Boolean_0(moveReadPos);


        public static Vector3 ReadVector3(this Packet self, bool moveReadPos = true)
            => self.Method_Public_Vector3_Boolean_0(moveReadPos);


        public static Quaternion ReadQuaternion(this Packet self, bool moveReadPos = true)
            => self.Method_Public_Quaternion_Boolean_0(moveReadPos);


        public static void Write(this Packet self, bool value)
            => self.Method_Public_Void_Boolean_0(value);


        public static void Write(this Packet self, byte value)
            => self.Method_Public_Void_Byte_PDM_1(value);


        public static void Write(this Packet self, byte[] value)
            => self.Method_Public_Void_ArrayOf_Byte_0(value);


        public static void Write(this Packet self, float value)
            => self.Method_Public_Void_Single_0(value);


        public static void Write(this Packet self, int value)
            => self.Method_Public_Void_Int32_0(value);


        public static void Write(this Packet self, string value)
            => self.Method_Public_Void_String_0(value);


        public static void Write(this Packet self, short value)
            => self.Method_Public_Void_Int16_PDM_1(value);


        public static void Write(this Packet self, long value)
            => self.Method_Public_Void_Int64_PDM_2(value);

        
        public static void Write(this Packet self, ulong value)
            => self.Method_Public_Void_UInt64_1(value);


        public static void Write(this Packet self, Vector3 value)
            => self.Method_Public_Void_Vector3_1(value);


        public static void Write(this Packet self, Quaternion value)
            => self.Method_Public_Void_Quaternion_0(value);


        public static void WriteLength(this Packet self)
            => self.Method_Public_Void_0();


        public static void InsertInt(this Packet self, int value)
            => self.Method_Public_Void_Int32_PDM_0(value);


        public static void Dispose(this Packet self, bool reset)
            => self.Method_Protected_Virtual_New_Void_Boolean_1(reset);
    }

    public static class PhysicsObjectExtensions
    {
        public static SharedObject get_sharedObject(this PhysicsObject self)
            => self.field_Private_MonoBehaviourPublicInidBoskUnique_0;

        public static void set_sharedObject(this PhysicsObject self, SharedObject sharedObject)
            => self.field_Private_MonoBehaviourPublicInidBoskUnique_0 = sharedObject;


        public static Rigidbody get_rb(this PhysicsObject self)
            => self.field_Private_Rigidbody_0;

        public static void set_rb(this PhysicsObject self, Rigidbody rb)
            => self.field_Private_Rigidbody_0 = rb;


        public static float get_updateFrequency(this PhysicsObject self)
            => self.field_Private_Single_0;

        public static void set_updateFrequency(this PhysicsObject self, float updateFrequency)
            => self.field_Private_Single_0 = updateFrequency;


        public static Vector3 get_desiredVelocity(this PhysicsObject self)
            => self.field_Private_Vector3_0;

        public static void set_desiredVelocity(this PhysicsObject self, Vector3 desiredVelocity)
            => self.field_Private_Vector3_0 = desiredVelocity;


        public static Vector3 get_correctionVelocity(this PhysicsObject self)
            => self.field_Private_Vector3_1;

        public static void set_correctionVelocity(this PhysicsObject self, Vector3 correctionVelocity)
            => self.field_Private_Vector3_1 = correctionVelocity;


        public static Vector3 get_desiredPosition(this PhysicsObject self)
            => self.field_Private_Vector3_2;

        public static void set_desiredPosition(this PhysicsObject self, Vector3 desiredPosition)
            => self.field_Private_Vector3_2 = desiredPosition;


        public static Vector3 get_correctionPosition(this PhysicsObject self)
            => self.field_Private_Vector3_3;

        public static void set_correctionPosition(this PhysicsObject self, Vector3 correctionPosition)
            => self.field_Private_Vector3_3 = correctionPosition;


        public static Quaternion get_desiredRotation(this PhysicsObject self)
            => self.field_Private_Quaternion_0;

        public static void set_desiredRotation(this PhysicsObject self, Quaternion desiredRotation)
            => self.field_Private_Quaternion_0 = desiredRotation;


        public static Quaternion get_correctionRotation(this PhysicsObject self)
            => self.field_Private_Quaternion_1;

        public static void set_correctionRotation(this PhysicsObject self, Quaternion correctionRotation)
            => self.field_Private_Quaternion_1 = correctionRotation;


        public static Vector3 get_lastSentPosition(this PhysicsObject self)
            => self.field_Private_Vector3_4;

        public static void set_lastSentPosition(this PhysicsObject self, Vector3 lastSentPosition)
            => self.field_Private_Vector3_4 = lastSentPosition;


        public static Vector3 get_lastSentVelocity(this PhysicsObject self)
            => self.field_Private_Vector3_5;

        public static void set_lastSentVelocity(this PhysicsObject self, Vector3 lastSentVelocity)
            => self.field_Private_Vector3_5 = lastSentVelocity;


        public static Quaternion get_lastSentRotation(this PhysicsObject self)
            => self.field_Private_Quaternion_2;

        public static void set_lastSentRotation(this PhysicsObject self, Quaternion lastSentRotation)
            => self.field_Private_Quaternion_2 = lastSentRotation;


        public static float get_positionThreshold(this PhysicsObject self)
            => self.field_Private_Single_1;

        public static void set_positionThreshold(this PhysicsObject self, float positionThreshold)
            => self.field_Private_Single_1 = positionThreshold;


        public static float get_rotationThreshold(this PhysicsObject self)
            => self.field_Private_Single_2;

        public static void set_rotationThreshold(this PhysicsObject self, float rotationThreshold)
            => self.field_Private_Single_2 = rotationThreshold;


        public static float get_timeSinceLastSnapshot(this PhysicsObject self)
            => self.field_Private_Single_3;

        public static void set_timeSinceLastSnapshot(this PhysicsObject self, float timeSinceLastSnapshot)
            => self.field_Private_Single_3 = timeSinceLastSnapshot;


        public static LinkedList<PhysicsObject_Snapshot> get_positionHistory(this PhysicsObject self)
            => self.field_Private_LinkedList_1_ObjectNPrivateVeQuVeUnique_0;

        public static void set_positionHistory(this PhysicsObject self, LinkedList<PhysicsObject_Snapshot> positionHistory)
            => self.field_Private_LinkedList_1_ObjectNPrivateVeQuVeUnique_0 = positionHistory;


        public static int get_snapshotsPerSecond(this PhysicsObject self)
            => self.field_Private_Int32_0;

        public static void set_snapshotsPerSecond(this PhysicsObject self, int snapshotsPerSecond)
            => self.field_Private_Int32_0 = snapshotsPerSecond;


        public static float get_snapshotSendRate(this PhysicsObject self)
            => self.field_Private_Single_4;

        public static void set_snapshotSendRate(this PhysicsObject self, float snapshotSendRate)
            => self.field_Private_Single_4 = snapshotSendRate;


        public static float get_damageThreshold(this PhysicsObject self)
            => self.field_Private_Single_5;

        public static void set_damageThreshold(this PhysicsObject self, float damageThreshold)
            => self.field_Private_Single_5 = damageThreshold;


        public static bool get_ready(this PhysicsObject self)
            => self.field_Private_Boolean_0;

        public static void set_ready(this PhysicsObject self, bool ready)
            => self.field_Private_Boolean_0 = ready;
    }

    public static class PhysicsObject_SnapshotExtensions
    {
        public static Vector3 get_position(this PhysicsObject_Snapshot self)
            => self.field_Public_Vector3_0;

        public static void set_position(this PhysicsObject_Snapshot self, Vector3 position)
            => self.field_Public_Vector3_0 = position;


        public static Vector3 get_velocity(this PhysicsObject_Snapshot self)
            => self.field_Public_Vector3_1;

        public static void set_velocity(this PhysicsObject_Snapshot self, Vector3 velocity)
            => self.field_Public_Vector3_1 = velocity;


        public static Quaternion get_rotation(this PhysicsObject_Snapshot self)
            => self.field_Public_Quaternion_0;

        public static void set_rotation(this PhysicsObject_Snapshot self, Quaternion rotation)
            => self.field_Public_Quaternion_0 = rotation;
    }

    public static class PiecesManagerExtensions
    {
        public static Il2CppSystem.Random get_random(this PiecesManager self)
            => self.field_Private_Random_0;

        public static void set_random(this PiecesManager self, Il2CppSystem.Random random)
            => self.field_Private_Random_0 = random;
    }

    public static class PlayerColorsExtensions
    {
        public static Color get_white()
            => PlayerColors.field_Private_Static_Color_0;

        public static void set_white(Color white)
            => PlayerColors.field_Private_Static_Color_0 = white;


        public static Color get_black()
            => PlayerColors.field_Private_Static_Color_1;

        public static void set_black(Color black)
            => PlayerColors.field_Private_Static_Color_1 = black;


        public static Color get_red()
            => PlayerColors.field_Private_Static_Color_2;

        public static void set_red(Color red)
            => PlayerColors.field_Private_Static_Color_2 = red;


        public static Color get_orange()
            => PlayerColors.field_Private_Static_Color_3;

        public static void set_orange(Color orange)
            => PlayerColors.field_Private_Static_Color_3 = orange;


        public static Color get_yellow()
            => PlayerColors.field_Private_Static_Color_4;

        public static void set_yellow(Color yellow)
            => PlayerColors.field_Private_Static_Color_4 = yellow;


        public static Color get_dream()
            => PlayerColors.field_Private_Static_Color_5;

        public static void set_dream(Color dream)
            => PlayerColors.field_Private_Static_Color_5 = dream;


        public static Color get_green()
            => PlayerColors.field_Private_Static_Color_6;

        public static void set_green(Color green)
            => PlayerColors.field_Private_Static_Color_6 = green;


        public static Color get_turquoise()
            => PlayerColors.field_Private_Static_Color_7;

        public static void set_turquoise(Color turquoise)
            => PlayerColors.field_Private_Static_Color_7 = turquoise;


        public static Color get_cyan()
            => PlayerColors.field_Private_Static_Color_8;

        public static void set_cyan(Color cyan)
            => PlayerColors.field_Private_Static_Color_8 = cyan;


        public static Color get_ocean()
            => PlayerColors.field_Private_Static_Color_9;

        public static void set_ocean(Color ocean)
            => PlayerColors.field_Private_Static_Color_9 = ocean;


        public static Color get_blue()
            => PlayerColors.field_Private_Static_Color_10;

        public static void set_blue(Color blue)
            => PlayerColors.field_Private_Static_Color_10 = blue;


        public static Color get_violet()
            => PlayerColors.field_Private_Static_Color_11;

        public static void set_violet(Color violet)
            => PlayerColors.field_Private_Static_Color_11 = violet;


        public static Color get_magenta()
            => PlayerColors.field_Private_Static_Color_12;

        public static void set_magenta(Color magenta)
            => PlayerColors.field_Private_Static_Color_12 = magenta;


        public static Color get_raspberry()
            => PlayerColors.field_Private_Static_Color_13;

        public static void set_raspberry(Color raspberry)
            => PlayerColors.field_Private_Static_Color_13 = raspberry;


        public static Color[] get_allColors()
            => PlayerColors.field_Private_Static_ArrayOf_Color_0;

        public static void set_allColors(Color[] allColors)
            => PlayerColors.field_Private_Static_ArrayOf_Color_0 = allColors;
    }

    public static class PlayerCustomizationExtensions
    {
        public static Vector3 get_deobf_crownPosition(this PlayerCustomization self)
            => self.field_Private_Vector3_0;

        public static void set_deobf_crownPosition(this PlayerCustomization self, Vector3 deobf_crownPosition)
            => self.field_Private_Vector3_0 = deobf_crownPosition;
    }

    public static class PlayerEyesExtensions
    {
        public static bool get_canSee(this PlayerEyes self)
            => self.field_Private_Boolean_0;

        public static void set_canSee(this PlayerEyes self, bool canSee)
            => self.field_Private_Boolean_0 = canSee;


        public static Quaternion get_deobf_defaultRotation(this PlayerEyes self)
            => self.field_Private_Quaternion_0;

        public static void set_deobf_defaultRotation(this PlayerEyes self, Quaternion deobf_defaultRotation)
            => self.field_Private_Quaternion_0 = deobf_defaultRotation;


        public static Vector3 get_deobf_targetOffset(this PlayerEyes self)
            => self.field_Private_Vector3_0;

        public static void set_deobf_targetOffset(this PlayerEyes self, Vector3 deobf_targetOffset)
            => self.field_Private_Vector3_0 = deobf_targetOffset;


        public static void UpdateTarget(this PlayerEyes self)
            => self.Method_Private_Void_PDM_81();
    }

    public static class PlayerInventoryExtensions
    {
        public static ItemData[] get_inventory()
            => PlayerInventory.field_Private_Static_ArrayOf_ItemData_0;

        public static void set_inventory(ItemData[] inventory)
            => PlayerInventory.field_Private_Static_ArrayOf_ItemData_0 = inventory;


        public static int[] get_primarySlot()
            => PlayerInventory.field_Private_Static_ArrayOf_Int32_0;

        public static void set_primarySlot(int[] primarySlot)
            => PlayerInventory.field_Private_Static_ArrayOf_Int32_0 = primarySlot;


        public static int[] get_secondarySlot()
            => PlayerInventory.field_Private_Static_ArrayOf_Int32_1;

        public static void set_secondarySlot(int[] secondarySlot)
            => PlayerInventory.field_Private_Static_ArrayOf_Int32_1 = secondarySlot;


        public static int[] get_meleeSlot()
            => PlayerInventory.field_Private_Static_ArrayOf_Int32_2;

        public static void set_meleeSlot(int[] meleeSlot)
            => PlayerInventory.field_Private_Static_ArrayOf_Int32_2 = meleeSlot;


        public static int[] get_throwableSlot()
            => PlayerInventory.field_Private_Static_ArrayOf_Int32_3;

        public static void set_throwableSlot(int[] throwableSlot)
            => PlayerInventory.field_Private_Static_ArrayOf_Int32_3 = throwableSlot;


        public static int[] get_otherSlot()
            => PlayerInventory.field_Private_Static_ArrayOf_Int32_4;

        public static void set_otherSlot(int[] otherSlot)
            => PlayerInventory.field_Private_Static_ArrayOf_Int32_4 = otherSlot;


        public static int get_activeSlot(this PlayerInventory self)
            => self.field_Private_Int32_0;

        public static void set_activeSlot(this PlayerInventory self, int activeSlot)
            => self.field_Private_Int32_0 = activeSlot;


        public static int get_previousSlot(this PlayerInventory self)
            => self.field_Private_Int32_1;

        public static void set_previousSlot(this PlayerInventory self, int previousSlot)
            => self.field_Private_Int32_1 = previousSlot;


        public static int get_lastSentItem(this PlayerInventory self)
            => self.field_Private_Int32_2;

        public static void set_lastSentItem(this PlayerInventory self, int lastSentItem)
            => self.field_Private_Int32_2 = lastSentItem;


        public static bool get_locked(this PlayerInventory self)
            => self.field_Private_Boolean_0;

        public static void set_locked(this PlayerInventory self, bool locked)
            => self.field_Private_Boolean_0 = locked;


        public static void PlayWosh(this PlayerInventory self)
            => self.Method_Private_Void_PDM_5();
    }

    public static class PlayerListExtensions
    {
        public static Dictionary<ulong, PlayerListingPrefab> get_players(this PlayerList self)
            => self.field_Private_Dictionary_2_UInt64_MonoBehaviourPublicRabaicRaTeusscTepiObUnique_0;

        public static void set_players(this PlayerList self, Dictionary<ulong, PlayerListingPrefab> players)
            => self.field_Private_Dictionary_2_UInt64_MonoBehaviourPublicRabaicRaTeusscTepiObUnique_0 = players;


        public static void UpdatePlayerListing(this PlayerList self, ulong clientId)
            => self.Method_Private_Void_UInt64_0(clientId);
    }

    public static class PlayerListingPrefabExtensions
    {
        public static PlayerManager get_pm(this PlayerListingPrefab self)
            => self.field_Private_MonoBehaviourPublicCSstReshTrheObplBojuUnique_0;

        public static void set_pm(this PlayerListingPrefab self, PlayerManager pm)
            => self.field_Private_MonoBehaviourPublicCSstReshTrheObplBojuUnique_0 = pm;


        public static ulong get_deobf_clientId(this PlayerListingPrefab self)
            => self.field_Private_UInt64_0;

        public static void set_deobf_clientId(this PlayerListingPrefab self, ulong deobf_clientId)
            => self.field_Private_UInt64_0 = deobf_clientId;
    }

    public static class PlayerManagerExtensions
    {
        public static int get_backing_ping(this PlayerManager self)
            => self.field_Private_Int32_0;

        public static void set_backing_ping(this PlayerManager self, int backing_ping)
            => self.field_Private_Int32_0 = backing_ping;


        public static OnlinePlayerMovement get_backing_onlinePlayerMovement(this PlayerManager self)
            => self.field_Private_MonoBehaviourPublicObVeSiVeRiSiAnVeanTrUnique_0;

        public static void set_backing_onlinePlayerMovement(this PlayerManager self, OnlinePlayerMovement backing_onlinePlayerMovement)
            => self.field_Private_MonoBehaviourPublicObVeSiVeRiSiAnVeanTrUnique_0 = backing_onlinePlayerMovement;


        public static Texture get_backing_profileTexture(this PlayerManager self)
            => self.prop_Texture_0;

        public static void set_backing_profileTexture(this PlayerManager self, Texture backing_profileTexture)
            => self.field_Private_Texture_0 = backing_profileTexture;


        public static bool get_forceMute(this PlayerManager self)
            => self.field_Private_Boolean_0;

        public static void set_forceMute(this PlayerManager self, bool forceMute)
            => self.field_Private_Boolean_0 = forceMute;


        public static int get_ping(this PlayerManager self)
            => self.prop_Int32_0;

        public static void set_ping(this PlayerManager self, int ping)
            => self.prop_Int32_0 = ping;


        public static OnlinePlayerMovement get_onlinePlayerMovement(this PlayerManager self)
            => self.prop_MonoBehaviourPublicObVeSiVeRiSiAnVeanTrUnique_0;

        public static void set_onlinePlayerMovement(this PlayerManager self, OnlinePlayerMovement onlinePlayerMovement)
            => self.prop_MonoBehaviourPublicObVeSiVeRiSiAnVeanTrUnique_0 = onlinePlayerMovement;


        public static Texture get_profileTexture(this PlayerManager self)
            => self.prop_Texture_0;

        public static void set_profileTexture(this PlayerManager self, Texture profileTexture)
            => self.prop_Texture_0 = profileTexture;


        public static void LoadAvatar(this PlayerManager self)
            => self.Method_Private_Void_0();
    }

    public static class PlayerMovementExtensions
    {
        public static Rigidbody get_rb(this PlayerMovement self)
            => self.field_Private_Rigidbody_0;

        public static void set_rb(this PlayerMovement self, Rigidbody rb)
            => self.field_Private_Rigidbody_0 = rb;


        public static float get_moveSpeed(this PlayerMovement self)
            => self.field_Private_ObscuredFloat_0.Read();

        public static void set_moveSpeed(this PlayerMovement self, float moveSpeed)
            => self.field_Private_ObscuredFloat_0 = moveSpeed.Obscure();


        public static float get_defaultMoveSpeed(this PlayerMovement self)
            => self.field_Private_ObscuredFloat_1.Read();

        public static void set_defaultMoveSpeed(this PlayerMovement self, float defaultMoveSpeed)
            => self.field_Private_ObscuredFloat_1 = defaultMoveSpeed.Obscure();


        public static float get_iceMoveSpeed(this PlayerMovement self)
            => self.field_Private_ObscuredFloat_2.Read();

        public static void set_iceMoveSpeed(this PlayerMovement self, float iceMoveSpeed)
            => self.field_Private_ObscuredFloat_2 = iceMoveSpeed.Obscure();


        public static float get_iceMoveSpeedFaster(this PlayerMovement self)
            => self.field_Private_ObscuredFloat_3.Read();

        public static void set_iceMoveSpeedFaster(this PlayerMovement self, float iceMoveSpeedFaster)
            => self.field_Private_ObscuredFloat_3 = iceMoveSpeedFaster.Obscure();


        public static float get_maxWalkSpeed(this PlayerMovement self)
            => self.field_Private_ObscuredFloat_4.Read();

        public static void set_maxWalkSpeed(this PlayerMovement self, float maxWalkSpeed)
            => self.field_Private_ObscuredFloat_4 = maxWalkSpeed.Obscure();


        public static float get_maxRunSpeed(this PlayerMovement self)
            => self.field_Private_ObscuredFloat_5.Read();

        public static void set_maxRunSpeed(this PlayerMovement self, float maxRunSpeed)
            => self.field_Private_ObscuredFloat_5 = maxRunSpeed.Obscure();


        public static float get_maxSpeed(this PlayerMovement self)
            => self.field_Private_ObscuredFloat_6.Read();

        public static void set_maxSpeed(this PlayerMovement self, float maxSpeed)
            => self.field_Private_ObscuredFloat_6 = maxSpeed.Obscure();


        public static float get_slideForce(this PlayerMovement self)
            => self.field_Private_ObscuredFloat_7.Read();

        public static void set_slideForce(this PlayerMovement self, float slideForce)
            => self.field_Private_ObscuredFloat_7 = slideForce.Obscure();


        public static Vector3 get_playerScale(this PlayerMovement self)
            => self.field_Private_Vector3_0;

        public static void set_playerScale(this PlayerMovement self, Vector3 playerScale)
            => self.field_Private_Vector3_0 = playerScale;


        public static Vector3 get_crouchScale(this PlayerMovement self)
            => self.field_Private_Vector3_1;

        public static void set_crouchScale(this PlayerMovement self, Vector3 crouchScale)
            => self.field_Private_Vector3_1 = crouchScale;


        public static float get_backing_playerHeight(this PlayerMovement self)
            => self.field_Private_Single_0;

        public static void set_backing_playerHeight(this PlayerMovement self, float backing_playerHeight)
            => self.field_Private_Single_0 = backing_playerHeight;


        public static float get_slideCounterMovement(this PlayerMovement self)
            => self.field_Private_Single_1;

        public static void set_slideCounterMovement(this PlayerMovement self, float slideCounterMovement)
            => self.field_Private_Single_1 = slideCounterMovement;


        public static bool get_readyTojump(this PlayerMovement self)
            => self.field_Private_ObscuredBool_0.Read();

        public static void set_readyTojump(this PlayerMovement self, bool readyTojump)
            => self.field_Private_ObscuredBool_0 = readyTojump.Obscure();


        public static float get_jumpCooldown(this PlayerMovement self)
            => self.field_Private_Single_2;

        public static void set_jumpCooldown(this PlayerMovement self, float jumpCooldown)
            => self.field_Private_Single_2 = jumpCooldown;


        public static float get_jumpForce(this PlayerMovement self)
            => self.field_Private_Single_3;

        public static void set_jumpForce(this PlayerMovement self, float jumpForce)
            => self.field_Private_Single_3 = jumpForce;


        public static int get_jumps(this PlayerMovement self)
            => self.field_Private_Int32_0;

        public static void set_jumps(this PlayerMovement self, int jumps)
            => self.field_Private_Int32_0 = jumps;


        public static float get_x(this PlayerMovement self)
            => self.field_Private_Single_4;

        public static void set_x(this PlayerMovement self, float x)
            => self.field_Private_Single_4 = x;


        public static float get_y(this PlayerMovement self)
            => self.field_Private_Single_5;

        public static void set_y(this PlayerMovement self, float y)
            => self.field_Private_Single_5 = y;


        public static float get_mouseDeltaX(this PlayerMovement self)
            => self.field_Private_Single_6;

        public static void set_mouseDeltaX(this PlayerMovement self, float mouseDeltaX)
            => self.field_Private_Single_6 = mouseDeltaX;


        public static float get_mouseDeltaY(this PlayerMovement self)
            => self.field_Private_Single_7;

        public static void set_mouseDeltaY(this PlayerMovement self, float mouseDeltaY)
            => self.field_Private_Single_7 = mouseDeltaY;


        public static bool get_backing_jumping(this PlayerMovement self)
            => self.field_Private_Boolean_0;

        public static void set_backing_jumping(this PlayerMovement self, bool backing_jumping)
            => self.field_Private_Boolean_0 = backing_jumping;


        public static bool get_backing_crouching(this PlayerMovement self)
            => self.field_Private_Boolean_1;

        public static void set_backing_crouching(this PlayerMovement self, bool backing_crouching)
            => self.field_Private_Boolean_1 = backing_crouching;


        public static bool get_backing_sprinting(this PlayerMovement self)
            => self.field_Private_Boolean_2;

        public static void set_backing_sprinting(this PlayerMovement self, bool backing_sprinting)
            => self.field_Private_Boolean_2 = backing_sprinting;
        

        public static PlayerMovement_CrouchState get_crouchState(this PlayerMovement self)
            => self.field_Private_EnumNPrivateSealedvaNoCrSl4vUnique_0;

        public static void set_crouchState(this PlayerMovement self, PlayerMovement_CrouchState crouchState)
            => self.field_Private_EnumNPrivateSealedvaNoCrSl4vUnique_0 = crouchState;


        public static Vector3 get_normalVector(this PlayerMovement self)
            => self.field_Private_Vector3_2;

        public static void set_normalVector(this PlayerMovement self, Vector3 normalVector)
            => self.field_Private_Vector3_2 = normalVector;


        public static ParticleSystem.EmissionModule get_psEmission(this PlayerMovement self)
            => self.field_Private_EmissionModule_0;

        public static void set_psEmission(this PlayerMovement self, ParticleSystem.EmissionModule psEmission)
            => self.field_Private_EmissionModule_0 = psEmission;


        public static Collider get_playerCollider(this PlayerMovement self)
            => self.field_Private_Collider_0;

        public static void set_playerCollider(this PlayerMovement self, Collider playerCollider)
            => self.field_Private_Collider_0 = playerCollider;


        public static float get_fallSpeed(this PlayerMovement self)
            => self.field_Private_Single_8;

        public static void set_fallSpeed(this PlayerMovement self, float fallSpeed)
            => self.field_Private_Single_8 = fallSpeed;


        public static PlayerMovement get_backing_Instance()
            => PlayerMovement.field_Private_Static_MonoBehaviourPublicGaplfoGaTrorplTrRiBoUnique_0;

        public static void set_backing_Instance(PlayerMovement backing_Instance)
            => PlayerMovement.field_Private_Static_MonoBehaviourPublicGaplfoGaTrorplTrRiBoUnique_0 = backing_Instance;


        public static float get_deobf_crouchCooldownTime(this PlayerMovement self)
            => self.field_Private_Single_9;

        public static void set_deobf_crouchCooldownTime(this PlayerMovement self, float deobf_crouchCooldownTime)
            => self.field_Private_Single_9 = deobf_crouchCooldownTime;


        public static bool get_deobf_crouchCooldown(this PlayerMovement self)
            => self.field_Private_Boolean_3;

        public static void set_deobf_crouchCooldown(this PlayerMovement self, bool deobf_crouchCooldown)
            => self.field_Private_Boolean_3 = deobf_crouchCooldown;


        public static float get_slideCooldown(this PlayerMovement self)
            => self.field_Private_Single_10;

        public static void set_slideCooldown(this PlayerMovement self, float slideCooldown)
            => self.field_Private_Single_10 = slideCooldown;


        public static bool get_readyToSlide(this PlayerMovement self)
            => self.field_Private_Boolean_4;

        public static void set_readyToSlide(this PlayerMovement self, bool readyToSlide)
            => self.field_Private_Boolean_4 = readyToSlide;


        public static bool get_justLanded(this PlayerMovement self)
            => self.field_Private_Boolean_5;

        public static void set_justLanded(this PlayerMovement self, bool justLanded)
            => self.field_Private_Boolean_5 = justLanded;


        public static float get_deobf_maxFootstepDistance(this PlayerMovement self)
            => self.field_Private_Single_11;

        public static void set_deobf_maxFootstepDistance(this PlayerMovement self, float deobf_maxFootstepDistance)
            => self.field_Private_Single_11 = deobf_maxFootstepDistance;


        public static float get_distance(this PlayerMovement self)
            => self.field_Private_Single_12;

        public static void set_distance(this PlayerMovement self, float distance)
            => self.field_Private_Single_12 = distance;


        public static float get_swimSpeed(this PlayerMovement self)
            => self.field_Private_ObscuredFloat_8.Read();

        public static void set_swimSpeed(this PlayerMovement self, float swimSpeed)
            => self.field_Private_ObscuredFloat_8 = swimSpeed.Obscure();


        public static float get_deobf_unusedFloatOne(this PlayerMovement self)
            => self.field_Private_ObscuredFloat_9.Read();

        public static void set_deobf_unusedFloatOne(this PlayerMovement self, float deobf_unusedFloatOne)
            => self.field_Private_ObscuredFloat_9 = deobf_unusedFloatOne.Obscure();


        public static Vector2 get_deobf_velRelativeToLook(this PlayerMovement self)
            => self.field_Private_Vector2_0;

        public static void set_deobf_velRelativeToLook(this PlayerMovement self, Vector2 deobf_velRelativeToLook)
            => self.field_Private_Vector2_0 = deobf_velRelativeToLook;


        public static float get_deobf_velRelativeToLookX(this PlayerMovement self)
            => self.field_Private_Single_13;

        public static void set_deobf_velRelativeToLookX(this PlayerMovement self, float deobf_velRelativeToLookX)
            => self.field_Private_Single_13 = deobf_velRelativeToLookX;


        public static float get_deobf_velRelativeToLookY(this PlayerMovement self)
            => self.field_Private_Single_14;

        public static void set_deobf_velRelativeToLookY(this PlayerMovement self, float deobf_velRelativeToLookY)
            => self.field_Private_Single_14 = deobf_velRelativeToLookY;


        public static float get_deobf_airDrag(this PlayerMovement self)
            => self.field_Private_Single_15;

        public static void set_deobf_airDrag(this PlayerMovement self, float deobf_airDrag)
            => self.field_Private_Single_15 = deobf_airDrag;


        public static bool get_onLadder(this PlayerMovement self)
            => self.field_Private_Boolean_6;

        public static void set_onLadder(this PlayerMovement self, bool onLadder)
            => self.field_Private_Boolean_6 = onLadder;


        public static Vector3 get_ladderNormal(this PlayerMovement self)
            => self.field_Private_Vector3_3;

        public static void set_ladderNormal(this PlayerMovement self, Vector3 ladderNormal)
            => self.field_Private_Vector3_3 = ladderNormal;


        public static Transform get_ladder(this PlayerMovement self)
            => self.field_Private_Transform_0;

        public static void set_ladder(this PlayerMovement self, Transform ladder)
            => self.field_Private_Transform_0 = ladder;


        public static float get_ladderSpeed(this PlayerMovement self)
            => self.field_Private_Single_16;

        public static void set_ladderSpeed(this PlayerMovement self, float ladderSpeed)
            => self.field_Private_Single_16 = ladderSpeed;


        public static bool get_onLadderLastFrame(this PlayerMovement self)
            => self.field_Private_Boolean_7;

        public static void set_onLadderLastFrame(this PlayerMovement self, bool onLadderLastFrame)
            => self.field_Private_Boolean_7 = onLadderLastFrame;


        public static float get_ladderRefreshTime(this PlayerMovement self)
            => self.field_Private_Single_17;

        public static void set_ladderRefreshTime(this PlayerMovement self, float ladderRefreshTime)
            => self.field_Private_Single_17 = ladderRefreshTime;


        public static Vector3 get_deobf_ladderMovement(this PlayerMovement self)
            => self.field_Private_Vector3_4;

        public static void set_deobf_ladderMovement(this PlayerMovement self, Vector3 deobf_ladderMovement)
            => self.field_Private_Vector3_4 = deobf_ladderMovement;


        public static Vector3 get_deobf_ladderMovementAngled(this PlayerMovement self)
            => self.field_Private_Vector3_5;

        public static void set_deobf_ladderMovementAngled(this PlayerMovement self, Vector3 deobf_ladderMovementAngled)
            => self.field_Private_Vector3_5 = deobf_ladderMovementAngled;


        public static float get_playerRadius(this PlayerMovement self)
            => self.field_Private_Single_18;

        public static void set_playerRadius(this PlayerMovement self, float playerRadius)
            => self.field_Private_Single_18 = playerRadius;


        public static bool get_pushed(this PlayerMovement self)
            => self.field_Private_Boolean_8;

        public static void set_pushed(this PlayerMovement self, bool pushed)
            => self.field_Private_Boolean_8 = pushed;


        public static float get_pushMultiplier(this PlayerMovement self)
            => self.field_Private_Single_19;

        public static void set_pushMultiplier(this PlayerMovement self, float pushMultiplier)
            => self.field_Private_Single_19 = pushMultiplier;


        public static float get_pushResetSpeed(this PlayerMovement self)
            => self.field_Private_Single_20;

        public static void set_pushResetSpeed(this PlayerMovement self, float pushResetSpeed)
            => self.field_Private_Single_20 = pushResetSpeed;


        public static bool get_onRamp(this PlayerMovement self)
            => self.field_Private_Boolean_9;

        public static void set_onRamp(this PlayerMovement self, bool onRamp)
            => self.field_Private_Boolean_9 = onRamp;


        public static int get_extraJumps(this PlayerMovement self)
            => self.field_Private_Int32_1;

        public static void set_extraJumps(this PlayerMovement self, int extraJumps)
            => self.field_Private_Int32_1 = extraJumps;


        public static int get_resetJumpCounter(this PlayerMovement self)
            => self.field_Private_Int32_2;

        public static void set_resetJumpCounter(this PlayerMovement self, int resetJumpCounter)
            => self.field_Private_Int32_2 = resetJumpCounter;


        public static int get_jumpCounterResetTime(this PlayerMovement self)
            => self.field_Private_Int32_3;

        public static void set_jumpCounterResetTime(this PlayerMovement self, int jumpCounterResetTime)
            => self.field_Private_Int32_3 = jumpCounterResetTime;


        public static float get_iceMultiplier(this PlayerMovement self)
            => self.field_Private_Single_21;

        public static void set_iceMultiplier(this PlayerMovement self, float iceMultiplier)
            => self.field_Private_Single_21 = iceMultiplier;


        public static float get_iceMultiplierFaster(this PlayerMovement self)
            => self.field_Private_Single_22;

        public static void set_iceMultiplierFaster(this PlayerMovement self, float iceMultiplierFaster)
            => self.field_Private_Single_22 = iceMultiplierFaster;


        public static float get_counterMovement(this PlayerMovement self)
            => self.field_Private_Single_23;

        public static void set_counterMovement(this PlayerMovement self, float counterMovement)
            => self.field_Private_Single_23 = counterMovement;


        public static float get_defaultCounterMovement(this PlayerMovement self)
            => self.field_Private_Single_24;

        public static void set_defaultCounterMovement(this PlayerMovement self, float defaultCounterMovement)
            => self.field_Private_Single_24 = defaultCounterMovement;


        public static float get_threshold(this PlayerMovement self)
            => self.field_Private_Single_25;

        public static void set_threshold(this PlayerMovement self, float threshold)
            => self.field_Private_Single_25 = threshold;


        public static int get_readyToCounterX(this PlayerMovement self)
            => self.field_Private_Int32_4;

        public static void set_readyToCounterX(this PlayerMovement self, int readyToCounterX)
            => self.field_Private_Int32_4 = readyToCounterX;


        public static int get_readyToCounterY(this PlayerMovement self)
            => self.field_Private_Int32_5;

        public static void set_readyToCounterY(this PlayerMovement self, int readyToCounterY)
            => self.field_Private_Int32_5 = readyToCounterY;


        public static float get_slowDownSpeed(this PlayerMovement self)
            => self.field_Private_Single_26;

        public static void set_slowDownSpeed(this PlayerMovement self, float slowDownSpeed)
            => self.field_Private_Single_26 = slowDownSpeed;


        public static bool get_cancelling(this PlayerMovement self)
            => self.field_Private_Boolean_10;

        public static void set_cancelling(this PlayerMovement self, bool cancelling)
            => self.field_Private_Boolean_10 = cancelling;


        public static float get_maxSlopeAngle(this PlayerMovement self)
            => self.field_Private_Single_27;

        public static void set_maxSlopeAngle(this PlayerMovement self, float maxSlopeAngle)
            => self.field_Private_Single_27 = maxSlopeAngle;


        public static float get_slideAngle(this PlayerMovement self)
            => self.field_Private_Single_28;

        public static void set_slideAngle(this PlayerMovement self, float slideAngle)
            => self.field_Private_Single_28 = slideAngle;


        public static bool get_airborne(this PlayerMovement self)
            => self.field_Private_Boolean_11;

        public static void set_airborne(this PlayerMovement self, bool airborne)
            => self.field_Private_Boolean_11 = airborne;


        public static PlayerMovement_Surface get_surfaceType(this PlayerMovement self)
            => self.field_Private_EnumNPrivateSealedvaGeIc4vIcUnique_0;

        public static void set_surfaceType(this PlayerMovement self, PlayerMovement_Surface surfaceType)
            => self.field_Private_EnumNPrivateSealedvaGeIc4vIcUnique_0 = surfaceType;


        public static float get_minBreakFallAngle(this PlayerMovement self)
            => self.field_Private_Single_29;

        public static void set_minBreakFallAngle(this PlayerMovement self, float minBreakFallAngle)
            => self.field_Private_Single_29 = minBreakFallAngle;


        public static float get_maxBreakFallAngle(this PlayerMovement self)
            => self.field_Private_Single_30;

        public static void set_maxBreakFallAngle(this PlayerMovement self, float maxBreakFallAngle)
            => self.field_Private_Single_30 = maxBreakFallAngle;


        public static bool get_onGround(this PlayerMovement self)
            => self.field_Private_Boolean_12;

        public static void set_onGround(this PlayerMovement self, bool onGround)
            => self.field_Private_Boolean_12 = onGround;


        public static bool get_surfing(this PlayerMovement self)
            => self.field_Private_Boolean_13;

        public static void set_surfing(this PlayerMovement self, bool surfing)
            => self.field_Private_Boolean_13 = surfing;


        public static bool get_cancellingGrounded(this PlayerMovement self)
            => self.field_Private_Boolean_14;

        public static void set_cancellingGrounded(this PlayerMovement self, bool cancellingGrounded)
            => self.field_Private_Boolean_14 = cancellingGrounded;


        public static bool get_cancellingSurf(this PlayerMovement self)
            => self.field_Private_Boolean_15;

        public static void set_cancellingSurf(this PlayerMovement self, bool cancellingSurf)
            => self.field_Private_Boolean_15 = cancellingSurf;


        public static float get_delay(this PlayerMovement self)
            => self.field_Private_Single_31;

        public static void set_delay(this PlayerMovement self, float delay)
            => self.field_Private_Single_31 = delay;


        public static int get_groundCancel(this PlayerMovement self)
            => self.field_Private_Int32_6;

        public static void set_groundCancel(this PlayerMovement self, int groundCancel)
            => self.field_Private_Int32_6 = groundCancel;


        public static int get_wallCancel(this PlayerMovement self)
            => self.field_Private_Int32_7;

        public static void set_wallCancel(this PlayerMovement self, int wallCancel)
            => self.field_Private_Int32_7 = wallCancel;


        public static int get_surfCancel(this PlayerMovement self)
            => self.field_Private_Int32_8;

        public static void set_surfCancel(this PlayerMovement self, int surfCancel)
            => self.field_Private_Int32_8 = surfCancel;


        public static float get_vel(this PlayerMovement self)
            => self.field_Private_Single_32;

        public static void set_vel(this PlayerMovement self, float vel)
            => self.field_Private_Single_32 = vel;


        public static float get_playerHeight(this PlayerMovement self)
            => self.prop_Single_0;

        public static void set_playerHeight(this PlayerMovement self, float playerHeight)
            => self.prop_Single_0 = playerHeight;


        public static bool get_jumping(this PlayerMovement self)
            => self.prop_Boolean_0;

        public static void set_jumping(this PlayerMovement self, bool jumping)
            => self.prop_Boolean_0 = jumping;


        public static bool get_crouching(this PlayerMovement self)
            => self.prop_Boolean_1;

        public static void set_crouching(this PlayerMovement self, bool crouching)
            => self.prop_Boolean_1 = crouching;


        public static bool get_sprinting(this PlayerMovement self)
            => self.prop_Boolean_2;

        public static void set_sprinting(this PlayerMovement self, bool sprinting)
            => self.prop_Boolean_2 = sprinting;


        public static PlayerMovement get_Instance()
            => PlayerMovement.prop_MonoBehaviourPublicGaplfoGaTrorplTrRiBoUnique_0;

        public static void set_Instance(PlayerMovement Instance)
            => PlayerMovement.prop_MonoBehaviourPublicGaplfoGaTrorplTrRiBoUnique_0 = Instance;


        public static void CheckInput(this PlayerMovement self)
            => self.Method_Private_Void_0();


        public static void StopLadder(this PlayerMovement self)
            => self.Method_Private_Void_PDM_0();


        public static void StopGrounded(this PlayerMovement self)
            => self.Method_Private_Void_PDM_1();


        public static void RampMovement(this PlayerMovement self, Vector2 velRelativeToLook)
            => self.Method_Private_Void_Vector2_0(velRelativeToLook);


        public static void ResetJump(this PlayerMovement self)
            => self.Method_Private_Void_PDM_2();


        public static void ResetPush(this PlayerMovement self)
            => self.Method_Private_Void_PDM_3();


        public static void StopJustLanded(this PlayerMovement self)
            => self.Method_Private_Void_PDM_4();


        public static bool IsSlideable(this PlayerMovement self, Vector3 groundNormal)
            => self.Method_Private_Boolean_Vector3_PDM_0(groundNormal);


        public static void UpdateCollisionChecks(this PlayerMovement self)
            => self.Method_Private_Void_PDM_5();


        public static bool IsWall(this PlayerMovement self, Vector3 groundNormal)
            => self.Method_Private_Boolean_Vector3_PDM_1(groundNormal);


        public static void Deobf_CrouchCooldown(this PlayerMovement self)
            => self.Method_Private_Void_PDM_7();


        public static void StickToLadder(this PlayerMovement self)
            => self.Method_Private_Void_PDM_8();


        public static void Footsteps(this PlayerMovement self)
            => self.Method_Private_Void_1();


        public static void StopSlide(this PlayerMovement self)
            => self.Method_Private_Void_2();


        public static bool IsBreakingFall(this PlayerMovement self, Vector3 groundNormal, Collision collision)
            => self.Method_Private_Boolean_Vector3_Collision_0(groundNormal, collision);


        public static bool IsHoldingAgainstHorizontalVel(this PlayerMovement self, Vector2 velRelativeToLook)
            => self.Method_Private_Boolean_Vector2_PDM_1(velRelativeToLook);


        public static bool CanStopCrouching(this PlayerMovement self)
            => self.Method_Private_Boolean_0();


        public static bool IsHoldingAgainstVerticalVel(this PlayerMovement self, Vector2 velRelativeToLook)
            => self.Method_Private_Boolean_Vector2_0(velRelativeToLook);


        public static void StartSlide(this PlayerMovement self)
            => self.Method_Private_Void_3();


        public static void CounterMovement(this PlayerMovement self, float x, float y, Vector2 velRelativeToLook)
            => self.Method_Private_Void_Single_Single_Vector2_0(x, y, velRelativeToLook);


        public static void LadderMovement(this PlayerMovement self, float x, float y, Vector2 velRelativeToLook)
            => self.Method_Private_Void_Single_Single_Vector2_PDM_1(x, y, velRelativeToLook);


        public static void UpdatePushMultiplier(this PlayerMovement self)
            => self.Method_Private_Void_PDM_11();


        public static void StopSurf(this PlayerMovement self)
            => self.Method_Private_Void_PDM_12();


        public static void SlideCooldown(this PlayerMovement self)
            => self.Method_Private_Void_PDM_14();


        public static void SetKinematic(this PlayerMovement self, bool kinematic)
            => self.Method_Private_Void_Boolean_0(kinematic);


        public static bool IsSurf(this PlayerMovement self, Vector3 groundNormal)
            => self.Method_Private_Boolean_Vector3_PDM_4(groundNormal);


        public static bool HasFooting(this PlayerMovement self)
            => self.Method_Private_Boolean_1();


        public static bool IsFloor(this PlayerMovement self, Vector3 groundNormal)
            => self.Method_Private_Boolean_Vector3_PDM_5(groundNormal);


        public static bool IsTouchingGround(this PlayerMovement self)
            => self.Method_Private_Boolean_2();


        public static bool IsRoof(this PlayerMovement self, Vector3 groundNormal)
            => self.Method_Private_Boolean_Vector3_PDM_6(groundNormal);


        public static void JumpCooldown(this PlayerMovement self)
            => self.Method_Private_Void_PDM_15();


        public static void WaterMovement(this PlayerMovement self)
            => self.Method_Private_Void_PDM_16();


        public static void UpdateCrouchState(this PlayerMovement self)
            => self.Method_Private_Void_PDM_17();
    }

    public static class PlayerServerCommunicationExtensions
    {
        public static int get_lastSentHp(this PlayerServerCommunication self)
            => self.field_Private_Int32_0;

        public static void set_lastSentHp(this PlayerServerCommunication self, int lastSentHp)
            => self.field_Private_Int32_0 = lastSentHp;


        public static float get_hpThreshold(this PlayerServerCommunication self)
            => self.field_Private_Single_0;

        public static void set_hpThreshold(this PlayerServerCommunication self, float hpThreshold)
            => self.field_Private_Single_0 = hpThreshold;


        public static float get_posThreshold(this PlayerServerCommunication self)
            => self.field_Private_Single_1;

        public static void set_posThreshold(this PlayerServerCommunication self, float posThreshold)
            => self.field_Private_Single_1 = posThreshold;


        public static float get_rotThreshold(this PlayerServerCommunication self)
            => self.field_Private_Single_2;

        public static void set_rotThreshold(this PlayerServerCommunication self, float rotThreshold)
            => self.field_Private_Single_2 = rotThreshold;


        public static Vector3 get_lastSentPosition(this PlayerServerCommunication self)
            => self.field_Private_Vector3_0;

        public static void set_lastSentPosition(this PlayerServerCommunication self, Vector3 lastSentPosition)
            => self.field_Private_Vector3_0 = lastSentPosition;


        public static float get_lastSentRotationY(this PlayerServerCommunication self)
            => self.field_Private_Single_3;

        public static void set_lastSentRotationY(this PlayerServerCommunication self, float lastSentRotationY)
            => self.field_Private_Single_3 = lastSentRotationY;


        public static float get_lastSentRotationX(this PlayerServerCommunication self)
            => self.field_Private_Single_4;

        public static void set_lastSentRotationX(this PlayerServerCommunication self, float lastSentRotationX)
            => self.field_Private_Single_4 = lastSentRotationX;


        public static float get_lastSentXZ(this PlayerServerCommunication self)
            => self.field_Private_Single_5;

        public static void set_lastSentXZ(this PlayerServerCommunication self, float lastSentXZ)
            => self.field_Private_Single_5 = lastSentXZ;


        public static float get_lastSentBlendX(this PlayerServerCommunication self)
            => self.field_Private_Single_6;

        public static void set_lastSentBlendX(this PlayerServerCommunication self, float lastSentBlendX)
            => self.field_Private_Single_6 = lastSentBlendX;


        public static float get_lastSentBlendZ(this PlayerServerCommunication self)
            => self.field_Private_Single_7;

        public static void set_lastSentBlendZ(this PlayerServerCommunication self, float lastSentBlendZ)
            => self.field_Private_Single_7 = lastSentBlendZ;


        public static float get_closeDistance(this PlayerServerCommunication self)
            => self.field_Private_Single_8;

        public static void set_closeDistance(this PlayerServerCommunication self, float closeDistance)
            => self.field_Private_Single_8 = closeDistance;


        public static float get_mediumDistance(this PlayerServerCommunication self)
            => self.field_Private_Single_9;

        public static void set_mediumDistance(this PlayerServerCommunication self, float mediumDistance)
            => self.field_Private_Single_9 = mediumDistance;


        public static float get_farDistance(this PlayerServerCommunication self)
            => self.field_Private_Single_10;

        public static void set_farDistance(this PlayerServerCommunication self, float farDistance)
            => self.field_Private_Single_10 = farDistance;


        public static float get_slowUpdateFrequency(this PlayerServerCommunication self)
            => self.field_Private_Single_11;

        public static void set_slowUpdateFrequency(this PlayerServerCommunication self, float slowUpdateFrequency)
            => self.field_Private_Single_11 = slowUpdateFrequency;


        public static bool get_lastSentCrouching(this PlayerServerCommunication self)
            => self.field_Private_Boolean_0;

        public static void set_lastSentCrouching(this PlayerServerCommunication self, bool lastSentCrouching)
            => self.field_Private_Boolean_0 = lastSentCrouching;


        public static int get_deobf_unusedIntTen(this PlayerServerCommunication self)
            => self.field_Private_Int32_1;

        public static void set_deobf_unusedIntTen(this PlayerServerCommunication self, int deobf_unusedIntTen)
            => self.field_Private_Int32_1 = deobf_unusedIntTen;


        /**
         * <summary>This is a Coroutine: <see cref="PlayerServerCommunication.ObjectNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSire841diVoObMoUnique"/></summary>
         */
        public static IEnumerator RotationUpdate(this PlayerServerCommunication self, float interval, PlayerServerCommunication_RenderDistance distance)
            => self.Method_Private_IEnumerator_Single_EnumNPublicSealedvaClMeFaAn5vUnique_0(interval, distance);


        public static void CrouchUpdate(this PlayerServerCommunication self)
            => self.Method_Private_Void_PDM_7();


        public static void SendRotationToAll(this PlayerServerCommunication self, float x, float y, PlayerServerCommunication_RenderDistance distance)
            => self.Method_Private_Void_Single_Single_EnumNPublicSealedvaClMeFaAn5vUnique_0(x, y, distance);


        /**
         * <summary>This is a Coroutine: <see cref="PlayerServerCommunication.ObjectNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSire41di8VoObMoUnique"/></summary>
         */
        public static IEnumerator PositionUpdate(this PlayerServerCommunication self, float interval, PlayerServerCommunication_RenderDistance distance)
            => self.Method_Private_IEnumerator_Single_EnumNPublicSealedvaClMeFaAn5vUnique_1(interval, distance);


        public static void UpdateDistancesList(this PlayerServerCommunication self)
            => self.Method_Private_Void_PDM_16();


        public static void SendPositionToAll(this PlayerServerCommunication self, Vector3 position, PlayerServerCommunication_RenderDistance distance)
            => self.Method_Private_Void_Vector3_EnumNPublicSealedvaClMeFaAn5vUnique_0(position, distance);
    }

    public static class PlayersInLobbyExtensions
    {
        public static void UpdatePlayerCount(this PlayersInLobby self)
            => self.Method_Private_Void_0();
    }

    public static class PlayerStatusExtensions
    {
        public static void UpdateStatusUI(this PlayerStatus self)
            => self.Method_Private_Void_2();


        public static void PlayerDied(this PlayerStatus self, ulong clientId, Vector3 impactNormal)
            => self.Method_Private_Void_UInt64_Vector3_0(clientId, impactNormal);
    }

    public static class PlayerVoiceExtensions
    {
        public static InterfacePublicAbstractStVeQuObBogeStgeVeQuUnique get_player(this PlayerVoice self)
            => self.field_Private_InterfacePublicAbstractStVeQuObBogeStgeVeQuUnique_0;

        public static void set_player(this PlayerVoice self, InterfacePublicAbstractStVeQuObBogeStgeVeQuUnique player)
            => self.field_Private_InterfacePublicAbstractStVeQuObBogeStgeVeQuUnique_0 = player;


        public static ObjectPublicAbstractObStAc12ObAc1BoStUnique get_state(this PlayerVoice self)
            => self.field_Private_ObjectPublicAbstractObStAc12ObAc1BoStUnique_0;

        public static void set_state(this PlayerVoice self, ObjectPublicAbstractObStAc12ObAc1BoStUnique state)
            => self.field_Private_ObjectPublicAbstractObStAc12ObAc1BoStUnique_0 = state;


        public static bool get_transmitting(this PlayerVoice self)
            => self.field_Private_Boolean_0;

        public static void set_transmitting(this PlayerVoice self, bool transmitting)
            => self.field_Private_Boolean_0 = transmitting;


        public static void SetIcon(this PlayerVoice self, bool transmitting)
            => self.Method_Private_Void_Boolean_6(transmitting);
    }

    public static class PPControllerExtensions
    {
        public static MotionBlur get_motionBlur(this PPController self)
            => self.field_Private_MotionBlur_0;

        public static void set_motionBlur(this PPController self, MotionBlur motionBlur)
            => self.field_Private_MotionBlur_0 = motionBlur;


        public static Bloom get_bloom(this PPController self)
            => self.field_Private_Bloom_0;

        public static void set_bloom(this PPController self, Bloom bloom)
            => self.field_Private_Bloom_0 = bloom;


        public static AmbientOcclusion get_ao(this PPController self)
            => self.field_Private_AmbientOcclusion_0;

        public static void set_ao(this PPController self, AmbientOcclusion ao)
            => self.field_Private_AmbientOcclusion_0 = ao;


        public static ChromaticAberration get_chromaticAberration(this PPController self)
            => self.field_Private_ChromaticAberration_0;

        public static void set_chromaticAberration(this PPController self, ChromaticAberration chromaticAberration)
            => self.field_Private_ChromaticAberration_0 = chromaticAberration;


        public static PostProcessProfile get_profile(this PPController self)
            => self.field_Private_PostProcessProfile_0;

        public static void set_profile(this PPController self, PostProcessProfile profile)
            => self.field_Private_PostProcessProfile_0 = profile;
    }

    public static class PromptPrefabExtensions
    {
        public static Vector3 get_desiredScale(this PromptPrefab self)
            => self.field_Private_Vector3_0;

        public static void set_desiredScale(this PromptPrefab self, Vector3 desiredScale)
            => self.field_Private_Vector3_0 = desiredScale;


        public static Vector3 get_defaultScale(this PromptPrefab self)
            => self.field_Private_Vector3_1;

        public static void set_defaultScale(this PromptPrefab self, Vector3 defaultScale)
            => self.field_Private_Vector3_1 = defaultScale;


        public static float get_animateSpeed(this PromptPrefab self)
            => self.field_Private_Single_0;

        public static void set_animateSpeed(this PromptPrefab self, float animateSpeed)
            => self.field_Private_Single_0 = animateSpeed;


        public static void DestroySelf(this PromptPrefab self)
            => self.Method_Private_Void_PDM_1();


        public static void AnimatePrompt(this PromptPrefab self)
            => self.Method_Private_Void_8();
    }

    public static class PunchPlayersExtensions
    {
        public static bool get_ready(this PunchPlayers self)
            => self.field_Private_Boolean_0;

        public static void set_ready(this PunchPlayers self, bool ready)
            => self.field_Private_Boolean_0 = ready;


        public static float get_maxDistance(this PunchPlayers self)
            => self.field_Private_Single_0;

        public static void set_maxDistance(this PunchPlayers self, float maxDistance)
            => self.field_Private_Single_0 = maxDistance;


        public static void Cooldown(this PunchPlayers self)
            => self.Method_Private_Void_3();


        public static void RaycastPunch(this PunchPlayers self)
            => self.Method_Private_Void_23();
    }

    public static class QuestExtensions
    {
        public static string Deobf_GetDetails(this Quest self)
            => self.Method_Public_String_0();
    }

    public static class RaceUIExtensions
    {
        public static GameModeRace get_gameMode(this RaceUI self)
            => self.field_Private_GameModePublicInquUnique_0;

        public static void set_gameMode(this RaceUI self, GameModeRace gameMode)
            => self.field_Private_GameModePublicInquUnique_0 = gameMode;


        public static PlayerManager get_pm(this RaceUI self)
            => self.field_Private_MonoBehaviourPublicCSstReshTrheObplBojuUnique_0;

        public static void set_pm(this RaceUI self, PlayerManager pm)
            => self.field_Private_MonoBehaviourPublicCSstReshTrheObplBojuUnique_0 = pm;
    }

    public static class RandomSfxExtensions
    {
        public static AudioSource get_s(this RandomSfx self)
            => self.field_Private_AudioSource_0;

        public static void set_s(this RandomSfx self, AudioSource s)
            => self.field_Private_AudioSource_0 = s;


        public static float get_defaultVolume(this RandomSfx self)
            => self.field_Private_Single_0;

        public static void set_defaultVolume(this RandomSfx self, float defaultVolume)
            => self.field_Private_Single_0 = defaultVolume;
    }

    public static class RaycastExtensionsExtensions // this is crazy
    {
        public static Vector3 PositionToGround(Vector3 position)
            => RaycastExtensions.Method_Public_Static_Vector3_Vector3_0(position);
    }

    public static class ReadyDisplayExtensions
    {
        public static Dictionary<ulong, ReadyPrefabUi> get_idToPrefab(this ReadyDisplay self)
            => self.field_Private_Dictionary_2_UInt64_MonoBehaviourPublicTeusRaovObCorenoCoUnique_0;

        public static void set_idToPrefab(this ReadyDisplay self, Dictionary<ulong, ReadyPrefabUi> idToPrefab)
            => self.field_Private_Dictionary_2_UInt64_MonoBehaviourPublicTeusRaovObCorenoCoUnique_0 = idToPrefab;


        public static List<ulong> get_deobf_playerList(this ReadyDisplay self)
            => self.field_Private_List_1_UInt64_0;

        public static void set_deobf_playerList(this ReadyDisplay self, List<ulong> deobf_playerList)
            => self.field_Private_List_1_UInt64_0 = deobf_playerList;
    }

    public static class ReadyPrefabUiExtensions
    {
        public static PlayerManager get_pm(this ReadyPrefabUi self)
            => self.field_Private_MonoBehaviourPublicCSstReshTrheObplBojuUnique_0;

        public static void set_pm(this ReadyPrefabUi self, PlayerManager pm)
            => self.field_Private_MonoBehaviourPublicCSstReshTrheObplBojuUnique_0 = pm;


        public static string GetReadyText(this ReadyPrefabUi self, bool ready)
            => self.Method_Private_String_Boolean_PDM_5(ready);
    }

    public static class RedLightStatueExtensions
    {
        public static Quaternion get_defaultRotation(this RedLightStatue self)
            => self.field_Private_Quaternion_0;

        public static void set_defaultRotation(this RedLightStatue self, Quaternion defaultRotation)
            => self.field_Private_Quaternion_0 = defaultRotation;


        public static Quaternion get_spinRotation(this RedLightStatue self)
            => self.field_Private_Quaternion_1;

        public static void set_spinRotation(this RedLightStatue self, Quaternion spinRotation)
            => self.field_Private_Quaternion_1 = spinRotation;


        public static Quaternion get_startSpinRotation(this RedLightStatue self)
            => self.field_Private_Quaternion_2;

        public static void set_startSpinRotation(this RedLightStatue self, Quaternion startSpinRotation)
            => self.field_Private_Quaternion_2 = startSpinRotation;


        public static Quaternion get_desiredRotation(this RedLightStatue self)
            => self.field_Private_Quaternion_3;

        public static void set_desiredRotation(this RedLightStatue self, Quaternion desiredRotation)
            => self.field_Private_Quaternion_3 = desiredRotation;


        public static float get_spinTime(this RedLightStatue self)
            => self.field_Private_Single_0;

        public static void set_spinTime(this RedLightStatue self, float spinTime)
            => self.field_Private_Single_0 = spinTime;


        public static float get_currentTime(this RedLightStatue self)
            => self.field_Private_Single_1;

        public static void set_currentTime(this RedLightStatue self, float currentTime)
            => self.field_Private_Single_1 = currentTime;
    }

    public static class ReloadUIExtensions
    {
        public static float get_currentTime(this ReloadUI self)
            => self.field_Private_Single_0;

        public static void set_currentTime(this ReloadUI self, float currentTime)
            => self.field_Private_Single_0 = currentTime;


        public static float get_desiredTime(this ReloadUI self)
            => self.field_Private_Single_1;

        public static void set_desiredTime(this ReloadUI self, float desiredTime)
            => self.field_Private_Single_1 = desiredTime;


        public static void StopReload(this ReloadUI self)
            => self.Method_Private_Void_PDM_12();
    }

    public static class ResolutionSettingExtensions
    {
        public static Resolution[] get_resolutions(this ResolutionSetting self)
            => self.field_Private_ArrayOf_Resolution_0;

        public static void set_resolutions(this ResolutionSetting self, Resolution[] resolutions)
            => self.field_Private_ArrayOf_Resolution_0 = resolutions;


        public static void UpdateSetting(this ResolutionSetting self)
            => self.Method_Private_Void_0();


        public static string ResolutionToText(this ResolutionSetting self, Resolution resolution)
            => self.Method_Private_String_Resolution_PDM_16(resolution);
    }

    public static class RevealPlayerNamesExtensions
    {
        public static RaycastHit[] get_deobf_collisions(this RevealPlayerNames self)
            => self.field_Private_ArrayOf_RaycastHit_0;

        public static void set_deobf_collisions(this RevealPlayerNames self, RaycastHit[] deobf_collisions)
            => self.field_Private_ArrayOf_RaycastHit_0 = deobf_collisions;
    }

    public static class RewardUIExtensions
    {
        public static Vector3 get_topStart(this RewardUI self)
            => self.field_Private_Vector3_0;

        public static void set_topStart(this RewardUI self, Vector3 topStart)
            => self.field_Private_Vector3_0 = topStart;


        public static Vector3 get_topDesired(this RewardUI self)
            => self.field_Private_Vector3_1;

        public static void set_topDesired(this RewardUI self, Vector3 topDesired)
            => self.field_Private_Vector3_1 = topDesired;


        public static Vector3 get_botStart(this RewardUI self)
            => self.field_Private_Vector3_2;

        public static void set_botStart(this RewardUI self, Vector3 botStart)
            => self.field_Private_Vector3_2 = botStart;


        public static Vector3 get_botDesired(this RewardUI self)
            => self.field_Private_Vector3_3;

        public static void set_botDesired(this RewardUI self, Vector3 botDesired)
            => self.field_Private_Vector3_3 = botDesired;


        public static float get_timer(this RewardUI self)
            => self.field_Private_Single_0;

        public static void set_timer(this RewardUI self, float timer)
            => self.field_Private_Single_0 = timer;


        public static float get_timeToFade(this RewardUI self)
            => self.field_Private_Single_1;

        public static void set_timeToFade(this RewardUI self, float timeToFade)
            => self.field_Private_Single_1 = timeToFade;
    }

    public static class RotationObjectExtensions
    {
        public static Vector3 get_startEuler(this RotationObject self)
            => self.field_Private_Vector3_0;

        public static void set_startEuler(this RotationObject self, Vector3 startEuler)
            => self.field_Private_Vector3_0 = startEuler;


        public static Rigidbody get_rb(this RotationObject self)
            => self.field_Private_Rigidbody_0;

        public static void set_rb(this RotationObject self, Rigidbody rb)
            => self.field_Private_Rigidbody_0 = rb;


        public static bool get_deobf_firstFixedUpdate(this RotationObject self)
            => self.field_Private_Boolean_0;

        public static void set_deobf_firstFixedUpdate(this RotationObject self, bool deobf_firstFixedUpdate)
            => self.field_Private_Boolean_0 = deobf_firstFixedUpdate;
    }

    public static class ScoreVisualsExtensions
    {
        public static GameMode get_gameMode(this ScoreVisuals self)
            => self.field_Private_GameMode_0;

        public static void set_gameMode(this ScoreVisuals self, GameMode gameMode)
            => self.field_Private_GameMode_0 = gameMode;


        public static PlayerManager get_pm(this ScoreVisuals self)
            => self.field_Private_MonoBehaviourPublicCSstReshTrheObplBojuUnique_0;

        public static void set_pm(this ScoreVisuals self, PlayerManager pm)
            => self.field_Private_MonoBehaviourPublicCSstReshTrheObplBojuUnique_0 = pm;


        public static void UpdateSfx(this ScoreVisuals self)
            => self.Method_Private_Void_PDM_19();


        public static void StopFx(this ScoreVisuals self)
            => self.Method_Private_Void_PDM_39();
    }

    public static class ScrollSettingsExtensions
    {
        public static string[] get_settingNames(this ScrollSettings self)
            => self.field_Private_ArrayOf_0;

        public static void set_settingNames(this ScrollSettings self, string[] settingNames)
            => self.field_Private_ArrayOf_0 = settingNames;


        public static void UpdateSetting(this ScrollSettings self)
            => self.Method_Private_Void_0();
    }

    public static class SerevrUIPrefabExtensions
    {
        public static string get_deobf_mapsString(this SerevrUIPrefab self)
            => self.field_Private_String_0;

        public static void set_deobf_mapsString(this SerevrUIPrefab self, string deobf_mapsString)
            => self.field_Private_String_0 = deobf_mapsString;


        public static string get_deobf_modesString(this SerevrUIPrefab self)
            => self.field_Private_String_1;

        public static void set_deobf_modesString(this SerevrUIPrefab self, string deobf_modesString)
            => self.field_Private_String_1 = deobf_modesString;


        public static CSteamID get_lobby(this SerevrUIPrefab self)
            => self.field_Private_CSteamID_0;

        public static void set_lobby(this SerevrUIPrefab self, CSteamID lobby)
            => self.field_Private_CSteamID_0 = lobby;


        public static void DoSearch(this SerevrUIPrefab self)
            => self.Method_Private_Void_0();


        public static void Deobf_ModifiedLobby(this SerevrUIPrefab self)
            => self.Method_Private_Void_1();
    }

    public static class ServerClockExtensions
    {
        public static float get_syncRate(this ServerClock self)
            => self.field_Private_Single_0;

        public static void set_syncRate(this ServerClock self, float syncRate)
            => self.field_Private_Single_0 = syncRate;
    }

    public static class ServerConfigExtensions
    {
        public static int get_maxPlayers()
            => ServerConfig.field_Public_Static_Int32_0;

        public static void set_maxPlayers(int maxPlayers)
            => ServerConfig.field_Public_Static_Int32_0 = maxPlayers;


        public static int get_recommendedPlayers()
            => ServerConfig.field_Public_Static_Int32_1;

        public static void set_recommendedPlayers(int recommendedPlayers)
            => ServerConfig.field_Public_Static_Int32_1 = recommendedPlayers;


        public static int get_minPlayers()
            => ServerConfig.field_Public_Static_Int32_2;

        public static void set_minPlayers(int minPlayers)
            => ServerConfig.field_Public_Static_Int32_2 = minPlayers;


        public static int get_countdownTime()
            => ServerConfig.field_Public_Static_Int32_3;

        public static void set_countdownTime(int countdownTime)
            => ServerConfig.field_Public_Static_Int32_3 = countdownTime;


        public static int get_shortCountdownTime()
            => ServerConfig.field_Public_Static_Int32_4;

        public static void set_shortCountdownTime(int shortCountdownTime)
            => ServerConfig.field_Public_Static_Int32_4 = shortCountdownTime;


        public static int get_roundStartFreeze()
            => ServerConfig.field_Public_Static_Int32_5;

        public static void set_roundStartFreeze(int roundStartFreeze)
            => ServerConfig.field_Public_Static_Int32_5 = roundStartFreeze;


        public static int get_roundStopCinematic()
            => ServerConfig.field_Public_Static_Int32_6;

        public static void set_roundStopCinematic(int roundStopCinematic)
            => ServerConfig.field_Public_Static_Int32_6 = roundStopCinematic;


        public static int get_roundEndTimeout()
            => ServerConfig.field_Public_Static_Int32_7;

        public static void set_roundEndTimeout(int roundEndTimeout)
            => ServerConfig.field_Public_Static_Int32_7 = roundEndTimeout;


        public static int get_gameOverTimeout()
            => ServerConfig.field_Public_Static_Int32_8;

        public static void set_gameOverTimeout(int gameOverTimeout)
            => ServerConfig.field_Public_Static_Int32_8 = gameOverTimeout;


        public static int get_loadTimeBeforeKicked()
            => ServerConfig.field_Public_Static_Int32_9;

        public static void set_loadTimeBeforeKicked(int loadTimeBeforeKicked)
            => ServerConfig.field_Public_Static_Int32_9 = loadTimeBeforeKicked;


        public static float get_speakAfterDeathTime()
            => ServerConfig.field_Public_Static_Single_0;

        public static void set_speakAfterDeathTime(float speakAfterDeathTime)
            => ServerConfig.field_Public_Static_Single_0 = speakAfterDeathTime;
    }

    public static class ServerListExtensions
    {
        public static List<CSteamID> get_activeLobbies(this ServerList self)
            => self.field_Private_List_1_CSteamID_0;

        public static void set_activeLobbies(this ServerList self, List<CSteamID> activeLobbies)
            => self.field_Private_List_1_CSteamID_0 = activeLobbies;


        public static CallResult<LobbyMatchList_t> get_m_CallResultLobbyMatchList(this ServerList self)
            => self.field_Private_CallResult_1_LobbyMatchList_t_0;

        public static void set_m_CallResultLobbyMatchList(this ServerList self, CallResult<LobbyMatchList_t> m_CallResultLobbyMatchList)
            => self.field_Private_CallResult_1_LobbyMatchList_t_0 = m_CallResultLobbyMatchList;


        public static void TooManyLobbiesDetected(this ServerList self)
            => self.Method_Private_Void_PDM_18();


        public static void ClearList(this ServerList self)
            => self.Method_Private_Void_0();


        public static string Deobf_NameKey(this ServerList self)
            => self.Method_Private_String_0();


        public static void SetBuffering(this ServerList self, bool buffering)
            => self.Method_Private_Void_Boolean_8(buffering);


        public static void FindLobbies(this ServerList self)
            => self.Method_Private_Void_1();


        public static void OnLobbyMatchList(this ServerList self, LobbyMatchList_t lobbyMatchList, bool bIOFailure)
            => self.Method_Private_Void_LobbyMatchList_t_Boolean_PDM_9(lobbyMatchList, bIOFailure);
    }

    public static class ServerSendExtensions
    {
        public static int get_deobf_reliable()
            => ServerSend.field_Private_Static_Int32_0;

        public static void set_deobf_reliable(int deobf_reliable)
            => ServerSend.field_Private_Static_Int32_0 = deobf_reliable;


        public static int get_deobf_unreliable()
            => ServerSend.field_Private_Static_Int32_1;

        public static void set_deobf_unreliable(int deobf_unreliable)
            => ServerSend.field_Private_Static_Int32_1 = deobf_unreliable;


        public static void SendTCPData(ulong clientId, Packet packet)
            => ServerSend.Method_Private_Static_Void_UInt64_ObjectPublicIDisposableLi1ByInByBoUnique_0(clientId, packet);


        public static void SendTCPDataToAll(Packet packet)
            => ServerSend.Method_Private_Static_Void_ObjectPublicIDisposableLi1ByInByBoUnique_0(packet);


        public static void SendTCPDataToAll(ulong clientId, Packet packet)
            => ServerSend.Method_Private_Static_Void_UInt64_ObjectPublicIDisposableLi1ByInByBoUnique_1(clientId, packet);


        public static void SendUDPData(ulong clientId, Packet packet)
            => ServerSend.Method_Private_Static_Void_UInt64_ObjectPublicIDisposableLi1ByInByBoUnique_2(clientId, packet);


        public static void SendUDPDataToAll(ulong clientId, Packet packet)
            => ServerSend.Method_Private_Static_Void_UInt64_ObjectPublicIDisposableLi1ByInByBoUnique_3(clientId, packet);


        public static void SendUDPDataToAll(Packet packet)
            => ServerSend.Method_Private_Static_Void_ObjectPublicIDisposableLi1ByInByBoUnique_1(packet);
    }

    public static class SettingsExtensions
    {
        public static void UpdateStreamerMode(this Settings self)
            => self.Method_Private_Void_PDM_6();


        public static void UpdateInteractKey(this Settings self)
            => self.Method_Private_Void_PDM_8();


        public static void UpdateVoipVolume(this Settings self)
            => self.Method_Private_Void_PDM_10();


        public static void UpdateDropKey(this Settings self)
            => self.Method_Private_Void_PDM_12();


        public static void UpdateForwardKey(this Settings self)
            => self.Method_Private_Void_PDM_13();


        public static void UpdateMapKey(this Settings self)
            => self.Method_Private_Void_PDM_14();


        public static void UpdateCamShake(this Settings self)
            => self.Method_Private_Void_PDM_15();


        public static void UpdateShadowCascades(this Settings self)
            => self.Method_Private_Void_PDM_16();


        public static void UpdateVSync(this Settings self)
            => self.Method_Private_Void_PDM_17();


        public static void UpdateMotionBlur(this Settings self)
            => self.Method_Private_Void_PDM_18();


        public static void UpdateSprintKey(this Settings self)
            => self.Method_Private_Void_PDM_20();


        public static void UpdateFullscreenMode(this Settings self)
            => self.Method_Private_Void_PDM_21();


        public static void UpdateTutorial(this Settings self)
            => self.Method_Private_Void_PDM_22();


        public static void UpdateSave(this Settings self)
            => self.Method_Private_Void_0();


        public static void UpdateBackwardKey(this Settings self)
            => self.Method_Private_Void_PDM_23();


        public static void UpdateTextureRes(this Settings self)
            => self.Method_Private_Void_PDM_24();


        public static void UpdateVolume(this Settings self)
            => self.Method_Private_Void_PDM_25();


        public static void UpdateRightClickKey(this Settings self)
            => self.Method_Private_Void_PDM_31();


        public static void UpdateJumpKey(this Settings self)
            => self.Method_Private_Void_PDM_32();


        public static void UpdateRightKey(this Settings self)
            => self.Method_Private_Void_PDM_34();


        public static void UpdateSens(this Settings self)
            => self.Method_Private_Void_PDM_35();


        public static void UpdateLeftClickKey(this Settings self)
            => self.Method_Private_Void_PDM_37();


        public static void UpdateLeftKey(this Settings self)
            => self.Method_Private_Void_PDM_38();


        public static void UpdateVoipKey(this Settings self)
            => self.Method_Private_Void_PDM_41();


        public static void UpdateChat(this Settings self)
            => self.Method_Private_Void_PDM_42();


        public static void UpdateMusic(this Settings self)
            => self.Method_Private_Void_PDM_43();


        public static float IntToFloat(this Settings self, int value)
            => self.Method_Private_Single_Int32_PDM_0(value);


        public static void UpdateCrouchKey(this Settings self)
            => self.Method_Private_Void_PDM_48();


        public static void UpdateMaxFps(this Settings self)
            => self.Method_Private_Void_PDM_52();


        public static int BoolToInt(this Settings self, bool value)
            => self.Method_Private_Int32_Boolean_PDM_0(value);


        public static void UpdateShadowQuality(this Settings self)
            => self.Method_Private_Void_PDM_54();


        public static void UpdateFov(this Settings self)
            => self.Method_Private_Void_PDM_55();


        public static void UpdateAO(this Settings self)
            => self.Method_Private_Void_PDM_56();


        public static int FloatToInt(this Settings self, float value)
            => self.Method_Private_Int32_Single_PDM_1(value);


        public static void UpdateGrass(this Settings self)
            => self.Method_Private_Void_PDM_58();


        public static void UpdateHoldCrouch(this Settings self)
            => self.Method_Private_Void_PDM_59();


        public static void UpdateFullscreen(this Settings self)
            => self.Method_Private_Void_PDM_60();


        public static void UpdateShadowDistance(this Settings self)
            => self.Method_Private_Void_PDM_61();


        public static void UpdateAntiAliasing(this Settings self)
            => self.Method_Private_Void_PDM_62();


        public static void UpdateShadowResolution(this Settings self)
            => self.Method_Private_Void_PDM_63();


        public static void UpdateBloom(this Settings self)
            => self.Method_Private_Void_PDM_64();


        public static void UpdateInverted(this Settings self)
            => self.Method_Private_Void_PDM_65();


        public static void UpdateDeaf(this Settings self)
            => self.Method_Private_Void_PDM_68();


        public static void Deobf_UpdateInputDelay(this Settings self)
            => self.Method_Private_Void_PDM_74();


        public static void UpdateSoftParticles(this Settings self)
            => self.Method_Private_Void_PDM_76();


        public static void UpdateMicSetting(this Settings self)
            => self.Method_Private_Void_PDM_77();


        public static void UpdateInventoryKey(this Settings self)
            => self.Method_Private_Void_PDM_78();
    }

    public static class SharedObjectManagerExtensions
    {
        public static Dictionary<int, SharedObject> get_sharedObjects(this SharedObjectManager self)
            => self.field_Private_Dictionary_2_Int32_MonoBehaviourPublicInidBoskUnique_0;

        public static void set_sharedObjects(this SharedObjectManager self, Dictionary<int, SharedObject> sharedObjects)
            => self.field_Private_Dictionary_2_Int32_MonoBehaviourPublicInidBoskUnique_0 = sharedObjects;


        public static int get_id(this SharedObjectManager self)
            => self.field_Private_Int32_0;

        public static void set_id(this SharedObjectManager self, int id)
            => self.field_Private_Int32_0 = id;


        public static void RemoveNulls(this SharedObjectManager self)
            => self.Method_Private_Void_0();
    }

    public static class ShopItemPrefabExtensions
    {
        public static int get_backing_itemId(this ShopItemPrefab self)
            => self.field_Private_Int32_0;

        public static void set_backing_itemId(this ShopItemPrefab self, int backing_itemId)
            => self.field_Private_Int32_0 = backing_itemId;


        public static ItemData get_backing_itemData(this ShopItemPrefab self)
            => self.field_Private_ItemData_0;

        public static void set_backing_itemData(this ShopItemPrefab self, ItemData backing_itemData)
            => self.field_Private_ItemData_0 = backing_itemData;


        public static float get_currentBuyTransition(this ShopItemPrefab self)
            => self.field_Private_Single_0;

        public static void set_currentBuyTransition(this ShopItemPrefab self, float currentBuyTransition)
            => self.field_Private_Single_0 = currentBuyTransition;


        public static float get_desiredBuyTransition(this ShopItemPrefab self)
            => self.field_Private_Single_1;

        public static void set_desiredBuyTransition(this ShopItemPrefab self, float desiredBuyTransition)
            => self.field_Private_Single_1 = desiredBuyTransition;


        public static int get_itemId(this ShopItemPrefab self)
            => self.prop_Int32_0;

        public static void set_itemId(this ShopItemPrefab self, int itemId)
            => self.prop_Int32_0 = itemId;


        public static ItemData get_itemData(this ShopItemPrefab self)
            => self.prop_ItemData_0;

        public static void set_itemData(this ShopItemPrefab self, ItemData itemData)
            => self.prop_ItemData_0 = itemData;
    }

    public static class ShopWindowExtensions
    {
        public static void AddItemToTab(this ShopWindow self, ItemData itemData, Transform contentParent)
            => self.Method_Private_Void_ItemData_Transform_PDM_3(itemData, contentParent);
    }

    public static class SmokeLegExtensions
    {
        public static bool get_ready(this SmokeLeg self)
            => self.field_Private_Boolean_0;

        public static void set_ready(this SmokeLeg self, bool ready)
            => self.field_Private_Boolean_0 = ready;
    }

    public static class SoundComponentExtensions
    {
        public static AudioClip GetRandomSound(this SoundComponent self, AudioClip[] clips)
            => self.Method_Public_AudioClip_ArrayOf_AudioClip_3(clips);
    }

    public static class StageForceFieldExtensions
    {
        public static bool get_ready(this StageForceField self)
            => self.field_Private_Boolean_0;

        public static void set_ready(this StageForceField self, bool ready)
            => self.field_Private_Boolean_0 = ready;
    }

    public static class SteamManagerExtensions
    {
        public static string get_backing_PlayerName(this SteamManager self)
            => self.field_Private_String_0;

        public static void set_backing_PlayerName(this SteamManager self, string backing_PlayerName)
            => self.field_Private_String_0 = backing_PlayerName;


        public static CSteamID get_backing_PlayerSteamId(this SteamManager self)
            => self.field_Private_CSteamID_0;

        public static void set_backing_PlayerSteamId(this SteamManager self, CSteamID backing_PlayerSteamId)
            => self.field_Private_CSteamID_0 = backing_PlayerSteamId;


        public static string get_playerSteamIdString(this SteamManager self)
            => self.field_Private_String_1;

        public static void set_playerSteamIdString(this SteamManager self, string playerSteamIdString)
            => self.field_Private_String_1 = playerSteamIdString;


        public static bool get_connectedToSteam(this SteamManager self)
            => self.field_Private_Boolean_0;

        public static void set_connectedToSteam(this SteamManager self, bool connectedToSteam)
            => self.field_Private_Boolean_0 = connectedToSteam;


        public static CSteamID get_backing_lobbyOwnerSteamId(this SteamManager self)
            => self.field_Private_CSteamID_1;

        public static void set_backing_lobbyOwnerSteamId(this SteamManager self, CSteamID backing_lobbyOwnerSteamId)
            => self.field_Private_CSteamID_1 = backing_lobbyOwnerSteamId;


        public static bool get_backing_LobbyPartnerDisconnected(this SteamManager self)
            => self.field_Private_Boolean_1;

        public static void set_backing_LobbyPartnerDisconnected(this SteamManager self, bool backing_LobbyPartnerDisconnected)
            => self.field_Private_Boolean_1 = backing_LobbyPartnerDisconnected;


        public static bool get_applicationHasQuit(this SteamManager self)
            => self.field_Private_Boolean_2;

        public static void set_applicationHasQuit(this SteamManager self, bool applicationHasQuit)
            => self.field_Private_Boolean_2 = applicationHasQuit;


        public static bool get_daRealOne(this SteamManager self)
            => self.field_Private_Boolean_3;

        public static void set_daRealOne(this SteamManager self, bool daRealOne)
            => self.field_Private_Boolean_3 = daRealOne;


        public static int get_nAccepted(this SteamManager self)
            => self.field_Private_Int32_0;

        public static void set_nAccepted(this SteamManager self, int nAccepted)
            => self.field_Private_Int32_0 = nAccepted;


        public static float get_updateConnectionsRate(this SteamManager self)
            => self.field_Private_Single_0;

        public static void set_updateConnectionsRate(this SteamManager self, float updateConnectionsRate)
            => self.field_Private_Single_0 = updateConnectionsRate;


        public static string get_PlayerName(this SteamManager self)
            => self.prop_String_0;

        public static void set_PlayerName(this SteamManager self, string PlayerName)
            => self.prop_String_0 = PlayerName;


        public static CSteamID get_PlayerSteamId(this SteamManager self)
            => self.prop_CSteamID_0;

        public static void set_PlayerSteamId(this SteamManager self, CSteamID PlayerSteamId)
            => self.prop_CSteamID_0 = PlayerSteamId;


        public static string get_PlayerSteamIdString(this SteamManager self)
            => self.prop_String_1;


        public static CSteamID get_lobbyOwnerSteamId(this SteamManager self)
            => self.prop_CSteamID_1;

        public static void set_lobbyOwnerSteamId(this SteamManager self, CSteamID lobbyOwnerSteamId)
            => self.prop_CSteamID_1 = lobbyOwnerSteamId;


        public static bool get_LobbyPartnerDisconnected(this SteamManager self)
            => self.prop_Boolean_0;

        public static void set_LobbyPartnerDisconnected(this SteamManager self, bool LobbyPartnerDisconnected)
            => self.prop_Boolean_0 = LobbyPartnerDisconnected;


        public static void OnFailedP2P(this SteamManager self, SteamNetworkingMessagesSessionFailed_t ev)
            => self.Method_Private_Void_SteamNetworkingMessagesSessionFailed_t_PDM_0(ev);


        public static void CheckConnections(this SteamManager self)
            => self.Method_Private_Void_PDM_1();


        public static void OnAcceptP2P(this SteamManager self, SteamNetworkingMessagesSessionRequest_t ev)
            => self.Method_Private_Void_SteamNetworkingMessagesSessionRequest_t_PDM_1(ev);


        public static void GameCleanup(this SteamManager self)
            => self.Method_Private_Void_1();


        public static void LobbyEnter(this SteamManager self, LobbyEnter_t ev)
            => self.Method_Private_Void_LobbyEnter_t_PDM_1(ev);


        public static void OnJoinRequest(this SteamManager self, GameLobbyJoinRequested_t ev)
            => self.Method_Private_Void_GameLobbyJoinRequested_t_PDM_0(ev);


        public static void LobbyGameCreated(this SteamManager self, LobbyGameCreated_t ev)
            => self.Method_Private_Void_LobbyGameCreated_t_1(ev);


        public static void PlayerJoinOrLeave(this SteamManager self, LobbyChatUpdate_t ev)
            => self.Method_Private_Void_LobbyChatUpdate_t_PDM_3(ev);


        public static void LobbyCreated(this SteamManager self, LobbyCreated_t ev)
            => self.Method_Private_Void_LobbyCreated_t_PDM_3(ev);
    }

    public static class SteamManagerNativeExtensions
    {
        public static bool get_s_EverInitialized()
            => SteamManagerNative.field_Protected_Static_Boolean_0;

        public static void set_s_EverInitialized(bool s_EverInitialized)
            => SteamManagerNative.field_Protected_Static_Boolean_0 = s_EverInitialized;


        public static SteamManagerNative get_s_instance()
            => SteamManagerNative.field_Protected_Static_SteamManagerNative_0;

        public static void set_s_instance(SteamManagerNative s_instance)
            => SteamManagerNative.field_Protected_Static_SteamManagerNative_0 = s_instance;


        public static bool get_m_bInitialized(this SteamManagerNative self)
            => self.field_Protected_Boolean_0;

        public static void set_m_bInitialized(this SteamManagerNative self, bool m_bInitialized)
            => self.field_Protected_Boolean_0 = m_bInitialized;


        public static SteamAPIWarningMessageHook_t get_m_SteamAPIWarningMessageHook(this SteamManagerNative self)
            => self.field_Protected_SteamAPIWarningMessageHook_t_0;

        public static void set_m_SteamAPIWarningMessageHook(this SteamManagerNative self, SteamAPIWarningMessageHook_t m_SteamAPIWarningMessageHook)
            => self.field_Protected_SteamAPIWarningMessageHook_t_0 = m_SteamAPIWarningMessageHook;


        public static SteamManagerNative get_Instance()
            => SteamManagerNative.prop_SteamManagerNative_0;


        public static bool get_Initialized()
            => SteamManagerNative.prop_Boolean_0;


        public static void SteamAPIDebugTextHook(int logLevel, StringBuilder log)
            => SteamManagerNative.Method_Protected_Static_Void_Int32_StringBuilder_PDM_4(logLevel, log);
    }

    public static class SteamPacketManagerExtensions
    {
        public static int get_deobf_messagesToCheckFor()
            => SteamPacketManager.field_Private_Static_Int32_0;

        public static void set_deobf_messagesToCheckFor(int deobf_messagesToCheckFor)
            => SteamPacketManager.field_Private_Static_Int32_0 = deobf_messagesToCheckFor;


        public static System.IntPtr[] get_deobf_messagePtrs()
            => SteamPacketManager.field_Private_Static_ArrayOf_IntPtr_0;

        public static void set_deobf_messagePtrs(System.IntPtr[] deobf_messagePtrs)
            => SteamPacketManager.field_Private_Static_ArrayOf_IntPtr_0 = deobf_messagePtrs;


        public static SteamNetworkingMessage_t get_deobf_message()
            => SteamPacketManager.field_Private_Static_SteamNetworkingMessage_t_0;

        public static void set_deobf_message(SteamNetworkingMessage_t deobf_message)
            => SteamPacketManager.field_Private_Static_SteamNetworkingMessage_t_0 = deobf_message;


        public static void HandlePacket(SteamNetworkingMessage_t message, int channel)
            => SteamPacketManager.Method_Private_Static_Void_SteamNetworkingMessage_t_Int32_0(message, channel);
    }

    public static class TabNavigateExtensions
    {
        public static List<RawImage> get_btns(this TabNavigate self)
            => self.field_Private_List_1_RawImage_0;

        public static void set_btns(this TabNavigate self, List<RawImage> btns)
            => self.field_Private_List_1_RawImage_0 = btns;


        public static List<GameObject> get_tabs(this TabNavigate self)
            => self.field_Private_List_1_GameObject_0;

        public static void set_tabs(this TabNavigate self, List<GameObject> tabs)
            => self.field_Private_List_1_GameObject_0 = tabs;
    }

    public static class TestLobbyExtensions
    {
        public static bool get_lobbyStarted(this TestLobby self)
            => self.field_Private_Boolean_0;

        public static void set_lobbyStarted(this TestLobby self, bool lobbyStarted)
            => self.field_Private_Boolean_0 = lobbyStarted;
    }

    public static class TestRagdollsExtensions
    {
        public static void SpawnRagdoll(this TestRagdolls self)
            => self.Method_Private_Void_PDM_22();
    }
    
    public static class TestRocksExtensions
    {
        public static void AddRock(this TestRocks self)
            => self.Method_Private_Void_PDM_27();
    }

    public static class TileExtensions
    {
        public static Vector3 get_downPosition(this Tile self)
            => self.field_Private_Vector3_0;

        public static void set_downPosition(this Tile self, Vector3 downPosition)
            => self.field_Private_Vector3_0 = downPosition;


        public static Vector3 get_topPosition(this Tile self)
            => self.field_Private_Vector3_1;

        public static void set_topPosition(this Tile self, Vector3 topPosition)
            => self.field_Private_Vector3_1 = topPosition;


        public static Vector3 get_desiredPos(this Tile self)
            => self.field_Private_Vector3_2;

        public static void set_desiredPos(this Tile self, Vector3 desiredPos)
            => self.field_Private_Vector3_2 = desiredPos;


        public static Material get_mat(this Tile self)
            => self.field_Private_Material_0;

        public static void set_mat(this Tile self, Material mat)
            => self.field_Private_Material_0 = mat;


        public static int get_tileId(this Tile self)
            => self.field_Private_Int32_0;

        public static void set_tileId(this Tile self, int tileId)
            => self.field_Private_Int32_0 = tileId;


        public static List<Transform> get_onTile(this Tile self)
            => self.field_Private_List_1_Transform_0;

        public static void set_onTile(this Tile self, List<Transform> onTile)
            => self.field_Private_List_1_Transform_0 = onTile;


        public static int get_playersOnTile(this Tile self)
            => self.field_Private_Int32_1;

        public static void set_playersOnTile(this Tile self, int playersOnTile)
            => self.field_Private_Int32_1 = playersOnTile;

        
        public static int get_backing_teamId(this Tile self)
            => self.field_Private_Int32_2;

        public static void set_backing_teamId(this Tile self, int backing_teamId)
            => self.field_Private_Int32_2 = backing_teamId;


        public static bool get_activated(this Tile self)
            => self.field_Private_Boolean_0;

        public static void set_activated(this Tile self, bool activated)
            => self.field_Private_Boolean_0 = activated;


        public static float get_speed(this Tile self)
            => self.field_Private_Single_0;

        public static void set_speed(this Tile self, float speed)
            => self.field_Private_Single_0 = speed;


        public static float get_movedDistance(this Tile self)
            => self.field_Private_Single_1;

        public static void set_movedDistance(this Tile self, float movedDistance)
            => self.field_Private_Single_1 = movedDistance;


        public static int get_teamId(this Tile self)
            => self.prop_Int32_0;

        public static void set_teamId(this Tile self, int teamId)
            => self.prop_Int32_0 = teamId;


        public static void EnterTile(this Tile self)
            => self.Method_Private_Void_PDM_17();


        public static void ExitTile(this Tile self)
            => self.Method_Private_Void_PDM_21();
    }

    public static class TileDriveUIExtensions
    {
        public static bool get_initialized(this TileDriveUI self)
            => self.field_Private_Boolean_0;

        public static void set_initialized(this TileDriveUI self, bool initialized)
            => self.field_Private_Boolean_0 = initialized;


        public static GameModeTileDrive get_mode(this TileDriveUI self)
            => self.field_Private_GameModePublicDi2UIInidnTInUnique_0;

        public static void set_mode(this TileDriveUI self, GameModeTileDrive mode)
            => self.field_Private_GameModePublicDi2UIInidnTInUnique_0 = mode;
    }

    public static class TileManagerExtensions
    {
        public static Dictionary<int, int> get_deobf_tileChangesDictionary(this TileManager self)
            => self.field_Private_Dictionary_2_Int32_Int32_0;

        public static void set_deobf_tileChangesDictionary(this TileManager self, Dictionary<int, int> deobf_tileChangesDictionary)
            => self.field_Private_Dictionary_2_Int32_Int32_0 = deobf_tileChangesDictionary;


        public static List<ValueTuple<int, int>> get_deobf_tileChangesList(this TileManager self)
            => self.field_Private_List_1_ValueTuple_2_Int32_Int32_0;

        public static void set_deobf_tileChangesList(this TileManager self, List<ValueTuple<int, int>> deobf_tileChangesList)
            => self.field_Private_List_1_ValueTuple_2_Int32_Int32_0 = deobf_tileChangesList;


        public static Dictionary<int, int> get_currentTileChange(this TileManager self)
            => self.field_Private_Dictionary_2_Int32_Int32_1;

        public static void set_currentTileChange(this TileManager self, Dictionary<int, int> currentTileChange)
            => self.field_Private_Dictionary_2_Int32_Int32_1 = currentTileChange;


        public static Dictionary<int, int> get_lastTileChange(this TileManager self)
            => self.field_Private_Dictionary_2_Int32_Int32_2;

        public static void set_lastTileChange(this TileManager self, Dictionary<int, int> lastTileChange)
            => self.field_Private_Dictionary_2_Int32_Int32_2 = lastTileChange;


        public static void InitTiles(this TileManager self)
            => self.Method_Private_Void_0();


        public static void SendTileChanges(this TileManager self)
            => self.Method_Private_Void_PDM_17();
    }

    public static class TimerExtensions
    {
        public static TextMeshProUGUI get_timerText(this Timer self)
            => self.field_Private_TextMeshProUGUI_0;

        public static void set_timerText(this Timer self, TextMeshProUGUI timerText)
            => self.field_Private_TextMeshProUGUI_0 = timerText;


        public static float get_currentTime(this Timer self)
            => self.field_Private_Single_0;

        public static void set_currentTime(this Timer self, float currentTime)
            => self.field_Private_Single_0 = currentTime;


        public static bool get_running(this Timer self)
            => self.field_Private_Boolean_0;

        public static void set_running(this Timer self, bool running)
            => self.field_Private_Boolean_0 = running;
    }

    public static class TntManagerExtensions
    {
        public static float get_pieceSize(this TntManager self)
            => self.field_Private_Single_0;

        public static void set_pieceSize(this TntManager self, float pieceSize)
            => self.field_Private_Single_0 = pieceSize;
    }

    public static class TopNavigateExtensions
    {
        public static int get_deobf_lastSelected(this TopNavigate self)
            => self.field_Private_Int32_0;

        public static void set_deobf_lastSelected(this TopNavigate self, int deobf_lastSelected)
            => self.field_Private_Int32_0 = deobf_lastSelected;
    }

    public static class TopRightStatusUiExtensions
    {
        public static ValueTuple<int, int> get_deobf_goodBadPlayers(this TopRightStatusUi self)
            => self.field_Private_ValueTuple_2_Int32_Int32_0;

        public static void set_deobf_goodBadPlayers(this TopRightStatusUi self, ValueTuple<int, int> deobf_goodBadPlayers)
            => self.field_Private_ValueTuple_2_Int32_Int32_0 = deobf_goodBadPlayers;


        public static GameMode get_deobf_gameMode(this TopRightStatusUi self)
            => self.field_Private_GameMode_0;

        public static void set_deobf_gameMode(this TopRightStatusUi self, GameMode deobf_gameMode)
            => self.field_Private_GameMode_0 = deobf_gameMode;


        public static GameModeHnS get_deobf_gameModeHnS(this TopRightStatusUi self)
            => self.field_Private_GameModePublicLi1UIsehiLi1UIDi2Unique_0;

        public static void set_deobf_gameModeHnS(this TopRightStatusUi self, GameModeHnS deobf_gameModeHnS)
            => self.field_Private_GameModePublicLi1UIsehiLi1UIDi2Unique_0 = deobf_gameModeHnS;


        public static int get_deobf_kills(this TopRightStatusUi self)
            => self.field_Private_Int32_0;

        public static void set_deobf_kills(this TopRightStatusUi self, int deobf_kills)
            => self.field_Private_Int32_0 = deobf_kills;


        public static string get_deobf_noEliminationsText(this TopRightStatusUi self)
            => self.field_Private_String_0;

        public static void set_deobf_noEliminationsText(this TopRightStatusUi self, string deobf_noEliminationsText)
            => self.field_Private_String_0 = deobf_noEliminationsText;


        public static string get_deobf_eliminationsString(this TopRightStatusUi self)
            => self.field_Private_String_1;

        public static void set_deobf_eliminationsString(this TopRightStatusUi self, string deobf_eliminationsString)
            => self.field_Private_String_1 = deobf_eliminationsString;


        public static void HnsUI(this TopRightStatusUi self)
            => self.Method_Private_Void_PDM_8();


        public static void UpdatePlayersLeft(this TopRightStatusUi self)
            => self.Method_Private_Void_PDM_65();


        public static void PlayersLeftUI(this TopRightStatusUi self)
            => self.Method_Private_Void_PDM_67();
    }

    public static class TransitionExtensions
    {
        public static Transition_TransitionCallback get_callbackFunction(this Transition self)
            => self.field_Private_MulticastDelegateNPublicSealedVoUnique_0;

        public static void set_callbackFunction(this Transition self, Transition_TransitionCallback callbackFunction)
            => self.field_Private_MulticastDelegateNPublicSealedVoUnique_0 = callbackFunction;


        public static float get_currentTime(this Transition self)
            => self.field_Private_Single_0;

        public static void set_currentTime(this Transition self, float currentTime)
            => self.field_Private_Single_0 = currentTime;


        public static float get_transitionTime(this Transition self)
            => self.field_Private_Single_1;

        public static void set_transitionTime(this Transition self, float transitionTime)
            => self.field_Private_Single_1 = transitionTime;


        /**
         * <summary>This is a Coroutine: <see cref="Transition.ObjectNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiObObObUnique"/></summary>
         */
        public static IEnumerator InvokeCallback(this Transition self, float delay)
            => self.Method_Private_IEnumerator_Single_0(delay);
    }

    public static class UiBtnExtensions
    {
        public static float get_desiredScaleX(this UiBtn self)
            => self.field_Private_Single_0;

        public static void set_desiredScaleX(this UiBtn self, float desiredScaleX)
            => self.field_Private_Single_0 = desiredScaleX;


        public static bool get_stopped(this UiBtn self)
            => self.field_Private_Boolean_0;

        public static void set_stopped(this UiBtn self, bool stopped)
            => self.field_Private_Boolean_0 = stopped;


        public static float get_textScaleMultiplier(this UiBtn self)
            => self.field_Private_Single_1;

        public static void set_textScaleMultiplier(this UiBtn self, float textScaleMultiplier)
            => self.field_Private_Single_1 = textScaleMultiplier;


        public static Vector3 get_defaultTextScale(this UiBtn self)
            => self.field_Private_Vector3_0;

        public static void set_defaultTextScale(this UiBtn self, Vector3 defaultTextScale)
            => self.field_Private_Vector3_0 = defaultTextScale;


        public static void SetScale(this UiBtn self, float scale)
            => self.Method_Private_Void_Single_0(scale);
    }

    public static class VignetteControllerExtensions
    {
        public static float get_currentFadeTime()
            => VignetteController.field_Private_Static_Single_0;

        public static void set_currentFadeTime(float currentFadeTime)
            => VignetteController.field_Private_Static_Single_0 = currentFadeTime;


        public static float get_fadeTime(this VignetteController self)
            => self.field_Private_Single_0;

        public static void set_fadeTime(this VignetteController self, float fadeTime)
            => self.field_Private_Single_0 = fadeTime;


        public static float get_dmgAlpha()
            => VignetteController.field_Private_Static_Single_1;

        public static void set_dmgAlpha(float dmgAlpha)
            => VignetteController.field_Private_Static_Single_1 = dmgAlpha;
    }

    public static class VoiceChatExtensions
    {
        public static MemoryStream get_stream(this VoiceChat self)
            => self.field_Private_MemoryStream_0;

        public static void set_stream(this VoiceChat self, MemoryStream stream)
            => self.field_Private_MemoryStream_0 = stream;


        public static int get_optimalRate(this VoiceChat self)
            => self.field_Private_Int32_0;

        public static void set_optimalRate(this VoiceChat self, int optimalRate)
            => self.field_Private_Int32_0 = optimalRate;


        public static int get_playbackBuffer(this VoiceChat self)
            => self.field_Private_Int32_1;

        public static void set_playbackBuffer(this VoiceChat self, int playbackBuffer)
            => self.field_Private_Int32_1 = playbackBuffer;


        public static int get_dataPosition(this VoiceChat self)
            => self.field_Private_Int32_2;

        public static void set_dataPosition(this VoiceChat self, int dataPosition)
            => self.field_Private_Int32_2 = dataPosition;


        public static int get_dataReceived(this VoiceChat self)
            => self.field_Private_Int32_3;

        public static void set_dataReceived(this VoiceChat self, int dataReceived)
            => self.field_Private_Int32_3 = dataReceived;
    }

    public static class WaterSplashExtensions
    {
        public static List<PlayerManager> get_onCooldown(this WaterSplash self)
            => self.field_Private_List_1_MonoBehaviourPublicCSstReshTrheObplBojuUnique_0;

        public static void set_onCooldown(this WaterSplash self, List<PlayerManager> onCooldown)
            => self.field_Private_List_1_MonoBehaviourPublicCSstReshTrheObplBojuUnique_0 = onCooldown;


        public static void Cooldown(this WaterSplash self)
            => self.Method_Private_Void_PDM_8();
    }

    public static class zzTransparencyCaptureExtensions
    {
        public static Texture2D captureScreenshot()
            => zzTransparencyCapture.Method_Public_Static_Texture2D_PDM_0();


        public static void captureScreenshot(string name)
            => zzTransparencyCapture.Method_Public_Static_Void_String_PDM_0(name);


        public static Texture2D captureView(Rect rect)
            => zzTransparencyCapture.Method_Private_Static_Texture2D_Rect_PDM_3(rect);


        public static Color getColor(Color color, Color color2)
            => zzTransparencyCapture.Method_Private_Static_Color_Color_Color_PDM_4(color, color2);


        public static float getAlpha(float num, float num2)
            => zzTransparencyCapture.Method_Private_Static_Single_Single_Single_PDM_0(num, num2);


        public static Texture2D capture(Rect rect)
            => zzTransparencyCapture.Method_Public_Static_Texture2D_Rect_PDM_2(rect);
    }

    public static class Deobf_BlockDropBlockManagerExtensions
    {
        public static Vector3 get_deobf_unusedBasePosition(this Deobf_BlockDropBlockManager self)
            => self.field_Private_Vector3_0;

        public static void set_deobf_unusedBasePosition(this Deobf_BlockDropBlockManager self, Vector3 deobf_unusedBasePosition)
            => self.field_Private_Vector3_0 = deobf_unusedBasePosition;


        public static Vector3 get_deobf_halfBlockSize(this Deobf_BlockDropBlockManager self)
            => self.field_Private_Vector3_1;

        public static void set_deobf_halfBlockSize(this Deobf_BlockDropBlockManager self, Vector3 deobf_halfBlockSize)
            => self.field_Private_Vector3_1 = deobf_halfBlockSize;


        public static Vector3 get_deobf_dropPosition(this Deobf_BlockDropBlockManager self)
            => self.field_Private_Vector3_2;

        public static void set_deobf_dropPosition(this Deobf_BlockDropBlockManager self, Vector3 deobf_dropPosition)
            => self.field_Private_Vector3_2 = deobf_dropPosition;


        public static float get_deobf_unusedFloat(this Deobf_BlockDropBlockManager self)
            => self.field_Private_Single_0;

        public static void set_deobf_unusedFloat(this Deobf_BlockDropBlockManager self, float deobf_unusedFloat)
            => self.field_Private_Single_0 = deobf_unusedFloat;


        public static Vector3 get_deobf_unusedPosition(this Deobf_BlockDropBlockManager self)
            => self.field_Private_Vector3_3;

        public static void set_deobf_unusedPosition(this Deobf_BlockDropBlockManager self, Vector3 deobf_unusedPosition)
            => self.field_Private_Vector3_3 = deobf_unusedPosition;


        public static List<Vector2> get_deobf_dropPositions(this Deobf_BlockDropBlockManager self)
            => self.field_Private_List_1_Vector2_0;

        public static void set_deobf_dropPositions(this Deobf_BlockDropBlockManager self, List<Vector2> deobf_dropPositions)
            => self.field_Private_List_1_Vector2_0 = deobf_dropPositions;


        public static Dictionary<Vector2, int> get_deobf_dropCounts(this Deobf_BlockDropBlockManager self)
            => self.field_Private_Dictionary_2_Vector2_Int32_0;

        public static void set_deobf_dropCounts(this Deobf_BlockDropBlockManager self, Dictionary<Vector2, int> deobf_dropCounts)
            => self.field_Private_Dictionary_2_Vector2_Int32_0 = deobf_dropCounts;


        public static MeshCollider get_deobf_unusedCollider(this Deobf_BlockDropBlockManager self)
            => self.field_Private_MeshCollider_0;

        public static void set_deobf_unusedCollider(this Deobf_BlockDropBlockManager self, MeshCollider deobf_unusedCollider)
            => self.field_Private_MeshCollider_0 = deobf_unusedCollider;


        public static float get_deobf_speed(this Deobf_BlockDropBlockManager self)
            => self.field_Private_Single_1;

        public static void set_deobf_speed(this Deobf_BlockDropBlockManager self, float deobf_speed)
            => self.field_Private_Single_1 = deobf_speed;


        public static int[,] get_deobf_unusedIntArray(this Deobf_BlockDropBlockManager self)
            => DimensionalArrayUtil.ToManaged2D<int>(self.field_Private_Il2CppObjectBase_0);

        public static void set_deobf_unusedIntArray(this Deobf_BlockDropBlockManager self, int[,] deobf_unusedIntArray)
            => self.field_Private_Il2CppObjectBase_0 = DimensionalArrayUtil.FromManaged2D(deobf_unusedIntArray);


        public static float get_deobf_unusedFloatTwelve(this Deobf_BlockDropBlockManager self)
            => self.field_Private_Single_2;

        public static void set_deobf_unusedFloatTwelve(this Deobf_BlockDropBlockManager self, float deobf_unusedFloatTwelve)
            => self.field_Private_Single_2 = deobf_unusedFloatTwelve;


        public static float get_deobf_dropSpeed(this Deobf_BlockDropBlockManager self)
            => self.field_Private_Single_3;

        public static void set_deobf_dropSpeed(this Deobf_BlockDropBlockManager self, float deobf_dropSpeed)
            => self.field_Private_Single_3 = deobf_dropSpeed;


        /**
         * <summary>This is a Coroutine: <see cref="Deobf_BlockDropBlockManager.ObjectNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeveSiObTrRiObVeUnique"/></summary>
         */
        public static IEnumerator Deobf_DropBlock(this Deobf_BlockDropBlockManager self, Vector2 position)
            => self.Method_Private_IEnumerator_Vector2_PDM_5(position);


        public static void Deobf_CombineMesh(this Deobf_BlockDropBlockManager self, MeshFilter filter)
            => self.Method_Private_Void_MeshFilter_PDM_12(filter);
    }

    public static class Deobf_CenterMeshExtensions
    {
        public static void Deobf_CenterMesh(this Deobf_CenterMesh self)
            => self.Method_Private_Void_0();
    }

    public static class Deobf_CosmeticItemUtilsExtensions
    {
        public static string[] get_deobf_hairColorsCommon()
            => Deobf_CosmeticItemUtils.field_Private_Static_ArrayOf_0;

        public static void set_deobf_hairColorsCommon(string[] deobf_hairColorsCommon)
            => Deobf_CosmeticItemUtils.field_Private_Static_ArrayOf_0 = deobf_hairColorsCommon;


        public static string get_deobf_hairBrown()
            => Deobf_CosmeticItemUtils.field_Private_Static_String_0;

        public static void set_deobf_hairBrown(string deobf_hairBrown)
            => Deobf_CosmeticItemUtils.field_Private_Static_String_0 = deobf_hairBrown;


        public static string get_deobf_hairBlond()
            => Deobf_CosmeticItemUtils.field_Private_Static_String_1;

        public static void set_deobf_hairBlond(string deobf_hairBlond)
            => Deobf_CosmeticItemUtils.field_Private_Static_String_1 = deobf_hairBlond;


        public static string get_deobf_hairGray()
            => Deobf_CosmeticItemUtils.field_Private_Static_String_2;

        public static void set_deobf_hairGray(string deobf_hairGray)
            => Deobf_CosmeticItemUtils.field_Private_Static_String_2 = deobf_hairGray;


        public static string get_deobf_hairLightBlue()
            => Deobf_CosmeticItemUtils.field_Private_Static_String_3;

        public static void set_deobf_hairLightBlue(string deobf_hairLightBlue)
            => Deobf_CosmeticItemUtils.field_Private_Static_String_3 = deobf_hairLightBlue;


        public static string get_deobf_hairCreme()
            => Deobf_CosmeticItemUtils.field_Private_Static_String_4;

        public static void set_deobf_hairCreme(string deobf_hairCreme)
            => Deobf_CosmeticItemUtils.field_Private_Static_String_4 = deobf_hairCreme;


        public static string[] get_deobf_hairColorsUncommon()
            => Deobf_CosmeticItemUtils.field_Private_Static_ArrayOf_1;

        public static void set_deobf_hairColorsUncommon(string[] deobf_hairColorsUncommon)
            => Deobf_CosmeticItemUtils.field_Private_Static_ArrayOf_1 = deobf_hairColorsUncommon;


        public static string get_deobf_hairBlue()
            => Deobf_CosmeticItemUtils.field_Private_Static_String_5;

        public static void set_deobf_hairBlue(string deobf_hairBlue)
            => Deobf_CosmeticItemUtils.field_Private_Static_String_5 = deobf_hairBlue;


        public static string get_deobf_hairGreen()
            => Deobf_CosmeticItemUtils.field_Private_Static_String_6;

        public static void set_deobf_hairGreen(string deobf_hairGreen)
            => Deobf_CosmeticItemUtils.field_Private_Static_String_6 = deobf_hairGreen;


        public static string get_deobf_hairRed()
            => Deobf_CosmeticItemUtils.field_Private_Static_String_7;

        public static void set_deobf_hairRed(string deobf_hairRed)
            => Deobf_CosmeticItemUtils.field_Private_Static_String_7 = deobf_hairRed;


        public static string[] get_deobf_hairColorsRare()
            => Deobf_CosmeticItemUtils.field_Private_Static_ArrayOf_2;

        public static void set_deobf_hairColorsRare(string[] deobf_hairColorsRare)
            => Deobf_CosmeticItemUtils.field_Private_Static_ArrayOf_2 = deobf_hairColorsRare;


        public static string get_deobf_hairOrange()
            => Deobf_CosmeticItemUtils.field_Private_Static_String_8;

        public static void set_deobf_hairOrange(string deobf_hairOrange)
            => Deobf_CosmeticItemUtils.field_Private_Static_String_8 = deobf_hairOrange;


        public static string get_deobf_hairPink()
            => Deobf_CosmeticItemUtils.field_Private_Static_String_9;

        public static void set_deobf_hairPink(string deobf_hairPink)
            => Deobf_CosmeticItemUtils.field_Private_Static_String_9 = deobf_hairPink;


        public static string get_deobf_hairBlack()
            => Deobf_CosmeticItemUtils.field_Private_Static_String_10;

        public static void set_deobf_hairBlack(string deobf_hairBlack)
            => Deobf_CosmeticItemUtils.field_Private_Static_String_10 = deobf_hairBlack;


        public static string[] get_deobf_hairColorsLegendary()
            => Deobf_CosmeticItemUtils.field_Private_Static_ArrayOf_3;

        public static void set_deobf_hairColorsLegendary(string[] deobf_hairColorsLegendary)
            => Deobf_CosmeticItemUtils.field_Private_Static_ArrayOf_3 = deobf_hairColorsLegendary;


        public static string get_deobf_hairGolden()
            => Deobf_CosmeticItemUtils.field_Private_Static_String_11;

        public static void set_deobf_hairGolden(string deobf_hairGolden)
            => Deobf_CosmeticItemUtils.field_Private_Static_String_11 = deobf_hairGolden;


        public static string get_deobf_colorCommon()
            => Deobf_CosmeticItemUtils.field_Private_Static_String_12;

        public static void set_deobf_colorCommon(string deobf_colorCommon)
            => Deobf_CosmeticItemUtils.field_Private_Static_String_12 = deobf_colorCommon;


        public static string get_deobf_colorUncommon()
            => Deobf_CosmeticItemUtils.field_Private_Static_String_13;

        public static void set_deobf_colorUncommon(string deobf_colorUncommon)
            => Deobf_CosmeticItemUtils.field_Private_Static_String_13 = deobf_colorUncommon;


        public static string get_deobf_colorRare()
            => Deobf_CosmeticItemUtils.field_Private_Static_String_14;

        public static void set_deobf_colorRare(string deobf_colorRare)
            => Deobf_CosmeticItemUtils.field_Private_Static_String_14 = deobf_colorRare;


        public static string get_deobf_colorExtraordinary()
            => Deobf_CosmeticItemUtils.field_Private_Static_String_15;

        public static void set_deobf_colorExtraordinary(string deobf_colorExtraordinary)
            => Deobf_CosmeticItemUtils.field_Private_Static_String_15 = deobf_colorExtraordinary;


        public static string get_deobf_colorBrand()
            => Deobf_CosmeticItemUtils.field_Private_Static_String_16;

        public static void set_deobf_colorBrand(string deobf_colorBrand)
            => Deobf_CosmeticItemUtils.field_Private_Static_String_16 = deobf_colorBrand;


        public static string get_deobf_unusedColorBrand2()
            => Deobf_CosmeticItemUtils.field_Private_Static_String_17;

        public static void set_deobf_unusedColorBrand2(string deobf_unusedColorBrand2)
            => Deobf_CosmeticItemUtils.field_Private_Static_String_17 = deobf_unusedColorBrand2;


        public static string get_deobf_colorUnique()
            => Deobf_CosmeticItemUtils.field_Private_Static_String_18;

        public static void set_deobf_colorUnique(string deobf_colorUnique)
            => Deobf_CosmeticItemUtils.field_Private_Static_String_18 = deobf_colorUnique;
    }

    public static class Deobf_CrabFightCrabAttackHitboxExtensions
    {
        public static float get_deobf_range(this Deobf_CrabFightCrabAttackHitbox self)
            => self.field_Private_Single_0;

        public static void set_deobf_range(this Deobf_CrabFightCrabAttackHitbox self, float deobf_range)
            => self.field_Private_Single_0 = deobf_range;


        public static bool get_deobf_disabled(this Deobf_CrabFightCrabAttackHitbox self)
            => self.field_Private_Boolean_0;

        public static void set_deobf_disabled(this Deobf_CrabFightCrabAttackHitbox self, bool deobf_disabled)
            => self.field_Private_Boolean_0 = deobf_disabled;


        public static void Deobf_DestroySelf(this Deobf_CrabFightCrabAttackHitbox self)
            => self.Method_Private_Void_PDM_10();
    }

    public static class Deobf_CrabFightCrabAttackWarningExtensions
    {
        public static Vector3 get_deobf_desiredScale(this Deobf_CrabFightCrabAttackWarning self)
            => self.field_Private_Vector3_0;

        public static void set_deobf_desiredScale(this Deobf_CrabFightCrabAttackWarning self, Vector3 deobf_desiredScale)
            => self.field_Private_Vector3_0 = deobf_desiredScale;


        public static void Deobf_DestroySelf(this Deobf_CrabFightCrabAttackWarning self)
            => self.Method_Private_Void_PDM_4();
    }

    public static class Deobf_CrabFightCrabBallAttackExtensions
    {
        public static Deobf_CrabFightCrabAttackWarning get_deobf_warning(this Deobf_CrabFightCrabBallAttack self)
            => self.field_Private_MonoBehaviourPublicVeofLawhPrprVeUnique_0;

        public static void set_deobf_warning(this Deobf_CrabFightCrabBallAttack self, Deobf_CrabFightCrabAttackWarning deobf_warning)
            => self.field_Private_MonoBehaviourPublicVeofLawhPrprVeUnique_0 = deobf_warning;
    }

    public static class Deobf_CrabFightCrabBallAttackControllerExtensions
    {
        public static float get_deobf_startHeight(this Deobf_CrabFightCrabBallAttackController self)
            => self.field_Private_Single_0;

        public static void set_deobf_startHeight(this Deobf_CrabFightCrabBallAttackController self, float deobf_startHeight)
            => self.field_Private_Single_0 = deobf_startHeight;


        public static int get_deobf_spawnedBalls(this Deobf_CrabFightCrabBallAttackController self)
            => self.field_Private_Int32_0;

        public static void set_deobf_spawnedBalls(this Deobf_CrabFightCrabBallAttackController self, int deobf_spawnedBalls)
            => self.field_Private_Int32_0 = deobf_spawnedBalls;


        public static Il2CppSystem.Random get_deobf_random(this Deobf_CrabFightCrabBallAttackController self)
            => self.field_Private_Random_0;

        public static void set_deobf_random(this Deobf_CrabFightCrabBallAttackController self, Il2CppSystem.Random deobf_random)
            => self.field_Private_Random_0 = deobf_random;


        public static void Deobf_SpawnBall(this Deobf_CrabFightCrabBallAttackController self)
            => self.Method_Private_Void_PDM_17();


        public static PlayerManager Deobf_GetRandomPlayer(this Deobf_CrabFightCrabBallAttackController self)
            => self.Method_Private_MonoBehaviourPublicCSstReshTrheObplBojuUnique_PDM_9();
    }

    public static class Deobf_CrabFightCrabBallAttackLandingFxExtensions
    {
        public static bool get_deobf_disabled(this Deobf_CrabFightCrabBallAttackLandingFx self)
            => self.field_Private_Boolean_0;

        public static void set_deobf_disabled(this Deobf_CrabFightCrabBallAttackLandingFx self, bool deobf_disabled)
            => self.field_Private_Boolean_0 = deobf_disabled;


        public static int get_backing_damage(this Deobf_CrabFightCrabBallAttackLandingFx self)
            => self.field_Private_Int32_0;

        public static void set_backing_damage(this Deobf_CrabFightCrabBallAttackLandingFx self, int backing_damage)
            => self.field_Private_Int32_0 = backing_damage;


        public static int get_damage(this Deobf_CrabFightCrabBallAttackLandingFx self)
            => self.prop_Int32_0;

        public static void set_damage(this Deobf_CrabFightCrabBallAttackLandingFx self, int damage)
            => self.prop_Int32_0 = damage;


        public static void Deobf_EnableCollider(this Deobf_CrabFightCrabBallAttackLandingFx self)
            => self.Method_Private_Void_PDM_3();


        public static void Deobf_DestroySelf(this Deobf_CrabFightCrabBallAttackLandingFx self)
            => self.Method_Private_Void_PDM_12();
    }

    public static class Deobf_CrabFightCrabBossBarExtensions
    {
        public static float get_deobf_maxHealth(this Deobf_CrabFightCrabBossBar self)
            => self.field_Private_Single_0;

        public static void set_deobf_maxHealth(this Deobf_CrabFightCrabBossBar self, float deobf_maxHealth)
            => self.field_Private_Single_0 = deobf_maxHealth;


        public static float get_deobf_health(this Deobf_CrabFightCrabBossBar self)
            => self.field_Private_Single_1;

        public static void set_deobf_health(this Deobf_CrabFightCrabBossBar self, float deobf_health)
            => self.field_Private_Single_1 = deobf_health;
    }

    public static class Deobf_CrabFightCrabManagerExtensions
    {
        public static Deobf_CrabFightCrabManager_Deobf_CurrentState get_deobf_currentState(this Deobf_CrabFightCrabManager self)
            => self.field_Private_EnumNPublicSealedvaWaAtDe4vUnique_0;

        public static void set_deobf_currentState(this Deobf_CrabFightCrabManager self, Deobf_CrabFightCrabManager_Deobf_CurrentState deobf_currentState)
            => self.field_Private_EnumNPublicSealedvaWaAtDe4vUnique_0 = deobf_currentState;


        public static int get_deobf_difficulty(this Deobf_CrabFightCrabManager self)
            => self.field_Private_Int32_0;

        public static void set_deobf_difficulty(this Deobf_CrabFightCrabManager self, int deobf_difficulty)
            => self.field_Private_Int32_0 = deobf_difficulty;


        public static float get_deobf_health(this Deobf_CrabFightCrabManager self)
            => self.field_Private_Single_0;

        public static void set_deobf_health(this Deobf_CrabFightCrabManager self, float deobf_health)
            => self.field_Private_Single_0 = deobf_health;


        public static float get_deobf_maxHealth(this Deobf_CrabFightCrabManager self)
            => self.field_Private_Single_1;

        public static void set_deobf_maxHealth(this Deobf_CrabFightCrabManager self, float deobf_maxHealth)
            => self.field_Private_Single_1 = deobf_maxHealth;


        public static Vector3 get_deobf_forward(this Deobf_CrabFightCrabManager self)
            => self.field_Private_Vector3_0;

        public static void set_deobf_forward(this Deobf_CrabFightCrabManager self, Vector3 deobf_forward)
            => self.field_Private_Vector3_0 = deobf_forward;


        public static Vector3 get_deobf_targetOffset(this Deobf_CrabFightCrabManager self)
            => self.field_Private_Vector3_1;

        public static void set_deobf_targetOffset(this Deobf_CrabFightCrabManager self, Vector3 deobf_targetOffset)
            => self.field_Private_Vector3_1 = deobf_targetOffset;


        public static float get_deobf_minFaceTargetAngle(this Deobf_CrabFightCrabManager self)
            => self.field_Private_Single_2;

        public static void set_deobf_minFaceTargetAngle(this Deobf_CrabFightCrabManager self, float deobf_minFaceTargetAngle)
            => self.field_Private_Single_2 = deobf_minFaceTargetAngle;


        public static bool get_deobf_rotating(this Deobf_CrabFightCrabManager self)
            => self.field_Private_Boolean_0;

        public static void set_deobf_rotating(this Deobf_CrabFightCrabManager self, bool deobf_rotating)
            => self.field_Private_Boolean_0 = deobf_rotating;


        public static List<ulong> get_deobf_allAlivePlayers(this Deobf_CrabFightCrabManager self)
            => self.field_Private_List_1_UInt64_0;

        public static void set_deobf_allAlivePlayers(this Deobf_CrabFightCrabManager self, List<ulong> deobf_allAlivePlayers)
            => self.field_Private_List_1_UInt64_0 = deobf_allAlivePlayers;


        public static float get_deobf_animationJumpTime(this Deobf_CrabFightCrabManager self)
            => self.field_Private_Single_3;

        public static void set_deobf_animationJumpTime(this Deobf_CrabFightCrabManager self, float deobf_animationJumpTime)
            => self.field_Private_Single_3 = deobf_animationJumpTime;


        public static float get_deobf_animationSlamTime(this Deobf_CrabFightCrabManager self)
            => self.field_Private_Single_4;

        public static void set_deobf_animationSlamTime(this Deobf_CrabFightCrabManager self, float deobf_animationSlamTime)
            => self.field_Private_Single_4 = deobf_animationSlamTime;


        public static float get_deobf_animationRainTime(this Deobf_CrabFightCrabManager self)
            => self.field_Private_Single_5;

        public static void set_deobf_animationRainTime(this Deobf_CrabFightCrabManager self, float deobf_animationRainTime)
            => self.field_Private_Single_5 = deobf_animationRainTime;


        public static float get_deobf_animationSpikesTime(this Deobf_CrabFightCrabManager self)
            => self.field_Private_Single_6;

        public static void set_deobf_animationSpikesTime(this Deobf_CrabFightCrabManager self, float deobf_animationSpikesTime)
            => self.field_Private_Single_6 = deobf_animationSpikesTime;


        public static float get_deobf_animationDoubleJumpTime(this Deobf_CrabFightCrabManager self)
            => self.field_Private_Single_7;

        public static void set_deobf_animationDoubleJumpTime(this Deobf_CrabFightCrabManager self, float deobf_animationDoubleJumpTime)
            => self.field_Private_Single_7 = deobf_animationDoubleJumpTime;


        public static void Deobf_TargetRandomPlayer(this Deobf_CrabFightCrabManager self)
            => self.Method_Private_Void_1();


        public static void Deobf_NextAnimation(this Deobf_CrabFightCrabManager self)
            => self.Method_Private_Void_PDM_49();


        public static void Deobf_StopRotating(this Deobf_CrabFightCrabManager self)
            => self.Method_Private_Void_PDM_50();


        public static void Deobf_KillCrab(this Deobf_CrabFightCrabManager self)
            => self.Method_Private_Void_2();


        public static void Deobf_FinishAnimation(this Deobf_CrabFightCrabManager self)
            => self.Method_Private_Void_PDM_56();
    }

    public static class Deobf_CrabFightCrabSpikeAttackExtensions
    {
        public static float get_deobf_warningTime(this Deobf_CrabFightCrabSpikeAttack self)
            => self.field_Private_Single_0;

        public static void set_deobf_warningTime(this Deobf_CrabFightCrabSpikeAttack self, float deobf_warningTime)
            => self.field_Private_Single_0 = deobf_warningTime;


        public static float get_deobf_warningScale(this Deobf_CrabFightCrabSpikeAttack self)
            => self.field_Private_Single_1;

        public static void set_deobf_warningScale(this Deobf_CrabFightCrabSpikeAttack self, float deobf_warningScale)
            => self.field_Private_Single_1 = deobf_warningScale;


        public static Deobf_CrabFightCrabAttackWarning get_deobf_warning(this Deobf_CrabFightCrabSpikeAttack self)
            => self.field_Private_MonoBehaviourPublicVeofLawhPrprVeUnique_0;

        public static void set_deobf_warning(this Deobf_CrabFightCrabSpikeAttack self, Deobf_CrabFightCrabAttackWarning deobf_warning)
            => self.field_Private_MonoBehaviourPublicVeofLawhPrprVeUnique_0 = deobf_warning;


        public static void Deobf_Attack(this Deobf_CrabFightCrabSpikeAttack self)
            => self.Method_Private_Void_PDM_71();
    }

    public static class Deobf_CrabFightCrabSpikeAttackControllerExtensions
    {
        public static float get_deobf_unusedStartHeight(this Deobf_CrabFightCrabSpikeAttackController self)
            => self.field_Private_Single_0;

        public static void set_deobf_unusedStartHeight(this Deobf_CrabFightCrabSpikeAttackController self, float deobf_unusedStartHeight)
            => self.field_Private_Single_0 = deobf_unusedStartHeight;


        public static int get_deobf_spikesSent(this Deobf_CrabFightCrabSpikeAttackController self)
            => self.field_Private_Int32_0;

        public static void set_deobf_spikesSent(this Deobf_CrabFightCrabSpikeAttackController self, int deobf_spikesSent)
            => self.field_Private_Int32_0 = deobf_spikesSent;


        public static Il2CppSystem.Random get_deobf_random(this Deobf_CrabFightCrabSpikeAttackController self)
            => self.field_Private_Random_0;

        public static void set_deobf_random(this Deobf_CrabFightCrabSpikeAttackController self, Il2CppSystem.Random deobf_random)
            => self.field_Private_Random_0 = deobf_random;


        public static PlayerManager Deobf_GetRandomPlayer(this Deobf_CrabFightCrabSpikeAttackController self)
            => self.Method_Private_MonoBehaviourPublicCSstReshTrheObplBojuUnique_PDM_0();


        public static void Deobf_SendSpike(this Deobf_CrabFightCrabSpikeAttackController self)
            => self.Method_Private_Void_PDM_1();
    }

    public static class Deobf_CrabFightCrabSpikeAttackDamageExtensions
    {
        public static bool get_deobf_disabled(this Deobf_CrabFightCrabSpikeAttackDamage self)
            => self.field_Private_Boolean_0;

        public static void set_deobf_disabled(this Deobf_CrabFightCrabSpikeAttackDamage self, bool deobf_disabled)
            => self.field_Private_Boolean_0 = deobf_disabled;

        public static void Deobf_DestroySelf(this Deobf_CrabFightCrabSpikeAttackDamage self)
            => self.Method_Private_Void_PDM_1();
    }

    public static class Deobf_CrateOpeningDisplayManagerExtensions
    {
        public static bool get_deobf_unusedHasShownText(this Deobf_CrateOpeningDisplayManager self)
            => self.field_Private_Boolean_0;

        public static void set_deobf_unusedHasShownText(this Deobf_CrateOpeningDisplayManager self, bool deobf_unusedHasShownText)
            => self.field_Private_Boolean_0 = deobf_unusedHasShownText;
    }

    public static class Deobf_CrateRoomManagerExtensions
    {
        public static Vector3 get_deobf_crateStartPosition(this Deobf_CrateRoomManager self)
            => self.field_Private_Vector3_0;

        public static void set_deobf_crateStartPosition(this Deobf_CrateRoomManager self, Vector3 deobf_crateStartPosition)
            => self.field_Private_Vector3_0 = deobf_crateStartPosition;


        public static Vector3 get_deobf_crateFallenPosition(this Deobf_CrateRoomManager self)
            => self.field_Private_Vector3_1;

        public static void set_deobf_crateFallenPosition(this Deobf_CrateRoomManager self, Vector3 deobf_crateFallenPosition)
            => self.field_Private_Vector3_1 = deobf_crateFallenPosition;


        public static Vector3 get_deobf_crateDesiredPosition(this Deobf_CrateRoomManager self)
            => self.field_Private_Vector3_2;

        public static void set_deobf_crateDesiredPosition(this Deobf_CrateRoomManager self, Vector3 deobf_crateDesiredPosition)
            => self.field_Private_Vector3_2 = deobf_crateDesiredPosition;


        public static Vector3 get_deobf_roomStartPosition(this Deobf_CrateRoomManager self)
            => self.field_Private_Vector3_3;

        public static void set_deobf_roomStartPosition(this Deobf_CrateRoomManager self, Vector3 deobf_roomStartPosition)
            => self.field_Private_Vector3_3 = deobf_roomStartPosition;


        public static Vector3 get_deobf_unusedVector3(this Deobf_CrateRoomManager self)
            => self.field_Private_Vector3_4;

        public static void set_deobf_unusedVector3(this Deobf_CrateRoomManager self, Vector3 deobf_unusedVector3)
            => self.field_Private_Vector3_4 = deobf_unusedVector3;


        public static Vector3 get_deobf_roomDesiredPosition(this Deobf_CrateRoomManager self)
            => self.field_Private_Vector3_5;

        public static void set_deobf_roomDesiredPosition(this Deobf_CrateRoomManager self, Vector3 deobf_roomDesiredPosition)
            => self.field_Private_Vector3_5 = deobf_roomDesiredPosition;


        public static Vector3 get_deobf_itemStartPosition(this Deobf_CrateRoomManager self)
            => self.field_Private_Vector3_6;

        public static void set_deobf_itemStartPosition(this Deobf_CrateRoomManager self, Vector3 deobf_itemStartPosition)
            => self.field_Private_Vector3_6 = deobf_itemStartPosition;


        public static Vector3 get_deobf_itemEndPosition(this Deobf_CrateRoomManager self)
            => self.field_Private_Vector3_7;

        public static void set_deobf_itemEndPosition(this Deobf_CrateRoomManager self, Vector3 deobf_itemEndPosition)
            => self.field_Private_Vector3_7 = deobf_itemEndPosition;


        public static Vector3 get_deobf_itemDesiredPosition(this Deobf_CrateRoomManager self)
            => self.field_Private_Vector3_8;

        public static void set_deobf_itemDesiredPosition(this Deobf_CrateRoomManager self, Vector3 deobf_itemDesiredPosition)
            => self.field_Private_Vector3_8 = deobf_itemDesiredPosition;


        public static Vector3 get_deobf_itemDesiredScale(this Deobf_CrateRoomManager self)
            => self.field_Private_Vector3_9;

        public static void set_deobf_itemDesiredScale(this Deobf_CrateRoomManager self, Vector3 deobf_itemDesiredScale)
            => self.field_Private_Vector3_9 = deobf_itemDesiredScale;


        public static bool get_deobf_opening(this Deobf_CrateRoomManager self)
            => self.field_Private_Boolean_0;

        public static void set_deobf_opening(this Deobf_CrateRoomManager self, bool deobf_opening)
            => self.field_Private_Boolean_0 = deobf_opening;


        public static float get_deobf_itemDesiredRotation(this Deobf_CrateRoomManager self)
            => self.field_Private_Single_0;

        public static void set_deobf_itemDesiredRotation(this Deobf_CrateRoomManager self, float deobf_itemDesiredRotation)
            => self.field_Private_Single_0 = deobf_itemDesiredRotation;


        public static float get_deobf_crateFallSpeed(this Deobf_CrateRoomManager self)
            => self.field_Private_Single_1;

        public static void set_deobf_crateFallSpeed(this Deobf_CrateRoomManager self, float deobf_crateFallSpeed)
            => self.field_Private_Single_1 = deobf_crateFallSpeed;


        /**
         * <summary>This is a Coroutine: <see cref="Deobf_CrateRoomManager.ObjectNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAuObitObObUnique"/></summary>
         */
        public static IEnumerator Deobf_OpenCrate(this Deobf_CrateRoomManager self, AudioClip clip)
            => self.Method_Private_IEnumerator_AudioClip_0(clip);
    }

    public static class Deobf_CustomPositiveRandomExtensions
    {
        public static int get_Deobf_Max()
            => Deobf_CustomPositiveRandom.field_Private_Static_Int32_0;


        public static int get_Deobf_Int()
            => Deobf_CustomPositiveRandom.field_Private_Static_Int32_1;


        public static int get_Deobf_Min()
            => Deobf_CustomPositiveRandom.field_Private_Static_Int32_2;


        public static int get_deobf_int1(this Deobf_CustomPositiveRandom self)
            => self.field_Private_Int32_0;

        public static void set_deobf_int1(this Deobf_CustomPositiveRandom self, int deobf_int1)
            => self.field_Private_Int32_0 = deobf_int1;


        public static int get_deobf_int2(this Deobf_CustomPositiveRandom self)
            => self.field_Private_Int32_1;

        public static void set_deobf_int2(this Deobf_CustomPositiveRandom self, int deobf_int2)
            => self.field_Private_Int32_1 = deobf_int2;


        public static int[] get_deobf_intArray(this Deobf_CustomPositiveRandom self)
            => self.field_Private_ArrayOf_Int32_0;

        public static void set_deobf_intArray(this Deobf_CustomPositiveRandom self, int[] deobf_intArray)
            => self.field_Private_ArrayOf_Int32_0 = deobf_intArray;


        public static int Deobf_Next(this Deobf_CustomPositiveRandom self)
            => self.Method_Private_Int32_18();


        public static double Deobf_Sample(this Deobf_CustomPositiveRandom self)
            => self.Method_Private_Double_PDM_8();
    }

    public static class Deobf_DeathFromAboveBlockColliderExtensions
    {
        public static Rigidbody get_deobf_rb(this Deobf_DeathFromAboveBlockCollider self)
            => self.field_Private_Rigidbody_0;

        public static void set_deobf_rb(this Deobf_DeathFromAboveBlockCollider self, Rigidbody deobf_rb)
            => self.field_Private_Rigidbody_0 = deobf_rb;
    }

    public static class Deobf_DeathFromAboveBlockManagerExtensions
    {
        public static Vector3 get_deobf_unusedPosition(this Deobf_DeathFromAboveBlockManager self)
            => self.field_Private_Vector3_0;

        public static void set_deobf_unusedPosition(this Deobf_DeathFromAboveBlockManager self, Vector3 deobf_unusedPosition)
            => self.field_Private_Vector3_0 = deobf_unusedPosition;


        public static Vector3 get_deobf_preFallHeight(this Deobf_DeathFromAboveBlockManager self)
            => self.field_Private_Vector3_1;

        public static void set_deobf_preFallHeight(this Deobf_DeathFromAboveBlockManager self, Vector3 deobf_preFallHeight)
            => self.field_Private_Vector3_1 = deobf_preFallHeight;


        public static Vector3 get_deobf_debugLineHeight(this Deobf_DeathFromAboveBlockManager self)
            => self.field_Private_Vector3_2;

        public static void set_deobf_debugLineHeight(this Deobf_DeathFromAboveBlockManager self, Vector3 deobf_debugLineHeight)
            => self.field_Private_Vector3_2 = deobf_debugLineHeight;


        public static Vector3 get_deobf_halfBlockSize(this Deobf_DeathFromAboveBlockManager self)
            => self.field_Private_Vector3_3;

        public static void set_deobf_halfBlockSize(this Deobf_DeathFromAboveBlockManager self, Vector3 deobf_halfBlockSize)
            => self.field_Private_Vector3_3 = deobf_halfBlockSize;


        public static ParticleSystem.EmissionModule get_deobf_unusedEmissionModule(this Deobf_DeathFromAboveBlockManager self)
            => self.field_Private_EmissionModule_0;

        public static void set_deobf_unusedEmissionModule(this Deobf_DeathFromAboveBlockManager self, ParticleSystem.EmissionModule deobf_unusedEmissionModule)
            => self.field_Private_EmissionModule_0 = deobf_unusedEmissionModule;


        public static float get_deobf_unusedFloat(this Deobf_DeathFromAboveBlockManager self)
            => self.field_Private_Single_0;

        public static void set_deobf_unusedFloat(this Deobf_DeathFromAboveBlockManager self, float deobf_unusedFloat)
            => self.field_Private_Single_0 = deobf_unusedFloat;


        public static Vector3 get_deobf_startBlockPosition(this Deobf_DeathFromAboveBlockManager self)
            => self.field_Private_Vector3_4;

        public static void set_deobf_startBlockPosition(this Deobf_DeathFromAboveBlockManager self, Vector3 deobf_startBlockPosition)
            => self.field_Private_Vector3_4 = deobf_startBlockPosition;


        public static float get_deobf_speed(this Deobf_DeathFromAboveBlockManager self)
            => self.field_Private_Single_1;

        public static void set_deobf_speed(this Deobf_DeathFromAboveBlockManager self, float deobf_speed)
            => self.field_Private_Single_1 = deobf_speed;


        public static int[,] get_deobf_blockHoles(this Deobf_DeathFromAboveBlockManager self)
            => DimensionalArrayUtil.ToManaged2D<int>(self.field_Private_Il2CppObjectBase_0);

        public static void set_deobf_blockHoles(this Deobf_DeathFromAboveBlockManager self, int[,] deobf_blockHoles)
            => self.field_Private_Il2CppObjectBase_0 = DimensionalArrayUtil.FromManaged2D(deobf_blockHoles);


        public static float get_deobf_slowSpeed(this Deobf_DeathFromAboveBlockManager self)
            => self.field_Private_Single_2;

        public static void set_deobf_slowSpeed(this Deobf_DeathFromAboveBlockManager self, float deobf_slowSpeed)
            => self.field_Private_Single_2 = deobf_slowSpeed;


        public static float get_deobf_fastSpeed(this Deobf_DeathFromAboveBlockManager self)
            => self.field_Private_Single_3;

        public static void set_deobf_fastSpeed(this Deobf_DeathFromAboveBlockManager self, float deobf_fastSpeed)
            => self.field_Private_Single_3 = deobf_fastSpeed;
    }

    public static class Deobf_DeathFromAboveVoxelRendererExtensions
    {
        public static Mesh get_deobf_mesh(this Deobf_DeathFromAboveVoxelRenderer self)
            => self.field_Private_Mesh_0;

        public static void set_deobf_mesh(this Deobf_DeathFromAboveVoxelRenderer self, Mesh deobf_mesh)
            => self.field_Private_Mesh_0 = deobf_mesh;


        public static List<Vector3> get_deobf_vertices(this Deobf_DeathFromAboveVoxelRenderer self)
            => self.field_Private_List_1_Vector3_0;

        public static void set_deobf_vertices(this Deobf_DeathFromAboveVoxelRenderer self, List<Vector3> deobf_vertices)
            => self.field_Private_List_1_Vector3_0 = deobf_vertices;


        public static List<int> get_deobf_triangles(this Deobf_DeathFromAboveVoxelRenderer self)
            => self.field_Private_List_1_Int32_0;

        public static void set_deobf_triangles(this Deobf_DeathFromAboveVoxelRenderer self, List<int> deobf_triangles)
            => self.field_Private_List_1_Int32_0 = deobf_triangles;


        public static float get_deobf_halfScale(this Deobf_DeathFromAboveVoxelRenderer self)
            => self.field_Private_Single_0;

        public static void set_deobf_halfScale(this Deobf_DeathFromAboveVoxelRenderer self, float deobf_halfScale)
            => self.field_Private_Single_0 = deobf_halfScale;


        public static void Deobf_ConstructMesh(this Deobf_DeathFromAboveVoxelRenderer self)
            => self.Method_Private_Void_0();


        public static void Deobf_GenerateFaces(this Deobf_DeathFromAboveVoxelRenderer self, float scale, Vector3 offset, int x, int y, Deobf_DeathFromAboveVoxelRendererHelper helper)
            => self.Method_Private_Void_Single_Vector3_Int32_Int32_ObjectPublicInObInInUnique_PDM_2(scale, offset, x, y, helper);


        public static void Deobf_GenerateFace(this Deobf_DeathFromAboveVoxelRenderer self, Deobf_Direction direction, float scale, Vector3 offset)
            => self.Method_Private_Void_EnumPublicSealedvaNoEaSoWeUpDo7vUnique_Single_Vector3_0(direction, scale, offset);


        public static void Deobf_GenerateMesh(this Deobf_DeathFromAboveVoxelRenderer self, Deobf_DeathFromAboveVoxelRendererHelper helper)
            => self.Method_Private_Void_ObjectPublicInObInInUnique_0(helper);
    }

    public static class Deobf_DeathFromAboveVoxelRendererHelperExtensions
    {
        public static int[,] get_deobf_2dGrid(this Deobf_DeathFromAboveVoxelRendererHelper self)
            => DimensionalArrayUtil.ToManaged2D<int>(self.field_Private_Il2CppObjectBase_0);

        public static void set_deobf_2dGrid(this Deobf_DeathFromAboveVoxelRendererHelper self, int[,] deobf_2dGrid)
            => self.field_Private_Il2CppObjectBase_0 = DimensionalArrayUtil.FromManaged2D(deobf_2dGrid);


        public static Deobf_DeathFromAboveVoxelRendererHelper_Deobf_FacePosition[] get_deobf_facePositionAtDirection(this Deobf_DeathFromAboveVoxelRendererHelper self)
            => self.field_Private_ArrayOf_ValueTypeNPrivateSealedInInInUnique_0;

        public static void set_deobf_facePositionAtDirection(this Deobf_DeathFromAboveVoxelRendererHelper self, Deobf_DeathFromAboveVoxelRendererHelper_Deobf_FacePosition[] deobf_facePositionAtDirection)
            => self.field_Private_ArrayOf_ValueTypeNPrivateSealedInInInUnique_0 = deobf_facePositionAtDirection;


        public static int get_Deobf_Width(this Deobf_DeathFromAboveVoxelRendererHelper self)
            => self.prop_Int32_0;


        public static int get_Deobf_Length(this Deobf_DeathFromAboveVoxelRendererHelper self)
            => self.prop_Int32_1;


        public static int Deobf_CollidingFaces(this Deobf_DeathFromAboveVoxelRendererHelper self, int x, int y, Deobf_Direction direction)
            => self.Method_Public_Int32_Int32_Int32_EnumPublicSealedvaNoEaSoWeUpDo7vUnique_0(x, y, direction);


        public static void Deobf_Set2dGrid(this Deobf_DeathFromAboveVoxelRendererHelper self, int[,] grid)
            => self.Method_Public_Void_Il2CppObjectBase_10(DimensionalArrayUtil.FromManaged2D(grid));


        public static int Deobf_GetValueAtGridPosition(this Deobf_DeathFromAboveVoxelRendererHelper self, int x, int y)
            => self.Method_Public_Int32_Int32_Int32_7(x, y);
    }

    public static class Deobf_DeathFromAboveVoxelRendererHelper_Deobf_FacePositionExtensions
    {
        public static int get_deobf_x(this Deobf_DeathFromAboveVoxelRendererHelper_Deobf_FacePosition self)
            => self.field_Public_Int32_0;

        public static void set_deobf_x(this Deobf_DeathFromAboveVoxelRendererHelper_Deobf_FacePosition self, int deobf_x)
            => self.field_Public_Int32_0 = deobf_x;


        public static int get_deobf_y(this Deobf_DeathFromAboveVoxelRendererHelper_Deobf_FacePosition self)
            => self.field_Public_Int32_1;

        public static void set_deobf_y(this Deobf_DeathFromAboveVoxelRendererHelper_Deobf_FacePosition self, int deobf_y)
            => self.field_Public_Int32_1 = deobf_y;


        public static int get_deobf_z(this Deobf_DeathFromAboveVoxelRendererHelper_Deobf_FacePosition self)
            => self.field_Public_Int32_2;

        public static void set_deobf_z(this Deobf_DeathFromAboveVoxelRendererHelper_Deobf_FacePosition self, int deobf_z)
            => self.field_Public_Int32_2 = deobf_z;
    }

    public static class Deobf_DodgeballTeamToClothesTriggerExtensions
    {
        public static List<PlayerManager> get_deobf_pms(this Deobf_DodgeballTeamToClothesTrigger self)
            => self.field_Private_List_1_MonoBehaviourPublicCSstReshTrheObplBojuUnique_0;

        public static void set_deobf_pms(this Deobf_DodgeballTeamToClothesTrigger self, List<PlayerManager> deobf_pms)
            => self.field_Private_List_1_MonoBehaviourPublicCSstReshTrheObplBojuUnique_0 = deobf_pms;


        public static PlayerManager get_deobf_pm(this Deobf_DodgeballTeamToClothesTrigger self)
            => self.field_Private_MonoBehaviourPublicCSstReshTrheObplBojuUnique_0;

        public static void set_deobf_pm(this Deobf_DodgeballTeamToClothesTrigger self, PlayerManager deobf_pm)
            => self.field_Private_MonoBehaviourPublicCSstReshTrheObplBojuUnique_0 = deobf_pm;
    }

    public static class Deobf_FollowTargetExtensions
    {
        public static Vector3 get_deobf_offset(this Deobf_FollowTarget self)
            => self.field_Private_Vector3_0;

        public static void set_deobf_offset(this Deobf_FollowTarget self, Vector3 deobf_offset)
            => self.field_Private_Vector3_0 = deobf_offset;
    }

    public static class Deobf_GameModeBlockDropExtensions
    {
        public static Deobf_CustomPositiveRandom get_deobf_random(this Deobf_GameModeBlockDrop self)
            => self.field_Private_RandomPublicInInInInInInUnique_0;

        public static void set_deobf_random(this Deobf_GameModeBlockDrop self, Deobf_CustomPositiveRandom deobf_random)
            => self.field_Private_RandomPublicInInInInInInUnique_0 = deobf_random;


        public static float get_deobf_dropSpeed(this Deobf_GameModeBlockDrop self)
            => self.field_Private_Single_0;

        public static void set_deobf_dropSpeed(this Deobf_GameModeBlockDrop self, float deobf_dropSpeed)
            => self.field_Private_Single_0 = deobf_dropSpeed;


        public static float get_deobf_maxDropSpeed(this Deobf_GameModeBlockDrop self)
            => self.field_Private_Single_1;

        public static void set_deobf_maxDropSpeed(this Deobf_GameModeBlockDrop self, float deobf_maxDropSpeed)
            => self.field_Private_Single_1 = deobf_maxDropSpeed;


        public static float get_deobf_incrementDropSpeed(this Deobf_GameModeBlockDrop self)
            => self.field_Private_Single_2;

        public static void set_deobf_incrementDropSpeed(this Deobf_GameModeBlockDrop self, float deobf_incrementDropSpeed)
            => self.field_Private_Single_2 = deobf_incrementDropSpeed;


        public static int get_deobf_desiredPlayersRemaining(this Deobf_GameModeBlockDrop self)
            => self.field_Private_Int32_0;

        public static void set_deobf_desiredPlayersRemaining(this Deobf_GameModeBlockDrop self, int deobf_desiredPlayersRemaining)
            => self.field_Private_Int32_0 = deobf_desiredPlayersRemaining;


        /**
         * <summary>This is a Coroutine: <see cref="Deobf_GameModeBlockDrop.ObjectNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitispObSiseInUIUnique"/></summary>
         */
        public static IEnumerator Deobf_DropNextBlock(this Deobf_GameModeBlockDrop self, float delay, float dropSpeed, int seed, ulong clientId)
            => self.Method_Private_IEnumerator_Single_Single_Int32_UInt64_1(delay, dropSpeed, seed, clientId);


        public static void Deobf_CheckGameOver(this Deobf_GameModeBlockDrop self)
            => self.Method_Private_Void_4();
    }

    public static class Deobf_GameModeDeathFromAboveExtensions
    {
        public static Il2CppSystem.Random get_deobf_random(this Deobf_GameModeDeathFromAbove self)
            => self.field_Private_Random_0;

        public static void set_deobf_random(this Deobf_GameModeDeathFromAbove self, Il2CppSystem.Random deobf_random)
            => self.field_Private_Random_0 = deobf_random;


        public static float get_deobf_dropSpeed(this Deobf_GameModeDeathFromAbove self)
            => self.field_Private_Single_0;

        public static void set_deobf_dropSpeed(this Deobf_GameModeDeathFromAbove self, float deobf_dropSpeed)
            => self.field_Private_Single_0 = deobf_dropSpeed;


        public static float get_deobf_maxDropSpeed(this Deobf_GameModeDeathFromAbove self)
            => self.field_Private_Single_1;

        public static void set_deobf_maxDropSpeed(this Deobf_GameModeDeathFromAbove self, float deobf_maxDropSpeed)
            => self.field_Private_Single_1 = deobf_maxDropSpeed;


        public static float get_deobf_incrementDropSpeed(this Deobf_GameModeDeathFromAbove self)
            => self.field_Private_Single_2;

        public static void set_deobf_incrementDropSpeed(this Deobf_GameModeDeathFromAbove self, float deobf_incrementDropSpeed)
            => self.field_Private_Single_2 = deobf_incrementDropSpeed;


        public static int get_deobf_openSpaces(this Deobf_GameModeDeathFromAbove self)
            => self.field_Private_Int32_0;

        public static void set_deobf_openSpaces(this Deobf_GameModeDeathFromAbove self, int deobf_openSpaces)
            => self.field_Private_Int32_0 = deobf_openSpaces;


        public static int get_deobf_desiredPlayersRemaining(this Deobf_GameModeDeathFromAbove self)
            => self.field_Private_Int32_1;

        public static void set_deobf_desiredPlayersRemaining(this Deobf_GameModeDeathFromAbove self, int deobf_desiredPlayersRemaining)
            => self.field_Private_Int32_1 = deobf_desiredPlayersRemaining;


        public static void Deobf_CheckGameOver(this Deobf_GameModeDeathFromAbove self)
            => self.Method_Private_Void_1();


        /**
         * <summary>This is a Coroutine: <see cref="Deobf_GameModeDeathFromAbove.ObjectNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitispObSiseInUIUnique"/></summary>
         */
        public static IEnumerator Deobf_DropNextBlock(this Deobf_GameModeDeathFromAbove self, float delay, float dropSpeed, int seed, ulong clientId)
            => self.Method_Private_IEnumerator_Single_Single_Int32_UInt64_3(delay, dropSpeed, seed, clientId);


        public static void Deobf_SetOpenSpaces(this Deobf_GameModeDeathFromAbove self)
            => self.Method_Private_Void_2();


        public static void Deobf_DecrementOpenSpaces(this Deobf_GameModeDeathFromAbove self)
            => self.Method_Private_Void_3();
    }

    public static class Deobf_GameModeDodgeballExtensions
    {
        public static List<ulong> get_deobf_team1(this Deobf_GameModeDodgeball self)
            => self.field_Private_List_1_UInt64_0;

        public static void set_deobf_team1(this Deobf_GameModeDodgeball self, List<ulong> deobf_team1)
            => self.field_Private_List_1_UInt64_0 = deobf_team1;


        public static List<ulong> get_deobf_team2(this Deobf_GameModeDodgeball self)
            => self.field_Private_List_1_UInt64_1;

        public static void set_deobf_team2(this Deobf_GameModeDodgeball self, List<ulong> deobf_team2)
            => self.field_Private_List_1_UInt64_1 = deobf_team2;


        public static bool get_deobf_canEndOnSoloPlayer(this Deobf_GameModeDodgeball self)
            => self.field_Private_Boolean_0;

        public static void set_deobf_canEndOnSoloPlayer(this Deobf_GameModeDodgeball self, bool deobf_canEndOnSoloPlayer)
            => self.field_Private_Boolean_0 = deobf_canEndOnSoloPlayer;


        public static int Deobf_GetLivingPlayersOnTeam(this Deobf_GameModeDodgeball self, List<ulong> team)
            => self.Method_Private_Int32_List_1_UInt64_3(team);
    }

    public static class Deobf_GameModeSnowBrawlExtensions
    {
        public static int get_deobf_desiredPlayers(this Deobf_GameModeSnowBrawl self)
            => self.field_Private_Int32_0;

        public static void set_deobf_desiredPlayers(this Deobf_GameModeSnowBrawl self, int deobf_desiredPlayers)
            => self.field_Private_Int32_0 = deobf_desiredPlayers;
    }

    public static class Deobf_GameModeStandoffExtensions
    {
        public static int get_deobf_playersToKill(this Deobf_GameModeStandoff self)
            => self.field_Private_Int32_0;

        public static void set_deobf_playersToKill(this Deobf_GameModeStandoff self, int deobf_playersToKill)
            => self.field_Private_Int32_0 = deobf_playersToKill;


        public static List<ulong> get_deobf_playersToEliminate(this Deobf_GameModeStandoff self)
            => self.field_Private_List_1_UInt64_0;

        public static void set_deobf_playersToEliminate(this Deobf_GameModeStandoff self, List<ulong> deobf_playersToEliminate)
            => self.field_Private_List_1_UInt64_0 = deobf_playersToEliminate;


        public static bool Deobf_CheckNoBullets(this Deobf_GameModeStandoff self)
            => self.Method_Private_Boolean_0();


        public static List<ulong> Deobf_GetAllAlivePlayers(this Deobf_GameModeStandoff self)
            => self.Method_Private_List_1_UInt64_1();
    }

    public static class Deobf_GameModeStandoff_Deobf_PlayerInfoExtensions
    {
        public static int get_deobf_bullets(this Deobf_GameModeStandoff_Deobf_PlayerInfo self)
            => self.field_Public_Int32_0;

        public static void set_deobf_bullets(this Deobf_GameModeStandoff_Deobf_PlayerInfo self, int deobf_bullets)
            => self.field_Public_Int32_0 = deobf_bullets;


        public static int get_deobf_marks(this Deobf_GameModeStandoff_Deobf_PlayerInfo self)
            => self.field_Public_Int32_1;

        public static void set_deobf_marks(this Deobf_GameModeStandoff_Deobf_PlayerInfo self, int deobf_marks)
            => self.field_Public_Int32_1 = deobf_marks;


        public static PlayerManager get_deobf_pm(this Deobf_GameModeStandoff_Deobf_PlayerInfo self)
            => self.field_Public_MonoBehaviourPublicCSstReshTrheObplBojuUnique_0;

        public static void set_deobf_pm(this Deobf_GameModeStandoff_Deobf_PlayerInfo self, PlayerManager deobf_pm)
            => self.field_Public_MonoBehaviourPublicCSstReshTrheObplBojuUnique_0 = deobf_pm;


        public static int Deobf_GetPenalties(this Deobf_GameModeStandoff_Deobf_PlayerInfo self)
            => self.Method_Public_Int32_7();


        public static string Deobf_UnusedBulletsAndMarks(this Deobf_GameModeStandoff_Deobf_PlayerInfo self)
            => self.Method_Public_String_PDM_38();
    }

    public static class Deobf_GameUiPauseMenuDailyQuestExtensions
    {
        public static bool get_deobf_claiming(this Deobf_GameUiPauseMenuDailyQuest self)
            => self.field_Private_Boolean_0;

        public static void set_deobf_claiming(this Deobf_GameUiPauseMenuDailyQuest self, bool deobf_claiming)
            => self.field_Private_Boolean_0 = deobf_claiming;


        public static void Deobf_UpdateQuestDetails(this Deobf_GameUiPauseMenuDailyQuest self)
            => self.Method_Private_Void_PDM_10();


        public static void Deobf_FinishClaiming(this Deobf_GameUiPauseMenuDailyQuest self)
            => self.Method_Private_Void_4();
    }

    public static class Deobf_GameUiPausePracticeMapSelectionExtensions
    {
        public static void Deobf_SelectMap(this Deobf_GameUiPausePracticeMapSelection self, Button button)
            => self.Method_Private_Void_Button_0(button);


        public static void Deobf_MakeMapButtons(this Deobf_GameUiPausePracticeMapSelection self)
            => self.Method_Private_Void_0();
    }

    public static class Deobf_GameUiStatusTopRightStandoffUIExtensions
    {
        public static Deobf_GameModeStandoff get_deobf_gameMode(this Deobf_GameUiStatusTopRightStandoffUI self)
            => self.field_Private_GameModePublicDi2UIObstBocaSiacwaUnique_0;

        public static void set_deobf_gameMode(this Deobf_GameUiStatusTopRightStandoffUI self, Deobf_GameModeStandoff deobf_gameMode)
            => self.field_Private_GameModePublicDi2UIObstBocaSiacwaUnique_0 = deobf_gameMode;


        public static PlayerManager get_deobf_pm(this Deobf_GameUiStatusTopRightStandoffUI self)
            => self.field_Private_MonoBehaviourPublicCSstReshTrheObplBojuUnique_0;

        public static void set_deobf_pm(this Deobf_GameUiStatusTopRightStandoffUI self, PlayerManager deobf_pm)
            => self.field_Private_MonoBehaviourPublicCSstReshTrheObplBojuUnique_0 = deobf_pm;


        public static int get_deobf_lastRecordedScore(this Deobf_GameUiStatusTopRightStandoffUI self)
            => self.field_Private_Int32_0;

        public static void set_deobf_lastRecordedScore(this Deobf_GameUiStatusTopRightStandoffUI self, int deobf_lastRecordedScore)
            => self.field_Private_Int32_0 = deobf_lastRecordedScore;


        public static List<ulong> get_deobf_playersToEliminate(this Deobf_GameUiStatusTopRightStandoffUI self)
            => self.field_Private_List_1_UInt64_0;

        public static void set_deobf_playersToEliminate(this Deobf_GameUiStatusTopRightStandoffUI self, List<ulong> deobf_playersToEliminate)
            => self.field_Private_List_1_UInt64_0 = deobf_playersToEliminate;


        public static void Deobf_AmBeingEliminated(this Deobf_GameUiStatusTopRightStandoffUI self)
            => self.Method_Private_Void_PDM_13();


        public static void Deobf_UpdateScore(this Deobf_GameUiStatusTopRightStandoffUI self, int newScore)
            => self.Method_Private_Void_Int32_0(newScore);
    }

    public static class Deobf_GeneralUiBaseMeshEffectModifierExtensions
    {
        public static List<UIVertex> get_deobf_uiVetexes(this Deobf_GeneralUiBaseMeshEffectModifier self)
            => self.field_Private_List_1_UIVertex_0;

        public static void set_deobf_uiVetexes(this Deobf_GeneralUiBaseMeshEffectModifier self, List<UIVertex> deobf_uiVetexes)
            => self.field_Private_List_1_UIVertex_0 = deobf_uiVetexes;


        public static Color get_effectColor(this Deobf_GeneralUiBaseMeshEffectModifier self)
            => self.prop_Color_0;

        public static void set_effectColor(this Deobf_GeneralUiBaseMeshEffectModifier self, Color effectColor)
            => self.prop_Color_0 = effectColor;


        public static Vector2 get_effectDistance(this Deobf_GeneralUiBaseMeshEffectModifier self)
            => self.prop_Vector2_0;

        public static void set_effectDistance(this Deobf_GeneralUiBaseMeshEffectModifier self, Vector2 effectDistance)
            => self.prop_Vector2_0 = effectDistance;

        
        public static bool get_useGraphicAlpha(this Deobf_GeneralUiBaseMeshEffectModifier self)
            => self.prop_Boolean_0;

        public static void set_useGraphicAlpha(this Deobf_GeneralUiBaseMeshEffectModifier self, bool useGraphicAlpha)
            => self.prop_Boolean_0 = useGraphicAlpha;


        public static void Deobf_MakeShadow(this Deobf_GeneralUiBaseMeshEffectModifier self, List<UIVertex> uiVertexes, Color32 color, int startIndex, int endLength, float xIncrement, float yIncrement)
            => self.Method_Protected_Void_List_1_UIVertex_Color32_Int32_Int32_Single_Single_PDM_0(uiVertexes, color, startIndex, endLength, xIncrement, yIncrement);


        public static void Deobf_MakeShadowAlloc(this Deobf_GeneralUiBaseMeshEffectModifier self, List<UIVertex> uiVertexes, Color32 color, int startIndex, int endLength, float xIncrement, float yIncrement)
            => self.Method_Protected_Void_List_1_UIVertex_Color32_Int32_Int32_Single_Single_1(uiVertexes, color, startIndex, endLength, xIncrement, yIncrement);
    }

    public static class Deobf_GeneralUiInventoryExtensions
    {
        public static Deobf_MenuUiItemsDisplayDetails get_deobf_equippedHair(this Deobf_GeneralUiInventory self)
            => self.field_Private_MonoBehaviourPublicIPointerEnterHandlerIEventSystemHandlerIPointerExitHandlerRaicbgRashovTeRaitquUnique_0;

        public static void set_deobf_equippedHair(this Deobf_GeneralUiInventory self, Deobf_MenuUiItemsDisplayDetails deobf_equippedHair)
            => self.field_Private_MonoBehaviourPublicIPointerEnterHandlerIEventSystemHandlerIPointerExitHandlerRaicbgRashovTeRaitquUnique_0 = deobf_equippedHair;


        public static Deobf_MenuUiItemsDisplayDetails get_deobf_equippedHat(this Deobf_GeneralUiInventory self)
            => self.field_Private_MonoBehaviourPublicIPointerEnterHandlerIEventSystemHandlerIPointerExitHandlerRaicbgRashovTeRaitquUnique_1;

        public static void set_deobf_equippedHat(this Deobf_GeneralUiInventory self, Deobf_MenuUiItemsDisplayDetails deobf_equippedHat)
            => self.field_Private_MonoBehaviourPublicIPointerEnterHandlerIEventSystemHandlerIPointerExitHandlerRaicbgRashovTeRaitquUnique_1 = deobf_equippedHat;


        public static Deobf_MenuUiItemsDisplayDetails get_deobf_equippedFace(this Deobf_GeneralUiInventory self)
            => self.field_Private_MonoBehaviourPublicIPointerEnterHandlerIEventSystemHandlerIPointerExitHandlerRaicbgRashovTeRaitquUnique_2;

        public static void set_deobf_equippedFace(this Deobf_GeneralUiInventory self, Deobf_MenuUiItemsDisplayDetails deobf_equippedFace)
            => self.field_Private_MonoBehaviourPublicIPointerEnterHandlerIEventSystemHandlerIPointerExitHandlerRaicbgRashovTeRaitquUnique_2 = deobf_equippedFace;


        public static Deobf_MenuUiItemsDisplayDetails get_deobf_equippedShoes(this Deobf_GeneralUiInventory self)
            => self.field_Private_MonoBehaviourPublicIPointerEnterHandlerIEventSystemHandlerIPointerExitHandlerRaicbgRashovTeRaitquUnique_3;

        public static void set_deobf_equippedShoes(this Deobf_GeneralUiInventory self, Deobf_MenuUiItemsDisplayDetails deobf_equippedShoes)
            => self.field_Private_MonoBehaviourPublicIPointerEnterHandlerIEventSystemHandlerIPointerExitHandlerRaicbgRashovTeRaitquUnique_3 = deobf_equippedShoes;


        public static Deobf_MenuUiItemsDisplayDetails get_deobf_equippedTop(this Deobf_GeneralUiInventory self)
            => self.field_Private_MonoBehaviourPublicIPointerEnterHandlerIEventSystemHandlerIPointerExitHandlerRaicbgRashovTeRaitquUnique_4;

        public static void set_deobf_equippedTop(this Deobf_GeneralUiInventory self, Deobf_MenuUiItemsDisplayDetails deobf_equippedTop)
            => self.field_Private_MonoBehaviourPublicIPointerEnterHandlerIEventSystemHandlerIPointerExitHandlerRaicbgRashovTeRaitquUnique_4 = deobf_equippedTop;


        public static Deobf_MenuUiItemsDisplayDetails get_deobf_equippedBackpack(this Deobf_GeneralUiInventory self)
            => self.field_Private_MonoBehaviourPublicIPointerEnterHandlerIEventSystemHandlerIPointerExitHandlerRaicbgRashovTeRaitquUnique_5;

        public static void set_deobf_equippedBackpack(this Deobf_GeneralUiInventory self, Deobf_MenuUiItemsDisplayDetails deobf_equippedBackpack)
            => self.field_Private_MonoBehaviourPublicIPointerEnterHandlerIEventSystemHandlerIPointerExitHandlerRaicbgRashovTeRaitquUnique_5 = deobf_equippedBackpack;


        public static CosmeticItem_Deobf_Type get_deobf_showItemsOfType(this Deobf_GeneralUiInventory self)
            => self.field_Private_EnumNPublicSealedvaNoHaFaHaShOtBoToBaUnique_0;

        public static void set_deobf_showItemsOfType(this Deobf_GeneralUiInventory self, CosmeticItem_Deobf_Type deobf_showItemsOfType)
            => self.field_Private_EnumNPublicSealedvaNoHaFaHaShOtBoToBaUnique_0 = deobf_showItemsOfType;


        public static CosmeticItem_Deobf_Type get_deobf_lastShownItems(this Deobf_GeneralUiInventory self)
            => self.field_Private_EnumNPublicSealedvaNoHaFaHaShOtBoToBaUnique_1;

        public static void set_deobf_lastShownItems(this Deobf_GeneralUiInventory self, CosmeticItem_Deobf_Type deobf_lastShownItems)
            => self.field_Private_EnumNPublicSealedvaNoHaFaHaShOtBoToBaUnique_1 = deobf_lastShownItems;


        public static int get_deobf_page(this Deobf_GeneralUiInventory self)
            => self.field_Private_Int32_0;

        public static void set_deobf_page(this Deobf_GeneralUiInventory self, int deobf_page)
            => self.field_Private_Int32_0 = deobf_page;


        public static int get_deobf_maxPage(this Deobf_GeneralUiInventory self)
            => self.field_Private_Int32_1;

        public static void set_deobf_maxPage(this Deobf_GeneralUiInventory self, int deobf_maxPage)
            => self.field_Private_Int32_1 = deobf_maxPage;


        public static int get_deobf_itemsPerPage(this Deobf_GeneralUiInventory self)
            => self.field_Private_Int32_2;

        public static void set_deobf_itemsPerPage(this Deobf_GeneralUiInventory self, int deobf_itemsPerPage)
            => self.field_Private_Int32_2 = deobf_itemsPerPage;


        public static bool get_deobf_firstLoad(this Deobf_GeneralUiInventory self)
            => self.field_Private_Boolean_0;

        public static void set_deobf_firstLoad(this Deobf_GeneralUiInventory self, bool deobf_firstLoad)
            => self.field_Private_Boolean_0 = deobf_firstLoad;


        public static List<Deobf_SteamInventory_Deobf_CosmeticItem> get_deobf_inventory(this Deobf_GeneralUiInventory self)
            => self.field_Private_List_1_ObjectNPublicIComparableStDi2InStStUnique_0;

        public static void set_deobf_inventory(this Deobf_GeneralUiInventory self, List<Deobf_SteamInventory_Deobf_CosmeticItem> deobf_inventory)
            => self.field_Private_List_1_ObjectNPublicIComparableStDi2InStStUnique_0 = deobf_inventory;


        public static bool get_deobf_inventorySorted(this Deobf_GeneralUiInventory self)
            => self.field_Private_Boolean_1;

        public static void set_deobf_inventorySorted(this Deobf_GeneralUiInventory self, bool deobf_inventorySorted)
            => self.field_Private_Boolean_1 = deobf_inventorySorted;


        public static string get_deobf_otherPageCircle(this Deobf_GeneralUiInventory self)
            => self.field_Private_String_0;

        public static void set_deobf_otherPageCircle(this Deobf_GeneralUiInventory self, string deobf_otherPageCircle)
            => self.field_Private_String_0 = deobf_otherPageCircle;


        public static string get_deobf_currentPageCircle(this Deobf_GeneralUiInventory self)
            => self.field_Private_String_1;

        public static void set_deobf_currentPageCircle(this Deobf_GeneralUiInventory self, string deobf_currentPageCircle)
            => self.field_Private_String_1 = deobf_currentPageCircle;


        public static void Deobf_RefreshInventory(this Deobf_GeneralUiInventory self)
            => self.Method_Private_Void_0();


        public static void Deobf_UpdatePageCircles(this Deobf_GeneralUiInventory self)
            => self.Method_Private_Void_1();


        public static void Deobf_ClickedItem(this Deobf_GeneralUiInventory self, int itemId, ulong itemUID, Deobf_MenuUiItemsDisplayDetails details)
            => self.Method_Private_Void_Int32_UInt64_MonoBehaviourPublicIPointerEnterHandlerIEventSystemHandlerIPointerExitHandlerRaicbgRashovTeRaitquUnique_0(itemId, itemUID, details);


        public static void Deobf_UpdateEquipped(this Deobf_GeneralUiInventory self, Deobf_MenuUiItemsDisplayDetails details, CosmeticItem_Deobf_Type type)
            => self.Method_Private_Void_MonoBehaviourPublicIPointerEnterHandlerIEventSystemHandlerIPointerExitHandlerRaicbgRashovTeRaitquUnique_EnumNPublicSealedvaNoHaFaHaShOtBoToBaUnique_0(details, type);
    }

    public static class Deobf_GeneralUiInventoryItemClickExtensions
    {
        public static float get_deobf_modifyAlpha(this Deobf_GeneralUiInventoryItemClick self)
            => self.field_Private_Single_0;

        public static void set_deobf_modifyAlpha(this Deobf_GeneralUiInventoryItemClick self, float deobf_modifyAlpha)
            => self.field_Private_Single_0 = deobf_modifyAlpha;


        public static float get_deobf_modifyAlphaSpeed(this Deobf_GeneralUiInventoryItemClick self)
            => self.field_Private_Single_1;

        public static void set_deobf_modifyAlphaSpeed(this Deobf_GeneralUiInventoryItemClick self, float deobf_modifyAlphaSpeed)
            => self.field_Private_Single_1 = deobf_modifyAlphaSpeed;


        public static SteamItemDetails_t get_deobf_unusedSteamItemDetails(this Deobf_GeneralUiInventoryItemClick self)
            => self.field_Private_SteamItemDetails_t_0;

        public static void set_deobf_unusedSteamItemDetails(this Deobf_GeneralUiInventoryItemClick self, SteamItemDetails_t deobf_unusedSteamItemDetails)
            => self.field_Private_SteamItemDetails_t_0 = deobf_unusedSteamItemDetails;


        public static int get_deobf_itemDefId(this Deobf_GeneralUiInventoryItemClick self)
            => self.field_Private_Int32_0;

        public static void set_deobf_itemDefId(this Deobf_GeneralUiInventoryItemClick self, int deobf_itemDefId)
            => self.field_Private_Int32_0 = deobf_itemDefId;


        public static ulong get_deobf_itemUID(this Deobf_GeneralUiInventoryItemClick self)
            => self.field_Private_UInt64_0;

        public static void set_deobf_itemUID(this Deobf_GeneralUiInventoryItemClick self, ulong deobf_itemUID)
            => self.field_Private_UInt64_0 = deobf_itemUID;


        public static Deobf_MenuUiItemsDisplayDetails get_deobf_itemDisplayDetails(this Deobf_GeneralUiInventoryItemClick self)
            => self.field_Private_MonoBehaviourPublicIPointerEnterHandlerIEventSystemHandlerIPointerExitHandlerRaicbgRashovTeRaitquUnique_0;

        public static void set_deobf_itemDisplayDetails(this Deobf_GeneralUiInventoryItemClick self, Deobf_MenuUiItemsDisplayDetails deobf_itemDisplayDetails)
            => self.field_Private_MonoBehaviourPublicIPointerEnterHandlerIEventSystemHandlerIPointerExitHandlerRaicbgRashovTeRaitquUnique_0 = deobf_itemDisplayDetails;


        public static CosmeticItem_Deobf_Type get_deobf_cosmeticType(this Deobf_GeneralUiInventoryItemClick self)
            => self.field_Private_EnumNPublicSealedvaNoHaFaHaShOtBoToBaUnique_0;

        public static void set_deobf_cosmeticType(this Deobf_GeneralUiInventoryItemClick self, CosmeticItem_Deobf_Type deobf_cosmeticType)
            => self.field_Private_EnumNPublicSealedvaNoHaFaHaShOtBoToBaUnique_0 = deobf_cosmeticType;


        public static void Deobf_ShowOption(this Deobf_GeneralUiInventoryItemClick self, Button button, RawImage image, TextMeshProUGUI text, bool active, string msg)
            => self.Method_Private_Void_Button_RawImage_TextMeshProUGUI_Boolean_String_PDM_0(button, image, text, active, msg);


        public static void Deobf_ShowRecycleOption(this Deobf_GeneralUiInventoryItemClick self)
            => self.Method_Private_Void_0();


        public static void Deobf_CheckHide(this Deobf_GeneralUiInventoryItemClick self)
            => self.Method_Private_Void_1();
    }

    public static class Deobf_GeneralUiInventoryItemHoverExtensions
    {
        public static string get_deobf_tagsTextColorString(this Deobf_GeneralUiInventoryItemHover self)
            => self.field_Private_String_0;

        public static void set_deobf_tagsTextColorString(this Deobf_GeneralUiInventoryItemHover self, string deobf_tagsTextColorString)
            => self.field_Private_String_0 = deobf_tagsTextColorString;


        public static float get_deobf_modifyAlpha(this Deobf_GeneralUiInventoryItemHover self)
            => self.field_Private_Single_0;

        public static void set_deobf_modifyAlpha(this Deobf_GeneralUiInventoryItemHover self, float deobf_modifyAlpha)
            => self.field_Private_Single_0 = deobf_modifyAlpha;


        public static float get_deobf_modifyAlphaSpeed(this Deobf_GeneralUiInventoryItemHover self)
            => self.field_Private_Single_1;

        public static void set_deobf_modifyAlphaSpeed(this Deobf_GeneralUiInventoryItemHover self, float deobf_modifyAlphaSpeed)
            => self.field_Private_Single_1 = deobf_modifyAlphaSpeed;


        public static float get_deobf_detailsHoverTime(this Deobf_GeneralUiInventoryItemHover self)
            => self.field_Private_Single_2;

        public static void set_deobf_detailsHoverTime(this Deobf_GeneralUiInventoryItemHover self, float deobf_detailsHoverTime)
            => self.field_Private_Single_2 = deobf_detailsHoverTime;


        /**
         * <summary>This is a Coroutine: <see cref="Deobf_GeneralUiInventoryItemHover.ObjectNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiCoObitDi2StUnique"/></summary>
         */
        public static IEnumerator Deobf_ShowDetails(this Deobf_GeneralUiInventoryItemHover self, float delay, CosmeticItem item, Dictionary<string, string> properties, RectTransform display)
            => self.Method_Private_IEnumerator_Single_CosmeticItem_Dictionary_2_String_String_RectTransform_1(delay, item, properties, display);
    }

    public static class Deobf_GenerateMeshFromGridExtensions
    {
        public static Mesh get_deobf_mesh(this Deobf_GenerateMeshFromGrid self)
            => self.field_Private_Mesh_0;

        public static void set_deobf_mesh(this Deobf_GenerateMeshFromGrid self, Mesh deobf_mesh)
            => self.field_Private_Mesh_0 = deobf_mesh;


        public static Vector3[] get_deobf_vertices(this Deobf_GenerateMeshFromGrid self)
            => self.field_Private_ArrayOf_Vector3_0;

        public static void set_deobf_vertices(this Deobf_GenerateMeshFromGrid self, Vector3[] deobf_vertices)
            => self.field_Private_ArrayOf_Vector3_0 = deobf_vertices;


        public static int[] get_deobf_triangles(this Deobf_GenerateMeshFromGrid self)
            => self.field_Private_ArrayOf_Int32_0;

        public static void set_deobf_triangles(this Deobf_GenerateMeshFromGrid self, int[] deobf_triangles)
            => self.field_Private_ArrayOf_Int32_0 = deobf_triangles;


        public static void Deobf_ConstructMesh(this Deobf_GenerateMeshFromGrid self)
            => self.Method_Private_Void_PDM_16();


        public static void Deobf_GenerateMesh(this Deobf_GenerateMeshFromGrid self)
            => self.Method_Private_Void_2();
    }

    public static class Deobf_GenerateMeshFromQuadExtensions
    {
        public static Mesh get_deobf_mesh(this Deobf_GenerateMeshFromQuad self)
            => self.field_Private_Mesh_0;

        public static void set_deobf_mesh(this Deobf_GenerateMeshFromQuad self, Mesh deobf_mesh)
            => self.field_Private_Mesh_0 = deobf_mesh;


        public static Vector3[] get_deobf_vertices(this Deobf_GenerateMeshFromQuad self)
            => self.field_Private_ArrayOf_Vector3_0;

        public static void set_deobf_vertices(this Deobf_GenerateMeshFromQuad self, Vector3[] deobf_vertices)
            => self.field_Private_ArrayOf_Vector3_0 = deobf_vertices;


        public static int[] get_deobf_triangles(this Deobf_GenerateMeshFromQuad self)
            => self.field_Private_ArrayOf_Int32_0;

        public static void set_deobf_triangles(this Deobf_GenerateMeshFromQuad self, int[] deobf_triangles)
            => self.field_Private_ArrayOf_Int32_0 = deobf_triangles;


        public static void Deobf_ConstructMesh(this Deobf_GenerateMeshFromQuad self)
            => self.Method_Private_Void_PDM_38();


        public static void Deobf_GenerateMesh(this Deobf_GenerateMeshFromQuad self, float scale, Vector3 offset)
            => self.Method_Private_Void_Single_Vector3_0(scale, offset);
    }

    public static class Deobf_GenerateWeirdMeshExtensions
    {
        public static Mesh get_deobf_mesh(this Deobf_GenerateWeirdMesh self)
            => self.field_Private_Mesh_0;

        public static void set_deobf_mesh(this Deobf_GenerateWeirdMesh self, Mesh deobf_mesh)
            => self.field_Private_Mesh_0 = deobf_mesh;


        public static Vector3[] get_deobf_vertices(this Deobf_GenerateWeirdMesh self)
            => self.field_Private_ArrayOf_Vector3_0;

        public static void set_deobf_vertices(this Deobf_GenerateWeirdMesh self, Vector3[] deobf_vertices)
            => self.field_Private_ArrayOf_Vector3_0 = deobf_vertices;


        public static int[] get_deobf_triangles(this Deobf_GenerateWeirdMesh self)
            => self.field_Private_ArrayOf_Int32_0;

        public static void set_deobf_triangles(this Deobf_GenerateWeirdMesh self, int[] deobf_triangles)
            => self.field_Private_ArrayOf_Int32_0 = deobf_triangles;


        public static void Deobf_ConstructMesh(this Deobf_GenerateWeirdMesh self)
            => self.Method_Private_Void_PDM_9();


        public static void Deobf_GenerateMesh(this Deobf_GenerateWeirdMesh self)
            => self.Method_Private_Void_1();
    }

    public static class Deobf_IProfanityDetectorExtensions
    {
        public static Deobf_IWordAllowlist get_Deobf_WordAllowList(this Deobf_IProfanityDetector self)
            => self.prop_InterfacePublicAbstractInRe1StVoBoStBoVoInUnique_0;


        public static int get_Deobf_ProfanitiesLength(this Deobf_IProfanityDetector self)
            => self.prop_Int32_0;


        public static bool Deobf_IsStrictlyProfanity(this Deobf_IProfanityDetector self, string word)
            => self.Method_Public_Abstract_Virtual_New_Boolean_String_0(word);


        public static ReadOnlyCollection<string> Deobf_FindProfaneWordsInString(this Deobf_IProfanityDetector self, string phrase)
            => self.Method_Public_Abstract_Virtual_New_ReadOnlyCollection_1_String_String_0(phrase);


        public static ReadOnlyCollection<string> Deobf_FindProfaneWordsInString(this Deobf_IProfanityDetector self, string phrase, bool option)
            => self.Method_Public_Abstract_Virtual_New_ReadOnlyCollection_1_String_String_Boolean_0(phrase, option);


        public static bool Deobf_IsProfanity(this Deobf_IProfanityDetector self, string word)
            => self.Method_Public_Abstract_Virtual_New_Boolean_String_1(word);


        public static string Deobf_Filter(this Deobf_IProfanityDetector self, string phrase)
            => self.Method_Public_Abstract_Virtual_New_String_String_0(phrase);


        public static string Deobf_Filter(this Deobf_IProfanityDetector self, string phrase, char filterCharacter)
            => self.Method_Public_Abstract_Virtual_New_String_String_Char_0(phrase, filterCharacter);


        public static string Deobf_Filter(this Deobf_IProfanityDetector self, string phrase, char filterCharacter, bool option)
            => self.Method_Public_Abstract_Virtual_New_String_String_Char_Boolean_0(phrase, filterCharacter, option);


        public static Nullable<ValueTuple<int, int, string>> Deobf_FindFullWord(this Deobf_IProfanityDetector self, string phrase, string word)
            => self.Method_Public_Abstract_Virtual_New_Nullable_1_ValueTuple_3_Int32_Int32_String_String_String_0(phrase, word);


        public static void Deobf_Add(this Deobf_IProfanityDetector self, string word)
            => self.Method_Public_Abstract_Virtual_New_Void_String_0(word);


        public static void Deobf_Add(this Deobf_IProfanityDetector self, string[] words)
            => self.Method_Public_Abstract_Virtual_New_Void_ArrayOf_0(words);


        public static void Deobf_Add(this Deobf_IProfanityDetector self, List<string> words)
            => self.Method_Public_Abstract_Virtual_New_Void_List_1_String_0(words);


        public static bool Deobf_Remove(this Deobf_IProfanityDetector self, string word)
            => self.Method_Public_Abstract_Virtual_New_Boolean_String_2(word);


        public static bool Deobf_Remove(this Deobf_IProfanityDetector self, List<string> words)
            => self.Method_Public_Abstract_Virtual_New_Boolean_List_1_String_0(words);


        public static bool Deobf_Remove(this Deobf_IProfanityDetector self, string[] words)
            => self.Method_Public_Abstract_Virtual_New_Boolean_ArrayOf_0(words);


        public static void Deobf_Clear(this Deobf_IProfanityDetector self)
            => self.Method_Public_Abstract_Virtual_New_Void_0();
    }

    public static class Deobf_IWordAllowlistExtensions
    {
        public static int get_Deobf_WordAllowListLength(this Deobf_IWordAllowlist self)
            => self.prop_Int32_0;


        public static ReadOnlyCollection<string> get_Deobf_WordAllowList(this Deobf_IWordAllowlist self)
            => self.prop_ReadOnlyCollection_1_String_0;


        public static void Deobf_Add(this Deobf_IWordAllowlist self, string word)
            => self.Method_Public_Abstract_Virtual_New_Void_String_0(word);


        public static bool Deobf_IsAllowed(this Deobf_IWordAllowlist self, string word)
            => self.Method_Public_Abstract_Virtual_New_Boolean_String_0(word);


        public static bool Deobf_Remove(this Deobf_IWordAllowlist self, string word)
            => self.Method_Public_Abstract_Virtual_New_Boolean_String_1(word);


        public static void Deobf_Clear(this Deobf_IWordAllowlist self)
            => self.Method_Public_Abstract_Virtual_New_Void_0();
    }

    public static class Deobf_MenuCameraPositionerExtensions
    {
        public static float get_deobf_menuFov(this Deobf_MenuCameraPositioner self)
            => self.field_Private_Single_0;

        public static void set_deobf_menuFov(this Deobf_MenuCameraPositioner self, float deobf_menuFov)
            => self.field_Private_Single_0 = deobf_menuFov;


        public static float get_deobf_desiredFov(this Deobf_MenuCameraPositioner self)
            => self.field_Private_Single_1;

        public static void set_deobf_desiredFov(this Deobf_MenuCameraPositioner self, float deobf_desiredFov)
            => self.field_Private_Single_1 = deobf_desiredFov;


        public static Vector3 get_deobf_menuRotation(this Deobf_MenuCameraPositioner self)
            => self.field_Private_Vector3_0;

        public static void set_deobf_menuRotation(this Deobf_MenuCameraPositioner self, Vector3 deobf_menuRotation)
            => self.field_Private_Vector3_0 = deobf_menuRotation;


        public static Vector3 get_deobf_menuPosition(this Deobf_MenuCameraPositioner self)
            => self.field_Private_Vector3_1;

        public static void set_deobf_menuPosition(this Deobf_MenuCameraPositioner self, Vector3 deobf_menuPosition)
            => self.field_Private_Vector3_1 = deobf_menuPosition;


        public static Quaternion get_deobf_desiredRotation(this Deobf_MenuCameraPositioner self)
            => self.field_Private_Quaternion_0;

        public static void set_deobf_desiredRotation(this Deobf_MenuCameraPositioner self, Quaternion deobf_desiredRotation)
            => self.field_Private_Quaternion_0 = deobf_desiredRotation;


        public static Vector3 get_deobf_desiredPosition(this Deobf_MenuCameraPositioner self)
            => self.field_Private_Vector3_2;

        public static void set_deobf_desiredPosition(this Deobf_MenuCameraPositioner self, Vector3 deobf_desiredPosition)
            => self.field_Private_Vector3_2 = deobf_desiredPosition;
    }

    public static class Deobf_MenuPlayerDragToSpinExtensions
    {
        public static float get_deobf_dragAmount(this Deobf_MenuPlayerDragToSpin self)
            => self.field_Private_Single_0;

        public static void set_deobf_dragAmount(this Deobf_MenuPlayerDragToSpin self, float deobf_dragAmount)
            => self.field_Private_Single_0 = deobf_dragAmount;


        public static Vector2 get_deobf_lastDragPosition(this Deobf_MenuPlayerDragToSpin self)
            => self.field_Private_Vector2_0;

        public static void set_deobf_lastDragPosition(this Deobf_MenuPlayerDragToSpin self, Vector2 deobf_lastDragPosition)
            => self.field_Private_Vector2_0 = deobf_lastDragPosition;


        public static bool get_deobf_dragging(this Deobf_MenuPlayerDragToSpin self)
            => self.field_Private_Boolean_0;

        public static void set_deobf_dragging(this Deobf_MenuPlayerDragToSpin self, bool deobf_dragging)
            => self.field_Private_Boolean_0 = deobf_dragging;


        public static List<RaycastResult> Deobf_GetRaycastResults()
            => Deobf_MenuPlayerDragToSpin.Method_Private_Static_List_1_RaycastResult_0();


        public static bool Deobf_RaycastResultsIncludesUI(this Deobf_MenuPlayerDragToSpin self, List<RaycastResult> raycastResults)
            => self.Method_Private_Boolean_List_1_RaycastResult_PDM_4(raycastResults);
    }

    public static class Deobf_MenuSnowSpeedModdingDetectorExtensions
    {
        public static void Deobf_DetectModding(this Deobf_MenuSnowSpeedModdingDetector self)
            => self.Method_Private_Void_0();
    }

    public static class Deobf_MenuUiCraftingExtensions
    {
        public static int get_deobf_lastQuantity(this Deobf_MenuUiCrafting self)
            => self.field_Private_Int32_0;

        public static void set_deobf_lastQuantity(this Deobf_MenuUiCrafting self, int deobf_lastQuantity)
            => self.field_Private_Int32_0 = deobf_lastQuantity;


        public static bool get_deobf_ready(this Deobf_MenuUiCrafting self)
            => self.field_Private_Boolean_0;

        public static void set_deobf_ready(this Deobf_MenuUiCrafting self, bool deobf_ready)
            => self.field_Private_Boolean_0 = deobf_ready;


        public static float get_deobf_unusedFloatFive(this Deobf_MenuUiCrafting self)
            => self.field_Private_Single_0;

        public static void set_deobf_unusedFloatFive(this Deobf_MenuUiCrafting self, float deobf_unusedFloatFive)
            => self.field_Private_Single_0 = deobf_unusedFloatFive;


        public static void Deobf_UpdateCrafting(this Deobf_MenuUiCrafting self)
            => self.Method_Private_Void_0();


        public static void Deobf_UpdateQuantity(this Deobf_MenuUiCrafting self, int quantity)
            => self.Method_Private_Void_Int32_0(quantity);
    }

    public static class Deobf_MenuUiCrateRatesExtensions
    {
        public static TextMeshProUGUI get_deobf_text(this Deobf_MenuUiCrateRates self)
            => self.field_Private_TextMeshProUGUI_0;

        public static void set_deobf_text(this Deobf_MenuUiCrateRates self, TextMeshProUGUI deobf_text)
            => self.field_Private_TextMeshProUGUI_0 = deobf_text;
    }

    public static class Deobf_MenuUiCreateLobbyGameModesAndMapsExtensions
    {
        public static void Deobf_MakeModeButtons(this Deobf_MenuUiCreateLobbyGameModesAndMaps self)
            => self.Method_Private_Void_0();


        public static void Deobf_DisableAllModes(this Deobf_MenuUiCreateLobbyGameModesAndMaps self)
            => self.Method_Private_Void_1();


        public static void Deobf_SelectMap(this Deobf_MenuUiCreateLobbyGameModesAndMaps self, Button button)
            => self.Method_Private_Void_Button_0(button);


        public static void Deobf_DisableAllMaps(this Deobf_MenuUiCreateLobbyGameModesAndMaps self)
            => self.Method_Private_Void_2();


        public static void Deobf_MakeMapButtons(this Deobf_MenuUiCreateLobbyGameModesAndMaps self)
            => self.Method_Private_Void_3();


        public static void Deobf_SelectMode(this Deobf_MenuUiCreateLobbyGameModesAndMaps self, Toggle toggle)
            => self.Method_Private_Void_Toggle_0(toggle);
    }

    public static class Deobf_MenuUiCreateLobbyPracticeExtensions
    {
        public static int get_deobf_selectedMapId(this Deobf_MenuUiCreateLobbyPractice self)
            => self.field_Private_Int32_0;

        public static void set_deobf_selectedMapId(this Deobf_MenuUiCreateLobbyPractice self, int deobf_selectedMapId)
            => self.field_Private_Int32_0 = deobf_selectedMapId;


        public static void Deobf_SelectMap(this Deobf_MenuUiCreateLobbyPractice self, Button button)
            => self.Method_Private_Void_Button_0(button);


        public static void Deobf_MakeMapButtons(this Deobf_MenuUiCreateLobbyPractice self)
            => self.Method_Private_Void_1();


        public static void Deobf_UnusedToggleMode(this Deobf_MenuUiCreateLobbyPractice self, Toggle toggle)
            => self.Method_Private_Void_Toggle_PDM_7(toggle);
    }

    public static class Deobf_MenuUiCreateLobbySpeedrunExtensions
    {
        public static int get_deobf_selectedMapId(this Deobf_MenuUiCreateLobbySpeedrun self)
            => self.field_Private_Int32_0;

        public static void set_deobf_selectedMapId(this Deobf_MenuUiCreateLobbySpeedrun self, int deobf_selectedMapId)
            => self.field_Private_Int32_0 = deobf_selectedMapId;


        public static void Deobf_SelectMap(this Deobf_MenuUiCreateLobbySpeedrun self, Button button)
            => self.Method_Private_Void_Button_0(button);


        public static void Deobf_UnusedToggleMode(this Deobf_MenuUiCreateLobbySpeedrun self, Toggle toggle)
            => self.Method_Private_Void_Toggle_PDM_11(toggle);


        public static void Deobf_MakeMapButtons(this Deobf_MenuUiCreateLobbySpeedrun self)
            => self.Method_Private_Void_9();
    }

    public static class Deobf_MenuUiDailyQuestExtensions
    {
        public static void Deobf_UpdateQuestDetails(this Deobf_MenuUiDailyQuest self)
            => self.Method_Private_Void_PDM_4();
    }

    public static class Deobf_MenuUiItemsDisplayExtensions
    {
        public static int get_deobf_currentScroll(this Deobf_MenuUiItemsDisplay self)
            => self.field_Private_Int32_0;

        public static void set_deobf_currentScroll(this Deobf_MenuUiItemsDisplay self, int deobf_currentScroll)
            => self.field_Private_Int32_0 = deobf_currentScroll;


        public static int get_deobf_cosmeticItemsLength(this Deobf_MenuUiItemsDisplay self)
            => self.field_Private_Int32_1;

        public static void set_deobf_cosmeticItemsLength(this Deobf_MenuUiItemsDisplay self, int deobf_cosmeticItemsLength)
            => self.field_Private_Int32_1 = deobf_cosmeticItemsLength;


        public static float get_deobf_slowUpdateTime(this Deobf_MenuUiItemsDisplay self)
            => self.field_Private_Single_0;

        public static void set_deobf_slowUpdateTime(this Deobf_MenuUiItemsDisplay self, float deobf_slowUpdateTime)
            => self.field_Private_Single_0 = deobf_slowUpdateTime;


        public static List<Deobf_SteamInventory_Deobf_CosmeticItem> get_deobf_cosmeticItems(this Deobf_MenuUiItemsDisplay self)
            => self.field_Private_List_1_ObjectNPublicIComparableStDi2InStStUnique_0;

        public static void set_deobf_cosmeticItems(this Deobf_MenuUiItemsDisplay self, List<Deobf_SteamInventory_Deobf_CosmeticItem> deobf_cosmeticItems)
            => self.field_Private_List_1_ObjectNPublicIComparableStDi2InStStUnique_0 = deobf_cosmeticItems;


        public static string get_deobf_unselectedCircle(this Deobf_MenuUiItemsDisplay self)
            => self.field_Private_String_0;

        public static void set_deobf_unselectedCircle(this Deobf_MenuUiItemsDisplay self, string deobf_unselectedCircle)
            => self.field_Private_String_0 = deobf_unselectedCircle;


        public static string get_deobf_selectedCircle(this Deobf_MenuUiItemsDisplay self)
            => self.field_Private_String_1;

        public static void set_deobf_selectedCircle(this Deobf_MenuUiItemsDisplay self, string deobf_selectedCircle)
            => self.field_Private_String_1 = deobf_selectedCircle;


        public static void Deobf_UpdateCircles(this Deobf_MenuUiItemsDisplay self)
            => self.Method_Private_Void_PDM_22();
    }

    public static class Deobf_MenuUiItemsDisplayDetailsExtensions
    {
        public static Vector3 get_deobf_baseScale(this Deobf_MenuUiItemsDisplayDetails self)
            => self.field_Private_Vector3_2;

        public static void set_deobf_baseScale(this Deobf_MenuUiItemsDisplayDetails self, Vector3 deobf_baseScale)
            => self.field_Private_Vector3_2 = deobf_baseScale;


        public static Vector3 get_deobf_hoverScale(this Deobf_MenuUiItemsDisplayDetails self)
            => self.field_Private_Vector3_1;

        public static void set_deobf_hoverScale(this Deobf_MenuUiItemsDisplayDetails self, Vector3 deobf_hoverScale)
            => self.field_Private_Vector3_1 = deobf_hoverScale;


        public static Vector3 get_deobf_desiredScale(this Deobf_MenuUiItemsDisplayDetails self)
            => self.field_Private_Vector3_2;

        public static void set_deobf_desiredScale(this Deobf_MenuUiItemsDisplayDetails self, Vector3 deobf_desiredScale)
            => self.field_Private_Vector3_2 = deobf_desiredScale;
    }

    public static class Deobf_MenuUiItemStoreExtensions
    {
        public static int get_deobf_page(this Deobf_MenuUiItemStore self)
            => self.field_Private_Int32_0;

        public static void set_deobf_page(this Deobf_MenuUiItemStore self, int deobf_page)
            => self.field_Private_Int32_0 = deobf_page;


        public static CosmeticItem get_deobf_cosmeticItem(this Deobf_MenuUiItemStore self)
            => self.field_Private_CosmeticItem_0;

        public static void set_deobf_cosmeticItem(this Deobf_MenuUiItemStore self, CosmeticItem deobf_cosmeticItem)
            => self.field_Private_CosmeticItem_0 = deobf_cosmeticItem;


        public static int get_deobf_numItems(this Deobf_MenuUiItemStore self)
            => self.field_Private_Int32_1;

        public static void set_deobf_numItems(this Deobf_MenuUiItemStore self, int deobf_numItems)
            => self.field_Private_Int32_1 = deobf_numItems;


        public static CallResult<SteamInventoryRequestPricesResult_t> get_deobf_steamInventoryRequestPricesResultCallback(this Deobf_MenuUiItemStore self)
            => self.field_Private_CallResult_1_SteamInventoryRequestPricesResult_t_0;

        public static void set_deobf_steamInventoryRequestPricesResultCallback(this Deobf_MenuUiItemStore self, CallResult<SteamInventoryRequestPricesResult_t> deobf_steamInventoryRequestPricesResultCallback)
            => self.field_Private_CallResult_1_SteamInventoryRequestPricesResult_t_0 = deobf_steamInventoryRequestPricesResultCallback;


        public static CallResult<SteamInventoryDefinitionUpdate_t> get_deobf_unusedSteamInventoryDefinitionUpdateCallback(this Deobf_MenuUiItemStore self)
            => self.field_Private_CallResult_1_SteamInventoryDefinitionUpdate_t_0;

        public static void set_deobf_unusedSteamInventoryDefinitionUpdateCallback(this Deobf_MenuUiItemStore self, CallResult<SteamInventoryDefinitionUpdate_t> deobf_unusedSteamInventoryDefinitionUpdateCallback)
            => self.field_Private_CallResult_1_SteamInventoryDefinitionUpdate_t_0 = deobf_unusedSteamInventoryDefinitionUpdateCallback;


        public static Deobf_MenuUiItemStore_Deobf_Item[] get_deobf_storeItems(this Deobf_MenuUiItemStore self)
            => self.field_Private_ArrayOf_ObjectNPublicIComparableStInUIUnique_0;

        public static void set_deobf_storeItems(this Deobf_MenuUiItemStore self, Deobf_MenuUiItemStore_Deobf_Item[] deobf_storeItems)
            => self.field_Private_ArrayOf_ObjectNPublicIComparableStInUIUnique_0 = deobf_storeItems;


        public static ulong[] get_deobf_storeItemIds(this Deobf_MenuUiItemStore self)
            => self.field_Private_ArrayOf_UInt64_0;

        public static void set_deobf_storeItemIds(this Deobf_MenuUiItemStore self, ulong[] deobf_storeItemIds)
            => self.field_Private_ArrayOf_UInt64_0 = deobf_storeItemIds;


        public static string get_deobf_currency(this Deobf_MenuUiItemStore self)
            => self.field_Private_String_0;

        public static void set_deobf_currency(this Deobf_MenuUiItemStore self, string deobf_currency)
            => self.field_Private_String_0 = deobf_currency;


        public static float get_deobf_pageCycleTime(this Deobf_MenuUiItemStore self)
            => self.field_Private_Single_0;

        public static void set_deobf_pageCycleTime(this Deobf_MenuUiItemStore self, float deobf_pageCycleTime)
            => self.field_Private_Single_0 = deobf_pageCycleTime;


        public static bool get_deobf_unusedBlockGetStoreTags(this Deobf_MenuUiItemStore self)
            => self.field_Private_Boolean_0;

        public static void set_deobf_unusedBlockGetStoreTags(this Deobf_MenuUiItemStore self, bool deobf_unusedBlockGetStoreTags)
            => self.field_Private_Boolean_0 = deobf_unusedBlockGetStoreTags;


        public static string get_deobf_currentPageCircle(this Deobf_MenuUiItemStore self)
            => self.field_Private_String_1;

        public static void set_deobf_currentPageCircle(this Deobf_MenuUiItemStore self, string deobf_currentPageCircle)
            => self.field_Private_String_1 = deobf_currentPageCircle;


        public static string get_deobf_otherPageCircle(this Deobf_MenuUiItemStore self)
            => self.field_Private_String_2;

        public static void set_deobf_otherPageCircle(this Deobf_MenuUiItemStore self, string deobf_otherPageCircle)
            => self.field_Private_String_2 = deobf_otherPageCircle;


        public static void Deobf_SteamInventoryDefinitionUpdateCallback(this Deobf_MenuUiItemStore self, SteamInventoryDefinitionUpdate_t ev)
            => self.Method_Private_Void_SteamInventoryDefinitionUpdate_t_PDM_4(ev);


        public static void Deobf_RestartCyclePage(this Deobf_MenuUiItemStore self)
            => self.Method_Private_Void_PDM_12();


        public static void Deobf_UnusedGetStoreTags(this Deobf_MenuUiItemStore self)
            => self.Method_Private_Void_PDM_23();


        public static void Deobf_RequestPrices(this Deobf_MenuUiItemStore self)
            => self.Method_Private_Void_PDM_25();


        public static int Deobf_GetFeatureIndex(this Deobf_MenuUiItemStore self, SteamItemDef_t itemDef)
            => self.Method_Private_Int32_SteamItemDef_t_PDM_5(itemDef);


        public static void Deobf_ShowItemPage(this Deobf_MenuUiItemStore self, int page)
            => self.Method_Private_Void_Int32_0(page);


        public static void Deobf_SteamInventoryRequestPricesResultCallback(this Deobf_MenuUiItemStore self, SteamInventoryRequestPricesResult_t ev, bool bIOFailure)
            => self.Method_Private_Void_SteamInventoryRequestPricesResult_t_Boolean_PDM_7(ev, bIOFailure);


        public static void Deobf_UpdatePageCircles(this Deobf_MenuUiItemStore self)
            => self.Method_Private_Void_0();


        public static void Deobf_CyclePage(this Deobf_MenuUiItemStore self)
            => self.Method_Private_Void_PDM_48();
    }

    public static class Deobf_MenuUiItemStore_Deobf_ItemExtensions
    {
        public static SteamItemDef_t get_deobf_itemDef(this Deobf_MenuUiItemStore_Deobf_Item self)
            => self.field_Public_SteamItemDef_t_0;

        public static void set_deobf_itemDef(this Deobf_MenuUiItemStore_Deobf_Item self, SteamItemDef_t deobf_itemDef)
            => self.field_Public_SteamItemDef_t_0 = deobf_itemDef;


        public static int get_deobf_featureIndex(this Deobf_MenuUiItemStore_Deobf_Item self)
            => self.field_Public_Int32_0;

        public static void set_deobf_featureIndex(this Deobf_MenuUiItemStore_Deobf_Item self, int deobf_featureIndex)
            => self.field_Public_Int32_0 = deobf_featureIndex;


        public static ulong get_deobf_price(this Deobf_MenuUiItemStore_Deobf_Item self)
            => self.field_Public_UInt64_0;

        public static void set_deobf_price(this Deobf_MenuUiItemStore_Deobf_Item self, ulong deobf_price)
            => self.field_Public_UInt64_0 = deobf_price;
    }

    public static class Deobf_MenuUiRecycleItemExtensions
    {
        public static Deobf_SteamInventory_Deobf_CosmeticItem get_deobf_cosmeticItem(this Deobf_MenuUiRecycleItem self)
            => self.field_Private_ObjectNPublicIComparableStDi2InStStUnique_0;

        public static void set_deobf_cosmeticItem(this Deobf_MenuUiRecycleItem self, Deobf_SteamInventory_Deobf_CosmeticItem deobf_cosmeticItem)
            => self.field_Private_ObjectNPublicIComparableStDi2InStStUnique_0 = deobf_cosmeticItem;
    }

    public static class Deobf_MenuUiRecycleItemDisplayExtensions
    {
        public static Quaternion get_deobf_baseRotation(this Deobf_MenuUiRecycleItemDisplay self)
            => self.field_Private_Quaternion_0;

        public static void set_deobf_baseRotation(this Deobf_MenuUiRecycleItemDisplay self, Quaternion deobf_baseRotation)
            => self.field_Private_Quaternion_0 = deobf_baseRotation;


        public static Vector3 get_deobf_baseScale(this Deobf_MenuUiRecycleItemDisplay self)
            => self.field_Private_Vector3_0;

        public static void set_deobf_baseScale(this Deobf_MenuUiRecycleItemDisplay self, Vector3 deobf_baseScale)
            => self.field_Private_Vector3_0 = deobf_baseScale;
    }

    public static class Deobf_MenuUiRecycleItemDisplaySpinExtensions
    {
        public static float get_deobf_dragAmount(this Deobf_MenuUiRecycleItemDisplaySpin self)
            => self.field_Private_Single_0;

        public static void set_deobf_dragAmount(this Deobf_MenuUiRecycleItemDisplaySpin self, float deobf_dragAmount)
            => self.field_Private_Single_0 = deobf_dragAmount;


        public static Vector2 get_deobf_lastMousePosition(this Deobf_MenuUiRecycleItemDisplaySpin self)
            => self.field_Private_Vector2_0;

        public static void set_deobf_lastMousePosition(this Deobf_MenuUiRecycleItemDisplaySpin self, Vector2 deobf_lastMousePosition)
            => self.field_Private_Vector2_0 = deobf_lastMousePosition;


        public static bool get_deobf_dragging(this Deobf_MenuUiRecycleItemDisplaySpin self)
            => self.field_Private_Boolean_0;

        public static void set_deobf_dragging(this Deobf_MenuUiRecycleItemDisplaySpin self, bool deobf_dragging)
            => self.field_Private_Boolean_0 = deobf_dragging;
    }

    public static class Deobf_MenuUiServerListingGameModesAndMapsHoverExtensions
    {
        public static string get_deobf_mapsString(this Deobf_MenuUiServerListingGameModesAndMapsHover self)
            => self.field_Private_String_0;

        public static void set_deobf_mapsString(this Deobf_MenuUiServerListingGameModesAndMapsHover self, string deobf_mapsString)
            => self.field_Private_String_0 = deobf_mapsString;


        public static string get_deobf_modesString(this Deobf_MenuUiServerListingGameModesAndMapsHover self)
            => self.field_Private_String_1;

        public static void set_deobf_modesString(this Deobf_MenuUiServerListingGameModesAndMapsHover self, string deobf_modesString)
            => self.field_Private_String_1 = deobf_modesString;
    }

    public static class Deobf_MenuUiServerListingGameModesAndMapsInfoExtensions
    {
        public static void Deobf_ClearMapsAndModes(this Deobf_MenuUiServerListingGameModesAndMapsInfo self)
            => self.Method_Private_Void_4();
    }

    public static class Deobf_MeshGeneratedFrom2dGridExtensions
    {
        public static Mesh get_deobf_mesh(this Deobf_MeshGeneratedFrom2dGrid self)
            => self.field_Private_Mesh_0;

        public static void set_deobf_mesh(this Deobf_MeshGeneratedFrom2dGrid self, Mesh deobf_mesh)
            => self.field_Private_Mesh_0 = deobf_mesh;


        public static List<Vector3> get_deobf_vertices(this Deobf_MeshGeneratedFrom2dGrid self)
            => self.field_Private_List_1_Vector3_0;

        public static void set_deobf_vertices(this Deobf_MeshGeneratedFrom2dGrid self, List<Vector3> deobf_vertices)
            => self.field_Private_List_1_Vector3_0 = deobf_vertices;


        public static List<int> get_deobf_triangles(this Deobf_MeshGeneratedFrom2dGrid self)
            => self.field_Private_List_1_Int32_0;

        public static void set_deobf_triangles(this Deobf_MeshGeneratedFrom2dGrid self, List<int> deobf_triangles)
            => self.field_Private_List_1_Int32_0 = deobf_triangles;


        public static float get_deobf_halfScale(this Deobf_MeshGeneratedFrom2dGrid self)
            => self.field_Private_Single_0;

        public static void set_deobf_halfScale(this Deobf_MeshGeneratedFrom2dGrid self, float deobf_halfScale)
            => self.field_Private_Single_0 = deobf_halfScale;


        public static void Deobf_ApplyMesh(this Deobf_MeshGeneratedFrom2dGrid self)
            => self.Method_Private_Void_0();


        public static void Deobf_GenerateFace(this Deobf_MeshGeneratedFrom2dGrid self, int direction, float scale, Vector3 offset)
            => self.Method_Private_Void_Int32_Single_Vector3_0(direction, scale, offset);


        public static void Deobf_GenerateMesh(this Deobf_MeshGeneratedFrom2dGrid self, float size, Vector3 offset)
            => self.Method_Private_Void_Single_Vector3_0(size, offset);
    }

    public static class Deobf_MeshGenerationFrom2dGridHelperExtensions
    {
        public static Vector3[] get_deobf_edges()
            => Deobf_MeshGenerationFrom2dGridHelper.field_Public_Static_ArrayOf_Vector3_0;

        public static void set_deobf_edges(Vector3[] deobf_edges)
            => Deobf_MeshGenerationFrom2dGridHelper.field_Public_Static_ArrayOf_Vector3_0 = deobf_edges;


        public static int[][] get_deobf_faceToEdges()
            => [.. Deobf_MeshGenerationFrom2dGridHelper.field_Public_Static_ArrayOf_ArrayOf_Int32_0];

        public static void set_deobf_faceToEdges(int[][] deobf_faceToEdges)
            => Deobf_MeshGenerationFrom2dGridHelper.field_Public_Static_ArrayOf_ArrayOf_Int32_0 = new([.. deobf_faceToEdges]);


        public static Vector3[] Deobf_GenerateMesh(int direction, float scale, Vector3 offset)
            => Deobf_MeshGenerationFrom2dGridHelper.Method_Public_Static_ArrayOf_Vector3_Int32_Single_Vector3_0(direction, scale, offset);


        public static Vector3[] Deobf_GenerateMesh(Deobf_Direction direction, float scale, Vector3 offset)
            => Deobf_MeshGenerationFrom2dGridHelper.Method_Public_Static_ArrayOf_Vector3_EnumPublicSealedvaNoEaSoWeUpDo7vUnique_Single_Vector3_0(direction, scale, offset);
    }

    public static class Deobf_OnlinePlayerCosmeticsExtensions
    {
        public static CosmeticItem get_deobf_cosmeticItemHat(this Deobf_OnlinePlayerCosmetics self)
            => self.field_Private_CosmeticItem_0;

        public static void set_deobf_cosmeticItemHat(this Deobf_OnlinePlayerCosmetics self, CosmeticItem deobf_cosmeticItemHat)
            => self.field_Private_CosmeticItem_0 = deobf_cosmeticItemHat;


        public static Vector3 get_deobf_topOfHead(this Deobf_OnlinePlayerCosmetics self)
            => self.field_Private_Vector3_0;

        public static void set_deobf_topOfHead(this Deobf_OnlinePlayerCosmetics self, Vector3 deobf_topOfHead)
            => self.field_Private_Vector3_0 = deobf_topOfHead;


        public static Vector3 get_deobf_baseHatOffset(this Deobf_OnlinePlayerCosmetics self)
            => self.field_Private_Vector3_1;

        public static void set_deobf_baseHatOffset(this Deobf_OnlinePlayerCosmetics self, Vector3 deobf_baseHatOffset)
            => self.field_Private_Vector3_1 = deobf_baseHatOffset;


        public static void Deobf_SetOffset(this Deobf_OnlinePlayerCosmetics self, Vector3 offset)
            => self.Method_Private_Void_Vector3_0(offset);
    }

    public static class Deobf_OnlinePlayerStandoffPenaltiesExtensions
    {
        public static Deobf_GameModeStandoff get_deobf_gameMode(this Deobf_OnlinePlayerStandoffPenalties self)
            => self.field_Private_GameModePublicDi2UIObstBocaSiacwaUnique_0;

        public static void set_deobf_gameMode(this Deobf_OnlinePlayerStandoffPenalties self, Deobf_GameModeStandoff deobf_gameMode)
            => self.field_Private_GameModePublicDi2UIObstBocaSiacwaUnique_0 = deobf_gameMode;


        public static int get_deobf_lastPenalties(this Deobf_OnlinePlayerStandoffPenalties self)
            => self.field_Private_Int32_0;

        public static void set_deobf_lastPenalties(this Deobf_OnlinePlayerStandoffPenalties self, int deobf_lastPenalties)
            => self.field_Private_Int32_0 = deobf_lastPenalties;


        public static string get_deobf_penaltySprite(this Deobf_OnlinePlayerStandoffPenalties self)
            => self.field_Private_String_0;

        public static void set_deobf_penaltySprite(this Deobf_OnlinePlayerStandoffPenalties self, string deobf_penaltySprite)
            => self.field_Private_String_0 = deobf_penaltySprite;


        public static void Deobf_UpdatePenalties(this Deobf_OnlinePlayerStandoffPenalties self, int penalties)
            => self.Method_Private_Void_Int32_0(penalties);
    }

    public static class Deobf_OverrideShadowSettingsExtensions
    {
        public static float get_deobf_overrideShadowDistance(this Deobf_OverrideShadowSettings self)
            => self.field_Private_Single_0;

        public static void set_deobf_overrideShadowDistance(this Deobf_OverrideShadowSettings self, float deobf_overrideShadowDistance)
            => self.field_Private_Single_0 = deobf_overrideShadowDistance;


        public static float get_deobf_baseShadowDistance(this Deobf_OverrideShadowSettings self)
            => self.field_Private_Single_1;

        public static void set_deobf_baseShadowDistance(this Deobf_OverrideShadowSettings self, float deobf_baseShadowDistance)
            => self.field_Private_Single_1 = deobf_baseShadowDistance;


        public static ShadowQuality get_deobf_baseShadowQuality(this Deobf_OverrideShadowSettings self)
            => self.field_Private_ShadowQuality_0;

        public static void set_deobf_baseShadowQuality(this Deobf_OverrideShadowSettings self, ShadowQuality deobf_baseShadowQuality)
            => self.field_Private_ShadowQuality_0 = deobf_baseShadowQuality;


        public static ShadowQuality get_deobf_overrideShadowQuality(this Deobf_OverrideShadowSettings self)
            => self.field_Private_ShadowQuality_1;

        public static void set_deobf_overrideShadowQuality(this Deobf_OverrideShadowSettings self, ShadowQuality deobf_overrideShadowQuality)
            => self.field_Private_ShadowQuality_1 = deobf_overrideShadowQuality;


        public static void Deobf_OverrideShadowSettings(this Deobf_OverrideShadowSettings self)
            => self.Method_Private_Void_PDM_9();
    }

    public static class Deobf_ProfanityDetectorExtensions
    {
        public static Deobf_IWordAllowlist get_backing_Deobf_WordAllowList(this Deobf_ProfanityDetector self)
            => self.field_Private_InterfacePublicAbstractInRe1StVoBoStBoVoInUnique_0;

        public static void set_backing_Deobf_WordAllowList(this Deobf_ProfanityDetector self, Deobf_IWordAllowlist backing_Deobf_WordAllowList)
            => self.field_Private_InterfacePublicAbstractInRe1StVoBoStBoVoInUnique_0 = backing_Deobf_WordAllowList;


        public static Deobf_IWordAllowlist get_Deobf_WordAllowList(this Deobf_ProfanityDetector self)
            => self.prop_InterfacePublicAbstractInRe1StVoBoStBoVoInUnique_0;


        public static string Deobf_Filter(this Deobf_ProfanityDetector self, string phrase)
            => self.Method_Public_Virtual_Final_New_String_String_0(phrase);


        public static ReadOnlyCollection<string> Deobf_FindProfaneWordsInString(this Deobf_ProfanityDetector self, string phrase)
            => self.Method_Public_Virtual_Final_New_ReadOnlyCollection_1_String_String_0(phrase);


        public static string Deobf_Filter(this Deobf_ProfanityDetector self, string phrase, char filterCharacter, bool option)
            => self.Method_Public_Virtual_Final_New_String_String_Char_Boolean_3(phrase, filterCharacter, option);


        public static string Deobf_Filter(this Deobf_ProfanityDetector self, string phrase, char filterCharacter)
            => self.Method_Public_Virtual_Final_New_String_String_Char_1(phrase, filterCharacter);


        public static List<string> Deobf_GetNotAllowListed(this Deobf_ProfanityDetector self, string[] words)
            => self.Method_Private_List_1_String_ArrayOf_0(words);


        public static ReadOnlyCollection<string> Deobf_FindProfaneWordsInString(this Deobf_ProfanityDetector self, string phrase, bool option)
            => self.Method_Public_Virtual_Final_New_ReadOnlyCollection_1_String_String_Boolean_3(phrase, option);


        public static StringBuilder Deobf_FilterProfanitiesInString(this Deobf_ProfanityDetector self, char filterCharacter, List<string> profanities, StringBuilder sb, StringBuilder sb2, bool option)
            => self.Method_Private_StringBuilder_Char_List_1_String_StringBuilder_StringBuilder_Boolean_2(filterCharacter, profanities, sb, sb2, option);


        public static bool Deobf_IsProfanity(this Deobf_ProfanityDetector self, string phrase)
            => self.Method_Public_Virtual_Final_New_Boolean_String_7(phrase);


        public static void Deobf_GetProfanitiesInString(this Deobf_ProfanityDetector self, List<string> profanities, string phrase)
            => self.Method_Private_Void_List_1_String_String_2(profanities, phrase);


        public static string Deobf_ReplaceNonSpaces(string phrase, char filterCharacter)
            => Deobf_ProfanityDetector.Method_Private_Static_String_String_Char_1(phrase, filterCharacter);


        public static List<string> Deobf_FindWordsInString(this Deobf_ProfanityDetector self, string phrase, List<string> words)
            => self.Method_Private_List_1_String_String_List_1_String_5(phrase, words);


        public static bool Deobf_IsStrictlyProfanity(this Deobf_ProfanityDetector self, string word)
            => self.Method_Public_Virtual_Final_New_Boolean_String_11(word);


        public static string Deobf_ConcatStrings(List<string> words)
            => Deobf_ProfanityDetector.Method_Private_Static_String_List_1_String_5(words);


        public static Nullable<ValueTuple<int, int, string>> Deobf_FindFullWord(this Deobf_ProfanityDetector self, string phrase, string word)
            => self.Method_Public_Virtual_Final_New_Nullable_1_ValueTuple_3_Int32_Int32_String_String_String_3(phrase, word);
    }

    public static class Deobf_ProfanityDetectorBaseExtensions
    {
        public static List<string> get_deobf_profanities(this Deobf_ProfanityDetectorBase self)
            => self.field_Protected_List_1_String_0;

        public static void set_deobf_profanities(this Deobf_ProfanityDetectorBase self, List<string> deobf_profanities)
            => self.field_Protected_List_1_String_0 = deobf_profanities;


        public static string[] get_deobf_profanityList(this Deobf_ProfanityDetectorBase self)
            => self.field_Private_ArrayOf_0;

        public static void set_deobf_profanities(this Deobf_ProfanityDetectorBase self, string[] deobf_profanityList)
            => self.field_Private_ArrayOf_0 = deobf_profanityList;


        public static int get_Deobf_ProfanitiesLength(this Deobf_ProfanityDetectorBase self)
            => self.prop_Int32_0;


        public static bool Deobf_Remove(this Deobf_ProfanityDetectorBase self, string word)
            => self.Method_Public_Virtual_Final_New_Boolean_String_5(word);


        public static void Deobf_Clear(this Deobf_ProfanityDetectorBase self)
           => self.Method_Public_Virtual_Final_New_Void_8();


        public static void Deobf_Add(this Deobf_ProfanityDetectorBase self, string[] words)
            => self.Method_Public_Virtual_Final_New_Void_ArrayOf_9(words);


        public static void Deobf_Add(this Deobf_ProfanityDetectorBase self, List<string> words)
            => self.Method_Public_Virtual_Final_New_Void_List_1_String_9(words);


        public static void Deobf_Add(this Deobf_ProfanityDetectorBase self, string word)
            => self.Method_Public_Virtual_Final_New_Void_String_15(word);


        public static bool Deobf_Remove(this Deobf_ProfanityDetectorBase self, string[] words)
            => self.Method_Public_Virtual_Final_New_Boolean_ArrayOf_14(words);


        public static bool Deobf_Remove(this Deobf_ProfanityDetectorBase self, List<string> words)
            => self.Method_Public_Virtual_Final_New_Boolean_List_1_String_15(words);
    }

    public static class Deobf_QuestManagerExtensions
    {
        public static int Deobf_PickNewQuest(this Deobf_QuestManager self)
            => self.Method_Private_Int32_PDM_1();


        public static void Deobf_StartNewQuest(this Deobf_QuestManager self)
            => self.Method_Private_Void_PDM_61();


        public static void Deobf_UpdateQuest(this Deobf_QuestManager self)
            => self.Method_Private_Void_PDM_81();
    }

    public static class Deobf_ScrollingGroundControllerExtensions
    {
        public static Material get_deobf_groundMaterial(this Deobf_ScrollingGroundController self)
            => self.field_Private_Material_0;

        public static void set_deobf_groundMaterial(this Deobf_ScrollingGroundController self, Material deobf_groundMaterial)
            => self.field_Private_Material_0 = deobf_groundMaterial;


        public static Vector2 get_deobf_groundVelocity(this Deobf_ScrollingGroundController self)
            => self.field_Private_Vector2_0;

        public static void set_deobf_groundVelocity(this Deobf_ScrollingGroundController self, Vector2 deobf_groundVelocity)
            => self.field_Private_Vector2_0 = deobf_groundVelocity;


        public static Vector2 get_deobf_trackVelocity(this Deobf_ScrollingGroundController self)
            => self.field_Private_Vector2_1;

        public static void set_deobf_trackVelocity(this Deobf_ScrollingGroundController self, Vector2 deobf_trackVelocity)
            => self.field_Private_Vector2_1 = deobf_trackVelocity;


        public static Material get_deobf_trackMaterial(this Deobf_ScrollingGroundController self)
            => self.field_Private_Material_1;

        public static void set_deobf_trackMaterial(this Deobf_ScrollingGroundController self, Material deobf_trackMaterial)
            => self.field_Private_Material_1 = deobf_trackMaterial;


        public static bool get_deobf_shaking(this Deobf_ScrollingGroundController self)
            => self.field_Private_Boolean_0;

        public static void set_deobf_shaking(this Deobf_ScrollingGroundController self, bool deobf_shaking)
            => self.field_Private_Boolean_0 = deobf_shaking;
    }

    public static class Deobf_SnowballPileExtensions
    {
        public static bool get_deobf_onCooldown(this Deobf_SnowballPile self)
            => self.field_Private_Boolean_0;

        public static void set_deobf_onCooldown(this Deobf_SnowballPile self, bool deobf_onCooldown)
            => self.field_Private_Boolean_0 = deobf_onCooldown;


        public static int get_deobf_itemId(this Deobf_SnowballPile self)
            => self.field_Private_Int32_0;

        public static void set_deobf_itemId(this Deobf_SnowballPile self, int deobf_itemId)
            => self.field_Private_Int32_0 = deobf_itemId;


        public static float get_deobf_maxInteractDistance(this Deobf_SnowballPile self)
            => self.field_Private_Single_0;

        public static void set_deobf_maxInteractDistance(this Deobf_SnowballPile self, float deobf_maxInteractDistance)
            => self.field_Private_Single_0 = deobf_maxInteractDistance;


        public static void Cooldown(this Deobf_SnowballPile self)
            => self.Method_Private_Void_PDM_10();
    }

    public static class Deobf_StandoffScoreboardExtensions
    {
        public static List<Deobf_StandoffScoreboard_Deobf_PlayerScore> get_deobf_idsSorted(this Deobf_StandoffScoreboard self)
            => self.field_Private_List_1_ObjectNPublicIComparable1ObfUIStInUnique_0;

        public static void set_deobf_idsSorted(this Deobf_StandoffScoreboard self, List<Deobf_StandoffScoreboard_Deobf_PlayerScore> deobf_idsSorted)
            => self.field_Private_List_1_ObjectNPublicIComparable1ObfUIStInUnique_0 = deobf_idsSorted;


        public static Deobf_GameModeStandoff get_deobf_gameMode(this Deobf_StandoffScoreboard self)
            => self.field_Private_GameModePublicDi2UIObstBocaSiacwaUnique_0;

        public static void set_deobf_gameMode(this Deobf_StandoffScoreboard self, Deobf_GameModeStandoff deobf_gameMode)
            => self.field_Private_GameModePublicDi2UIObstBocaSiacwaUnique_0 = deobf_gameMode;


        public static string get_deobf_selfColor(this Deobf_StandoffScoreboard self)
            => self.field_Private_String_0;

        public static void set_deobf_selfColor(this Deobf_StandoffScoreboard self, string deobf_selfColor)
            => self.field_Private_String_0 = deobf_selfColor;


        public static string get_deobf_dangerColor(this Deobf_StandoffScoreboard self)
            => self.field_Private_String_1;

        public static void set_deobf_dangerColor(this Deobf_StandoffScoreboard self, string deobf_dangerColor)
            => self.field_Private_String_1 = deobf_dangerColor;


        public static List<ulong> get_deobf_playersToEliminate(this Deobf_StandoffScoreboard self)
            => self.field_Private_List_1_UInt64_0;

        public static void set_deobf_playersToEliminate(this Deobf_StandoffScoreboard self, List<ulong> deobf_playersToEliminate)
            => self.field_Private_List_1_UInt64_0 = deobf_playersToEliminate;


        public static void Deobf_SortList(this Deobf_StandoffScoreboard self)
            => self.Method_Private_Void_PDM_31();
    }

    public static class Deobf_StandoffScoreboard_Deobf_PlayerScoreExtensions
    {
        public static ulong get_deobf_pid(this Deobf_StandoffScoreboard_Deobf_PlayerScore self)
            => self.field_Public_UInt64_0;

        public static void set_deobf_pid(this Deobf_StandoffScoreboard_Deobf_PlayerScore self, ulong deobf_pid)
            => self.field_Public_UInt64_0 = deobf_pid;


        public static string get_deobf_username(this Deobf_StandoffScoreboard_Deobf_PlayerScore self)
            => self.field_Public_String_0;

        public static void set_deobf_username(this Deobf_StandoffScoreboard_Deobf_PlayerScore self, string deobf_username)
            => self.field_Public_String_0 = deobf_username;


        public static int get_deobf_score(this Deobf_StandoffScoreboard_Deobf_PlayerScore self)
            => self.field_Public_Int32_0;

        public static void set_deobf_score(this Deobf_StandoffScoreboard_Deobf_PlayerScore self, int deobf_score)
            => self.field_Public_Int32_0 = deobf_score;
    }

    public static class Deobf_SteamInventoryExtensions
    {
        public static SteamInventoryResult_t get_deobf_getInventory()
            => Deobf_SteamInventory.field_Private_Static_SteamInventoryResult_t_0;

        public static void set_deobf_getInventory(SteamInventoryResult_t deobf_getInventory)
            => Deobf_SteamInventory.field_Private_Static_SteamInventoryResult_t_0 = deobf_getInventory;


        public static SteamInventoryResult_t get_deobf_serializeInventory()
            => Deobf_SteamInventory.field_Private_Static_SteamInventoryResult_t_1;

        public static void set_deobf_serializeInventory(SteamInventoryResult_t deobf_serializeInventory)
            => Deobf_SteamInventory.field_Private_Static_SteamInventoryResult_t_1 = deobf_serializeInventory;


        public static SteamInventoryResult_t get_deobf_inventoryResult()
            => Deobf_SteamInventory.field_Private_Static_SteamInventoryResult_t_2;

        public static void set_deobf_inventoryResult(SteamInventoryResult_t deobf_inventoryResult)
            => Deobf_SteamInventory.field_Private_Static_SteamInventoryResult_t_2 = deobf_inventoryResult;


        public static SteamInventoryResult_t get_deobf_itemDrop()
            => Deobf_SteamInventory.field_Private_Static_SteamInventoryResult_t_3;

        public static void set_deobf_itemDrop(SteamInventoryResult_t deobf_itemDrop)
            => Deobf_SteamInventory.field_Private_Static_SteamInventoryResult_t_3 = deobf_itemDrop;


        public static SteamInventoryResult_t get_deobf_exchange()
            => Deobf_SteamInventory.field_Private_Static_SteamInventoryResult_t_4;

        public static void set_deobf_exchange(SteamInventoryResult_t deobf_exchange)
            => Deobf_SteamInventory.field_Private_Static_SteamInventoryResult_t_4 = deobf_exchange;


        public static SteamInventoryResult_t get_deobf_generateItems()
            => Deobf_SteamInventory.field_Private_Static_SteamInventoryResult_t_5;

        public static void set_deobf_generateItems(SteamInventoryResult_t deobf_generateItems)
            => Deobf_SteamInventory.field_Private_Static_SteamInventoryResult_t_5 = deobf_generateItems;


        public static SteamInventoryResult_t get_deobf_dailyQuest()
            => Deobf_SteamInventory.field_Private_Static_SteamInventoryResult_t_6;

        public static void set_deobf_dailyQuest(SteamInventoryResult_t deobf_dailyQuest)
            => Deobf_SteamInventory.field_Private_Static_SteamInventoryResult_t_6 = deobf_dailyQuest;


        public static SteamInventoryResult_t get_deobf_playerChatDrop()
            => Deobf_SteamInventory.field_Private_Static_SteamInventoryResult_t_7;

        public static void set_deobf_playerChatDrop(SteamInventoryResult_t deobf_playerChatDrop)
            => Deobf_SteamInventory.field_Private_Static_SteamInventoryResult_t_7 = deobf_playerChatDrop;


        public static SteamInventoryResult_t get_deobf_promo()
            => Deobf_SteamInventory.field_Private_Static_SteamInventoryResult_t_8;

        public static void set_deobf_promo(SteamInventoryResult_t deobf_promo)
            => Deobf_SteamInventory.field_Private_Static_SteamInventoryResult_t_8 = deobf_promo;


        public static Callback<SteamInventoryResultReady_t> get_deobf_steamInventoryResultReadyCallback(this Deobf_SteamInventory self)
            => self.field_Private_Callback_1_SteamInventoryResultReady_t_0;

        public static void set_deobf_steamInventoryResultReadyCallback(this Deobf_SteamInventory self, Callback<SteamInventoryResultReady_t> deobf_steamInventoryResultReadyCallback)
            => self.field_Private_Callback_1_SteamInventoryResultReady_t_0 = deobf_steamInventoryResultReadyCallback;


        public static ulong get_deobf_dequeuedClientId(this Deobf_SteamInventory self)
            => self.field_Private_UInt64_0;

        public static void set_deobf_dequeuedClientId(this Deobf_SteamInventory self, ulong deobf_dequeuedClientId)
            => self.field_Private_UInt64_0 = deobf_dequeuedClientId;


        public static ulong get_deobf_handleClientId()
            => Deobf_SteamInventory.field_Private_Static_UInt64_0;

        public static void set_deobf_handleClientId(ulong deobf_handleClientId)
            => Deobf_SteamInventory.field_Private_Static_UInt64_0 = deobf_handleClientId;


        public static void Deobf_Store(this Deobf_SteamInventory self, SteamInventoryResultReady_t ev)
            => self.Method_Private_Void_SteamInventoryResultReady_t_PDM_1(ev);


        public static void Deobf_GenerateItems(this Deobf_SteamInventory self, SteamInventoryResultReady_t ev)
            => self.Method_Private_Void_SteamInventoryResultReady_t_PDM_2(ev);


        public static void Deobf_GetAttributes(this Deobf_SteamInventory self, uint itemIndex, ulong instanceId, SteamInventoryResult_t ev, Deobf_SteamInventory_Deobf_CosmeticItem item)
            => self.Method_Private_Void_UInt32_UInt64_SteamInventoryResult_t_ObjectNPublicIComparableStDi2InStStUnique_0(itemIndex, instanceId, ev, item);


        public static void Deobf_Promo(this Deobf_SteamInventory self, SteamInventoryResultReady_t ev)
            => self.Method_Private_Void_SteamInventoryResultReady_t_PDM_6(ev);


        public static void Deobf_ItemDrop(this Deobf_SteamInventory self)
            => self.Method_Private_Void_PDM_2();


        public static void Deobf_SetAttributes(this Deobf_SteamInventory self, string attrs, Deobf_SteamInventory_Deobf_CosmeticItem item)
            => self.Method_Private_Void_String_ObjectNPublicIComparableStDi2InStStUnique_0(attrs, item);


        public static void Deobf_SerializeInventory(SteamInventoryResultReady_t ev)
            => Deobf_SteamInventory.Method_Private_Static_Void_SteamInventoryResultReady_t_PDM_2(ev);


        public static void Deobf_DailyQuest(this Deobf_SteamInventory self, SteamInventoryResultReady_t ev)
            => self.Method_Private_Void_SteamInventoryResultReady_t_PDM_14(ev);


        public static void Deobf_SendReceivedDrop(this Deobf_SteamInventory self, SteamItemDetails_t[] items, SteamInventoryResult_t ev, uint itemCount, bool announceBoxes)
            => self.Method_Private_Void_ArrayOf_SteamItemDetails_t_SteamInventoryResult_t_UInt32_Boolean_PDM_1(items, ev, itemCount, announceBoxes);


        public static void Deobf_SteamInventoryResultReadyCallback(this Deobf_SteamInventory self, SteamInventoryResultReady_t ev)
            => self.Method_Private_Void_SteamInventoryResultReady_t_PDM_15(ev);
    }

    public static class Deobf_SteamInventory_Deobf_CosmeticItemExtensions
    {
        public static SteamItemDetails_t get_deobf_details(this Deobf_SteamInventory_Deobf_CosmeticItem self)
            => self.field_Public_SteamItemDetails_t_0;

        public static void set_deobf_details(this Deobf_SteamInventory_Deobf_CosmeticItem self, SteamItemDetails_t deobf_details)
            => self.field_Public_SteamItemDetails_t_0 = deobf_details;


        public static Dictionary<string, string> get_deobf_attributes(this Deobf_SteamInventory_Deobf_CosmeticItem self)
            => self.field_Public_Dictionary_2_String_String_0;

        public static void set_deobf_attributes(this Deobf_SteamInventory_Deobf_CosmeticItem self, Dictionary<string, string> deobf_attributes)
            => self.field_Public_Dictionary_2_String_String_0 = deobf_attributes;


        public static int get_deobf_quantity(this Deobf_SteamInventory_Deobf_CosmeticItem self)
            => self.field_Public_Int32_0;

        public static void set_deobf_quantity(this Deobf_SteamInventory_Deobf_CosmeticItem self, int deobf_quantity)
            => self.field_Public_Int32_0 = deobf_quantity;


        public static int Deobf_GetRarity(this Deobf_SteamInventory_Deobf_CosmeticItem self)
            => self.Method_Public_Int32_5();
    }

    public static class Deobf_SteamInventory_Deobf_PlayerInventoryExtensions
    {
        public static byte[] get_deobf_drip(this Deobf_SteamInventory_Deobf_PlayerInventory self)
            => self.field_Public_ArrayOf_Byte_0;

        public static void set_deobf_drip(this Deobf_SteamInventory_Deobf_PlayerInventory self, byte[] deobf_drip)
            => self.field_Public_ArrayOf_Byte_0 = deobf_drip;


        public static Deobf_SteamInventory_Deobf_CosmeticItem[] get_deobf_cosmeticItems(this Deobf_SteamInventory_Deobf_PlayerInventory self)
            => self.field_Public_ArrayOf_ObjectNPublicIComparableStDi2InStStUnique_0;

        public static void set_deobf_cosmeticItems(this Deobf_SteamInventory_Deobf_PlayerInventory self, Deobf_SteamInventory_Deobf_CosmeticItem[] deobf_cosmeticItems)
            => self.field_Public_ArrayOf_ObjectNPublicIComparableStDi2InStStUnique_0 = deobf_cosmeticItems;


        public static ulong get_deobf_clientId(this Deobf_SteamInventory_Deobf_PlayerInventory self)
            => self.field_Public_UInt64_0;

        public static void set_deobf_clientId(this Deobf_SteamInventory_Deobf_PlayerInventory self, ulong deobf_clientId)
            => self.field_Public_UInt64_0 = deobf_clientId;
    }

    public static class Deobf_StringDeobfuscatorExtensions
    {
        public static string Deobf_Deobfuscate(byte[] bytes1, byte[] bytes2)
            => Deobf_StringDeobfuscator.Method_Public_Static_String_ArrayOf_Byte_ArrayOf_Byte_0(bytes1, bytes2);
    }

    public static class Deobf_ThrownSnowballExtensions
    {
        public static Rigidbody get_deobf_rb(this Deobf_ThrownSnowball self)
            => self.field_Private_Rigidbody_0;

        public static void set_deobf_rb(this Deobf_ThrownSnowball self, Rigidbody deobf_rb)
            => self.field_Private_Rigidbody_0 = deobf_rb;


        public static Collider get_deobf_collider(this Deobf_ThrownSnowball self)
            => self.field_Private_Collider_0;

        public static void set_deobf_collider(this Deobf_ThrownSnowball self, Collider deobf_collider)
            => self.field_Private_Collider_0 = deobf_collider;


        public static bool get_deobf_isOwner(this Deobf_ThrownSnowball self)
            => self.field_Private_Boolean_0;

        public static void set_deobf_isOwner(this Deobf_ThrownSnowball self, bool deobf_isOwner)
            => self.field_Private_Boolean_0 = deobf_isOwner;


        public static ItemData get_deobf_itemData(this Deobf_ThrownSnowball self)
            => self.field_Private_ItemData_0;

        public static void set_deobf_itemData(this Deobf_ThrownSnowball self, ItemData deobf_itemData)
            => self.field_Private_ItemData_0 = deobf_itemData;


        public static Vector3 get_deobf_velocity(this Deobf_ThrownSnowball self)
            => self.field_Private_Vector3_0;

        public static void set_deobf_velocity(this Deobf_ThrownSnowball self, Vector3 deobf_velocity)
            => self.field_Private_Vector3_0 = deobf_velocity;


        public static bool get_deobf_disabled(this Deobf_ThrownSnowball self)
            => self.field_Private_Boolean_1;

        public static void set_deobf_disabled(this Deobf_ThrownSnowball self, bool deobf_disabled)
            => self.field_Private_Boolean_1 = deobf_disabled;


        public static bool get_deobf_justThrown(this Deobf_ThrownSnowball self)
            => self.field_Private_Boolean_2;

        public static void set_deobf_justThrown(this Deobf_ThrownSnowball self, bool deobf_justThrown)
            => self.field_Private_Boolean_2 = deobf_justThrown;


        public static void Deobf_FinishThrow(this Deobf_ThrownSnowball self)
            => self.Method_Private_Void_PDM_7();


        public static void Deobf_DestroySelf(this Deobf_ThrownSnowball self)
            => self.Method_Private_Void_PDM_10();
    }

    public static class Deobf_UpdateInventoryInGameExtensions
    {
        public static string get_deobf_drip(this Deobf_UpdateInventoryInGame self)
            => self.field_Private_String_0;

        public static void set_deobf_drip(this Deobf_UpdateInventoryInGame self, string deobf_drip)
            => self.field_Private_String_0 = deobf_drip;


        public static bool Deobf_DripDifferent(this Deobf_UpdateInventoryInGame self, string drip)
            => self.Method_Private_Boolean_String_PDM_5(drip);
    }

    public static class Deobf_WinScreenUiDropAlertExtensions
    {
        public static string get_deobf_white(this Deobf_WinScreenUiDropAlert self)
            => self.field_Private_String_0;

        public static void set_deobf_white(this Deobf_WinScreenUiDropAlert self, string deobf_white)
            => self.field_Private_String_0 = deobf_white;
    }

    public static class Deobf_WinScreenUiDropAlertsExtensions
    {
        public static float get_deobf_timeBetweenAlerts(this Deobf_WinScreenUiDropAlerts self)
            => self.field_Private_Single_0;

        public static void set_deobf_timeBetweenAlerts(this Deobf_WinScreenUiDropAlerts self, float deobf_timeBetweenAlerts)
            => self.field_Private_Single_0 = deobf_timeBetweenAlerts;


        public static bool get_deobf_ready(this Deobf_WinScreenUiDropAlerts self)
            => self.field_Private_Boolean_0;

        public static void set_deobf_ready(this Deobf_WinScreenUiDropAlerts self, bool deobf_ready)
            => self.field_Private_Boolean_0 = deobf_ready;


        public static void Deobf_NextAlert(this Deobf_WinScreenUiDropAlerts self)
            => self.Method_Private_Void_PDM_28();
    }

    public static class Deobf_WinScreenUiDropAlerts_Deobf_ItemExtensions
    {
        public static ulong get_deobf_clientId(this Deobf_WinScreenUiDropAlerts_Deobf_Item self)
            => self.field_Public_UInt64_0;

        public static void set_deobf_clientId(this Deobf_WinScreenUiDropAlerts_Deobf_Item self, ulong deobf_clientId)
            => self.field_Public_UInt64_0 = deobf_clientId;


        public static CosmeticItem get_deobf_cosmeticItem(this Deobf_WinScreenUiDropAlerts_Deobf_Item self)
            => self.field_Public_CosmeticItem_0;

        public static void set_deobf_cosmeticItem(this Deobf_WinScreenUiDropAlerts_Deobf_Item self, CosmeticItem deobf_cosmeticItem)
            => self.field_Public_CosmeticItem_0 = deobf_cosmeticItem;


        public static Dictionary<string, string> get_deobf_attributes(this Deobf_WinScreenUiDropAlerts_Deobf_Item self)
            => self.field_Public_Dictionary_2_String_String_0;

        public static void set_deobf_attributes(this Deobf_WinScreenUiDropAlerts_Deobf_Item self, Dictionary<string, string> deobf_attributes)
            => self.field_Public_Dictionary_2_String_String_0 = deobf_attributes;
    }

    public static class Deobf_WordAllowlistExtensions
    {
        public static List<string> get_deobf_wordAllowList(this Deobf_WordAllowlist self)
            => self.field_Private_List_1_String_0;

        public static void set_deobf_wordAllowList(this Deobf_WordAllowlist self, List<string> deobf_wordAllowList)
            => self.field_Private_List_1_String_0 = deobf_wordAllowList;


        public static int get_Deobf_WordAllowListLength(this Deobf_WordAllowlist self)
            => self.prop_Int32_0;


        public static ReadOnlyCollection<string> get_Deobf_WordAllowList(this Deobf_WordAllowlist self)
            => self.prop_ReadOnlyCollection_1_String_0;


        public static void Deobf_Add(this Deobf_WordAllowlist self, string word)
            => self.Method_Public_Virtual_Final_New_Void_String_2(word);


        public static void Deobf_Clear(this Deobf_WordAllowlist self)
            => self.Method_Public_Virtual_Final_New_Void_6();


        public static bool Deobf_IsAllowed(this Deobf_WordAllowlist self, string word)
            => self.Method_Public_Virtual_Final_New_Boolean_String_8(word);

        
        public static bool Deobf_Remove(this Deobf_WordAllowlist self, string word)
            => self.Method_Public_Virtual_Final_New_Boolean_String_11(word);
    }

    public static class ObscuredBoolExtensions
    {
        public static ObscuredBool Obscure(this bool self)
            => new(self);


        public static bool Read(this ObscuredBool self)
        {
            if (!self.inited)
            {
                self.currentCryptoKey = (byte)UnityEngine.Random.Range(100, 255);
                self.hiddenValue = 181 ^ self.currentCryptoKey;
                self.fakeValue = false;
                self.fakeValueActive = false;
                self.inited = true;

                return false;
            }

            return (self.hiddenValue ^ self.currentCryptoKey) != 181;
        }
    }

    public static class ObscuredFloatExtensions
    {
        public static ObscuredFloat Obscure(this float self)
            => new(self);


        public static float Read(this ObscuredFloat self)
        {
            if (!self.inited)
            {
                self.currentCryptoKey = UnityEngine.Random.Range(1_000_000_000, int.MaxValue);

                ObscuredFloat.ValueTypeNInternalSealedSiInACUnique obscurerInit = new()
                {
                    field_Internal_Single_0 = 0f
                };
                obscurerInit.field_Internal_Int32_0 ^= self.currentCryptoKey; // XOR bits
                (obscurerInit.field_Internal_ACTkByte4_0.b3, obscurerInit.field_Internal_ACTkByte4_0.b2) = (obscurerInit.field_Internal_ACTkByte4_0.b2, obscurerInit.field_Internal_ACTkByte4_0.b3); // Flip middle bytes

                self.hiddenValue = obscurerInit.field_Internal_Int32_0;
                self.fakeValue = 0f;
                self.fakeValueActive = false;
                self.inited = true;

                return 0f;
            }

            ObscuredFloat.ValueTypeNInternalSealedSiInACUnique obscurer = new()
            {
                field_Internal_Int32_0 = self.hiddenValue
            };
            (obscurer.field_Internal_ACTkByte4_0.b3, obscurer.field_Internal_ACTkByte4_0.b2) = (obscurer.field_Internal_ACTkByte4_0.b2, obscurer.field_Internal_ACTkByte4_0.b3); // Flip middle bytes
            obscurer.field_Internal_Int32_0 ^= self.currentCryptoKey; // XOR bits

            return obscurer.field_Internal_Single_0;
        }
    }
}