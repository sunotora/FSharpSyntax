namespace Namespace1
module Module1 = 
  let hoge =()
  // 先に定義されていない関数は呼び出し不可
  // let hoge = Namespace2.Module.hoge

namespace Namespace1.Child
module Module1_1 =
  let hoge = ()

namespace Namespace2
module Module2 =
  let hoge = Namespace1.Module1.hoge
  let piyo = Namespace1.Child.Module1_1.hoge

  open Namespace1.Module1
  let huga = hoge

  open Namespace1.Child.Module1_1
  let huuu = hoge