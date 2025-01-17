﻿using HarmonyLib;
using UnityEngine;
using System;
using System.Collections.Generic;
using Klei.AI;

namespace DiseasesExpanded
{
    class DiseasesExpanded_Patches_Vaccines
    {
        /*
         * Not satisfied with final effect, but leaving the code in case I changed my mind later
         *          
          
        public class VaccinationData
        {
            public HashedString key;
            public Tag vaccineTag;
            public string effectId;
        }

        public static List<VaccinationData> Vaccinations = new List<VaccinationData>
        {
            new VaccinationData() { key = (HashedString)SlimelungVaccine.ID, vaccineTag = (Tag)SlimelungVaccine.ID, effectId = SlimelungVaccine.EffectID}
        };

        [HarmonyPatch(typeof(DoctorStation))]
        [HarmonyPatch("OnStorageChange")]
        public static class DoctorStation_OnStorageChange_Patch
        {
            public static void Postfix(DoctorStation __instance)
            {
                Dictionary<HashedString, Tag> treatments_available = Traverse.Create(__instance).Field("treatments_available").GetValue<Dictionary<HashedString, Tag>>();
                DoctorStation.StatesInstance smi = Traverse.Create(__instance).Field("smi").GetValue<DoctorStation.StatesInstance>();
                if (treatments_available == null || smi == null)
                    return;

                foreach (GameObject go in __instance.storage.items)
                {
                    MedicinalPill component = go.GetComponent<MedicinalPill>();
                    if ((UnityEngine.Object)component != (UnityEngine.Object)null)
                    {
                        Tag tag = go.PrefabID();
                        foreach (VaccinationData data in Vaccinations)
                            if (data.vaccineTag == tag)
                                treatments_available.Add(data.key, tag);
                    }
                }
                smi.sm.hasSupplies.Set(treatments_available.Count > 0, smi);
            }
        }

        [HarmonyPatch(typeof(DoctorStation))]
        [HarmonyPatch("IsTreatmentAvailable")]
        public static class DoctorStation_IsTreatmentAvailable_Patch
        {
            public static void Postfix(DoctorStation __instance, GameObject target, ref bool __result)
            {
                Dictionary<HashedString, Tag> treatments_available = Traverse.Create(__instance).Field("treatments_available").GetValue<Dictionary<HashedString, Tag>>();
                if (treatments_available == null)
                    return;
                
                foreach(VaccinationData data in Vaccinations)
                    if(treatments_available.ContainsKey(data.key))
                    {
                        Effects effects = target.GetComponent<Effects>();
                        if (effects != null && !effects.HasEffect(data.effectId))
                            __result = true;
                        return;
                    }
            }
        }

        [HarmonyPatch(typeof(DoctorStation))]
        [HarmonyPatch("CompleteDoctoring")] 
        [HarmonyPatch(new Type[] { typeof(GameObject) })] 
        public static class DoctorStation_CompleteDoctoring_Patch
        {
            public static void Prefix(DoctorStation __instance, GameObject target)
            {
                Dictionary<HashedString, Tag> treatments_available = Traverse.Create(__instance).Field("treatments_available").GetValue<Dictionary<HashedString, Tag>>();
                if (treatments_available == null)
                    return;

                foreach (VaccinationData data in Vaccinations)
                    if (treatments_available.ContainsKey(data.key))
                    {
                        __instance.storage.ConsumeIgnoringDisease(data.vaccineTag, 1);
                        Effects effects = target.GetComponent<Effects>();
                        if(effects != null)
                            effects.Add(data.effectId, true);
                    }
            }
        }*/
    }
}
