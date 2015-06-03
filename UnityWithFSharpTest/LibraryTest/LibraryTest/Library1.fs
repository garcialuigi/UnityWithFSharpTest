namespace LibraryTest

open UnityEngine

type SimpleComponent() =
    inherit MonoBehaviour()
        [<SerializeField>]
        let mutable _speed = 10
        member this.stuff = 42
        member this.Start () = 
            this.transform.Translate(1.0f, -1.0f, 2.0f)
        member this.Update () = 
            Debug.Log("Hi");
    