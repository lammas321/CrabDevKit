using BepInEx.IL2CPP.Hook;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CrabDevPreloader
{
    public static class DetourFailures
    {
        public static readonly List<string> failures = [];

        public static event Action FailureRecorded;
        
        public static void Record(Exception ex, IL2CPPDetourMethodPatcher patcher)
        {
            string message = ex.Message;
            MethodBase original = patcher.Original;

            failures.Add($"Detour failed for {original}: {message}");

            FailureRecorded?.Invoke();
        }
    }
}