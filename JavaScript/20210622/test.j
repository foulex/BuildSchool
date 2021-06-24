function Trig_Item_Ice_ShieldConditions takes nothing returns nothing

 local unit     u1      = GetTriggerUnit()
 local integer  intel   = GetHeroInt(u1, true)	
 local real     HP      = GetUnitState(u1, UNIT_STATE_LIFE)
 local real     MP      = GetUnitState(u1, UNIT_STATE_MANA)
 local real     decRate = I2R(intel)/7*0.01+0.45
 local real     decNum  = 3.0
 local real     dmg     = GetEventDamage()
 local real     heal
 local real     cost

 if(UnitHasBuffBJ(GetTriggerUnit(), 'B0B9') then
  if(decRate > 0.7)then
   set decRate = 0.7
  endif
  set heal = dmg*decRate
  set cost = heal/decNum

  if((MP - cost) < 0)then
   set heal = heal - (cost - MP) * decNum
   set MP = cost
  endif
  call SetUnitLifeBJ( u1, ( HP + heal ) )
  call SetUnitManaBJ( u1, ( MP - cost ) )
 endif
   
 set u1= null
endfunction

//===========================================================================
function InitTrig_Item_Ice_Shield takes nothing returns nothing
 set gg_trg_Item_Ice_Shield = CreateTrigger()
 call TriggerAddCondition(gg_trg_Item_Ice_Shield, Condition(function Trig_Item_Ice_ShieldConditions))
endfunction