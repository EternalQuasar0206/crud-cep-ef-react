import React, { useState } from 'react';

export function Home() {
  var [counter, setCounter] = useState(0);
  function addCounter() {
    setCounter(counter + 1);
  }
    return (
      <div>
        <h4>Insira seu CEP para continuar</h4>
        <input type="text" class="form-control"></input>

        <p>This is a simple example of a React component.</p>

        <p aria-live="polite">Current count: <strong>{counter}</strong></p>

        <button className="btn btn-primary">
          Consulta WebService ViaCep
        </button>

        <button className="btn btn-secondary">
          Persistir Dados
        </button>

        <button className="btn btn-secondary">
          Consultar DB
        </button>
      </div>
    );
}
