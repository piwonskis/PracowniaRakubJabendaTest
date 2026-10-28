import { useState } from 'react'
import 'bootstrap/dist/css/bootstrap.css'
import './App.css'

// <button
// type="button"
// className="counter"
// onClick={() => setCount((count) => count + 1)}
// >
// Count is {count}
// </button>

function App() {
  const [count, setCount] = useState(0)
    const [generuj, setgeneruj] = useState<boolean>(true)
    const [adres, setAdres] = useState('')
    const [login, setLogin] = useState('')
    const [haslo, setHaslo] = useState('')

    function submitFunc(e: React.FormEvent<HTMLFormElement>) {
        e.preventDefault()




    }
  return (
    <>
      <div className="App">
          <h1>Menadzer haseł - wykonał 000000000</h1>
          <form onSubmit={submitFunc}>
              <label htmlFor="Adres">Adres WWW</label>
              <input id="Adres" type="text" placeholder="Adres WWW" value={adres} className="form-control" onChange={(e) => setAdres(e.target.value)}/>

              <label htmlFor="Login">Login</label>
              <input id="Login" type="text" placeholder="Login" className="form-control" value={login}  onChange={(e) => setLogin(e.target.value)}/>

              <input type="checkbox" id="Checkbox" value="Wygeneruj haslo" checked={generuj} onChange={()=>setgeneruj((generuj)=>!generuj)} className="form-check-input" />
              <label htmlFor="Checkbox">Wygeneruj haslo</label>
                <br/>

                  <label htmlFor="Haslo">Haslo</label>
                  <input id="Haslo" disabled = {generuj} type="password" className="form-control" value={haslo} onChange={(e) => setHaslo(e.target.value)}/>




              <button type="button" className="btn btn-primary">Zapisz</button>


          </form>
      </div>
        <div>
            <p className="p-2" style={{color:"blue", fontSize:"30px"}}>Adres: {adres}</p>
            <p className="p-2">{login}</p>
            <p className="p-2">{haslo}</p>
        </div>






    </>
  )
}

export default App
