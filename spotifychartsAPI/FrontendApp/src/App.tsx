import React from "react";
import { Button, Theme } from "@radix-ui/themes";

import "@radix-ui/themes/styles.css";

function App(): JSX.Element {
  return (
    <div className="App">
      <Theme>
        <Button color="cyan" variant="soft">
          Edit profile
        </Button>
      </Theme>
    </div>
  );
}

export default App;
