# Learn-C-Sharp
In this repo, you'll learn how to code using C# (C-Sharp).

## Basics

### Introduction

#### C# vs .NET:

C# is a programming language, while .NET is a framework. It consists of a run-time environment (CLR) and a class library that we use for building applications.

#### CLR

When you compile an application, C# compiler compiles your code to IL (Intermediate Language) code. IL code is platform agnostics, which makes it possible to a take a C# program on a different computer with different hardware architecture and operating system and run it. For this to happen, we need CLR. When you run a C# application, CLR compiles the IL code into the native machine code for the computer on which it is running. This process is called Just-in-time Compilation (JIT).

#### Architecture of .NET Applications

In terms of architecture, an application written with C# consists of building blocks called classes. A class is a container for data (attributes) and methods (functions). Attributes represent the state of the application. Methods include code. They have logic. That's where we implement our algorithms and write code.

A namespace is a container for related classes. So as your application grows in size, you may want to group the related classes into various namespaces for better maintainability.

As the number of classes and namespaces even grow further, you may want to physically separate related namespaces into separate assemblies. An assembly is a file (DLL or EXE) that contains one or more namespaces and classes. An EXE file represents a program that can be executed. A DLL is a file that includes code that can be re-used across different programs.

#### Installation

Follow this link for installaing C# in VSCode : https://channel9.msdn.com/Blogs/dotnet/Get-started-VSCode-Csharp-NET-Core-Windows

### Primitive Types and Expressions

#### Variables and Constants

Variable : A name given to a storage location in memory.
Constant : An immutable value. Used inorder to increase security.

C# is a case-sensitive language. You cannot use a variable without initializing it. 

Constants are declared using "const". Pascal Case is the recommended naming convention for constant variable and Camel case for normal variables.

Incase of a variable overflow, we can use "checked" keyword for avoiding the overflow. But the code throws an exception.

By using the 'var' keyword, the C# compiler automatically detects the type of the variable.

Format specifiers in  C# are given using {0}, {1}, etc.

#### Type Conversion

##### Implicit Type Conversion

Short data types can be converted to larger data types. For example, a byte can converted into an integer without type casting etc.

##### Explicit Type Conversion

When we try to convert larger data types into smaller data types, then the compiler throws an error, to avoid this we use "type-cating".

##### Non-Compatible Types

For non-compatible types like int and string, we can use Convert.ToInt32() or Parse.int() to convert a string into integer.

#### Operators

##### Arithmetic Operators

+, - , *, /, %, ++, --

##### Comparision Operators

==, !=, > , >= , < , <=

##### Assignment Operators

=, +=, -=, *=, /=

##### Logical Operators

&&, ||, !

##### Bitwise Operators

&, |

#### Comments

Inline comments can be written using // ... 

Multiline comments can be written using /* ... */

### Non-primitive Types

#### Classes

Combines related variables(fields) and functions(methods).

Objects are instances of a class.

To create a class we need to have a "access modifier" such as public, private etc.

Similar to other languages, we use "new" keyword to create a new object instance.

##### Static Modifier

By adding "static" keyword, we don't need to create an object.

#### Structs

Similar to classes, we can use Structures. Declare using the "struct" keyword.

#### Arrays

Array : A data structure to store a collection of variables of the same type.

When we declare an array, we need to give the size of the array and also by using "new" keyword.

We can access arrays using [] notation.

When we declare an array, all the elements of the array are set to a default value of the data type.


#### Strings
 
String : A sequence of characters.

We can concatenate strings using '+'.

We can create strings using "format" method.

We can also create strings using the "join" method.

Each character can be accessed using [].

Strings are immutable.

##### Escape Characters

\n : New line
\t : Tab
\\ : BackSlash
\' : Single Quotation Mark
\" : Double Quotation Mark

Verbatim Strings are used to avoid confusion while using '\'. For example, the path of a directory etc. To create a verbatim, just put @ at the beginning of the string.
 
 
#### Enums

Enum : A set of name/value pairs (constants).

We can create a enum using "enum" keyword.

Enums are used for shipping methods etc.

If we don't set values to enums, then the values are set automatically from zero.

#### Values Types vs. Reference Types

##### Value Types

Structures,
Primitive Types are declared,
Allocated on Stack,
Memory allocation done automatically,
Immediately removed when out of scope.

##### Reference Types

Classes,
Non-primitive Types are declared,
You need to allocate memory,
Memory allocated on heap,
Garbage collected by CLR.


 