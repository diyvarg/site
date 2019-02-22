open System.Text.RegularExpressions
let split (by:string) (str:string)  = 
    let rec split (m:Match) = [
        if m.Success then
            let n = m.NextMatch()
            if n.Success = false then yield str.Substring(m.Index).TrimEnd(' ')
            else 
                yield str.Substring(m.Index, n.Index-m.Index).TrimEnd(' ')
                yield! split n ]
    Regex(by).Match str |> split
