# **Случайная - Virtual Machine**

>***
It's a prototype of a project that is supposed to be a virtual machine, I can't realy describe it right now so *shrugs*.
>***

___
I'm currently working on Stacks, Pointers, Jmp and Mov fonctions.
___

## - **Memory Organisation :**

### There is a defined amount of memory registers along with a dedicated purpose :
+ Memory.**AX** - it's a byte array, bytes 0 to 3 are used to store result of maths operations, others aren't used yet.
+ Memory.**BX** - it's a byte that act as the buffer of a MOV fonction.
+ Memory.**CX** - it's a byte array, it stores counts of various operations and pointer shifts.
+ Memory.**DX** - it's a byte array, it stores ports addresses for I/O.
---
+ Memory.**SI** - it's a byte array, it stores input for operations.
+ Memory.**DI** - it's a byte that stores results of operations tempoorarly.
+ Memory.**SP** - it's a byte array, it stores top pointers of stacks.
+ Memory.**BP** - it's a byte array, it stores base pointers of stacks.
---
+ Memory.**CS** - it's a byte array, it stores text and code in strings.
+ Memory.**DS** - it's a byte array, it stores mapping data.
+ Memory.**SS** - it's a byte array, it manages stacks
+ Memory.**ES** - it's a byte array, it an extra storage if there is a lack of storage.
---
+ Memory.**FS** - it's a byte that stores files data.
+ Memory.**GS** - it's a byte that stores types data.
+ Memory.**FLAG** - it's a byte that stores zeo flags (Z), carry flags (C), priority flags (P) and negative flags (N).
+ Memory.**IP** - it's a byte array, it stores instructions pointers adrresses.
---
+ Memory.**DG** - it's a byte it stores data for debugging.
+ Memory.**EP** - it's a byte it stores printing data for debuging

___
## - **Command List :**

### - **Fonctions.Multiply(A, B)**
It multiplies the byte A stored in SI[0] to the byte B stored in SI[1] and output the result in AX[0].

### - **Fonctions.Divide(A, B)**
It divides the byte A stored in SI[2] by the byte B stored in SI[3] and output the result in AX[1].

### - **Fonctions.Add(A, B)**
It adds the byte A stored in SI[4] to the byte B stored in SI[5] and output the result in AX[2].

### - **Fonctions.Substract(A, B)**
It subtracts the byte B stored in SI[7] to the byte A stored in SI[6] and output the result in AX[3].

---
### - **Fonctions.Reset.Register**
This fonction re-initialize (reset) all the bytes of the selected byte array "Register" (AX, CX, DX, etc...) to 0.
⋅⋅⋅ There is also a possibiilty to use Fonctions.Reset.All which resets all the byte arrays.⋅⋅
