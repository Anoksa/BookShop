import React, { useEffect, useState } from 'react';
import axios from 'axios';

const BookDetails = ({ id }) => {
    const [book, setBook] = useState(null);

    useEffect(() => {
        const fetchBook = async () => {
            try {
                const response = await axios.get(`api/books/${id}`);
                setBook(response.data);
            } catch (error) {
                console.error('Ошибка при получении книги:', error);
            }
        };

        fetchBook();
    }, [id]);

    if (!book) {
        return <div>Loading...</div>;
    }

    return (
        <div>
            <h1>Детали книги</h1>
            <p>Название: {book.title}</p>
            <p>Автор: {book.author}</p>
            <p>Price: {book.price}</p>
        </div>
    );
};

export default BookDetails;