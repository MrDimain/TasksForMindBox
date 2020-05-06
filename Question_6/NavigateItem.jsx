// Элемент навигиции:
// Состоит из:
// Иконки элемента навигации : nav_icon
// Текста элемента навигации : nav_label
// Кол-во уведомлений по текушему элементу навигации : nav_notifier_count
class NavigateItem {
    render() {
        return (<li>
            <a>
                <span className="nav_icon"></span>
                <span className="nav_label">{this.props.item.label}</span>
                <span className="nav_notifier_count"></span>
            </a>
        </li>);
    }
}
