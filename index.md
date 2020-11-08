三层架构(自下而上形成层级关系)：独立三层架构
  1. DAL(Data Access Layer): 根据数据库创建出来, 得到原始数据后，传递到上一层
  2. BLL(Business Logic Layer): 进行数据验证，转化，以及对象封装，处理好到数据传递到UI层
  3. UI Layer: 展示来自BLL层的数据给用户

MVC架构：水平架构,没有层级关系，只有调用关系。所有数据流动，显示都是通过数据绑定,事件驱动所处理。
  根据业务确定模型Model，基于它来创建数据库。接着View层触发事件，调用Controller。然后Controller调用Model。Model从数据库获取数据,对数据进行各项处理，完成业务逻辑，将处理好的数据返回给Controller。Controller将数据返回到View，View进行展示。Model可直接与View绑定。

让一个类变成Asp.Net MVC controller的三种做法
  1.  类名后添加`Controller`
  2.  给这类添加`[Controller]` 特性
  3.  继承asp Controller类

  