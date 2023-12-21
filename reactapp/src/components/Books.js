import React, { useEffect, useState } from "react";
import axios from "axios";
import './Books.css';

const BookList = () => {
    const [books, setBooks] = useState([]);

    useEffect(() => {
        const fetchBooks = async () => {
            try {
                const responce = await axios.get('api/Books');
                setBooks(responce.data);
            } catch (error) {
                console.error('Error');
            }
        };

        fetchBooks();
    }, []);

    return(
        <div className="centered-table">
            <table>
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Title</th>
                        <th>Author</th>
                        <th>Price</th>
                    </tr>
                </thead>
                <tbody>
                {books.map((book) => (
                    <tr key={book.id}>
                        <td>{book.id}</td>
                        <td>{book.title}</td>
                        <td>{book.author}</td>
                        <td>{book.price}</td>
                    </tr>
                ))}
            </tbody>
            </table>
        </div>
    );
};

export default BookList;