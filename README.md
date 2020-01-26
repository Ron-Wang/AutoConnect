# AutoConnect
自动连接**清华校园网**（net.tsinghua.edu.cn）

## 概述
AutoConnect可以根据用户设定的时间间隔（单位：s），定时检查清华网连接状态。  
当网络断开时，则根据用户填写的用户名和密码填充网络登录界面信息，并进行连接，从而保证网络连接。  
在采用teamwear等远程连接软件时，通过AutoConnect可以避免出现网络断开而无法使用的情况。
    
## 更新说明
* 增加**记住密码**功能
    
## 运行环境
* 硬件环境：PC机
* 软件环境：Windows系列操作系统

## 运行说明
* 在releases (https://github.com/Ron-Wang/AutoConnect/releases) 中下载AutoConnect.zip，解压得到  
  
<div align="center">
    <img src="https://github.com/Ron-Wang/AutoConnect/blob/master/Images/AutoConnect_00.png" width="700">
</div>
  
* 运行AutoConnect，界面如下：  

<div align="center">
    <img src="https://github.com/Ron-Wang/AutoConnect/blob/master/Images/AutoConnect_01.png" width="600">
</div>

* 输入账号、密码及检查连接的时间间隔（单位：s，如输入“1800”则表示间隔 30 分钟）后，点击“开始自动连接”：  
  
<div align="center">
    <img src="https://github.com/Ron-Wang/AutoConnect/blob/master/Images/AutoConnect_02.png" width="600">
</div>
  
* 如果勾选“记住密码”，则会生成相应的数据文件data.int，此后打开AutoConnect会自动加载数据中的账号密码（可多个）  
  
<div align="center">
    <img src="https://github.com/Ron-Wang/AutoConnect/blob/master/Images/AutoConnect_04.png" width="700">
</div>
  
* 添加新账号，如果勾选“记住密码”，则AutoConnect会更新data.int，添加新的账号密码  
  
<div align="center">
    <img src="https://github.com/Ron-Wang/AutoConnect/blob/master/Images/AutoConnect_05.png" width="600">
</div>
  
* 点击账号中的下拉列表，加载所有账号：
  
<div align="center">
    <img src="https://github.com/Ron-Wang/AutoConnect/blob/master/Images/AutoConnect_06.png" width="600">
</div>
  
## 补充说明
* 自动连接的校园网网址为net.tsinghua.edu.cn,尚不支持auth4.tsinghua.edu.cn
* 如需断开连接，退出AutoConnect后需要手动断开连接
* 相关问题可联系作者：wangrongxin168@163.com


