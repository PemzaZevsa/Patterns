# Розрахунково-графічна робота

*з дисципліни «Архітектура та проектування ПЗ .NET»*

*На тему: «Шаблони проектування»*

**Мета роботи:** Вивчення стандартних ситуацій у процесі розробки складних програмних проектів та застосування шаблонів проектування (Design patterns) для їх вирішення.

## Builder

Будівельник (Builder) - шаблон проектування, який інкапсулює створення об'єкта та дозволяє розділити його на різні етапи. Іншими словами, ми даємо можливість створювати екземпляр класа іншому класу.

```mermaid
classDiagram
   Director o-- IBuilder
   ConcreteBuilder ..|> IBuilder
   Product <.. ConcreteBuilder
   
    class Director{
        -Builder: Builder
        +Director()   
        +Construct()      
    }
    class IBuilder{
        +BuildPartA()
        +BuildPartB()
        +BuildPartC()
        +Construct()
    }
    class ConcreteBuilder{
        +fieldA: string
        +fieldB: int
        +fieldC: double 
        +BuildPartA()
        +BuildPartB()
        +BuildPartC()
        +Construct()
    }
    class Product{ 
        +fieldA: string
        +fieldB: int
        +fieldC: double    
    }
```

## Front Controller 

Вхідна точка (Front Controller) - це шаблон розробки програмного забезпечення, який міститься в кількох каталогах шаблонів. Шаблон відноситься до дизайну веб-додатків. Він «надає централізовану точку входу для обробки запитів».

```mermaid
classDiagram
    Handler --> AbstractComand 
    Client ..> Handler
    AbstractComand <|-- Comand1
    AbstractComand <|-- Comand2
    class Handler{
        + HandleRequest(string request)
    }
    class AbstractComand{
        + exicute()
    }
    class Comand1{
        + exicute()
    }
    class Comand2{
        + exicute()
    }
    class Client{
        + SendRequest(string request)
    }
```

## Hierarchical visitor 

Відвідувач(visitor) — це шаблон поведінкового проектування, який дозволяє відокремити алгоритми від об’єктів, з якими вони працюють

```mermaid
classDiagram
   AbstractElement --> IVisitor
   Client --> ConcreteVisitor1
   Client --> ConcreteVisitor2   
   AbstractElement <-- Client 
   ConcreteVisitor1 ..|> IVisitor
   ConcreteVisitor2 ..|> IVisitor
   ElementA ..|> AbstractElement
   ElementB ..|> AbstractElement   
    class IVisitor{
        + visit(ElementA)
        + visit(ElementB)
    }
    class ConcreteVisitor1{
        + visit(ElementA)
        + visit(ElementB)
    }
    class ConcreteVisitor2{
        + visit(ElementA)
        + visit(ElementB)
    }
    class AbstractElement{
        + accept(IVisitor)
    }
    class ElementA{
        + accept(IVisitor)
    }
    class ElementB{
        + accept(IVisitor)
    }
    class Client{

    }
```

## Reactor

Reactor — це стратегія обробки подій, яка може відповідати на багато потенційних запитів на обслуговування одночасно. Ключовим компонентом шаблону є цикл подій, що виконується в одному потоці або процесі, який демультиплексує вхідні запити та відправляє їх правильному обробнику запитів.

```mermaid
classDiagram
    EventHandler <|-- ConcreteEventHandlerB
    EventHandler <|-- ConcreteEventHandlerA
    EventHandler -- Handle
    SynchoronousEventDemultiplexer -- Handle
    Reactor -- Handle
    EventHandler -- Reactor
    Reactor --> SynchoronousEventDemultiplexer
  
    class SynchoronousEventDemultiplexer{
        + Select()
    }
    class Handle{
    }
    class Reactor{
        + HandleEvents()
        + RegisterHandler()
        + RemoveHandler()
    }
    class EventHandler{
        + HandleEvent()
        + GetHandle()	
    }
    class ConcreteEventHandlerA{
        + HandleEvent()
        + GetHandle()
    }
    class ConcreteEventHandlerB{
        + HandleEvent()
        + GetHandle()
    }
```