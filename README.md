# AutoConnect
定时检查**清华校园网**连接状态

## 概述
AutoConnect可以根据用户设定的时间间隔（单位：s），定时检查清华网连接状态。  
当网络断开时，则根据用户填写的用户名和密码填充网络登录界面信息，并进行连接，从而保证网络连接。  
在采用teamwear等远程连接软件时，通过AutoConnect可以避免出现网络断开而无法使用的情况。
    
## 运行环境
* 硬件环境：PC机
* 软件环境：Windows系列操作系统

## 更新说明
* 增加**记住密码**功能
    
## 运行界面
在release中下载zip，解压得到  
  
<img src="https://github.com/Ron-Wang/AutoConnect/blob/master/Images/AutoConnect_00.png" width="250">
![AutoConect解压后](https://github.com/Ron-Wang/AutoConnect/blob/master/Images/AutoConnect_00.png)
运行AutoConnect，界面如下：  
  
![AutoConect界面](https://github.com/Ron-Wang/AutoConnect/blob/master/Images/AutoConnect_01.png = 250x)
输入账号、密码及检查连接的时间间隔（单位：s）后，点击“开始自动连接”，即可开始  
  
![AutoConect自动连接](https://github.com/Ron-Wang/AutoConnect/blob/master/Images/AutoConnect_02.png = 250x)
如果勾选“记住密码”，则会生成相应的数据文件data.ini，此后打开AutoConnect会自动加载数据中的账号密码（可多个）  

![AutoConect数据文件](https://github.com/Ron-Wang/AutoConnect/blob/master/Images/AutoConnect_04.png = 250x)
添加新账号
  
![AutoConect添加新账号](https://github.com/Ron-Wang/AutoConnect/blob/master/Images/AutoConnect_05.png = 250x)
点击账号中的下拉列表，加载所有账号：
  
![AutoConect账号列表](https://github.com/Ron-Wang/AutoConnect/blob/master/Images/AutoConnect_06.png = 250x)
