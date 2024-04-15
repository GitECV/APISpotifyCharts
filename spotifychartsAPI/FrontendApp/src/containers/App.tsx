import { BrowserRouter as Router, Route, Routes } from "react-router-dom";
import { Theme } from "@radix-ui/themes";
import { Button } from "@radix-ui/themes";

import "@radix-ui/themes/styles.css";

function App(): JSX.Element {
  // Componentes para las diferentes páginas
  const Home = () => (
    <div>
      <Button>Let's go</Button>
    </div>
  );
  const About = () => <h1>About</h1>;
  const Contact = () => <h1>Contact</h1>;
  const NotFound = () => <h1>404 - Not Found</h1>;

  return (
    <Theme>
      <Router>
        <Routes>
          <Route path="/" element={<Home />} />
          <Route path="/about" element={<About />} />
          <Route path="/contact" element={<Contact />} />
          <Route path="*" element={<NotFound />} />
        </Routes>
      </Router>
    </Theme>
  );
}

export default App;
