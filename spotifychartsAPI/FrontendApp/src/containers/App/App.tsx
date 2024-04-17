import { BrowserRouter as Router, Route, Routes } from "react-router-dom";
import MainArea from "../MainArea/MainArea";

function App(): JSX.Element {
  // Componentes para las diferentes páginas
  const About = () => <h1>About</h1>;
  const Contact = () => <h1>Contact</h1>;
  const NotFound = () => <h1>404 - Not Found</h1>;

  return (
    <Router>
      <Routes>
        <Route path="/" element={<MainArea />} />
        <Route path="/about" element={<About />} />
        <Route path="/contact" element={<Contact />} />
        <Route path="*" element={<NotFound />} />
      </Routes>
    </Router>
  );
}

export default App;
