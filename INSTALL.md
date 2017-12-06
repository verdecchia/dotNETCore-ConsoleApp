# Install instruction

### Create solution
```
cd dotNETCode-ConsoleApp
dotnet new sln
```
###

### Create ConsoleApp project and add to solution

```
mkdir ConsoleApp
cd ConsoleApp
dotnet new console
cd ..
cp \.gitignore .\ConsoleApp\
dotnet sln add .\ConsoleApp\ConsoleApp.csproj
```

### Create UnitTestConsoleApp project and add to solution
```
mkdir UnitTestConsoleApp
cd UnitTestConsoleApp
dotnet new mstest
dotnet remove package MSTest.TestFramework
dotnet remove package MSTest.TestAdapter
dotnet add package Nunit
dotnet add package Nunit3TestAdapter
dotnet add reference ..\ConsoleApp\ConsoleApp.csproj
cd ..
cp .\.gitignore .\UnitTestConsoleApp\
dotnet sln add .\UnitTestConsoleApp\UnitTestConsoleApp.csproj
```

### Modify UnitTestConsoleApp\UnitTest1.cs

#### from:

```Csharp
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestConsoleApp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
```

#### to:

```Csharp
using NUnit.Framework;

namespace UnitTestConsoleApp
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
        }
    }
}
```


