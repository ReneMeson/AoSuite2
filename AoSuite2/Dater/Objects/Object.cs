using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dater.Objects
{
    enum eClass //horrible
    {
        Mage = 1,
        Cleric,
        Warrior,
        Assasin,
        Thief,
        Bard,
        Druid,
        Bandit,
        Paladin,
        Hunter,
        Worker,
        Pirat
    }
    class Object
    {
        private string _objectName;
        private eObjType _objectType;

        private int _objectGrh;
        private int _objectGrhSec;

        private bool _objectApu;
        private bool _objectAcu;

        private int _objectSpellIndex;

        private string _objectForumID;

        private int _objectMinHP, _objectMaxHP;

        private int _objectMineralIndex, _objectLingoteIndex;

        private int _objectMunicion, _objectProjectile;

        private bool _objectCrucial;

        private bool _objectNewbie;

        private int _objectMinSta;

        private byte _objectPocionType;

        private int _objectMinModif, _objectMaxModif;

        private long _objectEffectLength;

        private int _objectMinSkill;

        private int _objectMinHit, _objectMaxHit;

        private int _objectMinHam, _objectMinSed;

        private int _objectDef, _objectMinDef, _objectMaxDef;

        private int _objectRopaje;

        private int _objectWeaponAnim, _objectWeaponRazaEnanaAnim;

        private int _objectShieldAnim, _objectHelmetAnim;

        private long _objectPrice;

        private int _objectClosed;

        private byte _objectKey;

        private long _objectKeyPass;

        private int _objectRadio;

        private byte _objectBagType;

        private byte _objectGuante;

        private int _objectIndexAbierta, _objectIndexCerrada, _objectIndexCerradaLlave;

        private byte _objectRazaEnana, _objectRazaHumana, _objectRazaElfa, _objectRazaGnoma, _objectRazaDrow;

        private byte _objectMen, _objectWomen;

        private byte _objectPoison, _objectParaliza;

        private byte _objectGrab;

        private int _objectLingH, _objectLingP, _objectLingO, _objectWood, _objectElficWood;

        private int _objectSkHerreria, _objectSkCarpinteria;

        private string _objectText;

        private eClass[] _objectCP;

        private int _objectSnd1, _objectSnd2, _objectSnd3;

        private int _objectReal, _objectCaos;

        private int _objectNoSeCae;

        private int _objectStaffPower, _objectStaffDamageBonus;

        private int _objectMinMagicDef, _objectMaxMagicDef;

        private byte _objectRefuerzo;

        private int _objectUpgrade;

        private byte _objectMenuIndex;

    }
}
