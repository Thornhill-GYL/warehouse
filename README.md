# 仓库管理项目

## 所需“外设”说明：

该项目使用C#编写，其中使用以下“外设”

1. OLEDB来管理数据文件
2. ZXing来生成二维码和读取二维码
3. 使用TSC条码打印机（TTP-244pro）对打印二维码
4. 使用斑马扫描枪 （DS2208+usb）扫描二维码

## 软件使用说明

在这部分讲述项目使用的过程

### 开机界面

分为五个功能部分：

1. 系统设置（用于整个项目的设置）
2. 打印标签（打印相应的零件的二维码）
3. 入库操作（通过扫描零件的二维码，将其入库）
4. 出库操作（通过扫描零件的二维码，将其出库）
5. 库存查询（查询仓库中的零件的入库、出库情况）

<img src="https://raw.githubusercontent.com/Thornhill-GYL/markdownpicture/master/project01.jpg"/>

### 系统设置

在进入系统设置时，会要求进行用户的身份验证，目前的方式是查表验证

#### 用户身份验证

<img src="https://raw.githubusercontent.com/Thornhill-GYL/markdownpicture/master/project02.jpg"/>

在点击系统设置后，会出现上方左边的窗口，输入正确的用户名和密码可以进入系统设置页面，该部分的用户名和密码在**权限.xlsx**文件中，若上方右边的窗口

#### 系统设置页面

在这部分中，分为四个功能：

1. 选取人员姓名，打印其身份卡（具体在后面说明）
2. 录入物品清单
3. 录入仓库信息
4. 录入人员信息

<img src="https://raw.githubusercontent.com/Thornhill-GYL/markdownpicture/master/project03.jpg"/>

##### 录入信息说明

点击**录入物品清单等**按钮，会弹出左边的窗口，选择相应的文件，选择后，右边窗口会出现，选择文件的绝对地址。

在这部分选取的文件，会作为**后面操作的文件**。

<img src="https://raw.githubusercontent.com/Thornhill-GYL/markdownpicture/master/project04.jpg"/>

##### 打印人员二维码

若已经**录入人员信息**，则选择姓名的时候，选取的是录入的信息的人员姓名，若未录入，则是默认文件的人员信息，（在代码中，有注释）；

选择人员姓名后，点击**打印身份卡**，会弹出右边的二维码，同样TSC打印机会打印二维码，演示视频在**项目展示**文件夹；该二维码经过简单加密，不会被微信、支付宝扫出具体信息。

<img src="https://raw.githubusercontent.com/Thornhill-GYL/markdownpicture/master/project05.jpg"/>

### 打印标签

#### 标签信息选择界面

点击**打印标签**按钮会出现下图左方窗口

PS:若在该部分前，选择了**录入物品清单**，则打开的是对应文件，反之则是，程序中的默认文件。

1. 在物品名称中，可**模糊搜索**查找相应物品
2. 选择后，点击**已入库**按钮，加载信息，如下图右方窗口所示。
3. 点击**下一个**按钮，序号会相应+1，生成的序号也会+1
4. 确定信息后，点击**打印二维码标签**

<img src="https://raw.githubusercontent.com/Thornhill-GYL/markdownpicture/master/project06.jpg"/>

#### 打印二维码界面

点击**打印二维码标签**后，出现下图界面，再次确定打印信息

确定后，点击**打印二维码**按钮，根据需求，在点击后，，将**打印二维码**按钮锁定30s

<img src="https://raw.githubusercontent.com/Thornhill-GYL/markdownpicture/master/project07.jpg"/>

#### 二维码打印结果界面

点击**打印二维码**按钮后，会出现下图界面，相应地，TSC打印机会打印该二维码，展示视频在**项目展示**文件夹中。

<img src="https://raw.githubusercontent.com/Thornhill-GYL/markdownpicture/master/project08.jpg"/>

### 入库操作

#### 入库操作界面

点击**入库操作**按钮后，出现下图界面

<img src="https://raw.githubusercontent.com/Thornhill-GYL/markdownpicture/master/project09.jpg"/>

##### 读取物品二维码

点击**读取二维码**按钮，使用**斑马扫描枪**扫描二维码。

扫描成功后将将物品信息填入对应的框体中。（操作视频在**项目展示**文件中）

##### 读取人员二维码

点击**扫描身份卡**按钮后，使用**斑马扫描枪**扫描人员身份二维码

扫描成功后，会把入库人的信息填充上

然后**仓库位置**信息，提示**存储位置**信息打开的文件夹。

#### 入库结果界面

在上述信息读取完成后，点击**入库**按钮，若仓库文件中没有该物品（以序列号为参考），则显示入库成功，若已经有了该物品，则弹出重复入库窗口。

PS：若在开始**录入了仓库信息**则该部分入库的文件则是先前的文件夹，反之则是程序中录入的文件夹

<img src="https://raw.githubusercontent.com/Thornhill-GYL/markdownpicture/master/project10.jpg"/>

<img src="https://raw.githubusercontent.com/Thornhill-GYL/markdownpicture/master/project10.jpg"/>

入库成功后的仓库文件如下图

上方是初始文件，下方是入库成功后的文件。

<img src="https://raw.githubusercontent.com/Thornhill-GYL/markdownpicture/master/project000.jpg"/>



### 出库操作

出库操作界面和操作与入库操作类似

<img src="https://raw.githubusercontent.com/Thornhill-GYL/markdownpicture/master/project12.jpg"/>

下图是出库成功的界面，可以发现，库存文件中，多了出库操作相关的信息。

<img src="https://raw.githubusercontent.com/Thornhill-GYL/markdownpicture/master/project13.jpg"/>

### 库存查询

#### 库存查询界面

点击**库存查询**按钮后，弹出下图界面

该部分可根据每个关键信息查询

也可直接点击**查询**按钮，可展示所有信息

<img src="https://raw.githubusercontent.com/Thornhill-GYL/markdownpicture/master/project15.jpg"/>

#### 查询展示

下图是库存中的信息

<img src="https://raw.githubusercontent.com/Thornhill-GYL/markdownpicture/master/project16.jpg"/>

##### 根据关键词查询

根据关键词**入库人**进行查询，得到下图查询结果

<img src="https://raw.githubusercontent.com/Thornhill-GYL/markdownpicture/master/project17.jpg"/>

##### 查询文件中所有信息

不填入关键词信息，直接点击**查询**按钮，即可得到文件所有信息。

<img src="https://raw.githubusercontent.com/Thornhill-GYL/markdownpicture/master/project18.jpg"/>

