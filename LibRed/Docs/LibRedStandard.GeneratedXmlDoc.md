# LibRedStandard #

#### Method LibRed.Red.OpenRuntime

 This must be called before calling Red Runtime functions 



---
#### Method LibRed.Red.CloseRuntime

 This closes the current runtime and cleans memory usage 



---
#### Method LibRed.Red.Do(System.String)

 This evaluates a string containing Red code and returns the last Red value 

|Name | Description |
|-----|------|
|redString: |A string containing Red code|
**Returns**: A Pointer the Red value that the string returns



---
#### Method LibRed.Red.DoFile(System.String)

 This evaluates a string containing Red code and returns the last Red value 

|Name | Description |
|-----|------|
|filePath: |The file path is formatted using Red OS-independent conventions (basically Unix-style).|
**Returns**: A Pointer the Red value that the string returns



---


