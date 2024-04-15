import React from "react";
import { Theme } from "@radix-ui/themes";

import "@radix-ui/themes/styles.css";
import { Link, Route, Router } from "react-router-dom";

function App(): JSX.Element {
  return (
    <div className="App">
      <Theme>
        <Router>
          <div>
            <nav>
              <ul>
                <li>
                  <Link to="/">Home</Link>
                </li>
                <li>
                  <Link to="/about">About</Link>
                </li>
                <li>
                  <Link to="/contact">Contact</Link>
                </li>
              </ul>
            </nav>

            {/* Definición de rutas */}
            <Route path="/" component={<h1>Cosas</h1>} />
            <Route path="/about" Component={About} />
            <Route path="/contact" Component={Contact} />
          </div>
        </Router>
      </Theme>
    </div>
  );
}

export default App;
