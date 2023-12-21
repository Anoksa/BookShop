import React, { useState } from "react";
import { useParams } from "react-router-dom";
import BookDetails from "./BookDetails";

const BookDetailsPage = () => {
    const { id } = useParams();
    const [bookId, setBookId] = useState(id);
    const [showBookDetails, setShowBookDetails] = useState(false);

    const handleButtonClick = () => {
        setShowBookDetails(true);
    };

    const handleInputChange = (e) => {
        setBookId(e.target.value);
    };

    return (
        <div>
            <h1>Страница деталей книги</h1>
            <div>
                <input type="text" value={bookId} onChange={handleInputChange} />
                <button onClick={handleButtonClick}>Показать детали книги</button>
            </div>
            {showBookDetails && <BookDetails id={bookId} />}
        </div>
    );
};

export default BookDetailsPage;