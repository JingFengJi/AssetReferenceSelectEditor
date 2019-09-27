笔记目录
[TOC]

# 工具介绍
文件选择器顾名思义是用来选中文件用的，那么与
![](https://tva1.sinaimg.cn/large/006y8mN6gy1g7e7fglrk5j309j00smwz.jpg)
上图中Unity自带的点击右边的小圆点 弹出文件搜索框有什么区别呢？

工具界面如下：
![](https://tva1.sinaimg.cn/large/006y8mN6gy1g7e7gpmtq6j30bt0a774z.jpg)

其中点击Select按钮，弹出文件搜索框（类比Add Component按钮点击后弹出的框）,根据资源类型筛选后形成的资源树状结构显示在下面的框中，点击其中一个结点进入子树，点击右侧的X按钮进行清空。（小声哔哔：看起来好像没啥用）

# 资源弱引用

首先说明一下个人理解的资源弱引用：不直接引用游戏资源，通过序列化存储一些用来从资源管理系统中加载资源的参数，来间接引用资源，这些参数可以称之为地址（不要强行沾边Addressable）。使用一个地址来加载资源，资源如何更改，地址都不要变，保证地址唯一性。无论是使用Resources文件夹进行资源加载管理、还是使用AssetBundle进行资源加载管理，都可以使用弱引用。

弱引用需要存储的数据：

* Guid
Editor可使用Guid来加载资源、定位资源，保证资源的路径修改后依然可以定位到资源。
* 用来加载的数据
取决于你的资源管理系统如何加载资源，如果使用Resources加载，可以存储Resources文件夹下的路径

WeakReference弱引用基类，其中存储了Guid
![](https://tva1.sinaimg.cn/large/006y8mN6gy1g7e7w1hcnoj30ve0qm78a.jpg)

各种资源类型对应的弱引用类型
![](https://tva1.sinaimg.cn/large/006y8mN6gy1g7e7x3r75pj30jy0citaa.jpg)

# 文件选择器

该文件选择器参考的Editor源码中AddComponent部分

[Unity-Technologies Add Component Editor源码地址](https://github.com/Unity-Technologies/UnityCsReference/blob/master/Editor/Mono/Inspector/AddComponent/ComponentDropdownItem.cs)

[AdvancedDropdown官方介绍](https://docs.unity3d.com/ScriptReference/IMGUI.Controls.AdvancedDropdown.html)

AdvancedDropdown部分此文不过多介绍，可能会另外开篇。本例中只存储了guid，其余数据在文件被选择的时候也可以赋值。

# 源码地址

[Github仓库地址](https://github.com/JingFengJi/AssetReferenceSelectEditor.git)

以上知识分享，如有错误，欢迎指出，共同学习，共同进步。

最近在用hexo 和 github page搭 个人博客，地址如下：
http://www.jingfengji.tech/
欢迎大家关注。

最近的一些博客 还是会更新在 CSDN这边，后续以自己个人的博客站点会主。【实在是没空去整那边，要学习的东西真是太多了。。。】