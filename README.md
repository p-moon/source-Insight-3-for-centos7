# source-Insight-3-for-centos7-
 centos7 下集成的source Insight 3

曾经试过用wine，但是安装以后总是出现bad format exe的错误。最后参考navicat的安装程序终于把问题解决了，并且做了一个集成包。就是上面那个链接了。实现的核心代码如下： 
现在将使用方法做一个说明，解压以后进入目录，

1、启动程序。输入：

./sourceinsight

即可启动。

2、创建桌面快捷方式

sudo sh ./create_entry.sh

 
