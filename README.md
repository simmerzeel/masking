Small benchmark test to parse a piece of JSON and mask certain values to hide information.

**Newtonsoft**

| Method             | Mean     | Error   | StdDev  | Allocated |
|------------------- |---------:|--------:|--------:|----------:|
| MaskWithNewtonsoft | 152.5 us | 2.93 us | 2.44 us | 171.33 KB |

**System.Text**

| Method             | Mean     | Error    | StdDev   | Allocated |
|------------------- |---------:|---------:|---------:|----------:|
| MaskWithSystemText | 70.48 us | 1.186 us | 1.981 us |  72.46 KB |


