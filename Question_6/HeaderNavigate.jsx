// Элемент верхней полосы управления страницы
class HeaderNavigate extends React.Component {
    render() {
        return (
            <nav className="page_header_nav">
                <HeaderHome />
                <HeaderSearch />
                <HeaderNotifier />
                <HeaderPlayer />
                <HeaderUserProfile />
            </nav>
        );
    }
}

