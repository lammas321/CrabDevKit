# Features
## Intermediary Namings
Since Crab Game is obfuscated, the names of most types, fields, methods, etc have been changed to gibberish, making it difficult to tell what anything actually is, or what is real in the case of all of the generated garbage methods.

Everything has been given a human readable name, so no more wondering what something is or which method is the one you want among all the garbage!
Do note that since the game is compiled with Il2Cpp, this does not give you access to any source code, only the deobfuscated names of the obfuscated names ripped from the Il2Cpp Unhollower.

You don't need to add CrabDevKit as a dependency to use these namings! Feel free to copy the entire files into your project, or just what you need!

## CrabDevPreloader
A preloader (BepInEx/patchers) packaged with CrabDevKit for general purpose fixes and utilities.

### Asset Bundle Patch
The class for Asset Bundles isn't properly unhollowed by the unhollower, leading to it not inheriting from Il2CppObjectBase and missing a constructor that takes in an IntPtr. This results in any attempt to load an Asset Bundle throwing exceptions and just not working. This was partially fixed in the past with Asset Bundle Ptr (avoiding calling the constructor by directly working with the IntPtr and never contructing Asset Bundle, though you couldn't load more than 1 at once) but this is no longer necessary! CrabDevPreloader will force Asset Bundle to inherit Il2CppObjectBase and give it the missing constructor, allowing Asset Bundles to be used as they normally would in any other Unity game!

## CrabNet
A simple networking solution (utilizing channel 123 of SteamNetworkingMessages) to allow mod makers to register and send custom messages between users of CrabDevKit through their mods.

Simply register a message via a string (ex: 'CrabDevKit:Test') and a MessageHandler delegate, which takes in a ulong for the sending client's steam id, and a Packet for the byte data within the message.
```cs
CrabNet.RegisterMessageHandler($"{MyPluginInfo.PLUGIN_NAME}:Test", (clientId, packet) =>
{
  Log.LogInfo($"Test message from {clientId}: {packet.ReadString()}");
});
```

Then you may send that message to any other user using CrabDevKit and your mod!
```cs
static IEnumerable<CSteamID> GetAllSteamIds()
{
    int members = SteamMatchmaking.GetNumLobbyMembers(LobbyManager.Instance.get_currentLobby());
    for (int i = 0; i < members; i++)
    {
        CSteamID steamId = SteamMatchmaking.GetLobbyMemberByIndex(LobbyManager.Instance.get_currentLobby(), i);
        yield return steamId;
    }
}

Packet packet = new();
packet.Write("Hello!");

CrabNet.SendMessage($"{MyPluginInfo.PLUGIN_NAME}:Test", packet, GetAllSteamIds());

// I would normally use a using statement, but Packet is an Il2Cpp unhollowed type and can't be used that way.
// CrabNet.SendMessage also calls packet.Dispose() itself when it's successfully sent the message, but it's good practice to do this anyway!
packet.Dispose();
```

Things to note with CrabNet:
- You may only register messages after CrabDevKit has loaded, and before the game has started, so you should have your mod depend on CrabDevKit and register methods while your mod is loading!
- Your message's identifier string is expected to contain a colon, which should separate your mod's name and the name of the message, in order to reduce the number of potential collisions caused by any mods using the same message identifiers.
- It is up to you to ensure your server and client bound messages are being sent to, received by, rejected, and properly handled by the right users. Always ensure you're only sending server bound messages to the server, and that clients will reject server bound messages not intended for them!
- In larger lobbies, due to the Steam networking issues detailed by FloatingPlayerPatch, messages you send client to client may not always reach eachother, though I don't recommend this style of network communication anyway.

## FakeClients
A simple solution for simulating what it'd be like to do anything with more players than you have available. (Useful if you have no friends, or they just aren't available right when you need them xD)

Here's a simple Harmony patch that will spawn and remove fake clients when pressing Left Alt+P or Left Alt+O as the host:
```cs
// Create/Remove FakeClients
internal static List<FakeClient> fakeClients = [];
[HarmonyPatch(typeof(PlayerInput), nameof(PlayerInput.Update))]
[HarmonyPostfix]
internal static void PostPlayerInputUpdate()
{
    if (!SteamManager.Instance.IsLobbyOwner() || !Input.GetKey(KeyCode.LeftAlt))
        return;

    if (Input.GetKeyDown(KeyCode.P))
    {
        CrabDevKit.Instance.Log.LogInfo("Creating fake player...");

        FakeClient fakeClient = FakeClients.Create(forceSpawnActive: true);
        fakeClients.Add(fakeClient);
    }

    if (Input.GetKeyDown(KeyCode.O))
    {
        FakeClient fakeClient = fakeClients.LastOrDefault();
        if (fakeClient == null)
          return;
        
        CrabDevKit.Instance.Log.LogInfo("Removing fake player...");

        FakeClients.Remove(fakeClient);
        fakeClients.RemoveAt(fakeClients.Count - 1);
    }
}
```

## Other Utilities
### ChatUtil
Provides a couple methods for sending chat messages with better formatting.

### GiveUtil
Allows you to directly give vanilla players any item with any amount of ammo.