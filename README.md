# Z.Expressions.Eval
Evaluate, Compile and Execute code and expression at runtime.

### From simple expression
```
Eval.Execute("x + y", new { x = 1, y = 2})
```
### To complex code
```
Eval.Execute(@"var list = new List<int>(x, y, z);
return list.Where(x => x > 2).Sum(x);", new { x = 1, y = 2, z = 3 });
```
## Table of Content
- Eval
- Compile
- Extension Methods
- Eval Context
- Free VS Pro
- Support
  - Doc
  - Forum
  - Email
- More Projects


