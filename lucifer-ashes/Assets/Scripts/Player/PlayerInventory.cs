using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    WeaponSlotManager weaponSlotManager;

    public WeaponItem rightWeapon;
    public WeaponItem leftWeapon;

    public WeaponItem unarmedWeapon;

    public WeaponItem[] weaponsInRightHandSlots = new WeaponItem[1];
    public WeaponItem[] weaponsInLeftHandSlots = new WeaponItem[1];

    public int currentRightWeaponIndex = 0;
    public int currentLeftWeaponIndex = 0;

    public List<WeaponItem> weaponsInventory;
    
    private void Awake()
    {
        weaponSlotManager = GetComponentInChildren<WeaponSlotManager>();
    }

    private void Start()
    {
        rightWeapon = unarmedWeapon;
        leftWeapon = unarmedWeapon;
    }

    public void ChangeRightWeapon()
    {
        currentRightWeaponIndex = currentRightWeaponIndex + 1;

                if (currentRightWeaponIndex > weaponsInRightHandSlots.Length - 1)
                {
                    currentRightWeaponIndex = -1;
                    rightWeapon = unarmedWeapon;
                    weaponSlotManager.LoadWeaponOnSlot(unarmedWeapon, false);
                }
                else if (weaponsInRightHandSlots[currentRightWeaponIndex] != null)
                {
                    rightWeapon = weaponsInRightHandSlots[currentRightWeaponIndex];
                    weaponSlotManager.LoadWeaponOnSlot(weaponsInRightHandSlots[currentRightWeaponIndex], false);
                }
                else
                {
                    currentRightWeaponIndex = currentRightWeaponIndex + 1;
                }

    }

    public void ChangeLeftWeapon()
    {
        currentLeftWeaponIndex = currentLeftWeaponIndex + 1;

        if (currentLeftWeaponIndex > weaponsInLeftHandSlots.Length - 1)
        {
        currentLeftWeaponIndex = -1;
        leftWeapon = unarmedWeapon;
        weaponSlotManager.LoadWeaponOnSlot(unarmedWeapon, true);
        }
        else if (weaponsInLeftHandSlots[currentLeftWeaponIndex] != null)
        {
        leftWeapon = weaponsInLeftHandSlots[currentLeftWeaponIndex];
        weaponSlotManager.LoadWeaponOnSlot(weaponsInLeftHandSlots[currentLeftWeaponIndex], true);
        }
        else
        {
        currentLeftWeaponIndex = currentLeftWeaponIndex + 1;
        }
    }
}
