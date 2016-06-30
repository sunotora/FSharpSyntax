module Lambda

  // func1, func2は同じ引数の関数
  let func1 = fun x -> x * x
  let func2 x = x * x
  
  // func3, func4は同じ引数の関数
  let func3 = fun x -> fun y -> fun z -> x + y + z
  let func4 x y z = x + y + z

  // func3はfunc5のように省略できる
  let func5 = fun x y z -> x + y + z

  // func3をインデント付与するとfunc6となる
  let func6 =
    fun x ->
      fun y ->
        fun z ->
          x + y + z 