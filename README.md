# **TypeDetect**
**Lightweight C# language extension to assess objects types, including nullables (it's value can be null), and objects mapped from database readers, or if its a null as returned by a database reader (DBNull).**<br><br>

add "**using TypeDetect;**" to enable the language extension and call the type detection methods on all objects.
<br><br>

Available on **NuGet** ([here](https://www.nuget.org/packages/TrishkaV.TypeDetect/)) and installed using the command:<br>
*dotnet add package TrishkaV.TypeDetect*<br><br>

**Examples:**

".IsDateTime()" returns true if the object is a datetime and false otherwise.<br>
".IsDateTimeNullable()" returns true if the object is a datetime OR null, and false otherwise.<br>
<br>
".IsNumeric()" returns true if the object is "int", "short", "double", ...<br>
".IsNumericNullable()" as before, including null values.<br>
<br>
".IsText()" returns true for strings and chars.<br>
".IsTextNullable()" as before, including null values.<br><br>

Easily check if an object belongs to a kind as numerics, text, is a base type, is nullable and so on.<br>

---------------------------------
<img src="https://user-images.githubusercontent.com/96583994/231207718-9d01018f-023f-42ca-a5f1-c43e78a35284.png" width="650"><br><br>
---------------------------------

<br><br>
NOTE
Legally this comes with no warranty and you are using it at your own risk.

This library have been tested agaist real database extractions and objects of all the mentioned types its results hold correct.

If you find an issue with the results or implementation or an optimization could be made please feel free to contact me or issue a pull request.
You will be credited for any contribution.
