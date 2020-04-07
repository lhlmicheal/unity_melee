using System.Collections;
using System.Collections.Generic;
using UnityEngine;
enum Gear
{
    Low = 0, //底
    Mid = 1,
    High = 2,//高
}

enum VisionType
{
    Narrow = 0, //窄
    Medium = 1,
    Wide = 2,//宽
}
public class GameAudioData
{
    //游戏中跟音效相关的设置数据
    public bool soundOpen = true;
    public bool bgmOpen = true;
    public int volume = 50; //音量值范围0-100，默认50
    public GameAudioData(bool openSound = true, bool openBgm = true, int vol = 0)
    {
        this.soundOpen = openSound;
        this.bgmOpen = openBgm;
        this.volume = vol;
    }
}

public class GameGraphicsData
{
    //游戏中跟画质相关的设置数据
    public int[] resolution;
    //刷新率
    public int refreshRate = (int)Gear.Mid;
    public int screenBrightness = (int)Gear.Mid;
    public int imitateDetails = (int)Gear.Mid;
    public int specialDetails = (int)Gear.Mid;
    public int roleVision = (int)VisionType.Medium;

    public int antialiasing = (int)Gear.Mid; //抗锯齿
    public int reflectionEffect = (int)Gear.Mid;//反射效果
    public int improveImage = (int)Gear.Mid;//提升画质
    public int volume = 50; //音量值范围0-100，默认50

    public bool shadowOpen = true;
    public bool gpuAnimation = true; //GPU动画加速
    public GameGraphicsData()
    {
        this.resolution[0] = Consts.GAME_WIDTH;
        this.resolution[1] = Consts.GAME_HEIGHT;

        this.refreshRate = (int)Gear.Mid;
        this.screenBrightness = (int)Gear.Mid;
        this.imitateDetails = (int)Gear.Mid;
        this.specialDetails = (int)Gear.Mid;
        this.roleVision = (int)VisionType.Medium;
        this.antialiasing = (int)Gear.Mid; //抗锯齿
        this.reflectionEffect = (int)Gear.Mid;//反射效果
        this.improveImage = (int)Gear.Mid;//提升画质
        this.volume = 50; //音量值范围0-100，默认50
        this.shadowOpen = true;
        this.gpuAnimation = true; //GPU动画加速
    }
    public GameGraphicsData(int width, int height, int rate, int bright, int imitate, int special, int vision, int antial, int reflect, int vol, int improve, bool shadow, bool gpu)
    {
        this.resolution[0] = width;
        this.resolution[1] = height;

        this.refreshRate = rate;//(Gear)rate;
        this.screenBrightness = bright;
        this.imitateDetails = imitate;
        this.specialDetails = special;
        this.roleVision = vision;
        this.antialiasing = antial; //抗锯齿
        this.reflectionEffect = reflect;//反射效果
        this.improveImage = improve;//提升画质
        this.volume = vol; //音量值范围0-100
        this.shadowOpen = shadow;
        this.gpuAnimation = gpu; //GPU动画加速
    }
}

public class GameOperateData
{
    public string forward = "";
    public string backward = "";
    public string left = "";
    public string right = "";
    public string fire = "";
    public string bulletClip = "";
    public GameOperateData()
    {
        this.forward = "W";
        this.backward = "S";
        this.left = "A";
        this.right = "D";
        this.fire = "J";
        this.bulletClip = "K";
    }
    public GameOperateData(string forward, string back, string left, string right, string fire, string bullet)
    {
        this.forward = forward;
        this.backward = back;
        this.left = left;
        this.right = right;
        this.fire = fire;
        this.bulletClip = bullet;
    }
}

// GameSettingData类中成员变量所引用的对内存不需要自己释放，CLR托管了对内存，会在该对象引用无效时自动释放内存。
public class GameSettingData
{
    public GameAudioData _mAudioData;
    public GameGraphicsData _mGraphicsData;
    public GameOperateData _mOperateData;
    public GameSettingData()
    {
        this._mAudioData = new GameAudioData();
        this._mGraphicsData = new GameGraphicsData();
        this._mOperateData = new GameOperateData();
    }
}