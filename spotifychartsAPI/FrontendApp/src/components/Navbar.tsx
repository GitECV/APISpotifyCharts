import React, { useState } from "react";
import { Button } from "@radix-ui/themes";

const App = (): JSX.Element => {
  // Estado para almacenar el contador
  const [contador, setContador] = useState<number>(0);

  // Función para incrementar el contador
  const incrementarContador = () => {
    setContador(contador + 1);
  };

  // Función para decrementar el contador
  const decrementarContador = () => {
    setContador(contador - 1);
  };

  return (
    <div>
      <h1>Contador: {contador}</h1>
      <Button />
    </div>
  );
};

export default App;
