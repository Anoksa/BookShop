import React from "react";
import BookList from "./components/Books";
import BookDetailsPage from "./components/BookDetailsPage";

const App = () => {
    return(
        <div>
            <BookList />
            <BookDetailsPage />
        </div>
    );
}

export default App;