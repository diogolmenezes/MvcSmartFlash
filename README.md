# MvcSmartFlash
MvcSmartFlash is simple way to send messages using TemData based in rails flash messages.

## Getting Started

Add [MvcSmartFlash.dll](https://github.com/diogolmenezes/MvcSmartFlash/tree/master/Binary) as reference on your mvc project.

or use the [NuGet repository](https://www.nuget.org/packages/MvcSmartFlash):

```
PM> Install-Package MvcSmartFlash
```

## Create Flash Message

MvcSmartFlash can create flash messages from your controller

```c#
using MvcSmartFlash.Core;

public class FooController : Controller
{
    public virtual ActionResult FooAction()
    {
        // doing something
        foo();

        // sending flash message with custom css class
        this.Flash("alert alert-success", "Yes! You did it!");

        // sending flash messages predefined classes
        this.FlashSuccess("Yes! You did it!");
        this.FlashInfo("Hey, look to this info");
        this.FlashError(":( We have a error");
        this.FlashAlert("Caution! Are you sure?");
    }
}
```

## Render Messages in view

MvcSmartFlash can create flash messages from your controller

```c#
@using MvcSmartFlash.Core;

<!-- your html -->
    
@Html.RenderFlash()

<!-- your html -->

```

## Tests

MvcSmartFlash has many tests in the test project if you want take a look.

## Pull Requests

MvcSmartFlash is open to improve, send your pull request and help MvcSmartFlash to be the best ever :)