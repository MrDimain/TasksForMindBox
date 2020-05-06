// Боковая навигация 
class LeftNavigate extends React.Component {
    render() {
        return (<nav>
            <NavigateItem item={{ label: "Моя страница" }} />
            <NavigateItem item={{ label: "Новости" }} />
            <NavigateItem item={{ label: "Сообщения" }} />
            <NavigateItem item={{ label: "Друзья" }} />
            <NavigateItem item={{ label: "Сообщества" }} />
            <NavigateItem item={{ label: "Фотографии" }} />
            <NavigateItem item={{ label: "...." }} />
        </nav>);
    }
}
