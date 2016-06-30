#load "Namespace.fs"
#load "Lambda.fs"

module Run =
  let namespaceRun = Namespace1.Child.Module1_1.hoge

  let lambdaRun = Lambda.Lambda.func1 5